using System;
using System.Collections.Generic;
using System.Text;

namespace pract8
{
    class Bus : ITransport, ICar
    {
        public int BusCapacity { get; set; }
        public string Name { get; set; }

        public Bus(string name,int capacity)
        {
            Name = name;
            BusCapacity = capacity;
        }

        public string ShowInformation()
        {
            string info = "Вместимость транспорта (" + Name + ") = " + BusCapacity;
            return info;
        }

        public int CompareTo (object object1)//Сравнение
        {
            Bus temp = (Bus)object1;
            if(this.BusCapacity > temp.BusCapacity)
            {
                return 1;
            }
            if (this.BusCapacity < temp.BusCapacity)
            {
                return -1;
            }
            return 0;
        }

        public Bus ShallowClone()//Поверхностное клонирование
        {
            return (Bus)this.MemberwiseClone();
        }

        public object Clone()//Полное клонирование
        {
            Bus bus = new Bus(this.Name, this.BusCapacity);
            //bus.Name = this.Name;
            //bus.BusCapacity = this.BusCapacity;
            return bus;
        }
    }
}
