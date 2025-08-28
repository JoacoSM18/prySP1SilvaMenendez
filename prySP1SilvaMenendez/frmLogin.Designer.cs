namespace prySP1SilvaMenendez
{
    partial class frmLogin
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(73, 110);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(96, 27);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(51, 197);
            lblContraseña.Margin = new Padding(4, 0, 4, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(132, 27);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(433, 103);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 50);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.TextAlign = ContentAlignment.TopCenter;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(433, 178);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 48);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.TopCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(203, 100);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 31);
            txtNombre.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Cursor = Cursors.IBeam;
            txtContraseña.Location = new Point(203, 187);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(183, 31);
            txtContraseña.TabIndex = 5;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 367);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            Text = "LOGIN";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private TextBox txtContraseña;
    }
}
