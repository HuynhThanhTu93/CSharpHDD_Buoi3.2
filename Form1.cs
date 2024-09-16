namespace CSharpHDD_Buoi3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> li_sinhVien = new List<SinhVien>();
        private void btn_nhap_Click(object sender, EventArgs e)
        { /*
            SinhVien sinhVien1 = new SinhVien(txt_MaSV.Text,txt_HT.Text,dt_NS.Value,txt_SDT.Text,txt_GT.Text);

            MessageBox.Show("Mã sinh viên: " + sinhVien1.getMSSV());
           */

            SinhVien sinhVien = new SinhVien();
            sinhVien.HoTen=txt_HT.Text;
            sinhVien.MSSV=txt_MaSV.Text;
            sinhVien.NgaySinh=dt_NS.Value;
            sinhVien.SDT=txt_SDT.Text;
            sinhVien.GioiTinh = txt_GT.Text;

            li_sinhVien.Add(sinhVien);
            dtG_Thongtin.DataSource = null; // reset DataGView
            dtG_Thongtin.DataSource = li_sinhVien;

            //MessageBox.Show("Họ và tên: " + sinhVien.getHoten() + "\nMSSV: " + sinhVien.getMSSV() + "\nNgày sinh: " + sinhVien.getNgaysinh() + "\nSĐT: " + sinhVien.getSdt() + "\nGiới tính: " + sinhVien.getGioitinh());
        }

    }
}
