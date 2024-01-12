using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    //Dinh nghia lop san pham
    class SanPham
    {
        private string _ten;
        private double _giaMua;
        public SanPham()
        { }
        public SanPham(string ten, double giaMua)
        {
            this._ten = ten;
            this._giaMua = giaMua;
        }
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        public double GiaMua
        {
            get { return _giaMua; }
            set
            {
                if (value >= 0)
                    _giaMua = value;
            }
        }
        public virtual double TinhGiaBan()
        {
            return 0;
        }
        public virtual string InChiTiet()
        {
            return _ten;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ten san pham:");
            _ten = Console.ReadLine();
            Console.Write("Nhap gia mua:");
            _giaMua = double.Parse(Console.ReadLine());
            }
        }
    }

