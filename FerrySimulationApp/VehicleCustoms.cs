﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class VehicleCustoms
    {
        public static void PerformCustomsCheck(bool CargoDoorsOpen, List<char> Path)
        {
            Console.WriteLine($"Inspection started! Doors are opened?: {!CargoDoorsOpen}");
            Thread.Sleep(1000);
            Console.WriteLine($"Inspection Done! Doors are opened?: {CargoDoorsOpen}");
            Path.Add('C');
        }
    }
}
