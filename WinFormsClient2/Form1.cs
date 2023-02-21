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
                    foreach (ProductCategory category in categories)
                    {
                        richTextBoxViewAllInformation.AppendText($"{category.CategoryID}\n");
                    }
                    break;



                case "Customers":
                    // Call the GetCustomers method and display the results in the RichTextBox
                    List<Customer> customers = service.GetCustomers();
                    foreach (Customer customer in customers)
                    {
                        richTextBoxViewAllInformation.AppendText($"{customer.Name}\n");
                    }
                    break;


                case "Orders":
                    // Call the GetOrders method and display the results in the RichTextBox
                    List<Order> orders = service.GetOrders();
                    foreach (Order order in orders)
                    {
                        richTextBoxViewAllInformation.AppendText($"{order.OrderID}\n");
                    }
                    break;


                case "Products":
                    // Call the GetOrders method and display the results in the RichTextBox
                    List<Product> products = service.GetProducts();
                    foreach (Product product in products)
                    {
                        richTextBoxViewAllInformation.AppendText($"{product.ProductID}\n");
                    }
                    break;

                case "Stores":
                    // Call the GetOrders method and display the results in the RichTextBox
                    List<Store> stores = service.GetStores();
                    foreach (Store store in stores)
                    {
                        richTextBoxViewAllInformation.AppendText($"{store.SupermarketID}\n");
                    }
                    break;

               

            }

            }
    }
}