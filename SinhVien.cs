using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHDD_Buoi3._2
{
    internal class SinhVien
    {
       private int mSSV;
       private string hoTen;
       private DateTime ngaySinh;
       private string sDT;
       private string gioiTinh;

        public void setMSSV(int mSSV) { this.mSSV = mSSV; }
        public int getMSSV() { return this.mSSV; }
        public void setHoten(string hoTen) { this.hoTen = hoTen; }
        public string getHoten() { return this.hoTen; }
        public void setNgaysinh(DateTime ngaySinh) { this.ngaySinh = ngaySinh; }
        public DateTime getNgaysinh() { return this.ngaySinh; }
        public void setSdt(string sDT) { this.sDT = sDT; }
        public string getSdt() { return this.sDT; }
        public void setGioitinh(string gioiTinh) { this.gioiTinh = gioiTinh; }
        public string getGioitinh() { return this.gioiTinh; }
    }
}
