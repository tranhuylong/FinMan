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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FinMan
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

        private void btn_Income_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Income), null);
        }

        private void btn_Outcome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Outcome), null);
        }

        private void btn_Statistical_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Summary), null);
        }
    }
}
