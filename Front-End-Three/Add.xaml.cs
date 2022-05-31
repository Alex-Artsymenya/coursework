using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        bool isEmpty = true, isEmptyTwo = true, isEmptyThree = true;
        private IAdminAccess module;
        public Add(IAdminAccess module)
        {
            this.module = module;
            InitializeComponent();
        }


         private void Add_Click(object sender, RoutedEventArgs e)
         {
            DatabaseEntities.TypeOfDetail TypeOfDetail;
            switch (DetailType.Text)
            {
                case "Двигатель":
                    {
                        TypeOfDetail = DatabaseEntities.TypeOfDetail.Engine;
                        break;
                    }
                case "Трансмиссия":
                    {
                        TypeOfDetail = DatabaseEntities.TypeOfDetail.Transmission;
                        break;
                    }
                case "Аккумулятр":
                    {
                        TypeOfDetail = DatabaseEntities.TypeOfDetail.Battery;
                        break;
                    }
                case "Демпфер":
                    {
                        TypeOfDetail = DatabaseEntities.TypeOfDetail.Damper;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Введите Двигатель, Трансмиссия, Аккумулятр или Демпфер!");
                        return;
                    }
            }
            Random random = new Random();
            var value = (random.Next(0, 9).ToString() + "," + random.Next(0,9).ToString());
            var answer = module.CreateDetailNomenclature(new DatabaseEntities.DetailNomenclature()
            {
                Name = Name.Text,
                Description = Description.Text,
                DetailType = TypeOfDetail,
                TotalRate = double.Parse(value)
            });
            switch (answer)
            {
                case ClassLibraryForTCPConnectionAPI_C_sharp_.AnswerFromServer.Successfully:
                    {
                        MessageBox.Show("Успешно!");
                        break;
                    }
                case ClassLibraryForTCPConnectionAPI_C_sharp_.AnswerFromServer.Error:
                    {
                        MessageBox.Show("Ошибка!");
                        break;
                    }
                case ClassLibraryForTCPConnectionAPI_C_sharp_.AnswerFromServer.UnknownCommand:
                    {
                        MessageBox.Show("Ошибка!");
                        break;
                    }
                default:
                    break;
            }
        }

        private void Description_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isEmptyThree)
            {
                Description.Text = "";
                isEmptyThree = false;
            }
            if (Description.Text == "Введите описание")
            {
                Description.Text = "";
            }
            if (DetailType.Text == "")
            {
                DetailType.Text = "Введите тип детали";
            }
            if (Name.Text == "")
            {
                Name.Text = "Введите название";
            }
        }

        private void DetailType_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isEmptyTwo)
            {
                DetailType.Text = "";
                isEmptyTwo = false;
            }
            if (DetailType.Text == "Введите тип детали")
            {
                DetailType.Text = "";
            }
            if (Description.Text == "")
            {
                Description.Text = "Введите описание";
            }
            if (Name.Text == "")
            {
                Name.Text = "Введите название";
            }
        }

        private void Name_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isEmpty)
            {
                Name.Text = "";
                isEmpty = false;
            }
            if (Name.Text == "Введите название")
            {
                Name.Text = "";
            }
            if (Description.Text == "")
            {
                Description.Text = "Введите описание";
            }
            if (DetailType.Text == "")
            {
                DetailType.Text = "Введите тип детали";
            }
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
