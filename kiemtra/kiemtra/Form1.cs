using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using kiemtra.Model;
using kiemtra.ViewModel;

namespace kiemtra
{
    public partial class Form1 : Form
    {
        int manhom = 0;
        int manguoi = 0;
        public Form1()
        {
            InitializeComponent();
            NapDSNhom();
        }
        void NapDSNhom()
        {
            var list = NhomViewModel.Getlist();
            dataGridView1.DataSource = list;
        }
        void NapDSNguoi(int id)
        {

            var list = NguoiViewModel.Getlist(id);
            dataGridView2.DataSource = list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDBDataSet.Nguoi' table. You can move, or remove it, as needed.
            this.nguoiTableAdapter.Fill(this.qLDBDataSet.Nguoi);
            // TODO: This line of code loads data into the 'qLDBDataSet.Nguoi' table. You can move, or remove it, as needed.
            this.nguoiTableAdapter.Fill(this.qLDBDataSet.Nguoi);
            // TODO: This line of code loads data into the 'qLDBDataSet.Nhom' table. You can move, or remove it, as needed.
            this.nhomTableAdapter.Fill(this.qLDBDataSet.Nhom);
            // TODO: This line of code loads data into the 'qLDBDataSet.Nguoi' table. You can move, or remove it, as needed.
            this.nguoiTableAdapter.Fill(this.qLDBDataSet.Nguoi);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ShowForm2()
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
        
        private void ThemClick(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm2));
            thread.Start();
            this.Close();
        }

        private void XoaClick(object sender, EventArgs e)
        {
            if (manhom != 0)
            {
                var rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NhomViewModel.DeleteNhom(manhom);
                    NapDSNhom();
                }
            }
        }

        private void Cellclick_nhom(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            string tennhom = Convert.ToString(row.Cells["TenNhom"].Value);
            var list = NhomViewModel.Getlist();
            int id = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].TenNhom.Equals(tennhom))
                {
                    id = list[i].ID;
                    manhom = id;
                }
            }
            NapDSNguoi(manhom);
        }
        private void ShowForm3()
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
        private void ThemLienLacClick(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm3));
            thread.Start();
            this.Close();
        }

        private void XoaLienlacClick(object sender, EventArgs e)
        {
            if (manguoi != 0)
            {
                var rs = MessageBox.Show("Ban co chac chan muon xoa lien lac nay?", "Chu y", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NguoiViewModel.DeleteSinhVien(manguoi);
                    NapDSNhom();
                    NapDSNguoi(manhom);
                }
            }
        }

        private void CellclickNguoi(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView2.Rows[e.RowIndex];
            txtTenGoi.Text = Convert.ToString(row.Cells["TenGoi"].Value);
            txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);
            txtSDT.Text = Convert.ToString(row.Cells["SDT"].Value);
            string email = Convert.ToString(row.Cells["Email"].Value);

            var list = NguoiViewModel.GetlistAll();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Email.Equals(email))
                {
                    txtDiaChi.Text = list[i].DiaChi;
                    manguoi = list[i].ID;
                }
            }
        }

        private void txtDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
