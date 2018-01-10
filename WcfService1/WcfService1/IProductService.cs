using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",UriTemplate = "FindAll", ResponseFormat = WebMessageFormat.Json)]
        List<productDetail> FindAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Find/{id}", ResponseFormat = WebMessageFormat.Json)]
        productDetail Find(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Create", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        bool Create(productDetail Product);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Edit", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        bool Edit(productDetail Product);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Delete", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        bool Delete(productDetail Product);
    }
}
