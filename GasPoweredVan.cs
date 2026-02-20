using System;

namespace MyFleetManager
{
    class GasPoweredVan : Vehicle
    {
        private double _fuel;

        public double Fuel
        {
            get => _fuel;
            set
            {
                // Encapsulation: validation logic
                if (value < 0) throw new ArgumentException("Fuel level cannot be negative!");
                _fuel = value;
            }
        }

        public GasPoweredVan(string id, string name, double f) : base(id, name)
        {
            Fuel = f;
        }

        public override void CalculateRange()
        {
            // Robustness logic: Check for energy threshold
            if (_fuel < 5)
                throw new Exception($"Low Fuel Alert on {UnitName}!");

            double range = _fuel * 10.0;
            Console.WriteLine($"Van {UnitName} (ID: {TravelID}) can travel {range} km.");
        }
    }
}