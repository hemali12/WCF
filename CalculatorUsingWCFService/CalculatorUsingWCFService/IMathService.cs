using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorUsingWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMathService" in both code and config file together.
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        Int32 Add(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Substract(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Division(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Multiplication(Int32 num1, Int32 num2);


    }
}
