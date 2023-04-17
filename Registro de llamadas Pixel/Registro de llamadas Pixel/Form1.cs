namespace Registro_de_llamadas_Pixel;
using Entidades;


    public partial class Form1 : Form
    {   
      
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

    private void btnIniciarSesion_Click(object sender, EventArgs e)
    {
        if (Usuario.ValidarLogin(txtUsuario.Text, txtContraseña.Text))
        {
            FrmPrincipal formularioPrincipal = new FrmPrincipal();
            this.Hide();
            formularioPrincipal.Show();
        }
        else
        {
            lblMensajeError.Visible = true;
        }
    }
}
