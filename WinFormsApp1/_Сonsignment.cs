using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Кусовая;

namespace WinFormsApp1
{
    public class Сonsignment : IToString
    {
        private int _сons_number;
        private int _declaration_number;
        private DateTime _dispatch_date;
        private DateTime _arrivel_date;
        private string _place_dispatch;
        private string _place_arrivel;
        private List <Load> _content;
        public int _Сons_number
        {
            get
            {
                return _сons_number;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Таможенный номер не может быть отрицательным");
                else _сons_number = value;
            }
        }
        public int _Declaration_number
        {
            get
            {
                return _declaration_number;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Номер декларации не может быть отрицательным");
                else _declaration_number = value;
            }
        }
        public DateTime _Dispatch_date
        {
            get
            {
                return _dispatch_date;
            }
            set
            {
                DateTime date = new DateTime();
                if (value == date) throw new ArgumentException("Дата отправки не введена");
                else _dispatch_date = value;
            }
        }
        public DateTime _Arrivel_date
        {
            get
            {
                return _arrivel_date;
            }
            set
            {
                DateTime date = new DateTime();
                if (value == date) throw new ArgumentException("Дата прибытия не введена");
                else _arrivel_date = value;
            }
        }
        public string _Place_dispatch
        {
            get
            {
                return _place_dispatch;
            }
            set
            {
                if (value == "") throw new ArgumentException("Место отправки не введено");
                else _place_dispatch = value;
            }
        }
        public string _Place_arrivel
        {
            get
            {
                return _place_arrivel;
            }
            set
            {
                if (value == "") throw new ArgumentException("Место прибытия не введено");
                else _place_arrivel = value;
            }
        }
        public List<Load> _Content
        {
            get
            {
                return _content;
            }
            set
            {
                if (value.Count == 0) throw new ArgumentException("Груз не выбран");
                else _content = value;
            }
        }
        public Сonsignment(int _сons_number, int _declaration_number,string _place_dispatch,string _place_arrivel,DateTime _dispatch_date, DateTime _arrivel_date, List<Load> _load)
        {
            _Сons_number = _сons_number;
            _Declaration_number = _declaration_number;
            _Dispatch_date = _dispatch_date;
            _Arrivel_date = _arrivel_date;
            _Place_dispatch = _place_dispatch;
            _Place_arrivel = _place_arrivel;
            _Content = _load;
        }
        public Сonsignment(Load _load)
        {
            _content.Add(_load);
        }
        public override string ToString()
        {
            return $"{_сons_number} {_declaration_number} {_dispatch_date} {_arrivel_date} {_place_dispatch} {_place_arrivel}";
        }
    }
}

