//Shane MacDonald
//March 29, 2018
//U2ShaneGoodTimes
//Program takes Ottawa time input and outputs time in other canadian cities
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

namespace U2ShaneGoodTimes
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
        
        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(txtInput.Text);
            int lasttwo = input % 100;
            int ottawa = input;
                int victoria = input - 300;
                int edmonton = input - 200;
                int winnipeg = input - 100;
                int halifax = input + 100;
                


            if (lasttwo < 30)
            {
                int stjohns = input + 130;
                if (halifax >= 2400)
                {
                    stjohns = input - 2270;
                    halifax = input - 2300;
                }
                if (input < 100)
                {
                    winnipeg = 2400 - (100 - input); 
                }

                if (input < 200)
                {
                    edmonton = 2400 - (200 - input);
                }
                    
                if (input < 300)
                {
                    victoria = 2400 - (300 - input); 
                    
                }
                lblOutput.Content = ("Ottawa " + ottawa + "\r" + "\n" + "Victoria " + victoria + "\r" + "\n" + "Edmonton " + edmonton + "\r" + "\n" + "Winnipeg " + winnipeg + "\r" + "\n" + "Halifax " + halifax + "\r" + "\n" + "St. John's " + stjohns);
            }
            
            else
            {
                int stjohns = input - lasttwo + (lasttwo - 30) + 200;

                if(halifax >= 2400)
                {
                    stjohns = input - 2230;
                    halifax = input -2300;
                }
                if (input < 100)
                {
                    winnipeg = 2400 - (100 - input);
                }

                if (input < 200)
                {
                    edmonton = 2400 - (200 - input);
                }

                if (input < 300)
                {
                    victoria = 2400 - (300 - input);

                }

                lblOutput.Content = ("Ottawa " + ottawa + "\r" + "\n" + "Victoria " + victoria + "\r" + "\n" + "Edmonton " + edmonton + "\r" + "\n" + "Winnipeg " + winnipeg + "\r" + "\n" + "Halifax " + halifax + "\r" + "\n" + "St. John's " + stjohns);
            }
            
        }
    }
}
