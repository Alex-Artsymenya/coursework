using DatabaseEntities;
using System;
using System.Collections.Generic;


namespace TCPConnectionAPI_C_sharp_
{
    public class ExpertAbilityProtocol : IExpertAbilityProtocol
    {
        public IExpertMethod expertMethod { get; set; }

        public IDataModifyPermission DBconnection;

        public bool Rate(Vehicle entity, Expert expert, float rate)
        {
            var ratedObj = expertMethod.Rate(entity, expert, rate) as Vehicle;
            return DBconnection.UpdateVehicle(ratedObj);
        }

        public List<Vehicle> FindVehiclesWhere(Func<Vehicle, bool> comparer)
        {
           return DBconnection.FindVehiclesWhere(comparer);
        }

        public void Dispose()
        {
            DBconnection.Dispose();
        }

        public ExpertAbilityProtocol()
        {
            expertMethod = new WeightingOfExpertOpinions();
            DBconnection = new DatabaseContext();
        }

    }
}
