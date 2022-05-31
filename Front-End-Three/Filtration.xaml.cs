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
    /// Логика взаимодействия для Filtration.xaml
    /// </summary>
    enum ParamToFilter
    {
        Rating
    }
    public partial class Filtration : Window
    {
        int counter = 0;
        ParamToFilter choosenParam;
        private IDataViewAccess module;
        List<DatabaseEntities.DetailNomenclature> details;
        public Filtration(IDataViewAccess module)
        {
            choosenParam = ParamToFilter.Rating;
            this.module = module;
            details = module.GetAllDetailNomenclatures();
            InitializeComponent();
            if (details == null || details.Count == 0 )
            {
                MessageBox.Show("Нет данных!");
            }
            else
                Show(details[0]);
        }

        private void FilterByRating_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFilter.Rating;
            TopMenuItem.Header = "Фильтрация по рейтингу";
        }

        private void FindSome_Click(object sender, RoutedEventArgs e)
        {
            double value1, value2;
            try
            {
                value1 = double.Parse(FirstValue.Text);
                value2 = double.Parse(SecondValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода!");
                return;
            }
            switch (choosenParam)
            {
                case ParamToFilter.Rating:
                    {
                        details = details.Where(c => (c.TotalRate >= value1 && c.TotalRate <= value2)).ToList();
                        break;
                    }
                default:
                    break;
            }
          
            counter = 0;
            if (details.Count == 0)
            {
                MessageBox.Show("Нет данных!");
                FirstValue.Text = "";
                SecondValue.Text = "";
                details = module.GetAllDetailNomenclatures();
            }
            if (details.Count == 0)
                MessageBox.Show("Ошибка!");
            else
                Show(details[counter]);

        }
        private void Show(DatabaseEntities.DetailNomenclature details)
        {
            if (details == null)
            {
                MessageBox.Show("Не найдено!");
            }
            else
            {
                DetailName.Text = details.Name;
                DetailDescription.Text = details.Description;
                DetailType.Text = details.DetailType.ToString();
                DetailRate.Text = details.TotalRate.ToString();
            }
        }


        private void LeftArrow_Click(object sender, RoutedEventArgs e)
        {
            if (details.Count == 0)
            {
                MessageBox.Show("Не найдено!");
            }
            else
            {
                if (counter == 0)
                {
                    Show(details[0]);
                }
                else
                {
                    counter--;
                    Show(details[counter]);
                }
            }
        }

        private void RightArrow_Click(object sender, RoutedEventArgs e)
        {
            if (details.Count == 0)
            {
                MessageBox.Show("Не найдено!");
            }
            else if (details.Count == 1)
            {
                Show(details[counter]);
            }
            else
            {
                if (counter + 1 == details.Count)
                {
                    Show(details[counter]);
                }
                else
                {
                    counter++;
                    Show(details[counter]);
                }
            }
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
