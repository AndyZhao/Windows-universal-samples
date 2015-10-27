using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SDKTemplate
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario2 : Page
    {
        public Scenario2()
        {
            this.InitializeComponent();
            button_calc.Click += new RoutedEventHandler(CalcButtion_Click);
        }

        private void CalcButtion_Click(object sender, RoutedEventArgs e)
        {
            int number1;
            int number2;
            string result = "error";
            if (!Int32.TryParse(textBox_para1.Text, out number1))
            {
                NotifyUser();
                return;
            }
            if (!Int32.TryParse(textBox_para2.Text, out number2))
            {
                NotifyUser();
                return;
            }

            result = (number1 + number2).ToString();
            textBlock_result.Text = result;
        }

        private void NotifyUser()
        {
            textBlock_result.Text = "error";
        }
    }
}
