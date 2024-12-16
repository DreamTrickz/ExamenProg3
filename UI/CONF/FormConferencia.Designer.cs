namespace TallerFinal.UI.CONF
{
    partial class FormConferencia
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
            groupBox3 = new GroupBox();
            label2 = new Label();
            buttonFiltrar = new Button();
            textBoxFiltro = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            groupBox2 = new GroupBox();
            dataGridViewConferencias = new DataGridView();
            buttonCancelar = new Button();
            buttonLimpiar = new Button();
            groupBox1 = new GroupBox();
            checkBoxEstado = new CheckBox();
            textBoxDescripcion = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConferencias).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(buttonFiltrar);
            groupBox3.Controls.Add(textBoxFiltro);
            groupBox3.Location = new Point(11, 206);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(619, 95);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 49);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "Titulo:";
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.Location = new Point(411, 36);
            buttonFiltrar.Margin = new Padding(3, 4, 3, 4);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(114, 40);
            buttonFiltrar.TabIndex = 8;
            buttonFiltrar.Text = "Buscar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            buttonFiltrar.Click += buttonFiltrar_Click;
            // 
            // textBoxFiltro
            // 
            textBoxFiltro.Location = new Point(108, 46);
            textBoxFiltro.Margin = new Padding(3, 4, 3, 4);
            textBoxFiltro.Name = "textBoxFiltro";
            textBoxFiltro.Size = new Size(284, 27);
            textBoxFiltro.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(11, 669);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 40);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += BtnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(132, 669);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(114, 40);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(253, 669);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 40);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewConferencias);
            groupBox2.Location = new Point(11, 309);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(619, 352);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de conferencias";
            // 
            // dataGridViewConferencias
            // 
            dataGridViewConferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConferencias.Location = new Point(7, 27);
            dataGridViewConferencias.Margin = new Padding(3, 4, 3, 4);
            dataGridViewConferencias.Name = "dataGridViewConferencias";
            dataGridViewConferencias.RowHeadersWidth = 51;
            dataGridViewConferencias.Size = new Size(606, 315);
            dataGridViewConferencias.TabIndex = 0;
            dataGridViewConferencias.CellClick += dataGridViewConferencias_CellClick;
            dataGridViewConferencias.CellContentClick += dataGridViewConferencias_CellContentClick;
            dataGridViewConferencias.SelectionChanged += dataGridViewConferencias_SelectionChanged;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(516, 669);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(114, 40);
            buttonCancelar.TabIndex = 20;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(395, 669);
            buttonLimpiar.Margin = new Padding(3, 4, 3, 4);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(114, 40);
            buttonLimpiar.TabIndex = 19;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBoxEstado);
            groupBox1.Controls.Add(textBoxDescripcion);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(619, 185);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Location = new Point(451, 48);
            checkBoxEstado.Margin = new Padding(3, 4, 3, 4);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(73, 24);
            checkBoxEstado.TabIndex = 5;
            checkBoxEstado.Text = "Activo";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(107, 45);
            textBoxDescripcion.Margin = new Padding(3, 4, 3, 4);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(327, 27);
            textBoxDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 48);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 80);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 27);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 83);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Fecha:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 115);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 27);
            textBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 118);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Lugar:";
            // 
            // FormConferencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 723);
            Controls.Add(groupBox3);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonLimpiar);
            Controls.Add(groupBox1);
            Name = "FormConferencia";
            Text = "Registro de conferencias";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewConferencias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Label label2;
        private Button buttonFiltrar;
        private TextBox textBoxFiltro;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private GroupBox groupBox2;
        private DataGridView dataGridViewConferencias;
        private Button buttonCancelar;
        private Button buttonLimpiar;
        private GroupBox groupBox1;
        private TextBox textBoxDescripcion;
        private Label label1;
        private CheckBox checkBoxEstado;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
    }
}