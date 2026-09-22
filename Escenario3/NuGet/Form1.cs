using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

namespace NuGet
{
    public partial class Form1 : Form
    {
        private static readonly ILogger logger = new LoggerConfiguration()
            .WriteTo.File("logs/app.log", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            logger.Information("La aplicación se inició correctamente.");

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            logger.Information("El usuario presionó el botón Registrar evento.");
            MessageBox.Show("Evento registrado correctamente.");
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = 10;
                int resultado = numero / 0;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ocurrió un error al realizar una operación.");
                MessageBox.Show("Se produjo un error. El evento fue registrado.");
            }
        }
    }
}
