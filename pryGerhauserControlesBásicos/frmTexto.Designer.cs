namespace pryGerhauserControlesBásicos
{
    partial class frmTexto
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
            this.lblCopia = new System.Windows.Forms.Label();
            this.txtEscribir = new System.Windows.Forms.TextBox();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.chkPicante = new System.Windows.Forms.CheckBox();
            this.chkFrio = new System.Windows.Forms.CheckBox();
            this.chkMilanesa = new System.Windows.Forms.CheckBox();
            this.lblEscribirCheck = new System.Windows.Forms.Label();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.mrcCheckBox = new System.Windows.Forms.GroupBox();
            this.cboAdicional = new System.Windows.Forms.ComboBox();
            this.mrcCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCopia
            // 
            this.lblCopia.AutoSize = true;
            this.lblCopia.Location = new System.Drawing.Point(315, 120);
            this.lblCopia.Name = "lblCopia";
            this.lblCopia.Size = new System.Drawing.Size(37, 13);
            this.lblCopia.TabIndex = 0;
            this.lblCopia.Text = "Copiar";
            // 
            // txtEscribir
            // 
            this.txtEscribir.Location = new System.Drawing.Point(256, 78);
            this.txtEscribir.Name = "txtEscribir";
            this.txtEscribir.Size = new System.Drawing.Size(155, 20);
            this.txtEscribir.TabIndex = 1;
            this.txtEscribir.TextChanged += new System.EventHandler(this.txtEscribir_TextChanged);
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(216, 153);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 2;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(305, 153);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 3;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(392, 147);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(61, 29);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // chkPicante
            // 
            this.chkPicante.AutoSize = true;
            this.chkPicante.Location = new System.Drawing.Point(6, 22);
            this.chkPicante.Name = "chkPicante";
            this.chkPicante.Size = new System.Drawing.Size(62, 17);
            this.chkPicante.TabIndex = 5;
            this.chkPicante.Text = "Picante";
            this.chkPicante.UseVisualStyleBackColor = true;
            // 
            // chkFrio
            // 
            this.chkFrio.AutoSize = true;
            this.chkFrio.Location = new System.Drawing.Point(89, 22);
            this.chkFrio.Name = "chkFrio";
            this.chkFrio.Size = new System.Drawing.Size(43, 17);
            this.chkFrio.TabIndex = 6;
            this.chkFrio.Text = "Frio";
            this.chkFrio.UseVisualStyleBackColor = true;
            // 
            // chkMilanesa
            // 
            this.chkMilanesa.AutoSize = true;
            this.chkMilanesa.Location = new System.Drawing.Point(163, 22);
            this.chkMilanesa.Name = "chkMilanesa";
            this.chkMilanesa.Size = new System.Drawing.Size(68, 17);
            this.chkMilanesa.TabIndex = 7;
            this.chkMilanesa.Text = "Milanesa";
            this.chkMilanesa.UseVisualStyleBackColor = true;
            // 
            // lblEscribirCheck
            // 
            this.lblEscribirCheck.AutoSize = true;
            this.lblEscribirCheck.Location = new System.Drawing.Point(45, 82);
            this.lblEscribirCheck.Name = "lblEscribirCheck";
            this.lblEscribirCheck.Size = new System.Drawing.Size(0, 13);
            this.lblEscribirCheck.TabIndex = 8;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(89, 45);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(49, 20);
            this.btnEscribir.TabIndex = 9;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // mrcCheckBox
            // 
            this.mrcCheckBox.Controls.Add(this.btnEscribir);
            this.mrcCheckBox.Controls.Add(this.lblEscribirCheck);
            this.mrcCheckBox.Controls.Add(this.chkMilanesa);
            this.mrcCheckBox.Controls.Add(this.chkFrio);
            this.mrcCheckBox.Controls.Add(this.chkPicante);
            this.mrcCheckBox.Location = new System.Drawing.Point(216, 181);
            this.mrcCheckBox.Name = "mrcCheckBox";
            this.mrcCheckBox.Size = new System.Drawing.Size(237, 111);
            this.mrcCheckBox.TabIndex = 10;
            this.mrcCheckBox.TabStop = false;
            // 
            // cboAdicional
            // 
            this.cboAdicional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdicional.FormattingEnabled = true;
            this.cboAdicional.Location = new System.Drawing.Point(216, 298);
            this.cboAdicional.Name = "cboAdicional";
            this.cboAdicional.Size = new System.Drawing.Size(98, 21);
            this.cboAdicional.TabIndex = 11;
            this.cboAdicional.SelectedIndexChanged += new System.EventHandler(this.cboAdicional_SelectedIndexChanged);
            // 
            // frmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.cboAdicional);
            this.Controls.Add(this.mrcCheckBox);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.txtEscribir);
            this.Controls.Add(this.lblCopia);
            this.Name = "frmTexto";
            this.Text = "frmTexto";
            this.mrcCheckBox.ResumeLayout(false);
            this.mrcCheckBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopia;
        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.CheckBox chkPicante;
        private System.Windows.Forms.CheckBox chkFrio;
        private System.Windows.Forms.CheckBox chkMilanesa;
        private System.Windows.Forms.Label lblEscribirCheck;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.GroupBox mrcCheckBox;
        private System.Windows.Forms.ComboBox cboAdicional;
    }
}