
namespace BASEDEDATOSLUCHA
{
    partial class FMERMA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_PROLabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label pRE_PROLabel;
            System.Windows.Forms.Label fEC_INGLabel;
            System.Windows.Forms.Label tIP_PROLabel;
            System.Windows.Forms.Label pROVEDORLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMERMA));
            this.tB_MERMADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tB_MERMABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLUCHADataSet = new BASEDEDATOSLUCHA.DBLUCHADataSet();
            this.iD_PROTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.pRE_PROTextBox = new System.Windows.Forms.TextBox();
            this.fEC_INGDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tIP_PROTextBox = new System.Windows.Forms.TextBox();
            this.pROVEDORTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_PRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_PRODUCTOTableAdapter = new BASEDEDATOSLUCHA.DBLUCHADataSetTableAdapters.TB_PRODUCTOTableAdapter();
            this.tableAdapterManager = new BASEDEDATOSLUCHA.DBLUCHADataSetTableAdapters.TableAdapterManager();
            this.tB_MERMATableAdapter = new BASEDEDATOSLUCHA.DBLUCHADataSetTableAdapters.TB_MERMATableAdapter();
            iD_PROLabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            pRE_PROLabel = new System.Windows.Forms.Label();
            fEC_INGLabel = new System.Windows.Forms.Label();
            tIP_PROLabel = new System.Windows.Forms.Label();
            pROVEDORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tB_MERMADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_MERMABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLUCHADataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_PRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PROLabel
            // 
            iD_PROLabel.AutoSize = true;
            iD_PROLabel.Location = new System.Drawing.Point(24, 31);
            iD_PROLabel.Name = "iD_PROLabel";
            iD_PROLabel.Size = new System.Drawing.Size(47, 13);
            iD_PROLabel.TabIndex = 2;
            iD_PROLabel.Text = "ID PRO:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(24, 57);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(57, 13);
            nOMBRELabel.TabIndex = 4;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // pRE_PROLabel
            // 
            pRE_PROLabel.AutoSize = true;
            pRE_PROLabel.Location = new System.Drawing.Point(24, 83);
            pRE_PROLabel.Name = "pRE_PROLabel";
            pRE_PROLabel.Size = new System.Drawing.Size(58, 13);
            pRE_PROLabel.TabIndex = 6;
            pRE_PROLabel.Text = "PRE PRO:";
            // 
            // fEC_INGLabel
            // 
            fEC_INGLabel.AutoSize = true;
            fEC_INGLabel.Location = new System.Drawing.Point(24, 110);
            fEC_INGLabel.Name = "fEC_INGLabel";
            fEC_INGLabel.Size = new System.Drawing.Size(52, 13);
            fEC_INGLabel.TabIndex = 8;
            fEC_INGLabel.Text = "FEC ING:";
            // 
            // tIP_PROLabel
            // 
            tIP_PROLabel.AutoSize = true;
            tIP_PROLabel.Location = new System.Drawing.Point(24, 135);
            tIP_PROLabel.Name = "tIP_PROLabel";
            tIP_PROLabel.Size = new System.Drawing.Size(53, 13);
            tIP_PROLabel.TabIndex = 10;
            tIP_PROLabel.Text = "TIP PRO:";
            // 
            // pROVEDORLabel
            // 
            pROVEDORLabel.AutoSize = true;
            pROVEDORLabel.Location = new System.Drawing.Point(24, 161);
            pROVEDORLabel.Name = "pROVEDORLabel";
            pROVEDORLabel.Size = new System.Drawing.Size(71, 13);
            pROVEDORLabel.TabIndex = 12;
            pROVEDORLabel.Text = "PROVEDOR:";
            // 
            // tB_MERMADataGridView
            // 
            this.tB_MERMADataGridView.AutoGenerateColumns = false;
            this.tB_MERMADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tB_MERMADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tB_MERMADataGridView.DataSource = this.tB_MERMABindingSource;
            this.tB_MERMADataGridView.Location = new System.Drawing.Point(392, 70);
            this.tB_MERMADataGridView.Name = "tB_MERMADataGridView";
            this.tB_MERMADataGridView.Size = new System.Drawing.Size(643, 336);
            this.tB_MERMADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PRO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_PRO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRE_PRO";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRE_PRO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FEC_ING";
            this.dataGridViewTextBoxColumn4.HeaderText = "FEC_ING";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TIP_PRO";
            this.dataGridViewTextBoxColumn5.HeaderText = "TIP_PRO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PROVEDOR";
            this.dataGridViewTextBoxColumn6.HeaderText = "PROVEDOR";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tB_MERMABindingSource
            // 
            this.tB_MERMABindingSource.DataMember = "TB_MERMA";
            this.tB_MERMABindingSource.DataSource = this.dBLUCHADataSet;
            // 
            // dBLUCHADataSet
            // 
            this.dBLUCHADataSet.DataSetName = "DBLUCHADataSet";
            this.dBLUCHADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_PROTextBox
            // 
            this.iD_PROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_MERMABindingSource, "ID_PRO", true));
            this.iD_PROTextBox.Location = new System.Drawing.Point(101, 28);
            this.iD_PROTextBox.Name = "iD_PROTextBox";
            this.iD_PROTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_PROTextBox.TabIndex = 3;
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_MERMABindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(101, 54);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(200, 20);
            this.nOMBRETextBox.TabIndex = 5;
            // 
            // pRE_PROTextBox
            // 
            this.pRE_PROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_MERMABindingSource, "PRE_PRO", true));
            this.pRE_PROTextBox.Location = new System.Drawing.Point(101, 80);
            this.pRE_PROTextBox.Name = "pRE_PROTextBox";
            this.pRE_PROTextBox.Size = new System.Drawing.Size(200, 20);
            this.pRE_PROTextBox.TabIndex = 7;
            // 
            // fEC_INGDateTimePicker
            // 
            this.fEC_INGDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tB_MERMABindingSource, "FEC_ING", true));
            this.fEC_INGDateTimePicker.Location = new System.Drawing.Point(101, 106);
            this.fEC_INGDateTimePicker.Name = "fEC_INGDateTimePicker";
            this.fEC_INGDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fEC_INGDateTimePicker.TabIndex = 9;
            // 
            // tIP_PROTextBox
            // 
            this.tIP_PROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_MERMABindingSource, "TIP_PRO", true));
            this.tIP_PROTextBox.Location = new System.Drawing.Point(101, 132);
            this.tIP_PROTextBox.Name = "tIP_PROTextBox";
            this.tIP_PROTextBox.Size = new System.Drawing.Size(200, 20);
            this.tIP_PROTextBox.TabIndex = 11;
            // 
            // pROVEDORTextBox
            // 
            this.pROVEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_MERMABindingSource, "PROVEDOR", true));
            this.pROVEDORTextBox.Location = new System.Drawing.Point(101, 158);
            this.pROVEDORTextBox.Name = "pROVEDORTextBox";
            this.pROVEDORTextBox.Size = new System.Drawing.Size(200, 20);
            this.pROVEDORTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(128, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Atras";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pROVEDORTextBox);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(pROVEDORLabel);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.tIP_PROTextBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(tIP_PROLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.fEC_INGDateTimePicker);
            this.panel1.Controls.Add(iD_PROLabel);
            this.panel1.Controls.Add(fEC_INGLabel);
            this.panel1.Controls.Add(this.iD_PROTextBox);
            this.panel1.Controls.Add(this.pRE_PROTextBox);
            this.panel1.Controls.Add(nOMBRELabel);
            this.panel1.Controls.Add(pRE_PROLabel);
            this.panel1.Controls.Add(this.nOMBRETextBox);
            this.panel1.Location = new System.Drawing.Point(25, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 336);
            this.panel1.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(128, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "MERMA";
            // 
            // tB_PRODUCTOBindingSource
            // 
            this.tB_PRODUCTOBindingSource.DataMember = "TB_PRODUCTO";
            this.tB_PRODUCTOBindingSource.DataSource = this.dBLUCHADataSet;
            // 
            // tB_PRODUCTOTableAdapter
            // 
            this.tB_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TB_LOGINTableAdapter = null;
            this.tableAdapterManager.TB_MERMATableAdapter = this.tB_MERMATableAdapter;
            this.tableAdapterManager.TB_PRODUCTOTableAdapter = this.tB_PRODUCTOTableAdapter;
            this.tableAdapterManager.UpdateOrder = BASEDEDATOSLUCHA.DBLUCHADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tB_MERMATableAdapter
            // 
            this.tB_MERMATableAdapter.ClearBeforeFill = true;
            // 
            // FMERMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1064, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tB_MERMADataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMERMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMERMA";
            this.Load += new System.EventHandler(this.FMERMA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tB_MERMADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_MERMABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLUCHADataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_PRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBLUCHADataSet dBLUCHADataSet;
        private System.Windows.Forms.BindingSource tB_PRODUCTOBindingSource;
        private DBLUCHADataSetTableAdapters.TB_PRODUCTOTableAdapter tB_PRODUCTOTableAdapter;
        private DBLUCHADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DBLUCHADataSetTableAdapters.TB_MERMATableAdapter tB_MERMATableAdapter;
        private System.Windows.Forms.BindingSource tB_MERMABindingSource;
        private System.Windows.Forms.DataGridView tB_MERMADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iD_PROTextBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox pRE_PROTextBox;
        private System.Windows.Forms.DateTimePicker fEC_INGDateTimePicker;
        private System.Windows.Forms.TextBox tIP_PROTextBox;
        private System.Windows.Forms.TextBox pROVEDORTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
    }
}