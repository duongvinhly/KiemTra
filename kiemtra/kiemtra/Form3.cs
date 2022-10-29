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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            NapDSNhom();
        }
        private void ShowForm1()
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
        void NapDSNhom()
        {
            var list = NhomViewModel.Getlist();
            //bdsSinhVien.DataSource = list;
            for (int i = 0; i < list.Count; i++)
            {
                comboBox1.Items.Add(list[i].TenNhom);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var list = NhomViewModel.Getlist();
            var id = 0;
            var chimuc = comboBox1.SelectedIndex;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == chimuc)
                {
                    id = list[i].ID;
                }
            }
            var sv = new Nguoi
            {
                TenGoi = textBox1.Text,
                Email = textBox2.Text,
                DiaChi = textBox3.Text,
                SDT = textBox4.Text,
                IDNhom = id,

            };
            NguoiViewModel.AddSinhVien(sv);
            Thread thread = new Thread(new ThreadStart(ShowForm1)); 
            thread.Start(); 
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm1));
            thread.Start();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
