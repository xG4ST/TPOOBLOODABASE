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
            this.CantidadDonada_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SeleccionarDonador_ComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Banco_de_Sangre
            // 
            this.Banco_de_Sangre.AutoSize = true;
            this.Banco_de_Sangre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Banco_de_Sangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banco_de_Sangre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.Banco_de_Sangre.Location = new System.Drawing.Point(415, 58);
            this.Banco_de_Sangre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Banco_de_Sangre.Name = "Banco_de_Sangre";
            this.Banco_de_Sangre.Size = new System.Drawing.Size(222, 31);
            this.Banco_de_Sangre.TabIndex = 89;
            this.Banco_de_Sangre.Text = "Banco de Sangre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(127)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(460, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
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
            this.TipoSangre_ComboBox.Location = new System.Drawing.Point(228, 169);
            this.TipoSangre_ComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TipoSangre_ComboBox.Name = "TipoSangre_ComboBox";
            this.TipoSangre_ComboBox.Size = new System.Drawing.Size(604, 24);
            this.TipoSangre_ComboBox.TabIndex = 128;
            // 
            // CantidadDonada_TextBox
            // 
            this.CantidadDonada_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CantidadDonada_TextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CantidadDonada_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CantidadDonada_TextBox.HintForeColor = System.Drawing.Color.Empty;
            this.CantidadDonada_TextBox.HintText = "";
            this.CantidadDonada_TextBox.isPassword = false;
            this.CantidadDonada_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.CantidadDonada_TextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.CantidadDonada_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.CantidadDonada_TextBox.LineThickness = 1;
            this.CantidadDonada_TextBox.Location = new System.Drawing.Point(228, 385);
            this.CantidadDonada_TextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CantidadDonada_TextBox.Name = "CantidadDonada_TextBox";
            this.CantidadDonada_TextBox.Size = new System.Drawing.Size(605, 41);
            this.CantidadDonada_TextBox.TabIndex = 129;
            this.CantidadDonada_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 130;
            this.button1.Text = "Registrar Ingreso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(127)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(223, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 131;
            this.label6.Text = "Tipo de Sangre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(127)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(223, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 132;
            this.label1.Text = "Cantidad Donada (ml):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(127)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(223, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 133;
            this.label3.Text = "Seleccione el Donador";
            // 
            // SeleccionarDonador_ComboBox
            // 
            this.SeleccionarDonador_ComboBox.FormattingEnabled = true;
            this.SeleccionarDonador_ComboBox.Location = new System.Drawing.Point(228, 236);
            this.SeleccionarDonador_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SeleccionarDonador_ComboBox.Name = "SeleccionarDonador_ComboBox";
            this.SeleccionarDonador_ComboBox.Size = new System.Drawing.Size(604, 24);
            this.SeleccionarDonador_ComboBox.TabIndex = 134;
            this.SeleccionarDonador_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(127)))), ((int)(((byte)(140)))));
            this.label4.Location = new System.Drawing.Point(223, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 25);
            this.label4.TabIndex = 135;
            this.label4.Text = "Departamento a la que va dirigida:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(227, 309);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(604, 24);
            this.comboBox2.TabIndex = 136;
            // 
            // RegistrarIngreso_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SeleccionarDonador_ComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CantidadDonada_TextBox);
            this.Controls.Add(this.TipoSangre_ComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Banco_de_Sangre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistrarIngreso_Banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Ingreso";
            this.Load += new System.EventHandler(this.RegistrarIngreso_Banco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Banco_de_Sangre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoSangre_ComboBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CantidadDonada_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SeleccionarDonador_ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}