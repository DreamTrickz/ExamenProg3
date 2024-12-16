namespace TallerFinal.UI.INI
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos utilizados.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben ser eliminados; de lo contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para el diseño.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonParticipantes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonConferencias = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonParticipaciones = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantesToolStripMenuItem,
            this.conferenciasToolStripMenuItem,
            this.participacionesToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.participantesToolStripMenuItem.Text = "Participantes";
            this.participantesToolStripMenuItem.Click += new System.EventHandler(this.participantesToolStripMenuItem_Click);
            // 
            // conferenciasToolStripMenuItem
            // 
            this.conferenciasToolStripMenuItem.Name = "conferenciasToolStripMenuItem";
            this.conferenciasToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.conferenciasToolStripMenuItem.Text = "Conferencias";
            this.conferenciasToolStripMenuItem.Click += new System.EventHandler(this.conferenciasToolStripMenuItem_Click);
            // 
            // participacionesToolStripMenuItem
            // 
            this.participacionesToolStripMenuItem.Name = "participacionesToolStripMenuItem";
            this.participacionesToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.participacionesToolStripMenuItem.Text = "Participaciones";
            this.participacionesToolStripMenuItem.Click += new System.EventHandler(this.participacionesToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonParticipantes,
            this.toolStripButtonConferencias,
            this.toolStripButtonParticipaciones});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonParticipantes
            // 
            this.toolStripButtonParticipantes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonParticipantes.Name = "toolStripButtonParticipantes";
            this.toolStripButtonParticipantes.Size = new System.Drawing.Size(99, 24);
            this.toolStripButtonParticipantes.Text = "Participantes";
            this.toolStripButtonParticipantes.Click += new System.EventHandler(this.participantesToolStripMenuItem_Click);
            // 
            // toolStripButtonConferencias
            // 
            this.toolStripButtonConferencias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonConferencias.Name = "toolStripButtonConferencias";
            this.toolStripButtonConferencias.Size = new System.Drawing.Size(95, 24);
            this.toolStripButtonConferencias.Text = "Conferencias";
            this.toolStripButtonConferencias.Click += new System.EventHandler(this.conferenciasToolStripMenuItem_Click);
            // 
            // toolStripButtonParticipaciones
            // 
            this.toolStripButtonParticipaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonParticipaciones.Name = "toolStripButtonParticipaciones";
            this.toolStripButtonParticipaciones.Size = new System.Drawing.Size(113, 24);
            this.toolStripButtonParticipaciones.Text = "Participaciones";
            this.toolStripButtonParticipaciones.Click += new System.EventHandler(this.participacionesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 20);
            this.toolStripStatusLabel1.Text = "UsuarioDemo";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Sistema de Gestión";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonParticipantes;
        private System.Windows.Forms.ToolStripButton toolStripButtonConferencias;
        private System.Windows.Forms.ToolStripButton toolStripButtonParticipaciones;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
