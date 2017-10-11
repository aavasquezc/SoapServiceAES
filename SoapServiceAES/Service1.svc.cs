using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapServiceAES
{
    public class Service1 : IService1
    {
        public decimal Calculator(CalculatorClass calculator)
        {

            decimal response = 0m;
            response = calculator.FirstNumber + calculator.SecondNumber;
            return response;
        }
    }
}
