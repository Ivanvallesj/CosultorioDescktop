
namespace ConsultorioDesktop.Forms
{
    partial class FrmDoctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctores));
            this.BtnAgregarPaciente = new System.Windows.Forms.Button();
            this.BtnEditarPaciente = new System.Windows.Forms.Button();
            this.BtnEliminarPaciente = new System.Windows.Forms.Button();
            this.GridPacientes = new System.Windows.Forms.DataGridView();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GridDoctores = new System.Windows.Forms.DataGridView();
            this.chkVerEliminados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDoctores)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregarPaciente
            // 
            this.BtnAgregarPaciente.Location = new System.Drawing.Point(82, 417);
            this.BtnAgregarPaciente.Name = "BtnAgregarPaciente";
            this.BtnAgregarPaciente.Size = new System.Drawing.Size(123, 30);
            this.BtnAgregarPaciente.TabIndex = 8;
            this.BtnAgregarPaciente.Text = "&Nuevo Paciente";
            this.BtnAgregarPaciente.UseVisualStyleBackColor = true;
            this.BtnAgregarPaciente.Click += new System.EventHandler(this.BtnAgregarPaciente_Click);
            // 
            // BtnEditarPaciente
            // 
            this.BtnEditarPaciente.Location = new System.Drawing.Point(263, 417);
            this.BtnEditarPaciente.Name = "BtnEditarPaciente";
            this.BtnEditarPaciente.Size = new System.Drawing.Size(105, 30);
            this.BtnEditarPaciente.TabIndex = 10;
            this.BtnEditarPaciente.Text = "&Editar Paciente";
            this.BtnEditarPaciente.UseVisualStyleBackColor = true;
            this.BtnEditarPaciente.Click += new System.EventHandler(this.BtnEditarPaciente_Click);
            // 
            // BtnEliminarPaciente
            // 
            this.BtnEliminarPaciente.Location = new System.Drawing.Point(429, 417);
            this.BtnEliminarPaciente.Name = "BtnEliminarPaciente";
            this.BtnEliminarPaciente.Size = new System.Drawing.Size(121, 30);
            this.BtnEliminarPaciente.TabIndex = 12;
            this.BtnEliminarPaciente.Text = "E&liminar Paciente";
            this.BtnEliminarPaciente.UseVisualStyleBackColor = true;
            this.BtnEliminarPaciente.Click += new System.EventHandler(this.BtnEliminarPaciente_Click);
            // 
            // GridPacientes
            // 
            this.GridPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPacientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPacientes.Location = new System.Drawing.Point(12, 223);
            this.GridPacientes.Name = "GridPacientes";
            this.GridPacientes.ReadOnly = true;
            this.GridPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPacientes.Size = new System.Drawing.Size(640, 177);
            this.GridPacientes.TabIndex = 6;
            this.GridPacientes.Text = "dataGridView1";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(670, 130);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(249, 23);
            this.TxtBusqueda.TabIndex = 15;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(766, 112);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(45, 15);
            this.LblBuscar.TabIndex = 14;
            this.LblBuscar.Text = "Buscar ";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(833, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 30);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(744, 12);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(83, 30);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(658, 12);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(80, 30);
            this.BtnNuevo.TabIndex = 9;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GridDoctores
            // 
            this.GridDoctores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridDoctores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDoctores.Location = new System.Drawing.Point(12, 12);
            this.GridDoctores.Name = "GridDoctores";
            this.GridDoctores.ReadOnly = true;
            this.GridDoctores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDoctores.Size = new System.Drawing.Size(640, 177);
            this.GridDoctores.TabIndex = 7;
            this.GridDoctores.Text = "dataGridView1";
            this.GridDoctores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDoctores_CellEnter);
            // 
            // chkVerEliminados
            // 
            this.chkVerEliminados.AutoSize = true;
            this.chkVerEliminados.Location = new System.Drawing.Point(670, 170);
            this.chkVerEliminados.Name = "chkVerEliminados";
            this.chkVerEliminados.Size = new System.Drawing.Size(103, 19);
            this.chkVerEliminados.TabIndex = 16;
            this.chkVerEliminados.Text = "Ver Eliminados";
            this.chkVerEliminados.UseVisualStyleBackColor = true;
            this.chkVerEliminados.CheckedChanged += new System.EventHandler(this.chkVerEliminados_CheckedChanged);
            // 
            // FrmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 499);
            this.Controls.Add(this.chkVerEliminados);
            this.Controls.Add(this.BtnAgregarPaciente);
            this.Controls.Add(this.BtnEditarPaciente);
            this.Controls.Add(this.BtnEliminarPaciente);
            this.Controls.Add(this.GridPacientes);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.GridDoctores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoctores";
            this.Text = "Fromulario principal de Doctores ";
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDoctores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarPaciente;
        private System.Windows.Forms.Button BtnEditarPaciente;
        private System.Windows.Forms.Button BtnEliminarPaciente;
        private System.Windows.Forms.DataGridView GridPacientes;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridView GridDoctores;
        private System.Windows.Forms.CheckBox chkVerEliminados;
    }
}