using ServiceReferenceClient1;

var endpointConfiguration = WebService1SoapClient.EndpointConfiguration.WebService1Soap;

WebService1SoapClient service = new WebService1SoapClient(endpointConfiguration); 

List<Customer> customers = service.GetCustomers();

foreach(Customer c in customers)
{
    Console.WriteLine("Customer:");
    Console.WriteLine(c.Name);
    Console.WriteLine("-------------");

}

List<Order> orders = service.GetOrdersFromCustomer(2);
foreach (Order o in orders)
{
    Console.WriteLine("Order:");
    Console.WriteLine(o.OrderID);
    Console.WriteLine("-------------");

}

List<Orderline> or = service.GetOrdersLinesFromOrder(18732);
foreach (Orderline o in or)
{
    Console.WriteLine("Quantity:");
    Console.WriteLine(o.ProductID);
    Console.WriteLine("-------------");

}