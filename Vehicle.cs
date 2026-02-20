using System;

namespace MyFleetManager
{
    // Base Class: The parent for all transit units
    class Vehicle
    {
        // Encapsulation: Private fields protect data from direct external access
        private string _travelID;
        private string _unitName;

        // Public Properties with accessors
        public string TravelID { get => _travelID; set => _travelID = value; }
        public string UnitName { get => _unitName; set => _unitName = value; }

        // Constructor
        public Vehicle(string id, string name)
        {
            _travelID = id;
            _unitName = name;
        }

        // Polymorphism: 'virtual' keyword allows sub-classes to provide their own logic
        public virtual void CalculateRange()
        {
            Console.WriteLine("Generic Range: 0km");
        }
    }
}