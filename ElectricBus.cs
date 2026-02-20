using System;

namespace MyFleetManager
{
    class ElectricBus : Vehicle
    {
        private double _battery;

        public double Battery
        {
            get => _battery;
            set
            {
                // Encapsulation: logic inside the set accessor to prevent invalid data
                if (value < 0) throw new ArgumentException("Battery percentage cannot be negative!");
                _battery = value;
            }
        }

        // Inheritance: passes 'id' and 'name' to the base Vehicle constructor
        public ElectricBus(string id, string name, double bat) : base(id, name)
        {
            Battery = bat;
        }

        // Polymorphism: Overriding the base method with specific Bus math
        public override void CalculateRange()
        {
            // Robustness logic: Check for energy threshold
            if (_battery < 5)
                throw new Exception($"Low Battery Alert on {UnitName}!");

            double range = _battery * 4.5;
            Console.WriteLine($"Bus {UnitName} (ID: {TravelID}) can travel {range} km.");
        }
    }
}