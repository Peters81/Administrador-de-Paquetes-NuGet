using Newtonsoft.Json;

namespace Pract1_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" &&
                txtEdad.Text != "" &&
                txtCarrera.Text != "")
            {
                var persona = new
                {
                    Nombre = txtNombre.Text,
                    Edad = txtEdad.Text,
                    Carrera = txtCarrera.Text
                };

                string json = JsonConvert.SerializeObject(persona);

                respuesta.Text = json;
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Se cerrará la aplicación",
                "Close",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private void respuesta_Click(object sender, EventArgs e)
        {

        }
    }
}