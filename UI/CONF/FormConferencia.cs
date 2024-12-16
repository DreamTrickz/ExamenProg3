using TallerFinal.BL.CONF;
using TallerFinal.DTO.CONF;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TallerFinal.UI.CONF
{
    public partial class FormConferencia : Form
    {
        private readonly ConferenciasBL _conferenciasBL;
        private int IdConferencia;
        private DateTime FechaCreacion;
        private string UsuarioCrea = string.Empty;

        public FormConferencia()
        {
            InitializeComponent();
            _conferenciasBL = new ConferenciasBL();
        }

        // Método para cargar las conferencias en el DataGridView
        private void CargarConferencias()
        {
            var conferencias = _conferenciasBL.ObtenerConferencias();
            dataGridViewConferencias.DataSource = conferencias.Select(c => new
            {
                c.IdConferencia,
                c.Titulo,
                c.Fecha,
                c.Lugar,
                c.FechaCreacion,
                c.UsuarioCrea,
                c.FechaModificacion,
                c.UsuarioModifica,
                Estado = c.Estado ? "Activo" : "Inactivo"
            }).ToList();
            FormateaDataGridView();
        }

        private void FormateaDataGridView()
        {
            dataGridViewConferencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewConferencias.MultiSelect = false;
            dataGridViewConferencias.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewConferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewConferencias.Columns["IdConferencia"].HeaderText = "ID";
            dataGridViewConferencias.Columns["Titulo"].HeaderText = "Título";
            dataGridViewConferencias.Columns["Fecha"].HeaderText = "Fecha";
            dataGridViewConferencias.Columns["Lugar"].HeaderText = "Lugar";
            dataGridViewConferencias.Columns["FechaCreacion"].HeaderText = "Fecha de Creación";
            dataGridViewConferencias.Columns["UsuarioCrea"].HeaderText = "Usuario Crea";
            dataGridViewConferencias.Columns["FechaModificacion"].HeaderText = "Fecha Modificación";
            dataGridViewConferencias.Columns["UsuarioModifica"].HeaderText = "Usuario Modifica";
            dataGridViewConferencias.Columns["Estado"].HeaderText = "Estado";

            dataGridViewConferencias.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewConferencias.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewConferencias.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        }

        private void CargarDatosDeFilaSeleccionada()
        {
            if (dataGridViewConferencias.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewConferencias.SelectedRows[0];
                IdConferencia = (int)row.Cells["IdConferencia"].Value;
                textBoxDescripcion.Text = row.Cells["Titulo"].Value?.ToString();
                textBox1.Text = row.Cells["Fecha"].Value?.ToString();
                textBox2.Text = row.Cells["Lugar"].Value?.ToString();
                UsuarioCrea = row.Cells["UsuarioCrea"].Value?.ToString() ?? string.Empty;
                checkBoxEstado.Checked = row.Cells["Estado"].Value.ToString() == "Activo";
            }
        }
        private void SeleccionarPrimeraFila()
        {
            if (dataGridViewConferencias.Rows.Count > 0) // Verificar que haya filas en el DataGridView
            {
                dataGridViewConferencias.ClearSelection(); // Limpiar cualquier selección previa
                dataGridViewConferencias.Rows[0].Selected = true; // Seleccionar la primera fila

                // Llamar al método que maneja la carga de datos en los controles
                CargarDatosDeFilaSeleccionada();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescripcion.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Los campos Título, Fecha y Lugar son obligatorios.");
                return;
            }

            var nuevaConferencia = new Conferencia
            {
                Titulo = textBoxDescripcion.Text,
                Fecha = DateTime.Parse(textBox1.Text),
                Lugar = textBox2.Text,
                FechaCreacion = DateTime.Now,
                UsuarioCrea = "UsuarioDemo",
                Estado = checkBoxEstado.Checked
            };

            _conferenciasBL.GuardarConferencia(
                nuevaConferencia.Titulo,
                nuevaConferencia.Fecha,
                nuevaConferencia.Lugar,
                nuevaConferencia.FechaCreacion,
                nuevaConferencia.UsuarioCrea
            );

            CargarConferencias();
            MessageBox.Show("Conferencia agregada correctamente.");
            buttonLimpiar_Click(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var conferencia = new Conferencia
            {
                IdConferencia = IdConferencia,
                Titulo = textBoxDescripcion.Text,
                Fecha = DateTime.Parse(textBox1.Text),
                Lugar = textBox2.Text,
                FechaCreacion = FechaCreacion,
                UsuarioCrea = UsuarioCrea,
                FechaModificacion = DateTime.Now,
                UsuarioModifica = "UsuarioDemo",
                Estado = checkBoxEstado.Checked
            };

            _conferenciasBL.ActualizarConferencia(
                conferencia.IdConferencia,
                conferencia.Titulo,
                conferencia.Fecha,
                conferencia.Lugar,
                conferencia.UsuarioModifica
            );

            CargarConferencias();
            MessageBox.Show("Conferencia actualizada correctamente.");
            buttonLimpiar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _conferenciasBL.EliminarConferencia(IdConferencia);
            CargarConferencias();
            MessageBox.Show("Conferencia eliminada correctamente.");
            buttonLimpiar_Click(sender, e);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            var filtro = textBoxFiltro.Text;
            var conferenciasFiltradas = _conferenciasBL.ObtenerConferenciasConFiltro(filtro);

            dataGridViewConferencias.DataSource = conferenciasFiltradas.Select(c => new
            {
                c.IdConferencia,
                c.Titulo,
                c.Fecha,
                c.Lugar,
                c.FechaCreacion,
                c.UsuarioCrea,
                c.FechaModificacion,
                c.UsuarioModifica,
                Estado = c.Estado ? "Activo" : "Inactivo" // Mostrar estado como texto
            }).ToList();

            FormateaDataGridView();
        }



        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            SeleccionarPrimeraFila();
            textBoxDescripcion.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBoxFiltro.Text = string.Empty;

            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            textBoxDescripcion.Focus();
        }
        private void dataGridViewConferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener el ítem seleccionado
                DataGridViewRow row = dataGridViewConferencias.Rows[e.RowIndex];

                // Cargar los valores en los controles del formulario                
                IdConferencia = Convert.ToInt32(row.Cells["IdConferencia"].Value);
                textBoxDescripcion.Text = row.Cells["NombreCompleto"].Value?.ToString();
                textBox1.Text = row.Cells["Fecha"].Value?.ToString();
                textBox2.Text = row.Cells["Lugar"].Value?.ToString();

                FechaCreacion = Convert.ToDateTime(row.Cells["FechaCreacion"].Value);
                UsuarioCrea = row.Cells["UsuarioCrea"].Value?.ToString() ?? string.Empty;

                // Habilitar los botones de actualización y eliminación
                btnAgregar.Enabled = false;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void FormConferencia_Load(object sender, EventArgs e)
        {
            CargarConferencias();
        }

        private void dataGridViewConferencias_SelectionChanged(object sender, EventArgs e)
        {
            CargarDatosDeFilaSeleccionada();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridViewConferencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
