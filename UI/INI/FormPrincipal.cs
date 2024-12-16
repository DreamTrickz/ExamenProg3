using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerFinal.UI.CONF;

namespace TallerFinal.UI.INI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnConferencias_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de Conferencias
            var formConferencias = new FormConferencia();
            formConferencias.ShowDialog();
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de Participaciones
            var formParticipaciones = new FormParticipante(); 
            formParticipante.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }
    }
}
