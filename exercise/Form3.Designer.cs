
namespace exercise
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodiTIDataSet1 = new exercise.ProdiTIDataSet1();
            this.nilaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nilaiTableAdapter = new exercise.ProdiTIDataSet1TableAdapters.NilaiTableAdapter();
            this.iDNilaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeMKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPeriodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(214, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Nilai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(373, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mahasiswa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNilaiDataGridViewTextBoxColumn,
            this.nIMDataGridViewTextBoxColumn,
            this.kodeMKDataGridViewTextBoxColumn,
            this.nilaiDataGridViewTextBoxColumn,
            this.iDPeriodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nilaiBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(27, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // prodiTIDataSet1
            // 
            this.prodiTIDataSet1.DataSetName = "ProdiTIDataSet1";
            this.prodiTIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nilaiBindingSource
            // 
            this.nilaiBindingSource.DataMember = "Nilai";
            this.nilaiBindingSource.DataSource = this.prodiTIDataSet1;
            // 
            // nilaiTableAdapter
            // 
            this.nilaiTableAdapter.ClearBeforeFill = true;
            // 
            // iDNilaiDataGridViewTextBoxColumn
            // 
            this.iDNilaiDataGridViewTextBoxColumn.DataPropertyName = "IDNilai";
            this.iDNilaiDataGridViewTextBoxColumn.HeaderText = "ID Nilai";
            this.iDNilaiDataGridViewTextBoxColumn.Name = "iDNilaiDataGridViewTextBoxColumn";
            this.iDNilaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // nIMDataGridViewTextBoxColumn
            // 
            this.nIMDataGridViewTextBoxColumn.DataPropertyName = "NIM";
            this.nIMDataGridViewTextBoxColumn.HeaderText = "No. Mahasiswa";
            this.nIMDataGridViewTextBoxColumn.Name = "nIMDataGridViewTextBoxColumn";
            this.nIMDataGridViewTextBoxColumn.Width = 150;
            // 
            // kodeMKDataGridViewTextBoxColumn
            // 
            this.kodeMKDataGridViewTextBoxColumn.DataPropertyName = "KodeMK";
            this.kodeMKDataGridViewTextBoxColumn.HeaderText = "Kode MataKuliah";
            this.kodeMKDataGridViewTextBoxColumn.Name = "kodeMKDataGridViewTextBoxColumn";
            this.kodeMKDataGridViewTextBoxColumn.Width = 150;
            // 
            // nilaiDataGridViewTextBoxColumn
            // 
            this.nilaiDataGridViewTextBoxColumn.DataPropertyName = "Nilai";
            this.nilaiDataGridViewTextBoxColumn.HeaderText = "Nilai";
            this.nilaiDataGridViewTextBoxColumn.Name = "nilaiDataGridViewTextBoxColumn";
            this.nilaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDPeriodeDataGridViewTextBoxColumn
            // 
            this.iDPeriodeDataGridViewTextBoxColumn.DataPropertyName = "IDPeriode";
            this.iDPeriodeDataGridViewTextBoxColumn.HeaderText = "Periode";
            this.iDPeriodeDataGridViewTextBoxColumn.Name = "iDPeriodeDataGridViewTextBoxColumn";
            this.iDPeriodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "DataNilai";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProdiTIDataSet1 prodiTIDataSet1;
        private System.Windows.Forms.BindingSource nilaiBindingSource;
        private ProdiTIDataSet1TableAdapters.NilaiTableAdapter nilaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNilaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeMKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPeriodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}