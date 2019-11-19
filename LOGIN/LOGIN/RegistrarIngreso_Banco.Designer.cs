namespace LOGIN
{
    partial class RegistrarIngreso_Banco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarIngreso_Banco));
            this.Banco_de_Sangre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoSangre_ComboBox = new System.Windows.Forms.ComboBox();
            this.Edad_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Banco_de_Sangre
            // 
            this.Banco_de_Sangre.AutoSize = true;
            this.Banco_de_Sangre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Banco_de_Sangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banco_de_Sangre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.Banco_de_Sangre.Location = new System.Drawing.Point(311, 47);
            this.Banco_de_Sangre.Name = "Banco_de_Sangre";
            this.Banco_de_Sangre.Size = new System.Drawing.Size(178, 25);
            this.Banco_de_Sangre.TabIndex = 89;
            this.Banco_de_Sangre.Text = "Banco de Sangre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(127)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(345, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 115;
            this.label2.Text = "Capacidad 12L";
            // 
            // TipoSangre_ComboBox
            // 
            this.TipoSangre_ComboBox.FormattingEnabled = true;
            this.TipoSangre_ComboBox.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.TipoSangre_ComboBox.Location = new System.Drawing.Point(172, 159);
            this.TipoSangre_ComboBox.Name = "TipoSangre_ComboBox";
            this.TipoSangre_ComboBox.Size = new System.Drawing.Size(454, 21);
            this.TipoSangre_ComboBox.TabIndex = 128;
            // 
            // Edad_TextBox
            // 
            this.Edad_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Edad_TextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Edad_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Edad_TextBox.HintForeColor = System.Drawing.Color.Empty;
            this.Edad_TextBox.HintText = "";
            this.Edad_TextBox.isPassword = false;
            this.Edad_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.Edad_TextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.Edad_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.Edad_TextBox.LineThickness = 1;
            this.Edad_TextBox.Location = new System.Drawing.Point(172, 264);
            this.Edad_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Edad_TextBox.Name = "Edad_TextBox";
            this.Edad_TextBox.Size = new System.Drawing.Size(454, 33);
            this.Edad_TextBox.TabIndex = 129;
            this.Edad_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 130;
            this.button1.Text = "Registrar Ingreso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(127)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(168, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 131;
            this.label6.Text = "Tipo de Sangre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(127)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(168, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 132;
            this.label1.Text = "Cantidad Donada (ml):";
            // 
            // RegistrarIngreso_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Edad_TextBox);
            this.Controls.Add(this.TipoSangre_ComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Banco_de_Sangre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarIngreso_Banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Banco_de_Sangre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoSangre_ComboBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Edad_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}