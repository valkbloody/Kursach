using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace Кусовая
{
    
    public class Vessel : IToString
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
        public int _Number
        {
            get 
            {
                return _number;
            }
            set {
                if (value < 0) throw new ArgumentException("Номер не может быть отрицательным");
                else   _number = value;
            }
        }
        public string _FN_Capitan
        {
            get
            {
                return _FN_capitan;
            }
            set
            {
                if (value == "") throw new ArgumentException("ФИО капитана не введено");
                else _FN_capitan = value;
            }
        }
        public _type_vessel _Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (value == _type_vessel.undefined) throw new ArgumentException("Тип судна не введен");
                else _type = value;
            }
        }
        public int _Lifting_capacity
        {
            get
            {
                return _lifting_capacity;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Грузоподъёмность не может быть отрицательной");
                else _number = value;
            }
        }
        public int _Year_building
        {
            get
            {
                return _year_building;
            }
            set
            {
                if (value < 1960 || value > 2024) throw new ArgumentException("Год строительства не корренктный");
                else _number = value;
            }
        }
        public string _Port_postscripts
        {
            get
            {
                return _port_postscripts;
            }
            set
            {
                if (value == "") throw new ArgumentException("Порт не введен");
                else _port_postscripts = value;
            }
        }
        public Vessel(int _number, string _FN_capitan, _type_vessel _type, int _lifting_capcity, int _year_building, string _photo1, string _port_postscripts)
        {
            _Number = _number;
            _FN_Capitan = _FN_capitan;
            _Type = _type;
            _Lifting_capacity = _lifting_capcity;
            _Year_building = _year_building;
            _Port_postscripts = _port_postscripts;
            _photo = _photo1;

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
        public override string ToString()
        {
            return $"{_number} {_FN_capitan} {_type} {_lifting_capacity} {_year_building} {_port_postscripts} ";
        }
        public string ToString_Number()
        {
            return $"{_number}";
        }
    }
    public enum _type_vessel
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
