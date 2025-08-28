namespace prySilvaMenendezSP1
{
    partial class frmInicio
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
            lblBienvenida = new Label();
            btnAceptar2 = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenida.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBienvenida.Location = new Point(37, 64);
            lblBienvenida.Margin = new Padding(4, 0, 4, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(610, 67);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "BIENVENIDO AL SISTEMA";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // btnAceptar2
            // 
            btnAceptar2.Font = new Font("Segoe UI", 11F);
            btnAceptar2.Location = new Point(266, 181);
            btnAceptar2.Margin = new Padding(4, 5, 4, 5);
            btnAceptar2.Name = "btnAceptar2";
            btnAceptar2.Size = new Size(127, 47);
            btnAceptar2.TabIndex = 1;
            btnAceptar2.Text = "&ACEPTAR";
            btnAceptar2.UseVisualStyleBackColor = true;
            btnAceptar2.Click += btnAceptar2_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 403);
            Controls.Add(btnAceptar2);
            Controls.Add(lblBienvenida);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmInicio";
            Text = "INICIO";
            Load += frmInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnAceptar2;
    }
}