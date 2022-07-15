using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PruebaTelefonicaMaicol.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PruebaTelefonicaMaicol
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Pruebas : IService1
    {
        public string ListarFibonacci(int param)
        {
            string jsonReturn;
            try
            {
                Fibonacci fibonacci = new Fibonacci();
                return fibonacci.SerieFibonacci(param);
            }
            catch (ArgumentException excArgu)
            {
                jsonReturn = "Error " + excArgu.ToString();
            }
            catch (TimeoutException excTime)
            {
                jsonReturn = "Error " + excTime.ToString();
            }
            finally
            {

            }
            return jsonReturn;
        }

        public string CalcularFormulaCuadratica()
        {
            double a, b, c;
            JObject jsonReturn = new JObject();
            try
            {
                a = 2;
                b = 7;
                c = 2;

                FormulaCuadratica formulaCuantica = new FormulaCuadratica();
                jsonReturn.Add("statusCode", 200);

                return formulaCuantica.CalcularFormula(a, b, c);
            }
            catch (ArgumentException excArgu)
            {
                jsonReturn.Add("Error", excArgu.ToString());
            }
            catch (TimeoutException excTime)
            {
                jsonReturn.Add("Error", excTime.ToString());
            }

            return JsonConvert.SerializeObject(jsonReturn);
        }
    }

}
