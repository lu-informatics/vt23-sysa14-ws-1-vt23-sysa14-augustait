using ServiceReferenceForms;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


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
            try { 
            string viewCertainInformation = comboBoxViewInformation.SelectedItem.ToString();

            var endpointConfiguration = WebService1SoapClient.EndpointConfiguration.WebService1Soap;

            WebService1SoapClient service = new WebService1SoapClient(endpointConfiguration);

            switch (viewCertainInformation)
            {

                case "Product Category":
                    List<ProductCategory> categories = service.GetCategories();

                    richTextBoxViewAllInformation.Clear();
                    richTextBoxViewAllInformation.AppendText("CATEGORIES INFO:\n\n");

                    foreach (ProductCategory category in categories)
                    {
                        string categoryInfo = string.Format("Category ID: {0} - Category Name: {1}\n", category.CategoryID, category.CategoryName);
                        richTextBoxViewAllInformation.AppendText(categoryInfo);
                    }
                    break;



                case "Customers":
                    List<Customer> customers = service.GetCustomers();

                    richTextBoxViewAllInformation.Clear();
                    richTextBoxViewAllInformation.AppendText("CUSTOMERS INFO:\n\n");

                    foreach (Customer customer in customers)
                    {
                        string customerInfo = string.Format("Name: {0} - Customer ID: {1} - Phone Number: {2}\n", customer.Name, customer.CustomerID, customer.PhoneNumber);
                        richTextBoxViewAllInformation.AppendText(customerInfo);
                    }
                    break;


                case "Orders":
                    List<Order> orders = service.GetOrders();

                    richTextBoxViewAllInformation.Clear();
                    richTextBoxViewAllInformation.AppendText("ORDERS INFO:\n\n");

                    foreach (Order order in orders)
                    {
                        string orderInfo = string.Format("Order ID: {0} - Date: {1} - Supermarket ID: {2} - Customer ID: {3} - Payment Method: {4}\n", order.OrderID, order.OrderDate, order.SupermarketID, order.CustomerID, order.PaymentMethod);
                        richTextBoxViewAllInformation.AppendText(orderInfo);
                    }
                    break;


                case "Products":
                    List<Product> products = service.GetProducts();

                    richTextBoxViewAllInformation.Clear();
                    richTextBoxViewAllInformation.AppendText("PRODUCTS INFO:\n\n");

                    foreach (Product product in products)
                    {
                        string productInfo = string.Format("Product ID: {0} - Name: {1} - Price: {2} - Category ID: {3}\n", product.ProductID, product.ProductName, product.Price, product.CategoryID);
                        richTextBoxViewAllInformation.AppendText(productInfo);
                    }
                    break;

                case "Stores":
                    List<Store> stores = service.GetStores();

                    richTextBoxViewAllInformation.Clear();
                    richTextBoxViewAllInformation.AppendText("STORES INFO:\n\n");

                    foreach (Store store in stores)
                    {
                        string storeInfo = string.Format("Supermarket ID: {0} - Region: {1} - Store name: {2} - City: {3} - Address: {4}\n", store.SupermarketID, store.RegionName, store.StoreName, store.City, store.StoreAddress);
                        richTextBoxViewAllInformation.AppendText(storeInfo);
                    }
                    break;

                default:
                    break;
                }
            }
            catch (System.ServiceModel.FaultException ex)
            {
                richTextBoxViewAllInformation.Clear();

                richTextBoxViewAllInformation.AppendText("Sorry, we encountered an error while processing your request. Please try again later");
            }
            catch (NullReferenceException ex)
            {
                richTextBoxViewAllInformation.Clear();

                richTextBoxViewAllInformation.AppendText("Please select a web service method to call");

            }
        }



        private void buttonSelectFind_Click(object sender, EventArgs e)
        {
            try {
                string findCertainInformation = comboBoxFindByID.SelectedItem.ToString();

                var endpointConfiguration = WebService1SoapClient.EndpointConfiguration.WebService1Soap;
                WebService1SoapClient service = new WebService1SoapClient(endpointConfiguration);

                string selectedOption = comboBoxFindByID.SelectedItem.ToString();
              

                int idInput = int.Parse(textBoxFindByID.Text);

                switch (selectedOption)
                {
                    case "Get Orders From Customer ID":
                        List<Order> orders = service.GetOrdersFromCustomer(idInput);
                        if (orders.Count == 0)
                        {
                            richTextBoxFindByID.Clear();
                            richTextBoxFindByID.AppendText($"No Orders found for Customer ID: {idInput}.{Environment.NewLine}");
                        }
                        else
                        {
                            richTextBoxFindByID.Clear();
                            richTextBoxFindByID.AppendText($"ORDERS FOR CUSTOMER ID {idInput}:{Environment.NewLine}");
                            foreach (Order order in orders)
                            {
                                string orderInfo = $"Order ID: {order.OrderID} - Date: {order.OrderDate} - Supermarket ID: {order.SupermarketID} - Payment Method: {order.PaymentMethod}";
                                richTextBoxFindByID.AppendText(orderInfo + Environment.NewLine);
                            }
                        }
                        break;

                    case "Get Orderlines From Order ID":
                        List<Orderline> orderlines = service.GetOrdersLinesFromOrder(idInput);
                        if (orderlines.Count == 0)
                        {
                            richTextBoxFindByID.Clear();
                            richTextBoxFindByID.AppendText($"No Orderlines found for Order ID: {idInput}.{Environment.NewLine}");
                        }
                        else
                        {
                            richTextBoxFindByID.Clear();
                            richTextBoxFindByID.AppendText($"ORDERLINES FOR ORDER ID: {idInput}:{Environment.NewLine}");
                            foreach (Orderline orderline in orderlines)
                            {
                                string orderlineInfo = $"Order ID: {orderline.OrderID} - Product ID: {orderline.ProductID} - Orderline number: {orderline.OrderlineNumber} - Quantity: {orderline.Quantity}";
                                richTextBoxFindByID.AppendText(orderlineInfo + Environment.NewLine);
                            }
                        }
                        break;

                    case "Get Products From Category ID":
                        List<Product> products = service.GetProductsFromCategory(idInput);
                        if (products.Count == 0)
                        {
                            richTextBoxFindByID.Clear();
                            richTextBoxFindByID.AppendText($"No Products found for Category ID: {idInput}.{Environment.NewLine}");
                        }
                        else
                        {
                            richTextBoxFindByID.Clear();
                            richTextBoxFindByID.AppendText($"PRODUCTS FOR CATEGORY ID: {idInput}:{Environment.NewLine}");
                            foreach (Product product in products)
                            {
                                string productInfo = $"Product ID: {product.ProductID} - Product Name: {product.ProductName} - Price: {product.Price} - Category ID: {product.CategoryID}";
                                richTextBoxFindByID.AppendText(productInfo + Environment.NewLine);
                            }
                        }
                        break;
                    default:
                        break;
                }
            } catch (FormatException ex)
            {
                richTextBoxFindByID.Clear();

                richTextBoxFindByID.AppendText("Please enter a valid Order ID, Customer ID or Category ID.");

            }
            catch(NullReferenceException ex)
            {
                richTextBoxFindByID.Clear();

                richTextBoxFindByID.AppendText("Please select a web service method to call");
            }
            catch(System.ServiceModel.FaultException ex)
            {
                richTextBoxFindByID.AppendText("Sorry, we encountered an error while processing your request. Please try again later");
            }




        }
        }
}