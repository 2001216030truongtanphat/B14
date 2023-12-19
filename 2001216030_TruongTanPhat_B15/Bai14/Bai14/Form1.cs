using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = ConnectDB.Connect(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            try
            {
                connection.Open();
                MessageBox.Show("Ket noi voi co so du lieu thanh cong", "Thong bao", MessageBoxButtons.OK);
                Form2 form2 = new Form2(connection);
                form2.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ket noi voi co so du lieu khong thanh cong. \nLoi: " + ex.Message, "Thong bao", MessageBoxButtons.OK);
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co muon thoat khong","Xac Nhan",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chương trình hoặc tên cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK);
                textBox2.Focus();
            }
        }
    }
}
