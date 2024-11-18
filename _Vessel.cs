using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Кусовая
{
    
    internal class Vessel
    {
        //поля
        private int _number;
        private string _FN_capitan;
        private _type_vessel _type;
        private int _lifting_capacity;
        private int _year_building;
        private string _photo;
        private string _port_postscripts;
        //свойства

        internal Vessel(int _number = 0, string _FN_capitan = "", _type_vessel _type = _type_vessel.undefined, int _lifting_capcity = 0,int _year_building = 0, string _photo = "",string _port_postscripts = "")
        {

        } 
        public void Print_Info()
        {
            Console.WriteLine("Информация о судне");
            Console.WriteLine("Номер судна:{0}", _number);
            Console.WriteLine("ФИО капитана судна:{0}", _FN_capitan);
            Console.WriteLine("Тип судна:{0}", _type);
            Console.WriteLine("Грузоподъёмность судна:{0}", _lifting_capacity);
            Console.WriteLine("Год создания судна:{0}", _year_building);
            Console.WriteLine("Фото судна:{0}", _photo);
            Console.WriteLine("Порт приписки судна:{0}", _port_postscripts);
        }
    }
    enum _type_vessel
    {
        undefined,
        tanker,
        bulker,
        dry_cargo,
        ro_ro,
        ferry,
        container_ships
    }
}
