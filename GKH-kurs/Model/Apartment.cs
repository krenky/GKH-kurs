using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKH_kurs.Model
{
    /// <summary>
    /// Классс: квартира
    /// </summary>
    public class Apartment
    {
        private int apartmentId;
        /// <summary>
        /// Конструктор квартиры
        /// </summary>
        /// <param name="number">Номер квртиры</param>
        /// <param name="payment">Оплата за квртиру</param>
        public Apartment(int number, float payment)
        {
            Number = number;
            Payment = payment;
            LastIndex++;
            apartmentId = LastIndex;
        }
        /// <summary>
        /// Идентефикатор квартиры
        /// </summary>
        public int ApartmentId => apartmentId; 
        /// <summary>
        /// Номер квартиры
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Оплата за квартиру
        /// </summary>
        public float Payment { get; set; }
        /// <summary>
        /// Идентефикатор последней добавленной квартиры
        /// </summary>
        public static int LastIndex { get; set; } = 0;
    }
}
