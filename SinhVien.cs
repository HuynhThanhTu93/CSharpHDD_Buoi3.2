using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHDD_Buoi3._2
{
    internal class SinhVien
    {
       private string mSSV;
       private string hoTen;
       private DateTime ngaySinh;
       private string sDT;
       private string gioiTinh;
        public string MSSV { get => mSSV; set => mSSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        // Viết hàm khỏi tạo:
        // Hàm khởi tạo ko có tham số:
        public SinhVien() { }

        // hàm khởi tạo có tham số:
        public SinhVien(string mSSV, string hoTen, DateTime ngaySinh, string sDT, string gioiTinh)
        {
            this.MSSV = mSSV;
            this.HoTen = hoTen;
            this.NgaySinh=ngaySinh;
            this.SDT = sDT;
            this.GioiTinh=gioiTinh;
        }

      
    }
}
