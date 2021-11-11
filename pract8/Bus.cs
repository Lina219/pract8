using System;
using System.Collections.Generic;
using System.Text;

namespace pract8
{
    class Bus : ITransport, ICar
    {
        public int Capacity { get; set; }
        public string Name { get; set; }

        public Bus(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public string ShowInformation()
        {
            return "Вместимость транспорта (" + Name + ") = " + Capacity;
        }

        public int CompareTo (object object1)//Сравнение
        {
            Bus temp = (Bus)object1;
            return this.Capacity - temp.Capacity;
            //if (this.BusCapacity > temp.BusCapacity)
            //{
            //    return 1;
            //}
            //if (this.BusCapacity < temp.BusCapacity)
            //{
            //    return -1;
            //}
            //return 0;
        }

        public Bus ShallowClone()//Поверхностное клонирование
        {
            return (Bus)this.MemberwiseClone();
        }

        public object Clone()//Полное клонирование
        {
            Bus bus = new Bus(this.Name, this.Capacity);
            return bus;
        }
    }
}
