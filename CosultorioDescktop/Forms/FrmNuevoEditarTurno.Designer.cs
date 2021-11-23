
namespace ConsultorioDesktop.Forms
{
    partial class FrmNuevoEditarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoEditarTurno));
            this.DtpFechaTurno = new System.Windows.Forms.DateTimePicker();
            this.LblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpHora = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CboTipoTurno = new System.Windows.Forms.ComboBox();
            this.NumUpDownPrecio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NumUpDownBonos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CboDoctor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboPaciente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownBonos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpFechaTurno
            // 
            this.DtpFechaTurno.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaTurno.Location = new System.Drawing.Point(147, 61);
            this.DtpFechaTurno.Name = "DtpFechaTurno";
            this.DtpFechaTurno.Size = new System.Drawing.Size(227, 23);
            this.DtpFechaTurno.TabIndex = 71;
            // 
            // LblFechaDeNacimiento
            // 
            this.LblFechaDeNacimiento.AutoSize = true;
            this.LblFechaDeNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaDeNacimiento.Location = new System.Drawing.Point(12, 63);
            this.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento";
            this.LblFechaDeNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblFechaDeNacimiento.Size = new System.Drawing.Size(120, 21);
            this.LblFechaDeNacimiento.TabIndex = 63;
            this.LblFechaDeNacimiento.Text = "Fecha del turno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Hora del turno:";
            // 
            // DtpHora
            // 
            this.DtpHora.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHora.Location = new System.Drawing.Point(147, 120);
            this.DtpHora.Name = "DtpHora";
            this.DtpHora.Size = new System.Drawing.Size(227, 23);
            this.DtpHora.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tipo del turno:";
            // 
            // CboTipoTurno
            // 
            this.CboTipoTurno.FormattingEnabled = true;
            this.CboTipoTurno.Location = new System.Drawing.Point(147, 181);
            this.CboTipoTurno.Name = "CboTipoTurno";
            this.CboTipoTurno.Size = new System.Drawing.Size(121, 23);
            this.CboTipoTurno.TabIndex = 78;
            // 
            // NumUpDownPrecio
            // 
            this.NumUpDownPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUpDownPrecio.Location = new System.Drawing.Point(147, 232);
            this.NumUpDownPrecio.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NumUpDownPrecio.Name = "NumUpDownPrecio";
            this.NumUpDownPrecio.Size = new System.Drawing.Size(228, 29);
            this.NumUpDownPrecio.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 79;
            this.label4.Text = "Precio:";
            // 
            // NumUpDownBonos
            // 
            this.NumUpDownBonos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUpDownBonos.Location = new System.Drawing.Point(147, 291);
            this.NumUpDownBonos.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NumUpDownBonos.Name = "NumUpDownBonos";
            this.NumUpDownBonos.Size = new System.Drawing.Size(228, 29);
            this.NumUpDownBonos.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 299);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 81;
            this.label5.Text = "Bonos:";
            // 
            // CboDoctor
            // 
            this.CboDoctor.FormattingEnabled = true;
            this.CboDoctor.Location = new System.Drawing.Point(568, 61);
            this.CboDoctor.Name = "CboDoctor";
            this.CboDoctor.Size = new System.Drawing.Size(121, 23);
            this.CboDoctor.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(433, 64);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 83;
            this.label3.Text = "Doctor:";
            // 
            // CboPaciente
            // 
            this.CboPaciente.FormattingEnabled = true;
            this.CboPaciente.Location = new System.Drawing.Point(568, 120);
            this.CboPaciente.Name = "CboPaciente";
            this.CboPaciente.Size = new System.Drawing.Size(121, 23);
            this.CboPaciente.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(433, 123);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 85;
            this.label6.Text = "Paciente:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(582, 326);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(107, 58);
            this.BtnCancelar.TabIndex = 88;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(582, 262);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(107, 58);
            this.BtnGuardar.TabIndex = 87;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmNuevoEditarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CboPaciente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CboDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumUpDownBonos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumUpDownPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboTipoTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpFechaTurno);
            this.Controls.Add(this.LblFechaDeNacimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevoEditarTurno";
            this.Text = "Formulario de turnos";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownBonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtpFechaTurno;
        private System.Windows.Forms.Label LblFechaDeNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboTipoTurno;
        private System.Windows.Forms.NumericUpDown NumUpDownPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumUpDownBonos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}