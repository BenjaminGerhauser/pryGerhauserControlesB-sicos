namespace pryGerhauserControlesBásicos
{
    partial class frmPrincipal
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
            this.lblEjeX = new System.Windows.Forms.Label();
            this.lblEjeY = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnFormulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEjeX
            // 
            this.lblEjeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeX.AutoSize = true;
            this.lblEjeX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEjeX.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjeX.Location = new System.Drawing.Point(408, 9);
            this.lblEjeX.Name = "lblEjeX";
            this.lblEjeX.Size = new System.Drawing.Size(19, 18);
            this.lblEjeX.TabIndex = 0;
            this.lblEjeX.Text = "X";
            // 
            // lblEjeY
            // 
            this.lblEjeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeY.AutoSize = true;
            this.lblEjeY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEjeY.Font = new System.Drawing.Font("Vladimir Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjeY.Location = new System.Drawing.Point(407, 36);
            this.lblEjeY.Name = "lblEjeY";
            this.lblEjeY.Size = new System.Drawing.Size(22, 19);
            this.lblEjeY.TabIndex = 1;
            this.lblEjeY.Text = "Y";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(110, 173);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(438, 73);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "BIENVENIDO";
            this.lblBienvenida.Visible = false;
            this.lblBienvenida.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBienvenida_MouseMove);
            // 
            // btnFormulario
            // 
            this.btnFormulario.Location = new System.Drawing.Point(21, 24);
            this.btnFormulario.Name = "btnFormulario";
            this.btnFormulario.Size = new System.Drawing.Size(87, 30);
            this.btnFormulario.TabIndex = 3;
            this.btnFormulario.Text = "Escribir";
            this.btnFormulario.UseVisualStyleBackColor = true;
            this.btnFormulario.Click += new System.EventHandler(this.btnFormulario_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 410);
            this.Controls.Add(this.btnFormulario);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblEjeY);
            this.Controls.Add(this.lblEjeX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.frmPrincipal_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjeX;
        private System.Windows.Forms.Label lblEjeY;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnFormulario;
    }
}