using TallerFinal.BL.CONF;
using TallerFinal.DTO.CONF;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TallerFinal.UI.CONF
{
    public partial class FormParticipante : Form
    {
        private readonly ParticipantesBL _participantesBL;
        private int IdParticipante;
        private DateTime FechaCreacion;
        private string UsuarioCrea = string.Empty;

        public FormParticipante()
        {
            InitializeComponent();
            _participantesBL = new ParticipantesBL();
        }

        // Método para cargar los participantes en el DataGridView
        private void CargarParticipantes()
        {
            var participantes = _participantesBL.ObtenerParticipantes();
            dataGridViewParticipantes.DataSource = participantes.Select(p => new
            {
                p.IdParticipante,
                p.Nombre,
                p.Apellido,
                p.Email,
                p.Telefono,
                p.Compania,
                p.Domicilio,
                p.Ciudad,
                p.Pais,
                p.FechaCreacion,
                p.UsuarioCrea,
                Estado = p.Estado ? "Activo" : "Inactivo"
            }).ToList();
            FormatearDataGridView();
        }

        private void FormatearDataGridView()
        {
            dataGridViewParticipantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewParticipantes.MultiSelect = false;
            dataGridViewParticipantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewParticipantes.Columns["IdParticipante"].HeaderText = "ID";
            dataGridViewParticipantes.Columns["Nombre"].HeaderText = "Nombre";
            dataGridViewParticipantes.Columns["Apellido"].HeaderText = "Apellido";
            dataGridViewParticipantes.Columns["Email"].HeaderText = "Email";
            dataGridViewParticipantes.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridViewParticipantes.Columns["Compania"].HeaderText = "Compañía";
            dataGridViewParticipantes.Columns["Domicilio"].HeaderText = "Domicilio";
            dataGridViewParticipantes.Columns["Ciudad"].HeaderText = "Ciudad";
            dataGridViewParticipantes.Columns["Pais"].HeaderText = "País";
            dataGridViewParticipantes.Columns["Estado"].HeaderText = "Estado";
            dataGridViewParticipantes.Columns["Region"].HeaderText = "País";
            dataGridViewParticipantes.Columns["CallesTransversales"].HeaderText = "Estado";
        }

        private void CargarDatosDeFilaSeleccionada()
        {
            if (dataGridViewParticipantes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewParticipantes.SelectedRows[0];
                IdParticipante = (int)row.Cells["IdParticipante"].Value;
                textBoxNombre.Text = row.Cells["Nombre"].Value?.ToString();
                textBox1.Text = row.Cells["Apellido"].Value?.ToString();
                textBox2.Text = row.Cells["Email"].Value?.ToString();
                textBox4.Text = row.Cells["Telefono"].Value?.ToString();
                textBox5.Text = row.Cells["Compania"].Value?.ToString();
                textBox9.Text = row.Cells["Domicilio"].Value?.ToString();
                textBox8.Text = row.Cells["Ciudad"].Value?.ToString();
                textBox3.Text = row.Cells["Pais"].Value?.ToString();
                textBox6.Text = row.Cells["CodigoPostal"].Value?.ToString();
                textBox7.Text = row.Cells["Region"].Value?.ToString();
                textBox10.Text = row.Cells["CallesTransversales"].Value?.ToString();

                FechaCreacion = Convert.ToDateTime(row.Cells["FechaCreacion"].Value);
                UsuarioCrea = row.Cells["UsuarioCrea"].Value?.ToString();
                checkBoxEstado.Checked = row.Cells["Estado"].Value.ToString() == "Activo";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var participante = new Participante
            {
                Nombre = textBoxNombre.Text,
                Apellido = textBox1.Text,
                Email = textBox2.Text,
                Telefono = textBox4.Text,
                Compania = textBox5.Text,
                Region = textBox7.Text,
                CallesTransversales = textBox10.Text,
                Domicilio = textBox9.Text,
                Ciudad = textBox8.Text,
                Pais = textBox3.Text,
                FechaCreacion = DateTime.Now,
                UsuarioCrea = "UsuarioDemo",
                Estado = checkBoxEstado.Checked
            };

            _participantesBL.GuardarParticipante(
                participante.Nombre, participante.Apellido, participante.Compania,
                participante.Telefono, participante.Email, participante.Domicilio,
                "", participante.Ciudad, "", "", participante.Pais
            );

            CargarParticipantes();
            MessageBox.Show("Participante agregado correctamente.");
            LimpiarFormulario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var participante = new Participante
            {
                IdParticipante = IdParticipante,
                Nombre = textBoxNombre.Text,
                Apellido = textBox1.Text,
                Email = textBox2.Text,
                Telefono = textBox4.Text,
                Compania = textBox5.Text,
                CodigoPostal = textBox6.Text,
                Domicilio = textBox9.Text,
                CallesTransversales = textBox10.Text,
                Ciudad = textBox8.Text,
                Region = textBox7.Text,
                Pais = textBox3.Text,
                FechaCreacion = FechaCreacion,
                UsuarioCrea = UsuarioCrea,
                FechaModificacion = DateTime.Now,
                UsuarioModifica = "UsuarioDemo",
                Estado = checkBoxEstado.Checked
            };

            _participantesBL.ActualizarParticipante(participante);
            CargarParticipantes();
            MessageBox.Show("Participante actualizado correctamente.");
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _participantesBL.EliminarParticipante(IdParticipante);
            CargarParticipantes();
            MessageBox.Show("Participante eliminado correctamente.");
            LimpiarFormulario();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            textBoxNombre.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox10.Text = string.Empty;
            checkBoxEstado.Checked = false;
        }

        private void FormParticipantes_Load(object sender, EventArgs e)
        {
            CargarParticipantes();
        }

        private void dataGridViewParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                CargarDatosDeFilaSeleccionada();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridViewParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewParticipantes_SelectionChanged(object sender, EventArgs e)
        {
            CargarDatosDeFilaSeleccionada();
        }
    }
}
