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
    public partial class FMERMA : Form
    {
        public FMERMA()
        {
            InitializeComponent();
        }

        private void tB_PRODUCTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_PRODUCTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBLUCHADataSet);

        }

        private void FMERMA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBLUCHADataSet.TB_MERMA' table. You can move, or remove it, as needed.
            this.tB_MERMATableAdapter.Fill(this.dBLUCHADataSet.TB_MERMA);
            // TODO: This line of code loads data into the 'dBLUCHADataSet.TB_PRODUCTO' table. You can move, or remove it, as needed.
            this.tB_PRODUCTOTableAdapter.Fill(this.dBLUCHADataSet.TB_PRODUCTO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tB_MERMATableAdapter.AgregarMerma(iD_PROTextBox.Text, nOMBRETextBox.Text, pRE_PROTextBox.Text, fEC_INGDateTimePicker.Text, tIP_PROTextBox.Text, pROVEDORTextBox.Text);
            this.tB_MERMATableAdapter.Fill(this.dBLUCHADataSet.TB_MERMA);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tB_MERMATableAdapter.BuscarMerma(this.dBLUCHADataSet.TB_MERMA, iD_PROTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tB_MERMATableAdapter.ModificarMerma(iD_PROTextBox.Text, nOMBRETextBox.Text, pRE_PROTextBox.Text, fEC_INGDateTimePicker.Text, tIP_PROTextBox.Text, pROVEDORTextBox.Text, iD_PROTextBox.Text);
            this.tB_MERMATableAdapter.Fill(this.dBLUCHADataSet.TB_MERMA);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tB_MERMATableAdapter.EliminarMerma(iD_PROTextBox.Text);
            this.tB_MERMATableAdapter.Fill(this.dBLUCHADataSet.TB_MERMA);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FMENU frm = new FMENU();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
