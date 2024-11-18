using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Кусовая;

namespace WinFormsApp1
{
    public enum __measurement
    {
        kg,
        t,
        g,
        undefined
    }
    public class Load : IToString
    {
        private int _number;
        private string _name;
        private int _declared_weight;
        private __measurement _measurement;
        private int _insured_weight;

        public int _Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Номер не может быть отрицательным");
                else _number = value;
            }
        }
        public string _Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "") throw new ArgumentException("Название груза не введено");
                else _name = value;
            }
        }
        public __measurement _Measurement
        {
            get
            {
                return _measurement;
            }
            set
            {
                if (value == __measurement.undefined) throw new ArgumentException("Единица измерений не введена");
                else _measurement = value;
            }
        }
        public int _Insured_weight
        {
            get
            {
                return _insured_weight;
            }
            set
            {
                if (value < 0 || value > _declared_weight) throw new ArgumentException("Застрахованный вес не корректен");
                else _insured_weight = value;
            }
        }
        public int _Declared_weight
        {
            get
            {
                return _declared_weight;
            }
            set
            {
                if (value < 0 ) throw new ArgumentException("Заявленный вес не может быть отрицателньым");
                else _declared_weight = value;
            }
        }
        public Load(int _number,string _name,int _declared_weight, __measurement _measurement,int _insured_weight)
        {
            _Number = _number;
            _Name = _name;
            _Declared_weight = _declared_weight;
            _Measurement = _measurement;
            _Insured_weight = _insured_weight;
        }
        public Load()
        {
            _number =0;
            _name = "";
            _declared_weight = 0;
            _measurement = __measurement.undefined;
            _Insured_weight = 0;
        }
        public override string ToString()
        {
            return $"{_number} {_name} {_declared_weight} {_measurement} {_insured_weight} ";
        }
        
    }
}
