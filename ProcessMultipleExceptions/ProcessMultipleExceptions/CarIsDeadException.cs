using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{

        //Специальное исключение описывает детали условия входа автомобиля из строя
        public class CarIsDeadException : ApplicationException
        {
            //private string messageDetails = String.Empty;
            public DateTime ErrorTimeStamp { get; set; }
            public string CauseOfError { get; set; }
            public CarIsDeadException() { }
            //Передача сообщения конструктору родительского класса
            public CarIsDeadException(string message, string cause, DateTime time)
            {
                // messageDetails = message;
                CauseOfError = cause;
                ErrorTimeStamp = time;
            }
            //Переопределение свойства Exception.Message
            /*    public override string Message
                {
                    get
                    {
                       return string.Format("Car Error Message: {0}", messageDetails);
                    }
                }*/

    }
}
