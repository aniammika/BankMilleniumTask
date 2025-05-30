using BankMilleniumTask.Contracts.Models;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BankMilleniumTask.Services.SOAP
{
    [ServiceContract]
    public interface ISummerActivityService
    {
        [OperationContract]
        GetActivityResponse GetSummerActivity(GetActivityRequest request);
    }

    [DataContract] 
    public class GetActivityRequest
    {
        [DataMember]
        public int Id { get; set; }
    }

    [DataContract]
    public class GetActivityResponse
    {
        [DataMember]
        public string Result { get; set; }
    }
}
