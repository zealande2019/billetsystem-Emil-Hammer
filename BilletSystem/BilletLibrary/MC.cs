﻿using System;

namespace BilletLibrary
{
    public class MC : Vehicle
    {
        public override decimal Price()
        {
            return 125;
        }

        public override string VehicleStatus()
        {
            return "MC";
        }
    }
}