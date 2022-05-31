using ClassLibraryForTCPConnectionAPI_C_sharp_;
using DatabaseEntities;

namespace TCPConnectionAPIClientModule_C_sharp_
{
    public interface IExpertAccess : IDataViewAccess, ICommonAccess
    {
        AnswerFromServer RateDetailNomenclature(int vehicleId, float expertRate);
    }
}
