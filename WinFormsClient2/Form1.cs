using ServiceReferenceForms;


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
            string viewProductCategory = comboBoxViewInformation.SelectedItem.ToString();
            string viewCustomer = comboBoxViewInformation.SelectedItem.ToString();
            string viewProduct = comboBoxViewInformation.SelectedItem.ToString();
            string viewStores = comboBoxViewInformation.SelectedItem.ToString();
            string viewOrders = comboBoxViewInformation.SelectedItem.ToString();



            var endpointConfiguration = WebService1SoapClient.EndpointConfiguration.WebService1Soap;

            WebService1SoapClient service = new WebService1SoapClient(endpointConfiguration);

        }
    }
}