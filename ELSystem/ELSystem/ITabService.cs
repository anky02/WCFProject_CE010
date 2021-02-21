using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data;

namespace ELSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITabService" in both code and config file together.
    [ServiceContract]
    public interface ITabService
    {
        [OperationContract]
        void Create(Tab tab);

        [OperationContract]
        DataSet GetAllTab(int CurId);

        [OperationContract]
        bool Update(Tab tab);

        [OperationContract]
        Tab Read(int TabId);

        [OperationContract]
        bool Delete(int TabId);

        [OperationContract]
        string GetFileContent(int CourseId,string TabName);

        [OperationContract]
        List<string> GetAllTabNames(int CurId);
    }
}
