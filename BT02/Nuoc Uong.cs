using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class NuocUong : SanPham
    {
        private double _loiNhuan;
        private double _chiPhiGiuLanh;

        public NuocUong() : base()
        { }

        public NuocUong(string ten, double giaMua) : base(ten, giaMua)
        {
            _loiNhuan = giaMua * 0.15;
            _chiPhiGiuLanh = giaMua * 0.1;
        }

        public override double TinhGiaBan()
        {
            return GiaMua + _loiNhuan + _chiPhiGiuLanh;
        }

        public override string InChiTiet()
        {
            return Ten + " - " + TinhGiaBan();
        }

        public override void Nhap()
        {
            base.Nhap();
            _loiNhuan = GiaMua * 0.15;
            _chiPhiGiuLanh = GiaMua * 0.1;
        }
    }
}
