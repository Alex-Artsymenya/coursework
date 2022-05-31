using System;
using DatabaseEntities;
namespace TCPConnectionAPI_C_sharp_
{
    public interface IDataModifyPermission : IDataViewPermision
    {
        int CreateDetailNomenclature(DetailNomenclature obj);
        bool DeleteDetailNomenclature(Func<DetailNomenclature, bool> comparer);
        bool UpdateDetailNomenclature(DetailNomenclature newVersion);
    }
}
