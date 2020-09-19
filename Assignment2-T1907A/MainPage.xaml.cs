using Assignment2_T1907A.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment2_T1907A
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ListViewLoaded(object sender, RoutedEventArgs e) {
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
            customers.Add(new Customer("Tung1", "0123", "Home"));
            customers.Add(new Customer("Tung2", "01234", "Company"));
            customers.Add(new Customer("Tung3", "01235", "Home"));
            customers.Add(new Customer("Tung4", "01236", "Company"));
            LV.ItemsSource = customers;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Customer c = new Customer(FullName.Text, Telephone.Text, TypeContact.Text);
            LV.Items.Add(c);
        }
    }
}
