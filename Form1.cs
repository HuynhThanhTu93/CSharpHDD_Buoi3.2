namespace CSharpHDD_Buoi3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.setHoten(txt_HT.Text);
            sinhVien.setMSSV(int.Parse(txt_MaSV.Text));
            sinhVien.setNgaysinh(dt_NS.Value);
            sinhVien.setSdt(txt_SDT.Text);
            sinhVien.setGioitinh(txt_GT.Text);

            MessageBox.Show("Họ và tên: " + sinhVien.getHoten() + "\nMSSV: " + sinhVien.getMSSV() + "\nNgày sinh: " + sinhVien.getNgaysinh() + "\nSĐT: " + sinhVien.getSdt() + "\nGiới tính: " + sinhVien.getGioitinh());
        }

    }
}
