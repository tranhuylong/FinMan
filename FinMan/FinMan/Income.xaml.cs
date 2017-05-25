using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using FinMan.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FinMan
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Income : Page
    {
        public Income()
        {
            this.InitializeComponent();
            incomeLoad();
            cb_Income.SelectedIndex = 0;
        }

        public void incomeLoad()
        {
            var str = File.ReadAllText(@"income.json");
            List<string> jins = JsonConvert.DeserializeObject<List<string>>(str);
            foreach(string x in jins)
            {
                cb_Income.Items.Add(x);
            }
        }

        private void cb_Income_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //this.Frame.Navigate(typeof(IncomeValue), null);
        }

        private void btn_vIncome_Click(object sender, RoutedEventArgs e)
        {
            Action act = new Action
            {
                Name = cb_Income.SelectedValue.ToString(),
                Value = txt_vIncome.Text.ToString()
            };
            //Task.Run(() => File.WriteAllText(@"h:/action.json", JsonConvert.SerializeObject(act)));
            Task.Run(() => {
                using (StreamWriter file = File.CreateText(@"h:/action.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, act);
                }
            });
            /**/
        }
    }
}
