using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKH_kurs.Model
{
    public class Apartment
    {
        private int apartmentId;

        public Apartment(int number, float payment)
        {
            Number = number;
            Payment = payment;
            LastIndex++;
            apartmentId = LastIndex;
        }

        public int ApartmentId => apartmentId; 
        public int Number { get; set; }
        public float Payment { get; set; }
        public static int LastIndex { get; set; } = 0;
    }
}
