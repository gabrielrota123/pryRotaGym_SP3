namespace pryRotaGym_SP3
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            chkEstudiante = new CheckBox();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            txtMeses = new TextBox();
            checkBox1 = new CheckBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            lblnombre = new Label();
            lbledad = new Label();
            gpbdatospersonales = new GroupBox();
            lblplan = new Label();
            lblturno = new Label();
            lblmeses = new Label();
            gpbplan = new GroupBox();
            cmbcuotas = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gpbpagos = new GroupBox();
            lblcuotas = new Label();
            gpbdatospersonales.SuspendLayout();
            gpbplan.SuspendLayout();
            gpbpagos.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 22);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(80, 51);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(93, 80);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 4;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación ", " Funcional ", " Natación" });
            cboPlan.Location = new Point(58, 22);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 1;
            cboPlan.SelectedIndexChanged += cboPlan_SelectedIndexChanged;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana ", "Tarde ", " Noche" });
            cboTurno.Location = new Point(58, 54);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 3;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(58, 84);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(100, 23);
            txtMeses.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(13, 119);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(145, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Casillero ($ 3.000/mes)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(21, 21);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(21, 46);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(20, 30);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(54, 15);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre:";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(20, 54);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(39, 15);
            lbledad.TabIndex = 2;
            lbledad.Text = "Edad: ";
            // 
            // gpbdatospersonales
            // 
            gpbdatospersonales.Controls.Add(lbledad);
            gpbdatospersonales.Controls.Add(txtNombre);
            gpbdatospersonales.Controls.Add(lblnombre);
            gpbdatospersonales.Controls.Add(txtEdad);
            gpbdatospersonales.Controls.Add(chkEstudiante);
            gpbdatospersonales.Location = new Point(25, 7);
            gpbdatospersonales.Name = "gpbdatospersonales";
            gpbdatospersonales.Size = new Size(186, 107);
            gpbdatospersonales.TabIndex = 0;
            gpbdatospersonales.TabStop = false;
            gpbdatospersonales.Text = "Datos Personales";
            gpbdatospersonales.Enter += gpbdatospersonales_Enter;
            // 
            // lblplan
            // 
            lblplan.AutoSize = true;
            lblplan.Location = new Point(12, 30);
            lblplan.Name = "lblplan";
            lblplan.Size = new Size(33, 15);
            lblplan.TabIndex = 0;
            lblplan.Text = "Plan:";
            // 
            // lblturno
            // 
            lblturno.AutoSize = true;
            lblturno.Location = new Point(12, 62);
            lblturno.Name = "lblturno";
            lblturno.Size = new Size(39, 15);
            lblturno.TabIndex = 2;
            lblturno.Text = "turno:";
            // 
            // lblmeses
            // 
            lblmeses.AutoSize = true;
            lblmeses.Location = new Point(12, 92);
            lblmeses.Name = "lblmeses";
            lblmeses.Size = new Size(43, 15);
            lblmeses.TabIndex = 4;
            lblmeses.Text = "meses:";
            // 
            // gpbplan
            // 
            gpbplan.Controls.Add(lblmeses);
            gpbplan.Controls.Add(cboPlan);
            gpbplan.Controls.Add(checkBox1);
            gpbplan.Controls.Add(lblturno);
            gpbplan.Controls.Add(cboTurno);
            gpbplan.Controls.Add(lblplan);
            gpbplan.Controls.Add(txtMeses);
            gpbplan.Location = new Point(26, 120);
            gpbplan.Name = "gpbplan";
            gpbplan.Size = new Size(185, 144);
            gpbplan.TabIndex = 1;
            gpbplan.TabStop = false;
            gpbplan.Text = "Plan";
            // 
            // cmbcuotas
            // 
            cmbcuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcuotas.FormattingEnabled = true;
            cmbcuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cmbcuotas.Location = new Point(73, 71);
            cmbcuotas.Name = "cmbcuotas";
            cmbcuotas.Size = new Size(88, 23);
            cmbcuotas.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(331, 141);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(237, 142);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // gpbpagos
            // 
            gpbpagos.Controls.Add(lblcuotas);
            gpbpagos.Controls.Add(rbtEfectivo);
            gpbpagos.Controls.Add(rbtTarjeta);
            gpbpagos.Controls.Add(cmbcuotas);
            gpbpagos.Location = new Point(231, 14);
            gpbpagos.Name = "gpbpagos";
            gpbpagos.Size = new Size(185, 100);
            gpbpagos.TabIndex = 2;
            gpbpagos.TabStop = false;
            gpbpagos.Text = "pagos";
            // 
            // lblcuotas
            // 
            lblcuotas.AutoSize = true;
            lblcuotas.Location = new Point(21, 77);
            lblcuotas.Name = "lblcuotas";
            lblcuotas.Size = new Size(45, 15);
            lblcuotas.TabIndex = 2;
            lblcuotas.Text = "cuotas:";
            lblcuotas.Click += label1_Click;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 288);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gpbdatospersonales);
            Controls.Add(gpbplan);
            Controls.Add(gpbpagos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmInscripcion_Load;
            gpbdatospersonales.ResumeLayout(false);
            gpbdatospersonales.PerformLayout();
            gpbplan.ResumeLayout(false);
            gpbplan.PerformLayout();
            gpbpagos.ResumeLayout(false);
            gpbpagos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEdad;
        private CheckBox chkEstudiante;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private TextBox txtMeses;
        private CheckBox checkBox1;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private Label lblnombre;
        private Label lbledad;
        private GroupBox gpbdatospersonales;
        private Label lblplan;
        private Label lblturno;
        private Label lblmeses;
        private GroupBox gpbplan;
        private ComboBox cmbcuotas;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox gpbpagos;
        private Label lblcuotas;
    }
}
