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

namespace BASEDEDATOSLUCHA
{
    public partial class FLOG : Form
    {
        public FLOG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OHDJA7I\SQLEXPRESS;Initial Catalog=DBLUCHA;Persist Security Info=True;User ID=sa;Password=1q2w3e4r");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From TB_LOGIN where Usuario='" + textBox1.Text+ "'and Contraseña='"+textBox2.Text+ "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                FMENU ss = new FMENU();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Porfavor revisa que este bien los datos");
            }
        }

        private void FLOG_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
