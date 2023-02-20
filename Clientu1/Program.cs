using ServiceReferenceClient1;

var endpointConfiguration = WebService1SoapClient.EndpointConfiguration.WebService1Soap;

WebService1SoapClient service = new WebService1SoapClient(endpointConfiguration);

List<Customer> customers = service.GetCustomers();

foreach(Customer c in customers)
{
    Console.WriteLine("Customer Names:");
    Console.WriteLine(c.Name);
    Console.WriteLine("-------------");

}