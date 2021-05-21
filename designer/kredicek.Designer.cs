namespace bankmanagementapp
{
    partial class kredicek
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtKredimiktari = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAylikodeme = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelonay = new System.Windows.Forms.Label();
            this.labelret = new System.Windows.Forms.Label();
            this.button_WOC5 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(839, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKredimiktari
            // 
            this.txtKredimiktari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKredimiktari.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKredimiktari.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtKredimiktari.HintForeColor = System.Drawing.Color.Empty;
            this.txtKredimiktari.HintText = "";
            this.txtKredimiktari.isPassword = false;
            this.txtKredimiktari.LineFocusedColor = System.Drawing.Color.Black;
            this.txtKredimiktari.LineIdleColor = System.Drawing.Color.Black;
            this.txtKredimiktari.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtKredimiktari.LineThickness = 3;
            this.txtKredimiktari.Location = new System.Drawing.Point(493, 138);
            this.txtKredimiktari.Margin = new System.Windows.Forms.Padding(4);
            this.txtKredimiktari.Name = "txtKredimiktari";
            this.txtKredimiktari.Size = new System.Drawing.Size(318, 49);
            this.txtKredimiktari.TabIndex = 12;
            this.txtKredimiktari.Text = "KREDİ TUTARI";
            this.txtKredimiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKredimiktari.Enter += new System.EventHandler(this.txtKredimiktari_Enter);
            this.txtKredimiktari.Leave += new System.EventHandler(this.txtKredimiktari_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(68, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "ALMAK İSTEDİGİNİZ KREDİ TUTARI";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "6",
            "12",
            "24",
            "36",
            "48"});
            this.comboBox1.Location = new System.Drawing.Point(493, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(69, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "TAKSİTLENDİRİLECEK AY SAYISI";
            // 
            // txtMaas
            // 
            this.txtMaas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMaas.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaas.HintText = "";
            this.txtMaas.isPassword = false;
            this.txtMaas.LineFocusedColor = System.Drawing.Color.Black;
            this.txtMaas.LineIdleColor = System.Drawing.Color.Black;
            this.txtMaas.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtMaas.LineThickness = 3;
            this.txtMaas.Location = new System.Drawing.Point(265, 309);
            this.txtMaas.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(142, 38);
            this.txtMaas.TabIndex = 16;
            this.txtMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(69, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "AYLIK MAASINIZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(453, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "AYLIK  ODEMENIZ";
            // 
            // txtAylikodeme
            // 
            this.txtAylikodeme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAylikodeme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAylikodeme.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtAylikodeme.HintForeColor = System.Drawing.Color.Empty;
            this.txtAylikodeme.HintText = "";
            this.txtAylikodeme.isPassword = false;
            this.txtAylikodeme.LineFocusedColor = System.Drawing.Color.Black;
            this.txtAylikodeme.LineIdleColor = System.Drawing.Color.Black;
            this.txtAylikodeme.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtAylikodeme.LineThickness = 3;
            this.txtAylikodeme.Location = new System.Drawing.Point(669, 309);
            this.txtAylikodeme.Margin = new System.Windows.Forms.Padding(4);
            this.txtAylikodeme.Name = "txtAylikodeme";
            this.txtAylikodeme.Size = new System.Drawing.Size(142, 38);
            this.txtAylikodeme.TabIndex = 19;
            this.txtAylikodeme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelonay
            // 
            this.labelonay.AutoSize = true;
            this.labelonay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelonay.ForeColor = System.Drawing.Color.Blue;
            this.labelonay.Location = new System.Drawing.Point(240, 409);
            this.labelonay.Name = "labelonay";
            this.labelonay.Size = new System.Drawing.Size(427, 25);
            this.labelonay.TabIndex = 20;
            this.labelonay.Text = "!!!KREDİ BASVURUNUZ ONAYLANDI!!! ";
            // 
            // labelret
            // 
            this.labelret.AutoSize = true;
            this.labelret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelret.ForeColor = System.Drawing.Color.Black;
            this.labelret.Location = new System.Drawing.Point(240, 409);
            this.labelret.Name = "labelret";
            this.labelret.Size = new System.Drawing.Size(432, 25);
            this.labelret.TabIndex = 21;
            this.labelret.Text = "!!!KREDİ BASVURUNUZ REDDEDİLDİ!!! ";
            // 
            // button_WOC5
            // 
            this.button_WOC5.BorderColor = System.Drawing.Color.Black;
            this.button_WOC5.ButtonColor = System.Drawing.Color.Crimson;
            this.button_WOC5.FlatAppearance.BorderSize = 0;
            this.button_WOC5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.button_WOC5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button_WOC5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_WOC5.Location = new System.Drawing.Point(375, 458);
            this.button_WOC5.Name = "button_WOC5";
            this.button_WOC5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_WOC5.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC5.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.button_WOC5.Size = new System.Drawing.Size(167, 60);
            this.button_WOC5.TabIndex = 25;
            this.button_WOC5.Text = "ONAYLA";
            this.button_WOC5.TextColor = System.Drawing.Color.White;
            this.button_WOC5.UseVisualStyleBackColor = true;
            this.button_WOC5.Click += new System.EventHandler(this.button_WOC5_Click);
            // 
            // kredicek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.button_WOC5);
            this.Controls.Add(this.labelret);
            this.Controls.Add(this.labelonay);
            this.Controls.Add(this.txtAylikodeme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKredimiktari);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kredicek";
            this.Text = "kredicek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKredimiktari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAylikodeme;
        private System.Windows.Forms.Label labelonay;
        private System.Windows.Forms.Label labelret;
        private ePOSOne.btnProduct.Button_WOC button_WOC5;
    }
}