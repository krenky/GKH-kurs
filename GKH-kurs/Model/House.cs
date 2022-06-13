using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GKH_kurs.Model
{
    /// <summary>
    /// Класс: Дом
    /// </summary>
    public class House
    {
        private int houseId;
        private int count;
        private Apartment[] apartments = new Apartment[5];
        private House houseNext;
        /// <summary>
        /// Конструктор дома
        /// </summary>
        public House()
        {
            HouseId = 0;
        }
        /// <summary>
        /// Конструктор дома
        /// </summary>
        /// <param name="street">Улица дома</param>
        /// <param name="number">Номер дома</param>
        /// <exception cref="ArgumentNullException"></exception>
        public House(string street, int number)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            Number = number;
            LastIndex++;
            HouseId = LastIndex;
        }
        /// <summary>
        /// Идентефикатор дома
        /// </summary>
        public int HouseId { get => houseId; set => houseId = value; }
        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Номер дома
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Список квартир в доме 
        /// </summary>
        public Apartment[] Apartments { get => apartments; set => apartments = value; }
        /// <summary>
        /// Суммарная оплат по всем квартирам
        /// </summary>
        public float AllPayments
        {
            get
            {
                if(count != 0)
                    return Apartments.Where(x => x != null).Sum(x => x.Payment);
                return 0;
            }
        }
        public int Count => count;
        /// <summary>
        /// Идентефикатор последнего добавленого дома
        /// </summary>
        public static int LastIndex { get; set; } = 0;
        /// <summary>
        /// Ссылка на следуюющий дом
        /// </summary>
        public House HouseNext { get => houseNext; set => houseNext = value; }

        /// <summary>
        /// Изменения размера массива при малом количестве места в нём
        /// </summary>
        void Resize()
        {
            if (count == apartments.Length - 2)
            {
                Array.Resize(ref apartments, apartments.Length + 10);
            }
        }

        /// <summary>
        /// Добавление квартиры в дом
        /// </summary>
        /// <param name="number">Номер квартиры</param>
        /// <param name="payment">Оплата за услуги за месяц</param>
        /// <returns></returns>
        public bool Add(int number, float payment)
        {
            Resize();
            if (!Search(number))
            {
                if (count == 0)
                {
                    apartments[0] = new Apartment(number, payment);
                    count++;
                    return true;
                }
                else
                {
                    for(int i = 0; i < count; i++)
                    {
                        if(apartments[i+1] == null)
                        {
                            if(apartments[i].Number < number)
                            {
                                apartments[i+1] = new Apartment(number, payment);
                                count++;
                                return true;
                            }
                            else
                            {
                                MoveNextApartments(i);
                                apartments[i] = new Apartment(number, payment);
                                count++;
                                return true;
                            }
                        }
                        else
                        {
                            if (apartments[i].Number < number)
                            {
                                if (apartments[i + 1].Number > number)
                                {
                                    MoveNextApartments(i + 1);
                                    apartments[i + 1] = new Apartment(number, payment);
                                    count++;
                                    return true;
                                }
                            }
                            else
                            {
                                MoveNextApartments(i);
                                apartments[i] = new Apartment(number, payment);
                                count++;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Метод сдвига элементов массива в вперед
        /// </summary>
        /// <param name="number">Номер квартиры</param>
        void MoveNextApartments(int number)
        {
            for (int i = count; i >= number; i--)
            {
                apartments[i + 1] = apartments[i];
            }
            apartments[number] = null;
        }
        /// <summary>
        /// Метод сдвига элементов массива назад
        /// </summary>
        /// <param name="number">Номер квартиры</param>
        void MoveBackApartments(int number)
        {
            for (int i = number; i < count; i++)
            {
                apartments[i] = apartments[i + 1];
            }
        }
        /// <summary>
        /// Удаление квартиры из дома
        /// </summary>
        /// <param name="number">Номер квартиры</param>
        /// <returns></returns>
        public bool DeleteApartment(int number)
        {
            MoveBackApartments(number);
            count--;
            return true;
        }
        /// <summary>
        /// Проверка наличия квартиры в доме
        /// </summary>
        /// <param name="number">Номер квартиры</param>
        /// <returns></returns>
        public bool Search(int number)
        {
            if (count == 0)
                return false;
            else
            {
                return apartments.Where(x => x != null).Select(apart => apart.Number).Contains(number);
            }
        }
        /// <summary>
        /// Получение квартиры
        /// </summary>
        /// <param name="number">Номер квартиры</param>
        /// <returns></returns>
        public Apartment GetApartment(int number)
        {
            return apartments.Where(x => x.Number == number).FirstOrDefault();
        }
    }
}
