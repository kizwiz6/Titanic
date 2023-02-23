using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    public class FilePassengerDataProvider : IPassengerDataProvider
    {
        private readonly string _fileName;

        public FilePassengerDataProvider(string fileName)
        {
            _fileName = fileName;
        }

        public Passenger[] GetAllPassengers()
        {
            // Read passengers from file and return as an array
            // Code omitted for brevity
        }
    }
}
