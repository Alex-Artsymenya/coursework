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
    /// Логика взаимодействия для Sort.xaml
    /// </summary>
    enum ParamToSort
    {
        Name,
        Description,
        DetailType,
        Rating
    }
    public partial class Sort : Window
    {
        int counter = 0;
        ParamToSort choosenParam;
        private IDataViewAccess module;
        List<DatabaseEntities.DetailNomenclature> details;
        public Sort(IDataViewAccess module)
        {
            choosenParam = ParamToSort.Name;
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

        private void SortByName_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToSort.Name;
            TopMenuItem.Header = "Сортировка по названию";
            details = details.OrderBy(c => c.Name).ToList();
        }

        private void SortByRating_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToSort.Rating;
            TopMenuItem.Header = "Сортировка по рейтингу";
            details = details.OrderByDescending(c => c.TotalRate).ToList();
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

        private void FindSome_Click(object sender, RoutedEventArgs e)
        {
            if(details.Count == 0)
            {
                MessageBox.Show("Ошибка!");
            }
            else
            {
                Show(details[0]);
            }
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SortByDescription_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToSort.Description;
            TopMenuItem.Header = "Сортировка по описанию";
            details = details.OrderBy(c => c.Description).ToList();
        }

        private void SortByDetailType_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToSort.DetailType;
            TopMenuItem.Header = "Сортировка по типу детали";
            details = details.OrderByDescending(c => c.DetailType).ToList();
        }
    }
}
