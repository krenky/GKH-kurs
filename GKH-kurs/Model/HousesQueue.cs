using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKH_kurs.Model
{
    /// <summary>
    /// Адресная очередь домов
    /// </summary>
    public class HousesQueue
    {
        House head;

        public HousesQueue()
        {
            head = new House();
        }

        public House Head { get => head; set => head = value; }

        /// <summary>
        /// Добавить дом
        /// </summary>
        /// <param name="street">Улица дома</param>
        /// <param name="number">Номер дома</param>
        /// <returns></returns>
        public bool AddHouse(string street, int number)
        {
            if(Head.houseNext == null)
            {
                head.houseNext = new House(street, number);
                return true;
            }
            else
            {
                House current = Head.houseNext;
                while(current.houseNext != null)
                {
                    current = current.houseNext;
                }
                current.houseNext = new House(street, number);
                return true;
            }
        }
        /// <summary>
        /// Удаление дома
        /// </summary>
        /// <returns></returns>
        public bool DeleteHouse()
        {
            if (Head.houseNext != null)
            {
                if (head.houseNext.houseNext == null)
                    head.houseNext = null;
                else
                    head.houseNext = head.houseNext.houseNext;
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Обновление данных дома
        /// </summary>
        /// <param name="houseId">идентефикатор дома</param>
        /// <param name="newStreet">Новое название улицы</param>
        /// <param name="newNumber">Новый номер дома</param>
        /// <returns></returns>
        public bool UpdateHouse(int houseId, string newStreet, int newNumber)
        {
            House current = Head.houseNext;
            while (current.HouseId != houseId)
            {
                if (current.houseNext == null)
                {
                    return false;
                }
                current = current.houseNext;
            }
            current.Street = newStreet;
            current.Number = newNumber;
            return true;
        }

        public House GetHouse(int houseId)
        {
            var current = head.houseNext;
            while( current != null )
            {
                if( current.HouseId == houseId )
                    return current;
            }
            return null;
        }

        public IEnumerable<House> GetEnumerator()
        {
            var current = head.houseNext;
            while(current != null)
            {
                yield return current;
                current = current.houseNext;
            }
        }
    }
}
