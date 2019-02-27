using System;

namespace BilletLibrary
{
    public abstract class Vehicle
    {
        private string _licenseplate;
        public DateTime Date;

        public abstract string VehicleStatus();
        public abstract decimal Price();

        public string Licenseplate
        {
            get{ return _licenseplate;}
            set
            {
                if (value.Length <= 7)
                {
                    _licenseplate = value;
                }
                else
                {
                    throw new Exception("License plate has to be 7 or less characters.");
                }
            }
        }
    }
}   