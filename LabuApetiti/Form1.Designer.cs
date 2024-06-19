namespace LabuApetiti
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            miOpenDB = new ToolStripMenuItem();
            miSaveDB = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabProdukti = new TabPage();
            dgvProdukti = new DataGridView();
            piegadatajiBindingSource = new BindingSource(components);
            dataSet11 = new DataSet1();
            tabPiegadataji = new TabPage();
            dgvPiegadataji = new DataGridView();
            tabIepirkumi = new TabPage();
            dgvIepirkumi = new DataGridView();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewComboBoxColumn();
            produktiBindingSource = new BindingSource(components);
            colDaudzums = new DataGridViewTextBoxColumn();
            colCena = new DataGridViewTextBoxColumn();
            colSumma = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewComboBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabProdukti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdukti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piegadatajiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).BeginInit();
            tabPiegadataji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPiegadataji).BeginInit();
            tabIepirkumi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIepirkumi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produktiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { miOpenDB, miSaveDB, miExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(989, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // miOpenDB
            // 
            miOpenDB.Name = "miOpenDB";
            miOpenDB.Size = new Size(95, 20);
            miOpenDB.Text = "Atvērt DB failu";
            miOpenDB.Click += miOpenDB_Click;
            // 
            // miSaveDB
            // 
            miSaveDB.Name = "miSaveDB";
            miSaveDB.Size = new Size(132, 20);
            miSaveDB.Text = "Saglabāt DB failu kā...";
            miSaveDB.Click += miSaveDB_Click;
            // 
            // miExit
            // 
            miExit.Alignment = ToolStripItemAlignment.Right;
            miExit.Name = "miExit";
            miExit.Size = new Size(80, 20);
            miExit.Text = "Beigt darbu";
            miExit.Click += beigtDarbuToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProdukti);
            tabControl1.Controls.Add(tabPiegadataji);
            tabControl1.Controls.Add(tabIepirkumi);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(989, 582);
            tabControl1.TabIndex = 1;
            // 
            // tabProdukti
            // 
            tabProdukti.Controls.Add(dgvProdukti);
            tabProdukti.Location = new Point(4, 24);
            tabProdukti.Name = "tabProdukti";
            tabProdukti.Padding = new Padding(3);
            tabProdukti.Size = new Size(981, 554);
            tabProdukti.TabIndex = 0;
            tabProdukti.Text = "Produkti";
            tabProdukti.UseVisualStyleBackColor = true;
            // 
            // dgvProdukti
            // 
            dgvProdukti.AutoGenerateColumns = false;
            dgvProdukti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdukti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdukti.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn3 });
            dgvProdukti.DataMember = "Produkti";
            dgvProdukti.DataSource = dataSet11;
            dgvProdukti.Dock = DockStyle.Fill;
            dgvProdukti.Location = new Point(3, 3);
            dgvProdukti.Name = "dgvProdukti";
            dgvProdukti.Size = new Size(975, 548);
            dgvProdukti.TabIndex = 0;
            // 
            // piegadatajiBindingSource
            // 
            piegadatajiBindingSource.DataMember = "Piegadataji";
            piegadatajiBindingSource.DataSource = dataSet11;
            // 
            // dataSet11
            // 
            dataSet11.DataSetName = "DataSet1";
            dataSet11.Namespace = "http://tempuri.org/DataSet1.xsd";
            dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPiegadataji
            // 
            tabPiegadataji.Controls.Add(dgvPiegadataji);
            tabPiegadataji.Location = new Point(4, 24);
            tabPiegadataji.Name = "tabPiegadataji";
            tabPiegadataji.Padding = new Padding(3);
            tabPiegadataji.Size = new Size(981, 554);
            tabPiegadataji.TabIndex = 1;
            tabPiegadataji.Text = "Piegādātāji";
            tabPiegadataji.UseVisualStyleBackColor = true;
            // 
            // dgvPiegadataji
            // 
            dgvPiegadataji.AutoGenerateColumns = false;
            dgvPiegadataji.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPiegadataji.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPiegadataji.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dgvPiegadataji.DataMember = "Piegadataji";
            dgvPiegadataji.DataSource = dataSet11;
            dgvPiegadataji.Dock = DockStyle.Fill;
            dgvPiegadataji.Location = new Point(3, 3);
            dgvPiegadataji.Name = "dgvPiegadataji";
            dgvPiegadataji.Size = new Size(975, 548);
            dgvPiegadataji.TabIndex = 0;
            // 
            // tabIepirkumi
            // 
            tabIepirkumi.Controls.Add(dgvIepirkumi);
            tabIepirkumi.Location = new Point(4, 24);
            tabIepirkumi.Name = "tabIepirkumi";
            tabIepirkumi.Padding = new Padding(3);
            tabIepirkumi.Size = new Size(981, 554);
            tabIepirkumi.TabIndex = 2;
            tabIepirkumi.Text = "Iepirkumi";
            tabIepirkumi.UseVisualStyleBackColor = true;
            // 
            // dgvIepirkumi
            // 
            dgvIepirkumi.AutoGenerateColumns = false;
            dgvIepirkumi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIepirkumi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIepirkumi.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, colDaudzums, colCena, colSumma, dataGridViewTextBoxColumn17 });
            dgvIepirkumi.DataMember = "Iepirkumi";
            dgvIepirkumi.DataSource = dataSet11;
            dgvIepirkumi.Dock = DockStyle.Fill;
            dgvIepirkumi.Location = new Point(3, 3);
            dgvIepirkumi.Name = "dgvIepirkumi";
            dgvIepirkumi.Size = new Size(975, 548);
            dgvIepirkumi.TabIndex = 0;
            dgvIepirkumi.CellValueChanged += dgvIepirkumi_CellValueChanged;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "Id";
            dataGridViewTextBoxColumn12.HeaderText = "Id";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "Datums";
            dataGridViewTextBoxColumn13.HeaderText = "Datums";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "ProduktsId";
            dataGridViewTextBoxColumn14.DataSource = produktiBindingSource;
            dataGridViewTextBoxColumn14.DisplayMember = "Nosaukums";
            dataGridViewTextBoxColumn14.HeaderText = "Produkts";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn14.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn14.ValueMember = "Id";
            // 
            // produktiBindingSource
            // 
            produktiBindingSource.DataMember = "Produkti";
            produktiBindingSource.DataSource = dataSet11;
            // 
            // colDaudzums
            // 
            colDaudzums.DataPropertyName = "Daudzums";
            colDaudzums.HeaderText = "Daudzums";
            colDaudzums.Name = "colDaudzums";
            // 
            // colCena
            // 
            colCena.DataPropertyName = "Cena";
            colCena.HeaderText = "Cena";
            colCena.Name = "colCena";
            // 
            // colSumma
            // 
            colSumma.DataPropertyName = "Summa";
            colSumma.HeaderText = "Summa";
            colSumma.Name = "colSumma";
            colSumma.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "Piezīmes";
            dataGridViewTextBoxColumn17.HeaderText = "Piezīmes";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nosaukums";
            dataGridViewTextBoxColumn2.HeaderText = "Nosaukums";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "PiegadatajsId";
            dataGridViewTextBoxColumn4.DataSource = piegadatajiBindingSource;
            dataGridViewTextBoxColumn4.DisplayMember = "Nosaukums";
            dataGridViewTextBoxColumn4.HeaderText = "Piegādātājs";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn4.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Piezimes";
            dataGridViewTextBoxColumn3.HeaderText = "Piezīmes";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            dataGridViewTextBoxColumn5.HeaderText = "Id";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Nosaukums";
            dataGridViewTextBoxColumn6.HeaderText = "Nosaukums";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Adrese";
            dataGridViewTextBoxColumn7.HeaderText = "Adrese";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Talrunis";
            dataGridViewTextBoxColumn8.HeaderText = "Tālrunis";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "E-pasts";
            dataGridViewTextBoxColumn9.HeaderText = "E-pasts";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Kontaktpersona";
            dataGridViewTextBoxColumn10.HeaderText = "Kontaktpersona";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Piezimes";
            dataGridViewTextBoxColumn11.HeaderText = "Piezīmes";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 606);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Labu apetīti!";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabProdukti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProdukti).EndInit();
            ((System.ComponentModel.ISupportInitialize)piegadatajiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).EndInit();
            tabPiegadataji.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPiegadataji).EndInit();
            tabIepirkumi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIepirkumi).EndInit();
            ((System.ComponentModel.ISupportInitialize)produktiBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem miOpenDB;
        private ToolStripMenuItem miExit;
        private TabControl tabControl1;
        private TabPage tabProdukti;
        private TabPage tabPiegadataji;
        private TabPage tabIepirkumi;
        private DataGridView dgvProdukti;
        private ToolStripMenuItem miSaveDB;
        private DataGridView dgvPiegadataji;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nosaukumsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adreseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn talrunisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn epastsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kontaktpersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn piezimesDataGridViewTextBoxColumn;
        private DataGridView dgvIepirkumi;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nosaukumsDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn piezimesDataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn piegadatajsIdDataGridViewTextBoxColumn;
        private BindingSource piegadatajiBindingSource;
        private BindingSource produktiBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn datumsDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn produktsIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn daudzumsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn piezīmesDataGridViewTextBoxColumn;
        private DataSet1 dataSet11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn colDaudzums;
        private DataGridViewTextBoxColumn colCena;
        private DataGridViewTextBoxColumn colSumma;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}
