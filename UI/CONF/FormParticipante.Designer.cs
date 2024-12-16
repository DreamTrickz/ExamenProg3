namespace TallerFinal.UI.CONF
{
    partial class FormParticipante
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
            dataGridViewParticipantes = new DataGridView();
            buttonCancelar = new Button();
            buttonLimpiar = new Button();
            groupBox1 = new GroupBox();
            label13 = new Label();
            textBox10 = new TextBox();
            label12 = new Label();
            textBox9 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox8 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBoxNombre = new TextBox();
            label4 = new Label();
            checkBoxEstado = new CheckBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParticipantes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(buttonFiltrar);
            groupBox3.Controls.Add(textBoxFiltro);
            groupBox3.Location = new Point(12, 222);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(619, 80);
            groupBox3.TabIndex = 41;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 32);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.Location = new Point(445, 22);
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
            textBoxFiltro.Location = new Point(97, 28);
            textBoxFiltro.Margin = new Padding(3, 4, 3, 4);
            textBoxFiltro.Name = "textBoxFiltro";
            textBoxFiltro.Size = new Size(325, 27);
            textBoxFiltro.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(30, 655);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 40);
            btnAgregar.TabIndex = 38;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(179, 655);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(114, 40);
            btnActualizar.TabIndex = 39;
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(333, 655);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 40);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewParticipantes);
            groupBox2.Location = new Point(12, 310);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1227, 337);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de participantes";
            // 
            // dataGridViewParticipantes
            // 
            dataGridViewParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParticipantes.Location = new Point(0, 28);
            dataGridViewParticipantes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewParticipantes.Name = "dataGridViewParticipantes";
            dataGridViewParticipantes.RowHeadersWidth = 51;
            dataGridViewParticipantes.Size = new Size(1218, 301);
            dataGridViewParticipantes.TabIndex = 0;
            dataGridViewParticipantes.CellClick += dataGridViewParticipantes_CellClick;
            dataGridViewParticipantes.CellContentClick += dataGridViewParticipantes_CellContentClick;
            dataGridViewParticipantes.SelectionChanged += dataGridViewParticipantes_SelectionChanged;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(1116, 655);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(114, 40);
            buttonCancelar.TabIndex = 36;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(489, 655);
            buttonLimpiar.Margin = new Padding(3, 4, 3, 4);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(114, 40);
            buttonLimpiar.TabIndex = 35;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxEstado);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1218, 201);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(598, 138);
            label13.Name = "label13";
            label13.Size = new Size(105, 20);
            label13.TabIndex = 28;
            label13.Text = "Intersecciones:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(709, 134);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(449, 27);
            textBox10.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 141);
            label12.Name = "label12";
            label12.Size = new Size(77, 20);
            label12.TabIndex = 26;
            label12.Text = "Domicilio:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(97, 138);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(495, 27);
            textBox9.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(749, 97);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 24;
            label9.Text = "Codigo postal:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(861, 93);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(151, 27);
            textBox6.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(749, 63);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 23;
            label10.Text = "Region:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(833, 60);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(259, 27);
            textBox7.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(749, 28);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 20;
            label11.Text = "Cuidad:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(833, 24);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(259, 27);
            textBox8.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 97);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 18;
            label6.Text = "Pais:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(478, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 27);
            textBox3.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(394, 63);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 17;
            label7.Text = "Telefono:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(478, 60);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 27);
            textBox4.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(394, 28);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 14;
            label8.Text = "Compañia:";
            //  label8.Click += label8_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(478, 24);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(259, 27);
            textBox5.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 100);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 12;
            label5.Text = "Email:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 27);
            textBox2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 66);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 11;
            label1.Text = "Apellido";
            // label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 62);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 31);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(97, 27);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(259, 27);
            textBoxNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 125);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 5;
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Location = new Point(1019, 95);
            checkBoxEstado.Margin = new Padding(3, 4, 3, 4);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(73, 24);
            checkBoxEstado.TabIndex = 30;
            checkBoxEstado.Text = "Activo";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // FormParticipante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 718);
            Controls.Add(groupBox3);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonLimpiar);
            Controls.Add(groupBox1);
            Name = "FormParticipante";
            Text = "Registro de participantes";
            Load += FormParticipantes_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewParticipantes).EndInit();
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
        private DataGridView dataGridViewParticipantes;
        private Button buttonCancelar;
        private Button buttonLimpiar;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBoxNombre;
        private Label label4;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox8;
        private Label label13;
        private TextBox textBox10;
        private Label label12;
        private TextBox textBox9;
        private CheckBox checkBoxEstado;
    }
}