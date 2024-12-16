using System;
using System.Windows.Forms;
using TallerFinal.UI.CONF;

namespace TallerFinal.UI.INI
{
    public partial class FormPrincipal : Form
    {
        private Form? childForm; // Variable para gestionar formularios hijos

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Opcional: Código para inicializar datos o configurar elementos al cargar el formulario
        }

        // Método para abrir el formulario de Participantes
        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormParticipante(), "Gestión de Participantes");
        }

        private void toolStripButtonParticipantes_Click(object sender, EventArgs e)
        {
            participantesToolStripMenuItem_Click(sender, e);
        }

        // Método para abrir el formulario de Conferencias
        private void conferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormConferencia(), "Gestión de Conferencias");
        }

        private void toolStripButtonConferencias_Click(object sender, EventArgs e)
        {
            conferenciasToolStripMenuItem_Click(sender, e);
        }

        // Método para abrir el formulario de Participaciones
        private void participacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormParticipacion(), "Gestión de Participaciones");
        }

        private void toolStripButtonParticipaciones_Click(object sender, EventArgs e)
        {
            participacionesToolStripMenuItem_Click(sender, e);
        }

        // Método genérico para abrir formularios hijos
        private void AbrirFormulario(Form form, string titulo)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = form;
                childForm.MdiParent = this; // Asignar como formulario hijo
                childForm.Text = titulo;
                childForm.Show();
            }
            else
            {
                // Si el formulario ya está abierto, tráelo al frente
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        // Método para salir del programa
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
