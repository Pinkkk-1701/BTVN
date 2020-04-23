using System;
using System.Collections.Generic;
using System.Text;
namespace BTVN
{
    class DanhSachSinhVien
    {
        private int n;
        private sinhvien[] DS;
        public void Nhap()
        {
            Console.WriteLine("Hay nhap so sinh vien trong danh sach:");
            n = Convert.ToInt32(Console.ReadLine());
            DS = new sinhvien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("hay nhap thong tin sinh vien thu:" + i);
                DS[i] = new sinhvien();
                DS[i].Nhap();
            }
        }
        public void Xuat()
        {
            if (DS != null && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    DS[i].Xuat();
                }
            }
        }
        public void SapXep() //sap xep theo ma sinh vien tang dan
        {
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < 0; j++)
                {
                    if (string.Compare(DS[i].masv, DS[j].masv, true) > 0)
                    {
                        sinhvien tg = new sinhvien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;
                    }
                }
        }
    }
}