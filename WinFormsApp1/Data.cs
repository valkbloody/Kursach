using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Кусовая;

namespace WinFormsApp1
{
    static class Data
    {
        public static Vessel Vessel1 = new Vessel(111111, "Ivanov Sergey Vladimirovich", _type_vessel.container_ships, 30000, 2001, "2", "Murmansk");
        public static Vessel Vessel2 = new Vessel(111112, "Kotik Ivan Alexandrovich", _type_vessel.ferry, 10000, 2005, "2", "Sochi");
        public static Vessel Vessel3 = new Vessel(111113, "Konstantin Edouardovich Tsiolkovskii", _type_vessel.dry_cargo, 30000, 1998, "2", "Sahalin");
        public static Vessel Vessel4 = new Vessel(111114, "Hvorostovsky Dmitriy Aleksandrovich", _type_vessel.bulker, 15000, 2015, "2", "Habarovsk");
        public static Client Client1 = new Client("OOO Sibmetal", 777771, "Sberbank", "Moscow");
        public static Client Client2 = new Client("OOO Lada", 777771, "Sberbank", "Severodvinsk");
        public static Load Load1 = new Load(11, "Copper", 4000, __measurement.kg, 2000);
        public static Load Load2 = new Load(12, "Steel", 5000, __measurement.kg, 3000);
        public static Load[] Load3 = { Load1,Load2 };
        //public static  Сonsignment Сonsignment1 = new Сonsignment(1111, 100001, "Vorzogori", "Severodvinsk", "01.01.24", "15.01.24",Load3);
    }
}
