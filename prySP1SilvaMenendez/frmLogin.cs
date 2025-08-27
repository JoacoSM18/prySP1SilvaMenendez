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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmInicio ventanaInicio = new frmInicio();
            ventanaInicio.ShowDialog();
        }
    }
}
