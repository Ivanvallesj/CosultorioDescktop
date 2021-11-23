
namespace ConsultorioDesktop.Forms
{
    partial class FrmNuevoEditarDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoEditarDoctor));
            this.LblCalendario = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblTutor = new System.Windows.Forms.Label();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.NUpDownDni = new System.Windows.Forms.NumericUpDown();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboEspecializacion = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtLocalidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDtelefono = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDtelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCalendario
            // 
            this.LblCalendario.AutoSize = true;
            this.LblCalendario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCalendario.Location = new System.Drawing.Point(23, 236);
            this.LblCalendario.Name = "LblCalendario";
            this.LblCalendario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCalendario.Size = new System.Drawing.Size(79, 21);
            this.LblCalendario.TabIndex = 20;
            this.LblCalendario.Text = "Localidad:";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSexo.Location = new System.Drawing.Point(23, 174);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblSexo.Size = new System.Drawing.Size(46, 21);
            this.LblSexo.TabIndex = 22;
            this.LblSexo.Text = "Sexo:";
            // 
            // CboSexo
            // 
            this.CboSexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Location = new System.Drawing.Point(186, 174);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(228, 29);
            this.CboSexo.TabIndex = 25;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(480, 398);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(107, 58);
            this.BtnCancelar.TabIndex = 32;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(480, 334);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(107, 58);
            this.BtnGuardar.TabIndex = 31;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblTutor
            // 
            this.LblTutor.AutoSize = true;
            this.LblTutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTutor.Location = new System.Drawing.Point(23, 290);
            this.LblTutor.Name = "LblTutor";
            this.LblTutor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTutor.Size = new System.Drawing.Size(51, 21);
            this.LblTutor.TabIndex = 17;
            this.LblTutor.Text = "Email:";
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(187, 462);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(227, 23);
            this.DtpFechaNacimiento.TabIndex = 26;
            // 
            // NUpDownDni
            // 
            this.NUpDownDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUpDownDni.Location = new System.Drawing.Point(187, 124);
            this.NUpDownDni.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NUpDownDni.Name = "NUpDownDni";
            this.NUpDownDni.Size = new System.Drawing.Size(228, 29);
            this.NUpDownDni.TabIndex = 23;
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDni.Location = new System.Drawing.Point(23, 132);
            this.LblDni.Name = "LblDni";
            this.LblDni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblDni.Size = new System.Drawing.Size(40, 21);
            this.LblDni.TabIndex = 16;
            this.LblDni.Text = "DNI:";
            // 
            // LblFechaDeNacimiento
            // 
            this.LblFechaDeNacimiento.AutoSize = true;
            this.LblFechaDeNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaDeNacimiento.Location = new System.Drawing.Point(23, 464);
            this.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento";
            this.LblFechaDeNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblFechaDeNacimiento.Size = new System.Drawing.Size(158, 21);
            this.LblFechaDeNacimiento.TabIndex = 15;
            this.LblFechaDeNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(186, 28);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(228, 29);
            this.TxtNombre.TabIndex = 12;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombre.Location = new System.Drawing.Point(23, 36);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblNombre.Size = new System.Drawing.Size(71, 21);
            this.LblNombre.TabIndex = 14;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblApellido.Location = new System.Drawing.Point(23, 78);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblApellido.Size = new System.Drawing.Size(70, 21);
            this.LblApellido.TabIndex = 18;
            this.LblApellido.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellido.Location = new System.Drawing.Point(186, 70);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(228, 29);
            this.TxtApellido.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 342);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Especializacion :";
            // 
            // CboEspecializacion
            // 
            this.CboEspecializacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboEspecializacion.FormattingEnabled = true;
            this.CboEspecializacion.Location = new System.Drawing.Point(186, 334);
            this.CboEspecializacion.Name = "CboEspecializacion";
            this.CboEspecializacion.Size = new System.Drawing.Size(228, 29);
            this.CboEspecializacion.TabIndex = 34;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.Location = new System.Drawing.Point(186, 282);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(228, 29);
            this.TxtEmail.TabIndex = 35;
            // 
            // TxtLocalidad
            // 
            this.TxtLocalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLocalidad.Location = new System.Drawing.Point(186, 228);
            this.TxtLocalidad.Name = "TxtLocalidad";
            this.TxtLocalidad.Size = new System.Drawing.Size(228, 29);
            this.TxtLocalidad.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 390);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Telefono:";
            // 
            // numUpDtelefono
            // 
            this.numUpDtelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDtelefono.Location = new System.Drawing.Point(186, 390);
            this.numUpDtelefono.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numUpDtelefono.Name = "numUpDtelefono";
            this.numUpDtelefono.Size = new System.Drawing.Size(228, 29);
            this.numUpDtelefono.TabIndex = 38;
            // 
            // FrmNuevoEditarDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 559);
            this.Controls.Add(this.numUpDtelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLocalidad);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboEspecializacion);
            this.Controls.Add(this.LblCalendario);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTutor);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.NUpDownDni);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.LblFechaDeNacimiento);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.TxtApellido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevoEditarDoctor";
            this.Text = "Formulario de Doctores";
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDtelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblCalendario;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblTutor;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.NumericUpDown NUpDownDni;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblFechaDeNacimiento;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboEspecializacion;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtLocalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDtelefono;
    }
}