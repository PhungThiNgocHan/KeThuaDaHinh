using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class QuanLySanPham
    {
        private string _ten;
        private SanPham[] _danhSachSP;
        private int n;

        public QuanLySanPham()
        {
            _ten = "Cua Hang Ban Le";
            _danhSachSP = new SanPham[100];
            n = 0;
        }
        public QuanLySanPham(int size)
        {
            _ten = "Cua Hang Ban Le";
            _danhSachSP = new SanPham[size];
            n = 0;
        }
        public void Nhap()
        {
            int chon;
            SanPham sp;
            while (true)
            {
                Console.Write("Chon loai san pham (1: Socola, 2: Nuoc uong): ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sp = new Socola();
                        sp.Nhap();
                        _danhSachSP[n++] = sp;
                        break;
                    case 2:
                        sp = new NuocUong();
                        sp.Nhap();
                        _danhSachSP[n++] = sp;
                        break;
                }
                Console.Write("Lua chon khong hop le.");
                chon = int.Parse(Console.ReadLine());
                if (chon == 0)
                    break;
            }
        }
        public void InDanhSachSP()
        {
            Console.WriteLine("Ten cua hang:" + _ten);
            Console.WriteLine("--------Danh sach cac san pham--------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(_danhSachSP[i].InChiTiet());
            }
        }
    }

    class Program
    {
        static void Main()
        {
            QuanLySanPham quanLySP = new QuanLySanPham();
            quanLySP.Nhap();
            quanLySP.InDanhSachSP();
            Console.ReadLine();
        }
    }
}
