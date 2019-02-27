using System;

namespace BilletLibrary
{
    public abstract class Vehicle
    {
        public string Licenseplate;
        public DateTime Date;

        public abstract string VehicleStatus();
        public abstract decimal Price();

    }
}   