using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace OClubs.Views.Clubs
{
    public class FinancialStuff
    {
        public string Name { get; set; }
        public int Amount { get; set; }
    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ClubDetail : Page
    {
        public ClubDetail()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadChartContents();
        }

        private void LoadChartContents()
        {
            Random rand = new Random();
            List<FinancialStuff> financialStuffList = new List<FinancialStuff>();
            financialStuffList.Add(new FinancialStuff() { Name = "January", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "February", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "March", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "April", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "May", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "June", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "July", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "August", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "September", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "October", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "November", Amount = rand.Next(-200, 200) });
            financialStuffList.Add(new FinancialStuff() { Name = "December", Amount = rand.Next(-200, 200) });

            (LineChart.Series[0] as LineSeries).ItemsSource = financialStuffList;

            List<FinancialStuff> financialStuffList1 = new List<FinancialStuff>();
            financialStuffList1.Add(new FinancialStuff() { Name = "January", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "February", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "March", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "April", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "May", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "June", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "July", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "August", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "September", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "October", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "November", Amount = rand.Next(-200, 200) });
            financialStuffList1.Add(new FinancialStuff() { Name = "December", Amount = rand.Next(-200, 200) });
            (LineChart.Series[1] as LineSeries).ItemsSource = financialStuffList1;
        }
    }
}
