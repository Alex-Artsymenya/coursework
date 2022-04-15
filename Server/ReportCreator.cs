using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPConnectionAPI_C_sharp_
{
    static public class ReportCreator
    {
        public static string CreateReportAboutVehicles()
        {
            using (IDataViewPermision db = new DatabaseContext())
            {
                var vehicles = db.FindVehiclesWhere(c => c != null);
                string str = ("Отчет состояния транспортных средств на " + DateTime.Now.ToString() + '\n');
                foreach (var item in vehicles)
                {
                    str += '\n';
                    str += "Производитель: " + item.Dealer + '\n';
                    str += "Модель: " + item.Model + '\n';
                    str += "Цвет: " + item.Colour + '\n';
                    str += "Регистрационный номер: " + item.RegistrationNumber + '\n';
                    str += "Общая оценка экспертов: " + item.TotalRate + '\n';
                }
                return str;
            }
        }
    }
}
