namespace PracticaFormativa2Formulario
{
    partial class frmIngreso
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
            lblDato1 = new System.Windows.Forms.Label();
            lblDato2 = new System.Windows.Forms.Label();
            txtDato1 = new System.Windows.Forms.TextBox();
            txtDato2 = new System.Windows.Forms.TextBox();
            btnAceptar = new System.Windows.Forms.Button();
            btnCalcular = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblDato1
            // 
            lblDato1.AutoSize = true;
            lblDato1.Location = new System.Drawing.Point(158, 124);
            lblDato1.Name = "lblDato1";
            lblDato1.Size = new System.Drawing.Size(50, 20);
            lblDato1.TabIndex = 0;
            lblDato1.Text = "Dato1";
            // 
            // lblDato2
            // 
            lblDato2.AutoSize = true;
            lblDato2.Location = new System.Drawing.Point(158, 188);
            lblDato2.Name = "lblDato2";
            lblDato2.Size = new System.Drawing.Size(50, 20);
            lblDato2.TabIndex = 1;
            lblDato2.Text = "Dato2";
            // 
            // txtDato1
            // 
            txtDato1.Location = new System.Drawing.Point(298, 124);
            txtDato1.Name = "txtDato1";
            txtDato1.Size = new System.Drawing.Size(160, 27);
            txtDato1.TabIndex = 2;
            txtDato1.Text = "Dato1";
            // 
            // txtDato2
            // 
            txtDato2.Location = new System.Drawing.Point(298, 188);
            txtDato2.Name = "txtDato2";
            txtDato2.Size = new System.Drawing.Size(160, 27);
            txtDato2.TabIndex = 3;
            txtDato2.Text = "Dato2";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new System.Drawing.Point(229, 242);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(94, 29);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new System.Drawing.Point(229, 294);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new System.Drawing.Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Dato2";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(btnAceptar);
            Controls.Add(txtDato2);
            Controls.Add(txtDato1);
            Controls.Add(lblDato2);
            Controls.Add(lblDato1);
            Name = "frmIngreso";
            Text = "Ingreso y Muestro Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCalcular;
    }
}