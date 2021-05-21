namespace bankmanagementapp
{
    partial class kullanicikaldir
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
            this.txtHesapnumara = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtHesapnumara
            // 
            this.txtHesapnumara.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHesapnumara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapnumara.ForeColor = System.Drawing.Color.White;
            this.txtHesapnumara.HintForeColor = System.Drawing.Color.Empty;
            this.txtHesapnumara.HintText = "";
            this.txtHesapnumara.isPassword = false;
            this.txtHesapnumara.LineFocusedColor = System.Drawing.Color.Black;
            this.txtHesapnumara.LineIdleColor = System.Drawing.Color.Black;
            this.txtHesapnumara.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtHesapnumara.LineThickness = 3;
            this.txtHesapnumara.Location = new System.Drawing.Point(290, 206);
            this.txtHesapnumara.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapnumara.Name = "txtHesapnumara";
            this.txtHesapnumara.Size = new System.Drawing.Size(318, 49);
            this.txtHesapnumara.TabIndex = 6;
            this.txtHesapnumara.Text = "HESAP NUMARA";
            this.txtHesapnumara.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHesapnumara.Enter += new System.EventHandler(this.txtHesapnumara_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "SİSTEMDEN KALDIRILMAK İSTENEN KULLANCININ HESAP NUMARASI";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(839, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 56);
            this.button4.TabIndex = 9;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Black;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Crimson;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_WOC1.Location = new System.Drawing.Point(341, 318);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.button_WOC1.Size = new System.Drawing.Size(208, 60);
            this.button_WOC1.TabIndex = 18;
            this.button_WOC1.Text = "KULLANICI KALDIR";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // kullanicikaldir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHesapnumara);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kullanicikaldir";
            this.Text = "kullanicikaldir";
            this.Enter += new System.EventHandler(this.enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHesapnumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}