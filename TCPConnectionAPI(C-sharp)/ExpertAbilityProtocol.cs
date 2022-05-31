using DatabaseEntities;
using System;
using System.Collections.Generic;


namespace TCPConnectionAPI_C_sharp_
{
    public class ExpertAbilityProtocol : IExpertAbilityProtocol
    {
        public IExpertMethod expertMethod { get; set; }

        public IDataModifyPermission DBconnection;

        public bool Rate(DetailNomenclature entity, Expert expert, float rate)
        {
            var ratedObj = expertMethod.Rate(entity, expert, rate) as DetailNomenclature;
            return DBconnection.UpdateDetailNomenclature(ratedObj);
        }

        public void Dispose()
        {
            DBconnection.Dispose();
        }

        public List<DetailNomenclature> FindDetailNomenclaturesWhere(Func<DetailNomenclature, bool> comparer)
        {
            return DBconnection.FindDetailNomenclaturesWhere(comparer);
        }

        public ExpertAbilityProtocol()
        {
            DBconnection = new DatabaseContext();
        }

    }
}
