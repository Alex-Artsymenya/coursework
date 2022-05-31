using ClassLibraryForTCPConnectionAPI_C_sharp_;
using DatabaseEntities;

namespace TCPConnectionAPIClientModule_C_sharp_
{
    public interface IDataModifyAccess : IDataViewAccess   
    {
        AnswerFromServer CreateDetailNomenclature(DetailNomenclature obj);
        AnswerFromServer ModifyDetailNomenclature(DetailNomenclature obj);
        AnswerFromServer DeleteDetailNomenclature(int id);
    }
}
