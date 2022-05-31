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
        public static string CreateReportAboutCarriers()
        {
            using (IDataViewPermision db = new DatabaseContext())
            {
                var carriers = db.FindDetailNomenclaturesWhere(c => c != null);
                string report = "Состояние номенклатур на " + DateTime.Now + "\n\n";
                foreach (var item in carriers)
                {
                    report += "Название: " + item.Name + "\n";
                    report += "Описание: " + item.Description + "\n";
                    report += "Тип детали: " + item.DetailType +  "\n";
                    report += "Общая оценка: " + item.TotalRate + "\n";
                    report += '\n';
                }
                return report;
            }
        }
    }
}
