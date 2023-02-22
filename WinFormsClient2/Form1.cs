using ServiceReferenceForms;
using System.Reflection;
using System.Windows.Forms;


namespace WinFormsClient2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonViewInformationSelect_Click(object sender, EventArgs e)
        {
            string viewCertainInformation = comboBoxViewInformation.SelectedItem.ToString();


            var endpointConfiguration = WebService1SoapClient.EndpointConfiguration.WebService1Soap;

            WebService1SoapClient service = new WebService1SoapClient(endpointConfiguration);

            switch (viewCertainInformation)
            {

                case "Product Category":
                    // Call the GetCustomers method and display the results in the RichTextBox
                    List<ProductCategory> categories = service.GetCategories();

                    listBoxViewAllInformation.Items.Clear();

                    listBoxViewAllInformation.Items.Add("CATEGORIES INFO:");


                    foreach (ProductCategory category in categories)
                    {

                        string categoryInfo = string.Format("Category ID: {0} - Category Name: {1}", category.CategoryID, category.CategoryName);
                        listBoxViewAllInformation.Items.Add(categoryInfo);

                    }
                    break;



                case "Customers":
                    // Call the GetCustomers method and display the results in the RichTextBox
                    List<Customer> customers = service.GetCustomers();

                    listBoxViewAllInformation.Items.Clear();
                    
                    listBoxViewAllInformation.Items.Add("CUSTOMERS INFO:");


                    foreach (Customer customer in customers)
                    {
                        string customerInfo = string.Format("Name: {0} - Customer ID: {1} - Phone Number: {2}", customer.Name, customer.CustomerID, customer.PhoneNumber);

                        listBoxViewAllInformation.Items.Add(customerInfo);
                       
                    }
                    break;


                case "Orders":
                    // Call the GetOrders method and display the results in the RichTextBox
                    List<Order> orders = service.GetOrders();
                    

                    listBoxViewAllInformation.Items.Clear();

                    listBoxViewAllInformation.Items.Add("ORDERS INFO:");


                    foreach (Order order in orders)
                    {
                        string orderInfo = string.Format("Order ID: {0} - Date: {1} - Supermarket ID: {2} - Customer ID: {3} - Payment Method: {4}", order.OrderID, order.OrderDate, order.SupermarketID, order.CustomerID, order.PaymentMethod);
                        listBoxViewAllInformation.Items.Add(orderInfo);
                    }
                    break;


                case "Products":
                    // Call the GetOrders method and display the results in the RichTextBox
                    List<Product> products = service.GetProducts();

                    listBoxViewAllInformation.Items.Clear();

                    listBoxViewAllInformation.Items.Add("PRODUCTS INFO:");


                    foreach (Product product in products)
                    {
                        string productInfo = string.Format("Product ID: {0} - Name: {1} - Price: {2} - Category ID: {3}", product.ProductID, product.ProductName, product.Price, product.CategoryID);
                        listBoxViewAllInformation.Items.Add(productInfo);

                    }
                    break;

                case "Stores":
                    // Call the GetOrders method and display the results in the RichTextBox
                    List<Store> stores = service.GetStores();

                    listBoxViewAllInformation.Items.Clear();

                    listBoxViewAllInformation.Items.Add("STORES INFO:");


                    foreach (Store store in stores)
                    {
                        string storeInfo = string.Format("Supermarket ID: {0} - Region: {1} - Store name: {2} - City: {3} - Address: {4}", store.SupermarketID, store.RegionName, store.StoreName, store.City, store.StoreAddress);

                        listBoxViewAllInformation.Items.Add(storeInfo);

                    }
                    break;
               

            }

        }
    }
}