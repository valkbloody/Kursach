using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace Кусовая
{
    public class Client : IToString
    {
        private string _name_client;
        private int _INN;
        private string _bank;
        private string _address;
        public string _Name_client
        {
            get
            {
                return _name_client;
            }
            set
            {
                if (value == "") throw new ArgumentException("Имя клиента не введено");
                else _name_client = value;
            }
        }
        public string _Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value == "") throw new ArgumentException("Адрес клиента не введен");
                else _address = value;
            }
        }
        public string _INN_
        {
            get
            {
                return Convert.ToString(_INN);
            }
            set
            {
                if (Convert.ToInt32(value) <= 0) throw new ArgumentException("ИНН не корректен");
                else _INN = (Convert.ToInt32(value));
            }
        }
        public string _Bank
        {
            get
            {
                return _bank;
            }
            set
            {
                if (value == "") throw new ArgumentException("Банк клиента не введен");
                else _bank = value;
            }
        }
        public Client(string _name_client, int _INN, string _bank, string _address)
        {
            _Name_client = _name_client;
            _INN_ = Convert.ToString(_INN);
            _Bank = _bank;
            _Address = _address;
        }
        public override string ToString()
        {
            return $"{_name_client} {_INN} {_bank} {_Address}";
        }
    }
}
