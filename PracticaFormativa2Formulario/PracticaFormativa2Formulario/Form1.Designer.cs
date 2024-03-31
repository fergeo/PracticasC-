namespace PracticaFormativa2Formulario
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            lblDocumento = new System.Windows.Forms.Label();
            txtDocumento = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            btnMostrar = new System.Windows.Forms.Button();
            btnIngresar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(69, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(69, 87);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(66, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new System.Drawing.Point(69, 143);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new System.Drawing.Size(87, 20);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(302, 143);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(125, 27);
            txtDocumento.TabIndex = 3;
            txtDocumento.Text = "Documento";
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(302, 84);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(125, 27);
            txtApellido.TabIndex = 4;
            txtApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(302, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(125, 27);
            txtNombre.TabIndex = 5;
            txtNombre.Text = "Nombre";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new System.Drawing.Point(255, 195);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new System.Drawing.Size(94, 29);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += button1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(126, 195);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(94, 29);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(btnMostrar);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Priner Proyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnIngresar;
    }
}
