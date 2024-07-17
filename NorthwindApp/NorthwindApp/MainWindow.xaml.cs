using System;
using System.Linq;
using System.Windows;

namespace NorthwindApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            LoadCustomers();
        }

        /// <summary>
        /// Loads the customers from the database.
        /// </summary>
        private void LoadCustomers()
        {
            try
            {
                using (var context = new NorthwindContext())
                {
                    var customers = context.Customers.ToList();

                    // Diagnostyka - sprawdzenie, które pole jest null
                    foreach (var customer in customers)
                    {
                        if (customer.CustomerID == null)
                            throw new InvalidOperationException("CustomerID is null for one of the customers.");
                        if (customer.CompanyName == null)
                            throw new InvalidOperationException("CompanyName is null for one of the customers.");
                        // Dodaj więcej sprawdzeń dla innych właściwości w razie potrzeby
                    }

                    CustomersGrid.ItemsSource = customers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}