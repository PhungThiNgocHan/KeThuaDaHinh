using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Socola : SanPham
    {
        private double _loiNhuan;
        public Socola() : base()
        { }
        public Socola(string ten, double giaMua) : base(ten, giaMua)
        {
            _loiNhuan = GiaMua * 0.2;
        }
        public override double TinhGiaBan()
        {
            return GiaMua + _loiNhuan;
        }
        public override string InChiTiet()
        {
            return Ten + " - " + TinhGiaBan();
        }
        public override void Nhap()
        {
            base.Nhap();
            _loiNhuan = GiaMua * 0.2;
        }
    }
}
