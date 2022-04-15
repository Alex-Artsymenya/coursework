using ClassLibraryForTCPConnectionAPI_C_sharp_;
using System;
using DatabaseEntities;
namespace TCPConnectionAPI_C_sharp_
{
    public class WeightingOfExpertOpinions : IExpertMethod
    {
        public IRateable Rate(IRateable obj, Expert expert, float rate)
        {
            Rate newRate = new Rate(expert.RateWeight / (obj.Rate.Count + 1));
            newRate.Expert = expert;
            newRate.TimeOfCommit = DateTime.Now;
            obj.Rate.Add(newRate);
            double sum = 0;
            foreach (var item in obj.Rate)
            {
                sum += item.Value;
            }
            obj.TotalRate = sum;
            return obj;
        }
    }
}
