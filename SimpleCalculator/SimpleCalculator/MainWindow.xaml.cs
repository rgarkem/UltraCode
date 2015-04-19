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

namespace SimpleCalculator
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

        /// <summary>
        /// The button click Event Handler
        /// </summary>
        /// <param name="sender">the sending component (the form)</param>
        /// <param name="e">some param</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int result = -1;
            if ((bool)this.rbAdd.IsChecked)
            {
                result = CalcEngine.Add(Int32.Parse(this.TB1.Text), Int32.Parse(this.TB2.Text));
            }
            else if ((bool)this.rbSubtract.IsChecked)
            {
                result = CalcEngine.Sub(Int32.Parse(this.TB1.Text), Int32.Parse(this.TB2.Text));
            }
            else if ((bool)this.rbMultiply.IsChecked)
            {
                result = CalcEngine.Mult(Int32.Parse(this.TB1.Text), Int32.Parse(this.TB2.Text));
            }
            else if ((bool)this.rbDivide.IsChecked)
            {
                result = CalcEngine.Div(Int32.Parse(this.TB1.Text), Int32.Parse(this.TB2.Text));
            }
            else 
            {
                this.Result.Text = "NOTHING SELECTED!! Please choose an operation first";
                return;
            }

            Result.Text = result.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {            
           
        }        
    }
}
