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



        private void buttonSelectFind_Click(object sender, EventArgs e)
        {


            string findCertainInformation = comboBox1.SelectedItem.ToString();

            var endpointConfiguration = WebService1SoapClient.EndpointConfiguration.WebService1Soap;

            WebService1SoapClient service = new WebService1SoapClient(endpointConfiguration);

            switch (findCertainInformation)
            {
                case "Get Orders From Customer ID":
                    if (int.TryParse(textBox1.Text, out int customerID))
                    {
                        // Call the GetOrdersFromCustomer method with the customer ID parameter
                        List<Order> orders = service.GetOrdersFromCustomer(customerID);

                        // Clear the rich text box and add a header
                        richTextBox1.Clear();
                        richTextBox1.AppendText("ORDERS FOR CUSTOMER ID " + customerID + ":" + Environment.NewLine);

                        // Loop through the orders and add them to the rich text box
                        foreach (Order order in orders)
                        {
                            string orderCustomerInfo = string.Format("Order ID: {0} - Date: {1} - Supermarket ID: {2} - Payment Method: {3}", order.OrderID, order.OrderDate, order.SupermarketID, order.PaymentMethod);
                            richTextBox1.AppendText(orderCustomerInfo + Environment.NewLine);
                        }
                    }
                    else
                    {
                        // Display an error message if the input is not a valid integer
                        MessageBox.Show("Please enter a valid customer ID.");
                    }
                    break;



                case "Get Orderlines From Order ID":
                    if (int.TryParse(textBox1.Text, out int orderId))
                    {
                        // Call the GetOrdersFromCustomer method with the customer ID parameter
                        List<Orderline> orderlines = service.GetOrdersLinesFromOrder(orderId);

                        // Clear the rich text box and add a header
                        richTextBox1.Clear();
                        richTextBox1.AppendText("ORDERLINES FOR ORDER ID: " + orderId + ":" + Environment.NewLine);

                        // Loop through the orders and add them to the rich text box
                        foreach (Orderline or in orderlines)
                        {
                            string orderCustomerInfo = string.Format("Order ID: {0} - Product ID: {1} - Orderline number: {2} - Quantity: {3}", or.OrderID, or.ProductID, or.OrderlineNumber, or.Quantity);
                            richTextBox1.AppendText(orderCustomerInfo + Environment.NewLine);
                        }
                    }
                    else
                    {
                        // Display an error message if the input is not a valid integer
                        MessageBox.Show("Please enter a valid customer ID.");
                    }
                    break;



                case "Get Products From Category ID":
                    if (int.TryParse(textBox1.Text, out int categoryID))
                    {
                        // Call the GetOrdersFromCustomer method with the customer ID parameter
                        List<Product> products = service.GetProductsFromCategory(categoryID);

                        // Clear the rich text box and add a header
                        richTextBox1.Clear();
                        richTextBox1.AppendText("PRODUCTS FOR CATEGORY ID: " + categoryID + ":" + Environment.NewLine);

                        // Loop through the orders and add them to the rich text box
                        foreach (Product p in products)
                        {
                            string orderCustomerInfo = string.Format("Product ID: {0} - Product Name: {1} - Price: {2} - Category ID: {3}",p.ProductID, p.ProductName, p.Price, p.CategoryID);
                            richTextBox1.AppendText(orderCustomerInfo + Environment.NewLine);
                        }
                    }
                    else
                    {
                        // Display an error message if the input is not a valid integer
                        MessageBox.Show("Please enter a valid customer ID.");
                    }
                    break;







            }
        }
    }
}