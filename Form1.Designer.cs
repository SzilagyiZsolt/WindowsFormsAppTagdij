namespace WindowsFormsAppTagdij
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxTagok = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonModositas = new System.Windows.Forms.Button();
            this.buttonLetrehozas = new System.Windows.Forms.Button();
            this.numericUpDownSzulev = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIrszam = new System.Windows.Forms.NumericUpDown();
            this.textBoxOrsz = new System.Windows.Forms.TextBox();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxAzon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzulev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIrszam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTagok
            // 
            this.listBoxTagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxTagok.FormattingEnabled = true;
            this.listBoxTagok.ItemHeight = 25;
            this.listBoxTagok.Location = new System.Drawing.Point(0, 0);
            this.listBoxTagok.Name = "listBoxTagok";
            this.listBoxTagok.Size = new System.Drawing.Size(193, 692);
            this.listBoxTagok.TabIndex = 0;
            this.listBoxTagok.SelectedIndexChanged += new System.EventHandler(this.listBoxTagok_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.groupBox2);
            this.groupBox.Controls.Add(this.numericUpDownSzulev);
            this.groupBox.Controls.Add(this.numericUpDownIrszam);
            this.groupBox.Controls.Add(this.textBoxOrsz);
            this.groupBox.Controls.Add(this.textBoxNev);
            this.groupBox.Controls.Add(this.textBoxAzon);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(193, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1007, 692);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Kiválasztott tag";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTorles);
            this.groupBox2.Controls.Add(this.buttonModositas);
            this.groupBox2.Controls.Add(this.buttonLetrehozas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 558);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1001, 131);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Műveletek";
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(680, 41);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(312, 39);
            this.buttonTorles.TabIndex = 0;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // buttonModositas
            // 
            this.buttonModositas.Location = new System.Drawing.Point(344, 41);
            this.buttonModositas.Name = "buttonModositas";
            this.buttonModositas.Size = new System.Drawing.Size(312, 39);
            this.buttonModositas.TabIndex = 0;
            this.buttonModositas.Text = "Módosítás";
            this.buttonModositas.UseVisualStyleBackColor = true;
            this.buttonModositas.Click += new System.EventHandler(this.buttonModositas_Click);
            // 
            // buttonLetrehozas
            // 
            this.buttonLetrehozas.Location = new System.Drawing.Point(11, 41);
            this.buttonLetrehozas.Name = "buttonLetrehozas";
            this.buttonLetrehozas.Size = new System.Drawing.Size(312, 39);
            this.buttonLetrehozas.TabIndex = 0;
            this.buttonLetrehozas.Text = "Létrehozás";
            this.buttonLetrehozas.UseVisualStyleBackColor = true;
            this.buttonLetrehozas.Click += new System.EventHandler(this.buttonLetrehozas_Click);
            // 
            // numericUpDownSzulev
            // 
            this.numericUpDownSzulev.Location = new System.Drawing.Point(10, 205);
            this.numericUpDownSzulev.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownSzulev.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownSzulev.Name = "numericUpDownSzulev";
            this.numericUpDownSzulev.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownSzulev.TabIndex = 2;
            this.numericUpDownSzulev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSzulev.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericUpDownIrszam
            // 
            this.numericUpDownIrszam.Increment = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownIrszam.Location = new System.Drawing.Point(10, 153);
            this.numericUpDownIrszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownIrszam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownIrszam.Name = "numericUpDownIrszam";
            this.numericUpDownIrszam.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownIrszam.TabIndex = 2;
            this.numericUpDownIrszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownIrszam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // textBoxOrsz
            // 
            this.textBoxOrsz.Location = new System.Drawing.Point(10, 257);
            this.textBoxOrsz.Name = "textBoxOrsz";
            this.textBoxOrsz.Size = new System.Drawing.Size(261, 30);
            this.textBoxOrsz.TabIndex = 1;
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(10, 101);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(261, 30);
            this.textBoxNev.TabIndex = 1;
            // 
            // textBoxAzon
            // 
            this.textBoxAzon.Location = new System.Drawing.Point(10, 49);
            this.textBoxAzon.Name = "textBoxAzon";
            this.textBoxAzon.ReadOnly = true;
            this.textBoxAzon.Size = new System.Drawing.Size(100, 30);
            this.textBoxAzon.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Országkód";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Születési év";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Irányítószám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.listBoxTagok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "tagok nyilvántartása";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzulev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIrszam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTagok;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxAzon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownIrszam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSzulev;
        private System.Windows.Forms.TextBox textBoxOrsz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Button buttonModositas;
        private System.Windows.Forms.Button buttonLetrehozas;
    }
}

