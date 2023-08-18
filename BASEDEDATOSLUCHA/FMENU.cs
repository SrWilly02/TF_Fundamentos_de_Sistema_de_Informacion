using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASEDEDATOSLUCHA
{
    public partial class FMENU : Form
    {
        public FMENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FLOG frm = new FLOG();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FINV sus = new FINV();
            sus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMERMA sus = new FMERMA();
            sus.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
