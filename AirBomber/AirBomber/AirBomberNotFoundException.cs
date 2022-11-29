using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    [Serializable]
    internal class AirBomberNotFoundException : ApplicationException
    {
        public AirBomberNotFoundException(int i) : base($"Не найден объект по позиции {i}") { }
        public AirBomberNotFoundException() : base() { }
        public AirBomberNotFoundException(string message) : base(message) { }
        public AirBomberNotFoundException(string message, Exception exception) : base(message, exception) { }
        protected AirBomberNotFoundException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
    }
}
