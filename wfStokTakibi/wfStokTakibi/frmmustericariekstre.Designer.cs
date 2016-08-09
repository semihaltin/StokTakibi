namespace wfStokTakibi
{
    partial class frmmustericariekstre
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
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.btnFirmaBul = new System.Windows.Forms.Button();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.rbTumFirmalar = new System.Windows.Forms.RadioButton();
            this.rbSaticilar = new System.Windows.Forms.RadioButton();
            this.rbAlicilar = new System.Windows.Forms.RadioButton();
            this.dtilktarih = new System.Windows.Forms.DateTimePicker();
            this.dtsontarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ssl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncarieksteresorgula = new System.Windows.Forms.Button();
            this.dgvcariekstre = new System.Windows.Forms.DataGridView();
            this.dgvcariler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcariekstre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcariler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCariNo
            // 
            this.txtCariNo.Location = new System.Drawing.Point(8, 12);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.ReadOnly = true;
            this.txtCariNo.Size = new System.Drawing.Size(19, 20);
            this.txtCariNo.TabIndex = 49;
            // 
            // btnFirmaBul
            // 
            this.btnFirmaBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaBul.Location = new System.Drawing.Point(273, 32);
            this.btnFirmaBul.Name = "btnFirmaBul";
            this.btnFirmaBul.Size = new System.Drawing.Size(38, 23);
            this.btnFirmaBul.TabIndex = 48;
            this.btnFirmaBul.Text = "...";
            this.btnFirmaBul.UseVisualStyleBackColor = true;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(138, 32);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.ReadOnly = true;
            this.txtFirma.Size = new System.Drawing.Size(129, 20);
            this.txtFirma.TabIndex = 47;
            // 
            // rbTumFirmalar
            // 
            this.rbTumFirmalar.AutoSize = true;
            this.rbTumFirmalar.Location = new System.Drawing.Point(226, 79);
            this.rbTumFirmalar.Name = "rbTumFirmalar";
            this.rbTumFirmalar.Size = new System.Drawing.Size(85, 17);
            this.rbTumFirmalar.TabIndex = 52;
            this.rbTumFirmalar.Text = "Tüm Firmalar";
            this.rbTumFirmalar.UseVisualStyleBackColor = true;
            this.rbTumFirmalar.CheckedChanged += new System.EventHandler(this.rbTumFirmalar_CheckedChanged);
            // 
            // rbSaticilar
            // 
            this.rbSaticilar.AutoSize = true;
            this.rbSaticilar.Location = new System.Drawing.Point(128, 79);
            this.rbSaticilar.Name = "rbSaticilar";
            this.rbSaticilar.Size = new System.Drawing.Size(62, 17);
            this.rbSaticilar.TabIndex = 51;
            this.rbSaticilar.Text = "Satıcılar";
            this.rbSaticilar.UseVisualStyleBackColor = true;
            this.rbSaticilar.CheckedChanged += new System.EventHandler(this.rbSaticilar_CheckedChanged);
            // 
            // rbAlicilar
            // 
            this.rbAlicilar.AutoSize = true;
            this.rbAlicilar.Location = new System.Drawing.Point(21, 78);
            this.rbAlicilar.Name = "rbAlicilar";
            this.rbAlicilar.Size = new System.Drawing.Size(55, 17);
            this.rbAlicilar.TabIndex = 50;
            this.rbAlicilar.Text = "Alıcılar";
            this.rbAlicilar.UseVisualStyleBackColor = true;
            this.rbAlicilar.CheckedChanged += new System.EventHandler(this.rbAlicilar_CheckedChanged);
            // 
            // dtilktarih
            // 
            this.dtilktarih.Location = new System.Drawing.Point(434, 44);
            this.dtilktarih.Name = "dtilktarih";
            this.dtilktarih.Size = new System.Drawing.Size(154, 20);
            this.dtilktarih.TabIndex = 53;
            // 
            // dtsontarih
            // 
            this.dtsontarih.Location = new System.Drawing.Point(609, 44);
            this.dtsontarih.Name = "dtsontarih";
            this.dtsontarih.Size = new System.Drawing.Size(156, 20);
            this.dtsontarih.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "ilk tarih";
            // 
            // ssl
            // 
            this.ssl.AutoSize = true;
            this.ssl.Location = new System.Drawing.Point(650, 28);
            this.ssl.Name = "ssl";
            this.ssl.Size = new System.Drawing.Size(47, 13);
            this.ssl.TabIndex = 56;
            this.ssl.Text = "son tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "label3";
            // 
            // btncarieksteresorgula
            // 
            this.btncarieksteresorgula.Location = new System.Drawing.Point(541, 93);
            this.btncarieksteresorgula.Name = "btncarieksteresorgula";
            this.btncarieksteresorgula.Size = new System.Drawing.Size(146, 23);
            this.btncarieksteresorgula.TabIndex = 58;
            this.btncarieksteresorgula.Text = "Cari Ekstre Sorgula";
            this.btncarieksteresorgula.UseVisualStyleBackColor = true;
            // 
            // dgvcariekstre
            // 
            this.dgvcariekstre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcariekstre.Location = new System.Drawing.Point(369, 144);
            this.dgvcariekstre.Name = "dgvcariekstre";
            this.dgvcariekstre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcariekstre.Size = new System.Drawing.Size(492, 250);
            this.dgvcariekstre.TabIndex = 59;
            // 
            // dgvcariler
            // 
            this.dgvcariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcariler.Location = new System.Drawing.Point(8, 144);
            this.dgvcariler.Name = "dgvcariler";
            this.dgvcariler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcariler.Size = new System.Drawing.Size(355, 289);
            this.dgvcariler.TabIndex = 60;
            this.dgvcariler.DoubleClick += new System.EventHandler(this.dgvcariler_DoubleClick);
            // 
            // frmmustericariekstre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 436);
            this.Controls.Add(this.dgvcariler);
            this.Controls.Add(this.dgvcariekstre);
            this.Controls.Add(this.btncarieksteresorgula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ssl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtsontarih);
            this.Controls.Add(this.dtilktarih);
            this.Controls.Add(this.rbTumFirmalar);
            this.Controls.Add(this.rbSaticilar);
            this.Controls.Add(this.rbAlicilar);
            this.Controls.Add(this.txtCariNo);
            this.Controls.Add(this.btnFirmaBul);
            this.Controls.Add(this.txtFirma);
            this.Name = "frmmustericariekstre";
            this.Text = "frmmustericariekstre";
            this.Load += new System.EventHandler(this.frmmustericariekstre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcariekstre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCariNo;
        private System.Windows.Forms.Button btnFirmaBul;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.RadioButton rbTumFirmalar;
        private System.Windows.Forms.RadioButton rbSaticilar;
        private System.Windows.Forms.RadioButton rbAlicilar;
        private System.Windows.Forms.DateTimePicker dtilktarih;
        private System.Windows.Forms.DateTimePicker dtsontarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ssl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncarieksteresorgula;
        private System.Windows.Forms.DataGridView dgvcariekstre;
        private System.Windows.Forms.DataGridView dgvcariler;
    }
}