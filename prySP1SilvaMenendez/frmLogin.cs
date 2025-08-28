using prySilvaMenendezSP1;

namespace prySP1SilvaMenendez
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == "Administrador" &&
                txtContraseña.Text == "adm135$") ||
                (txtNombre.Text == "Operador" &&
                txtContraseña.Text == "ope246$"))

            {
                this.Hide(); // oculta este formualrio
                frmInicio f = new frmInicio(); // crea el frmInicio
                f.Text = txtNombre.Text; // asigna el texto de título
                f.ShowDialog(); // visualiza y ejecuta el frmInicio
                this.Show(); // visualiza nuevamente este formulario
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++; // incrementa el contador de intentos fallidos
                if (intentos == 3) // si es 3 se cierra el formulario
                {
                    this.Close();
                }
            }
        }




        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            {
               this.Close(); // cierra el formulario
            }
        }
    }
}
