using DBApi;
using System;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Collections.Generic;

namespace ParkingWPF
{
    public partial class MyFirstWindow : Fluent.RibbonWindow
    {
        private DBApi.Models.Parking parking;
        private DbContextFactory dbContextFactory;
        private readonly IUnitOfWork unitOfWork;
        private int countOfCarsInCarManager;
        private DBApi.Models.Car car;

        public MyFirstWindow()
        {
            dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory.CreateDbContext(null));
            countOfCarsInCarManager = unitOfWork.CarManager.CountAddedCars();

            this.InitializeComponent();
            
            string Date = DateTime.Now.ToString();
            dateTimeNow.Text = Date;

            var getParking = unitOfWork.ParkingManager.GetAll().FirstOrDefault();
            if (getParking == null)
            {
            parking = new DBApi.Models.Parking(100);
            unitOfWork.ParkingManager.Create(parking);
            }
            else
            parking = getParking;

            unitOfWork.SaveChanges();
        }

        private void btnAddNewCar_Click(object sender, RoutedEventArgs e)
        {
            addCarTabItem.IsSelected = true;
            carsTabItem.IsSelected = false;
            removeCarTabItem.IsSelected = false;
            btnSave.IsEnabled = true;
            btnDiscard.IsEnabled = true;
            btnAddNewCar.IsEnabled = false;
            btnDeleteCar.IsEnabled = true;
            btnRemove.IsEnabled = false;
            modelBox.Text = "";
            colorBox.Text = "";
            numberBox.Text = "";
        }

        private void btnDeleteCar_Click(object sender, RoutedEventArgs e)
        {            
            addCarTabItem.IsSelected = false;
            carsTabItem.IsSelected = false;
            removeCarTabItem.IsSelected = true;
            btnSave.IsEnabled = false;
            btnDiscard.IsEnabled = true;
            btnAddNewCar.IsEnabled = true;
            btnDeleteCar.IsEnabled = false;
            btnRemove.IsEnabled = true;
            numberRemoveBox.Text = "";

            FillSuggestionBox();
        }

        private void btnParking_Click(object sender, RoutedEventArgs e)
        {
            addCarTabItem.IsSelected = false;
            carsTabItem.IsSelected = true;
            removeCarTabItem.IsSelected = false;
            btnSave.IsEnabled = false;
            btnDiscard.IsEnabled = false;
            btnAddNewCar.IsEnabled = true;
            btnDeleteCar.IsEnabled = true;
            btnRemove.IsEnabled = false;
            capacity.Text = $"{countOfCarsInCarManager} / {parking.Capacity}";
            FillDataGrid();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearDataGrid();
            FillDataGrid();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            btnSave.IsEnabled = false;
            btnDiscard.IsEnabled = false;
            btnAddNewCar.IsEnabled = true;
            btnDeleteCar.IsEnabled = true;
            btnRemove.IsEnabled = false;
            myTabControl.SelectedIndex = 0;
            car = new DBApi.Models.Car()
            {
                Model = modelBox.Text,
                Color = colorBox.Text,
                Number = numberBox.Text,
                StartTime = DateTime.Now,
                ParkingId = parking.Id
            };

            AddToCarTable(car, unitOfWork, parking);
            unitOfWork.SaveChanges();
            capacity.Text = $"{countOfCarsInCarManager} / {parking.Capacity}";
            FillDataGrid();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            btnSave.IsEnabled = false;
            btnDiscard.IsEnabled = false;
            btnAddNewCar.IsEnabled = true;
            btnDeleteCar.IsEnabled = true;
            btnRemove.IsEnabled = false;
            myTabControl.SelectedIndex = 0;

            UpdateCarTable(car, unitOfWork, parking);
            unitOfWork.SaveChanges();
            capacity.Text = $"{countOfCarsInCarManager} / {parking.Capacity}";
            FillDataGrid();
        }

        private void btnDiscard_Click(object sender, RoutedEventArgs e)
        {
            addCarTabItem.IsSelected = true;
            carsTabItem.IsSelected = true;
            removeCarTabItem.IsSelected = true;
            btnSave.IsEnabled = false;
            btnDiscard.IsEnabled = false;
            btnAddNewCar.IsEnabled = true;
            btnDeleteCar.IsEnabled = true;
            btnRemove.IsEnabled = false;
            myTabControl.SelectedIndex = 0;
        }

        void AddToCarTable(DBApi.Models.Car car, IUnitOfWork unitOfWork, DBApi.Models.Parking parking)
        {
            if (countOfCarsInCarManager < parking.Capacity)
            {
                car.Cost = 0;
                car.Status = "Added";
                DBApi.Models.Car obj = unitOfWork.CarManager.FindByNumber(car.Number);
                if (obj == null)
                {
                    countOfCarsInCarManager++;
                    parking.Count = countOfCarsInCarManager;
                    unitOfWork.CarManager.Create(car);
                }
                else
                    MessageBox.Show("Invalid Number !");
            }
            else
                MessageBox.Show("The parking is full !");
            
        }

        void UpdateCarTable(DBApi.Models.Car car, IUnitOfWork unitOfWork, DBApi.Models.Parking parking)
        {
            car = unitOfWork.CarManager.FindByNumber(numberRemoveBox.Text);
            if(car!=null)
            {
                car.EndTime = DateTime.Now;
                car.Cost = car.PaymantCalculator();
                car.Status = "Removed";
                parking.Count = --countOfCarsInCarManager;
                unitOfWork.CarManager.Update(car);
            }
            else
            {
                MessageBox.Show("Invalid number !");
            }
        }

        void FillDataGrid()
        {

            var connectionString = "Data Source=SV-APP-014\\IMOSSQL2016;Initial Catalog=FirstDB;Integrated Security=True;User ID=;Password=";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM[FirstDB].[dbo].[Cars] ORDER BY StartTime ASC", con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            carsInTheParking.ItemsSource = dt.DefaultView;
            
            cmd.Dispose();
            con.Close();

        }

        void ClearDataGrid()
        {

            var connectionString = "Data Source=SV-APP-014\\IMOSSQL2016;Initial Catalog=FirstDB;Integrated Security=True;User ID=;Password=";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM[FirstDB].[dbo].[Cars] WHERE Status='Removed'", con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            carsInTheParking.ItemsSource = dt.DefaultView;

            cmd.Dispose();
            con.Close();

        }

        void FillSuggestionBox()
        {
            List<DBApi.Models.Car> addedCars = unitOfWork.CarManager.GetAll().Where(x => x.Status == "Added").ToList();
            List<string> numbers = addedCars.Select(x => x.Number).ToList();
            numberRemoveBox.ItemsSource = numbers;
        }
    }
}