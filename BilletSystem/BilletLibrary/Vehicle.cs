using System;

namespace BilletLibrary
{
    public abstract class Vehicle
    {
        private string _licenseplate;
        public DateTime Date;
        public decimal Discount;

        public abstract string VehicleStatus();
        public abstract decimal Price();
        public double PriceWithDiscount()
        {
            return Convert.ToDouble(Price() - Price() * Discount);
        }

        public string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value.Length <= 7 && value.Length > 0)
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