using System;
using System.Collections.Generic;
using System.Text;
namespace BTVN
{
    class sinhvien
    {
        //Mã sinh vien, Họ tên, Năm sinh, Điểm lập trình, Điểm CSDL,Điểm TB
        public string masv;
        private string HoTen;
        private int NamSinh;
        private double DiemLT, DiemCSDL, DiemTB;
        //Hàm tạo không tham số
        public sinhvien()
        {
            masv = "";
            HoTen = "";
            NamSinh = 1900;
            DiemLT = DiemCSDL = DiemTB = 0;
        }
        //hàm khởi tạo chuẩn 5 tham số
        public sinhvien(string masv, string HoTen, int NamSinh, double DiemLT, double DiemCSDL)
        {
            this.masv = masv;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = 0.5 * (DiemCSDL + DiemLT);
        }
        public void Nhap()
        {
            Console.WriteLine("ban dang goi ham nhap tt");
            Console.WriteLine(" Nhap ma cua sinh vien:");
            masv = Console.ReadLine();
            Console.WriteLine("Nhap ho ten cua sinh vien");
            HoTen = Console.ReadLine();
            Console.WriteLine(" Nhap nam sinh cua sinh vien");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao diem  lap trinh cua sinh vien:");
            DiemLT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao diem  co so du lieu cua sinh vien:");
            DiemCSDL = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ban dang goi ham xuat tt");
            Console.WriteLine("Ma cua sinh vien la: " + masv);
            Console.WriteLine("Ho ten cua sinh vien la: " + HoTen);
            Console.WriteLine("Diem lap trinh cua sinh vien la: " + DiemLT);
            Console.WriteLine("Diem co so du lieu cua sinh vien la: " + DiemCSDL);
            Console.WriteLine("Diem trung binh cua sinh vien la: " + DiemTB);
        }
    }
}
