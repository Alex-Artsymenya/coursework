using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        int counter = 0;
        ParamToFind choosenParam;
        bool isEmpty = true;
        private IAdminAccess module;
        List<DatabaseEntities.DetailNomenclature> details;
        public Edit(IAdminAccess module)
        {
            choosenParam = ParamToFind.Name;
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

        private void SomeInput_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isEmpty)
            {
                SomeInput.Text = "";
                isEmpty = false;
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
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFind.None;
            TopMenuItem.Header = "Показать всё";
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

        private void FindSome_Click(object sender, RoutedEventArgs e)
        {
            details.Clear();
            switch (choosenParam)
            {
                case ParamToFind.Name:
                    {
                        details = module.GetAllDetailNomenclatures();
                        details = details.FindAll(c => (c.Name == SomeInput.Text)).ToList();
                        break;
                    }
                case ParamToFind.Description:
                    {
                        details = module.GetAllDetailNomenclatures();
                        details = details.FindAll(c => (c.Description == SomeInput.Text)).ToList();
                        break;
                    }
                case ParamToFind.DetailType:
                    {
                        details = module.GetAllDetailNomenclatures();
                        details = details.FindAll(c => (c.DetailType.ToString() == SomeInput.Text)).ToList();
                        break;
                    }
                case ParamToFind.None:
                    {
                        details = module.GetAllDetailNomenclatures();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Повторите попытку!");
                        break;
                    }
            }
        }

        private void FindByName_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFind.Name;
            TopMenuItem.Header = "Поиск по имени";
        }

        private void FindByDescription_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFind.Description;
            TopMenuItem.Header = "Поиск по описанию";
        }

        private void FindByDetailType_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFind.DetailType;
            TopMenuItem.Header = "Поиск по типу детали";
        }
        private void NewDetail(DatabaseEntities.DetailNomenclature detail)
        {
            DatabaseEntities.TypeOfDetail typeOfDetail;
            switch (DetailType.Text)
            {
                case "Двигатель":
                    {
                        typeOfDetail = DatabaseEntities.TypeOfDetail.Engine;
                        break;
                    }
                case "Трансмиссия":
                    {
                        typeOfDetail = DatabaseEntities.TypeOfDetail.Transmission;
                        break;
                    }
                case "Аккумулятр":
                    {
                        typeOfDetail = DatabaseEntities.TypeOfDetail.Battery;
                        break;
                    }
                case "Демпфер":
                    {
                        typeOfDetail = DatabaseEntities.TypeOfDetail.Damper;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Введите Двигатель, Трансмиссия, Аккумулятр или Демпфер!");
                        return;
                    }
            }
            if (detail == null)
            {
                MessageBox.Show("Не найдено!");
            }
            else
            {
                detail.Name = DetailName.Text;
                detail.TotalRate = float.Parse(DetailRate.Text);
                detail.Description = DetailDescription.Text;
                detail.DetailType = typeOfDetail;
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            DatabaseEntities.TypeOfDetail typeOfDetail;
            switch (DetailType.Text)
            {
                case "Двигатель":
                    {
                        typeOfDetail = DatabaseEntities.TypeOfDetail.Engine;
                        break;
                    }
                case "Трансмиссия":
                    {
                        typeOfDetail = DatabaseEntities.TypeOfDetail.Transmission;
                        break;
                    }
                case "Аккумулятр":
                    {
                        typeOfDetail = DatabaseEntities.TypeOfDetail.Battery;
                        break;
                    }
                case "Демпфер":
                    {
                        typeOfDetail = DatabaseEntities.TypeOfDetail.Damper;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Введите Двигатель, Трансмиссия, Аккумулятр или Демпфер!");
                        return;
                    }
            }

            if (DetailType.Text == "" || DetailName.Text == "" || DetailDescription.Text == "")
            {
                MessageBox.Show("Ошибка!");
            }
            else
                NewDetail(details[counter]);
        }

        private void SaveObject_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in details)
            {
                module.ModifyDetailNomenclature(item);
            }
        }
    }
}
