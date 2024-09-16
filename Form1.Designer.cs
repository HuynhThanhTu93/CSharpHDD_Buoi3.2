namespace CSharpHDD_Buoi3._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_S = new Label();
            txt_G = new Label();
            txt_MaSV = new TextBox();
            txt_HT = new TextBox();
            btn_nhap = new Button();
            dt_NS = new DateTimePicker();
            txt_SDT = new TextBox();
            txt_GT = new TextBox();
            dtG_Thongtin = new DataGridView();
            btn_xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dtG_Thongtin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 46);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã số sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 112);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 0;
            label3.Text = "Ngày sinh: ";
            // 
            // txt_S
            // 
            txt_S.AutoSize = true;
            txt_S.Location = new Point(23, 154);
            txt_S.Name = "txt_S";
            txt_S.Size = new Size(108, 19);
            txt_S.TabIndex = 0;
            txt_S.Text = "Số điện thoại:";
            // 
            // txt_G
            // 
            txt_G.AutoSize = true;
            txt_G.Location = new Point(23, 187);
            txt_G.Name = "txt_G";
            txt_G.Size = new Size(75, 19);
            txt_G.TabIndex = 0;
            txt_G.Text = "Giới tính:";
            // 
            // txt_MaSV
            // 
            txt_MaSV.Location = new Point(137, 38);
            txt_MaSV.Name = "txt_MaSV";
            txt_MaSV.Size = new Size(100, 27);
            txt_MaSV.TabIndex = 1;
            // 
            // txt_HT
            // 
            txt_HT.Location = new Point(137, 76);
            txt_HT.Name = "txt_HT";
            txt_HT.Size = new Size(100, 27);
            txt_HT.TabIndex = 1;
            // 
            // btn_nhap
            // 
            btn_nhap.Location = new Point(301, 38);
            btn_nhap.Name = "btn_nhap";
            btn_nhap.Size = new Size(98, 65);
            btn_nhap.TabIndex = 2;
            btn_nhap.Text = "Nhập";
            btn_nhap.UseVisualStyleBackColor = true;
            btn_nhap.Click += btn_nhap_Click;
            // 
            // dt_NS
            // 
            dt_NS.Location = new Point(119, 112);
            dt_NS.Name = "dt_NS";
            dt_NS.Size = new Size(280, 27);
            dt_NS.TabIndex = 3;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(137, 146);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(100, 27);
            txt_SDT.TabIndex = 1;
            // 
            // txt_GT
            // 
            txt_GT.Location = new Point(137, 176);
            txt_GT.Name = "txt_GT";
            txt_GT.Size = new Size(100, 27);
            txt_GT.TabIndex = 1;
            // 
            // dtG_Thongtin
            // 
            dtG_Thongtin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtG_Thongtin.Location = new Point(23, 225);
            dtG_Thongtin.Name = "dtG_Thongtin";
            dtG_Thongtin.Size = new Size(589, 187);
            dtG_Thongtin.TabIndex = 4;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(301, 146);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(98, 65);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_nhap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 424);
            Controls.Add(dtG_Thongtin);
            Controls.Add(dt_NS);
            Controls.Add(btn_xoa);
            Controls.Add(btn_nhap);
            Controls.Add(txt_GT);
            Controls.Add(txt_SDT);
            Controls.Add(txt_HT);
            Controls.Add(txt_MaSV);
            Controls.Add(txt_G);
            Controls.Add(label3);
            Controls.Add(txt_S);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtG_Thongtin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label txt_S;
        private Label txt_G;
        private TextBox txt_MaSV;
        private TextBox txt_HT;
        private Button btn_nhap;
        private DateTimePicker dt_NS;
        private TextBox txt_SDT;
        private TextBox txt_GT;
        private DataGridView dtG_Thongtin;
        private Button btn_xoa;
    }
}
