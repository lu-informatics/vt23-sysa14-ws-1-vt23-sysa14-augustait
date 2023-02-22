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

                    foreach (ProductCategory category in categories)
                    {
                  
                        listBoxViewAllInformation.Items.Add(category.CategoryID);

                    }
                    break;



                case "Customers":
                    // Call the GetCustomers method and display the results in the RichTextBox
                    List<Customer> customers = service.GetCustomers();

                    listBoxViewAllInformation.Items.Clear();
                    
                    listBoxViewAllInformation.Items.Add("CUSTOMER INFO:");


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

                    foreach (Order order in orders)
                    {
                        listBoxViewAllInformation.Items.Add(order.OrderID);
                    }
                    break;


                case "Products":
                    // Call the GetOrders method and display the results in the RichTextBox
                    List<Product> products = service.GetProducts();

                    listBoxViewAllInformation.Items.Clear();

                    foreach (Product product in products)
                    {
                        listBoxViewAllInformation.Items.Add(product.ProductID);

                    }
                    break;

                case "Stores":
                    // Call the GetOrders method and display the results in the RichTextBox
                    List<Store> stores = service.GetStores();

                    listBoxViewAllInformation.Items.Clear();

                    foreach (Store store in stores)
                    {
                        listBoxViewAllInformation.Items.Add(store.SupermarketID);

                    }
                    break;
               

            }

        }
    }
}