namespace bankmanagementapp
{
    partial class sifredegistir
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
            this.button4 = new System.Windows.Forms.Button();
            this.txtEskisifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtYenisifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtYenisifretekrar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
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
            this.button4.TabIndex = 4;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtEskisifre
            // 
            this.txtEskisifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEskisifre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEskisifre.ForeColor = System.Drawing.Color.White;
            this.txtEskisifre.HintForeColor = System.Drawing.Color.Empty;
            this.txtEskisifre.HintText = "";
            this.txtEskisifre.isPassword = false;
            this.txtEskisifre.LineFocusedColor = System.Drawing.Color.Black;
            this.txtEskisifre.LineIdleColor = System.Drawing.Color.Black;
            this.txtEskisifre.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtEskisifre.LineThickness = 3;
            this.txtEskisifre.Location = new System.Drawing.Point(407, 118);
            this.txtEskisifre.Margin = new System.Windows.Forms.Padding(5);
            this.txtEskisifre.Name = "txtEskisifre";
            this.txtEskisifre.Size = new System.Drawing.Size(318, 59);
            this.txtEskisifre.TabIndex = 6;
            this.txtEskisifre.Text = "ESKİ SİFRE";
            this.txtEskisifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEskisifre.Enter += new System.EventHandler(this.txtEskisifre_Enter);
            // 
            // txtYenisifre
            // 
            this.txtYenisifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYenisifre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYenisifre.ForeColor = System.Drawing.Color.White;
            this.txtYenisifre.HintForeColor = System.Drawing.Color.Empty;
            this.txtYenisifre.HintText = "";
            this.txtYenisifre.isPassword = false;
            this.txtYenisifre.LineFocusedColor = System.Drawing.Color.Black;
            this.txtYenisifre.LineIdleColor = System.Drawing.Color.Black;
            this.txtYenisifre.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtYenisifre.LineThickness = 3;
            this.txtYenisifre.Location = new System.Drawing.Point(407, 214);
            this.txtYenisifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtYenisifre.Name = "txtYenisifre";
            this.txtYenisifre.Size = new System.Drawing.Size(318, 49);
            this.txtYenisifre.TabIndex = 7;
            this.txtYenisifre.Text = "YENİ SİFRE";
            this.txtYenisifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtYenisifre.Enter += new System.EventHandler(this.txtYenisifre_Enter);
            // 
            // txtYenisifretekrar
            // 
            this.txtYenisifretekrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYenisifretekrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYenisifretekrar.ForeColor = System.Drawing.Color.White;
            this.txtYenisifretekrar.HintForeColor = System.Drawing.Color.Empty;
            this.txtYenisifretekrar.HintText = "";
            this.txtYenisifretekrar.isPassword = false;
            this.txtYenisifretekrar.LineFocusedColor = System.Drawing.Color.Black;
            this.txtYenisifretekrar.LineIdleColor = System.Drawing.Color.Black;
            this.txtYenisifretekrar.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtYenisifretekrar.LineThickness = 3;
            this.txtYenisifretekrar.Location = new System.Drawing.Point(407, 304);
            this.txtYenisifretekrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtYenisifretekrar.Name = "txtYenisifretekrar";
            this.txtYenisifretekrar.Size = new System.Drawing.Size(318, 49);
            this.txtYenisifretekrar.TabIndex = 8;
            this.txtYenisifretekrar.Text = "YENİ SİFRE TEKRAR";
            this.txtYenisifretekrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtYenisifretekrar.Enter += new System.EventHandler(this.txtYenisifretekrar_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "ESKİ SİFRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "YENİ SİFRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(184, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "YENİ SİFRE";
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
            this.button_WOC1.Location = new System.Drawing.Point(535, 403);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.button_WOC1.Size = new System.Drawing.Size(190, 56);
            this.button_WOC1.TabIndex = 18;
            this.button_WOC1.Text = "SİFRE DEGİSTİR";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // sifredegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYenisifretekrar);
            this.Controls.Add(this.txtYenisifre);
            this.Controls.Add(this.txtEskisifre);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sifredegistir";
            this.Text = "sifredegistir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEskisifre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtYenisifre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtYenisifretekrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}