using QLsinhVien;
using QuanLySinhVien;
using System;
using System.Windows.Forms;

namespace QLsinhVien
{
    public partial class MainForm : Form
    {
        private Label lblWelcome;
        private Button btnQuanLySinhVien;
        private Button btnQuanLyLop;
        private Button btnLogout;
        private Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            SinhVienForm sinhVienForm = new SinhVienForm();
            sinhVienForm.ShowDialog();
        }

        private void btnQuanLyLop_Click(object sender, EventArgs e)
        {
            LopForm lopForm = new LopForm();
            lopForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnQuanLySinhVien = new System.Windows.Forms.Button();
            this.btnQuanLyLop = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblWelcome.Location = new System.Drawing.Point(365, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(111, 18);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Xin chào Admin";

            // btnQuanLySinhVien
            this.btnQuanLySinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnQuanLySinhVien.Location = new System.Drawing.Point(343, 95);
            this.btnQuanLySinhVien.Name = "btnQuanLySinhVien";
            this.btnQuanLySinhVien.Size = new System.Drawing.Size(154, 51);
            this.btnQuanLySinhVien.TabIndex = 1;
            this.btnQuanLySinhVien.Text = "Quản lý sinh viên";
            this.btnQuanLySinhVien.UseVisualStyleBackColor = true;
            this.btnQuanLySinhVien.Click += new System.EventHandler(this.btnQuanLySinhVien_Click); // SỬA Ở ĐÂY

            // btnQuanLyLop
            this.btnQuanLyLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnQuanLyLop.Location = new System.Drawing.Point(343, 174);
            this.btnQuanLyLop.Name = "btnQuanLyLop";
            this.btnQuanLyLop.Size = new System.Drawing.Size(154, 49);
            this.btnQuanLyLop.TabIndex = 2;
            this.btnQuanLyLop.Text = "Quản lý lớp";
            this.btnQuanLyLop.UseVisualStyleBackColor = true;
            this.btnQuanLyLop.Click += new System.EventHandler(this.btnQuanLyLop_Click); // SỬA Ở ĐÂY

            // btnLogout
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLogout.Location = new System.Drawing.Point(345, 252);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(152, 43);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click); // SỬA Ở ĐÂY

            // btnExit
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExit.Location = new System.Drawing.Point(345, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát chương trình";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click); // THÊM DÒNG NÀY

            // MainForm
            this.ClientSize = new System.Drawing.Size(897, 445);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnQuanLyLop);
            this.Controls.Add(this.btnQuanLySinhVien);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}