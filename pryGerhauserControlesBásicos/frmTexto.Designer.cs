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
            this.optAzul.Location = new System.Drawing.Point(256, 153);
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
            this.optRojo.Location = new System.Drawing.Point(364, 153);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 3;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(438, 147);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(61, 29);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // frmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.txtEscribir);
            this.Controls.Add(this.lblCopia);
            this.Name = "frmTexto";
            this.Text = "frmTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopia;
        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.Button btnAsignar;
    }
}