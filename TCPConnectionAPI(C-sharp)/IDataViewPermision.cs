using DatabaseEntities;
using System;
using System.Collections.Generic;
namespace TCPConnectionAPI_C_sharp_
{
    public interface IDataViewPermision : IDisposable
    {
        List<DetailNomenclature> FindDetailNomenclaturesWhere(Func<DetailNomenclature, bool> comparer);
    }
}
