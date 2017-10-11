using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapServiceAES
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        decimal Calculator(CalculatorClass calculator);

    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
   
    [DataContract]

    public class CalculatorClass
    {
        decimal _FirstNumber;
        decimal _SecondNumber;
        
        [DataMember]
        public decimal FirstNumber { get => _FirstNumber; set => _FirstNumber = value; }
        [DataMember]
        public decimal SecondNumber { get => _SecondNumber; set => _SecondNumber = value; }
    }
}
