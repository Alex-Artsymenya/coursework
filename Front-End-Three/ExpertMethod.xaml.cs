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
using TCPConnectionAPIClientModule_C_sharp_;

namespace Front_End_Three
{
    /// <summary>
    /// Логика взаимодействия для ExpertMethod.xaml
    /// </summary>
    public partial class ExpertMethod : Window
    {
        private IExpertAccess module;
        public ExpertMethod(IExpertAccess module)
        {
            this.module = module;
            InitializeComponent();

            Z2_Z1.Text = "";
            Z3_Z1.Text = "";
            Z4_Z1.Text = "";
            Z1_Z2.Text = "";
            Z3_Z2.Text = "";
            Z4_Z2.Text = "";
            Z1_Z3.Text = "";
            Z2_Z3.Text = "";
            Z4_Z3.Text = "";
            Z1_Z4.Text = "";
            Z2_Z4.Text = "";
            Z3_Z4.Text = "";
        }

        private void Button_OK(object sender, RoutedEventArgs e)
        {
            if ((Z2_Z1.Text != "1" && Z2_Z1.Text != "0") ||
                (Z3_Z1.Text != "1" && Z3_Z1.Text != "0") ||
                (Z4_Z1.Text != "1" && Z4_Z1.Text != "0") ||
                (Z1_Z2.Text != "1" && Z1_Z2.Text != "0") ||
                (Z3_Z2.Text != "1" && Z3_Z2.Text != "0") ||
                (Z4_Z2.Text != "1" && Z4_Z2.Text != "0") ||
                (Z1_Z3.Text != "1" && Z1_Z3.Text != "0") ||
                (Z2_Z3.Text != "1" && Z2_Z3.Text != "0") ||
                (Z1_Z4.Text != "1" && Z1_Z4.Text != "0") ||
                (Z2_Z4.Text != "1" && Z2_Z4.Text != "0") ||
                (Z3_Z4.Text != "1" && Z3_Z4.Text != "0"))
            {
                MessageBox.Show("Матрица заполнена не полностью.");
            }
            else
            {

                double rez1, rez2, rez3, rez4;

                rez1 = Int32.Parse(Z2_Z1.Text) + Int32.Parse(Z3_Z1.Text) + Int32.Parse(Z4_Z1.Text);
                rez2 = Int32.Parse(Z1_Z2.Text) + Int32.Parse(Z3_Z2.Text) + Int32.Parse(Z4_Z2.Text);
                rez3 = Int32.Parse(Z2_Z3.Text) + Int32.Parse(Z2_Z3.Text) + Int32.Parse(Z4_Z3.Text);
                rez4 = Int32.Parse(Z1_Z4.Text) + Int32.Parse(Z2_Z4.Text) + Int32.Parse(Z3_Z4.Text);

                double sum = rez1 + rez2 + rez3 + rez4;

                double K1, K2, K3, K4;

                K1 = Math.Round(rez1 / sum, 2);
                K2 = Math.Round(rez2 / sum, 2);
                K3 = Math.Round(rez3 / sum, 2);
                K4 = Math.Round(rez4 / sum, 2);

                Rez_Z1.Text = "Коэффициент " + K1.ToString();
                Rez_Z2.Text = "Коэффициент " + K2.ToString();
                Rez_Z3.Text = "Коэффициент " + K3.ToString();
                Rez_Z4.Text = "Коэффициент " + K4.ToString();

                var map = new Dictionary<string, double>();

                map.Add("1", K1);
                map.Add("2", K2);
                map.Add("3", K3);
                map.Add("4", K4);

                //Res.Text = "Лучший вариант: " + map.OrderByDescending(key => key.Value).Max().Value + " = " + map.OrderByDescending(key => key.Value).First().Value.ToString();

                //map.OrderByDescending(key => key.Value);

                if (map.OrderByDescending(key => key.Value).First().Key == "1")
                {
                    N1.Text = "1";
                }
                if (map.OrderByDescending(key => key.Value).First().Key == "2")
                {
                    N2.Text = "1";
                }
                if (map.OrderByDescending(key => key.Value).First().Key == "3")
                {
                    N3.Text = "1";
                }
                if (map.OrderByDescending(key => key.Value).First().Key == "4")
                {
                    N4.Text = "1";
                }
            }
        }

        private void Button_Out(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox temp = new ComboBox();
            if (sender.Equals(Z2_Z1)) temp = Z1_Z2;
            if (sender.Equals(Z3_Z1)) temp = Z1_Z3;
            if (sender.Equals(Z4_Z1)) temp = Z1_Z4;
            if (sender.Equals(Z1_Z2)) temp = Z2_Z1;
            if (sender.Equals(Z3_Z2)) temp = Z2_Z3;
            if (sender.Equals(Z4_Z2)) temp = Z2_Z4;
            if (sender.Equals(Z1_Z3)) temp = Z3_Z1;
            if (sender.Equals(Z2_Z3)) temp = Z3_Z2;
            if (sender.Equals(Z4_Z3)) temp = Z3_Z4;
            if (sender.Equals(Z1_Z4)) temp = Z4_Z1;
            if (sender.Equals(Z2_Z4)) temp = Z4_Z2;
            if (sender.Equals(Z3_Z4)) temp = Z4_Z3;

            temp.SelectedIndex = ((ComboBox)sender).SelectedIndex == 0 ? 1 : 0;

            if (sender.Equals(Z2_Z1)) Z1_Z2 = temp;
            if (sender.Equals(Z3_Z1)) Z1_Z3 = temp;
            if (sender.Equals(Z4_Z1)) Z1_Z4 = temp;
            if (sender.Equals(Z1_Z2)) Z2_Z1 = temp;
            if (sender.Equals(Z3_Z2)) Z2_Z3 = temp;
            if (sender.Equals(Z4_Z2)) Z2_Z4 = temp;
            if (sender.Equals(Z1_Z3)) Z3_Z1 = temp;
            if (sender.Equals(Z2_Z3)) Z3_Z2 = temp;
            if (sender.Equals(Z4_Z3)) Z3_Z4 = temp;
            if (sender.Equals(Z1_Z4)) Z4_Z1 = temp;
            if (sender.Equals(Z2_Z4)) Z4_Z2 = temp;
            if (sender.Equals(Z3_Z4)) Z4_Z3 = temp;
        }
    }
}
