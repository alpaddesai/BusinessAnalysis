using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PMP_Click(object sender, RoutedEventArgs e)
        {
            PMP PMPObject = new PMP();
            PMPObject.Show();
        }

        private void BRD_Click(object sender, RoutedEventArgs e)
        {
            BusinessRequirementsDocument BusinessRequirementsDocumentObject = new BusinessRequirementsDocument();
            BusinessRequirementsDocumentObject.Show();
        }

        private void BusinessCasePrep_Click(object sender, RoutedEventArgs e)
        {
            UseCaseAnalysis UseCaseAnalysisObject = new UseCaseAnalysis();
            UseCaseAnalysisObject.Show();
        }

        private void UseCase_Click(object sender, RoutedEventArgs e)
        {
            UserCase UserCaseObject = new UserCase();
            UserCaseObject.Show();
        }

        private void UsabilityResearch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Customer experience and customer usability research can be stated as the voice of the customer on a  product team, digital product management includes designing websites and mobile apps to imrpove online customer value management.  This includes building customer loyalty, increasing customer involvement, lead generation and lead nurturing, value exchange, and customer portfolio segmentation","Digital Product Management");
        }

        private void Test_Planning_Click(object sender, RoutedEventArgs e)
        {
            Web_Application Web_ApplicationObjects = new Web_Application();
            Web_ApplicationObjects.Show();

        }

        private void WebAnalytics_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Utilize Google Analytics to derive customer experience and generate sales leads","Web Analytics");
        }

     
        private void JIRA_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" JIRA is flexible tool that can be utilized by software development organization to manage it's SW development lifecyle and bug tracking");
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
