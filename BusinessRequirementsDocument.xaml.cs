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
using System.Windows.Shapes;

namespace ProductManagement
{
    /// <summary>
    /// Interaction logic for BusinessRequirementsDocument.xaml
    /// </summary>
    public partial class BusinessRequirementsDocument : Window
    {
        public BusinessRequirementsDocument()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CompanyProductDistributionMap CompanyProductDistributionMapObject = new CompanyProductDistributionMap();
            CompanyProductDistributionMapObject.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StrategicGoals StrategicGoalsObject = new StrategicGoals();
            StrategicGoalsObject.Show();

        }

        private void MKTSEG_Click(object sender, RoutedEventArgs e)
        {
            MarketSegmentation MarketSegmentationObject = new MarketSegmentation();
            MarketSegmentationObject.Show();
        }

        private void AppSeg_Click(object sender, RoutedEventArgs e)
        {
            ApplicationsSegmentation ApplicationsSegmentationObject = new ApplicationsSegmentation();
            ApplicationsSegmentationObject.Show();
        }
    }
}
