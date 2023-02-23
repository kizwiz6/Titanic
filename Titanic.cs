using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    public class Titanic
    {
        private readonly IPassengerDataProvider _passengerDataProvider;

        public Titanic(IPassengerDataProvider passengerDataProvider)
        {
            _passengerDataProvider = passengerDataProvider;
        }

        public int NumberOfPassengers => _passengerDataProvider.GetAllPassengers().Length;

        public int NumberOfSurvivors
        {
            get
            {
                var passengers = _passengerDataProvider.GetAllPassengers();
                return passengers.Count(p => p.IsSurvivor);
            }
        }
    }
}
