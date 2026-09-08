namespace pryBritoSP2
{
    partial class Form1
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
            gbTitularDeReserva = new GroupBox();
            cbAdicionales = new GroupBox();
            gbTipoDeCabania = new GroupBox();
            gbFormasDePago = new GroupBox();
            lblTipo = new Label();
            txtTipo = new ComboBox();
            lblPersonas = new Label();
            cbPersonas = new ComboBox();
            txtDias = new TextBox();
            lblDias = new Label();
            Cocina = new CheckedListBox();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            lblTarjetas = new Label();
            cbTarjetas = new ComboBox();
            lblNombre = new Label();
            lblTelefono = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            gbTitularDeReserva.SuspendLayout();
            cbAdicionales.SuspendLayout();
            gbTipoDeCabania.SuspendLayout();
            gbFormasDePago.SuspendLayout();
            SuspendLayout();
            // 
            // gbTitularDeReserva
            // 
            gbTitularDeReserva.Controls.Add(textBox3);
            gbTitularDeReserva.Controls.Add(textBox2);
            gbTitularDeReserva.Controls.Add(lblTelefono);
            gbTitularDeReserva.Controls.Add(lblNombre);
            gbTitularDeReserva.Location = new Point(12, 237);
            gbTitularDeReserva.Name = "gbTitularDeReserva";
            gbTitularDeReserva.Size = new Size(509, 106);
            gbTitularDeReserva.TabIndex = 10;
            gbTitularDeReserva.TabStop = false;
            gbTitularDeReserva.Text = "Titular de la reserva";
            // 
            // cbAdicionales
            // 
            cbAdicionales.Controls.Add(Cocina);
            cbAdicionales.Location = new Point(12, 115);
            cbAdicionales.Name = "cbAdicionales";
            cbAdicionales.Size = new Size(196, 116);
            cbAdicionales.TabIndex = 11;
            cbAdicionales.TabStop = false;
            cbAdicionales.Text = "groupBox2";
            // 
            // gbTipoDeCabania
            // 
            gbTipoDeCabania.Controls.Add(lblDias);
            gbTipoDeCabania.Controls.Add(txtDias);
            gbTipoDeCabania.Controls.Add(cbPersonas);
            gbTipoDeCabania.Controls.Add(lblPersonas);
            gbTipoDeCabania.Controls.Add(txtTipo);
            gbTipoDeCabania.Controls.Add(lblTipo);
            gbTipoDeCabania.Location = new Point(12, 28);
            gbTipoDeCabania.Name = "gbTipoDeCabania";
            gbTipoDeCabania.Size = new Size(509, 69);
            gbTipoDeCabania.TabIndex = 12;
            gbTipoDeCabania.TabStop = false;
            gbTipoDeCabania.Text = "Tipo de cabaña";
            // 
            // gbFormasDePago
            // 
            gbFormasDePago.Controls.Add(cbTarjetas);
            gbFormasDePago.Controls.Add(lblTarjetas);
            gbFormasDePago.Controls.Add(rbTarjeta);
            gbFormasDePago.Controls.Add(rbEfectivo);
            gbFormasDePago.Location = new Point(214, 115);
            gbFormasDePago.Name = "gbFormasDePago";
            gbFormasDePago.Size = new Size(307, 116);
            gbFormasDePago.TabIndex = 13;
            gbFormasDePago.TabStop = false;
            gbFormasDePago.Text = "Formas de pago";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(20, 27);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // txtTipo
            // 
            txtTipo.FormattingEnabled = true;
            txtTipo.Location = new Point(57, 27);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(143, 23);
            txtTipo.TabIndex = 1;
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(221, 27);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(54, 15);
            lblPersonas.TabIndex = 2;
            lblPersonas.Text = "Personas";
            // 
            // cbPersonas
            // 
            cbPersonas.FormattingEnabled = true;
            cbPersonas.Location = new Point(277, 27);
            cbPersonas.Name = "cbPersonas";
            cbPersonas.Size = new Size(77, 23);
            cbPersonas.TabIndex = 3;
            cbPersonas.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(405, 27);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(79, 23);
            txtDias.TabIndex = 4;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(370, 27);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 5;
            lblDias.Text = "Días";
            // 
            // Cocina
            // 
            Cocina.FormattingEnabled = true;
            Cocina.Location = new Point(20, 22);
            Cocina.Name = "Cocina";
            Cocina.Size = new Size(155, 76);
            Cocina.TabIndex = 0;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(19, 22);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(19, 47);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(60, 19);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(147, 51);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(47, 15);
            lblTarjetas.TabIndex = 2;
            lblTarjetas.Text = "Tarjetas";
            // 
            // cbTarjetas
            // 
            cbTarjetas.FormattingEnabled = true;
            cbTarjetas.Location = new Point(147, 69);
            cbTarjetas.Name = "cbTarjetas";
            cbTarjetas.Size = new Size(121, 23);
            cbTarjetas.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(20, 64);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(58, 15);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Teléfonos";
            lblTelefono.Click += label6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(80, 64);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(413, 23);
            textBox3.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 355);
            Controls.Add(gbFormasDePago);
            Controls.Add(gbTipoDeCabania);
            Controls.Add(cbAdicionales);
            Controls.Add(gbTitularDeReserva);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservas de Cabañas";
            gbTitularDeReserva.ResumeLayout(false);
            gbTitularDeReserva.PerformLayout();
            cbAdicionales.ResumeLayout(false);
            gbTipoDeCabania.ResumeLayout(false);
            gbTipoDeCabania.PerformLayout();
            gbFormasDePago.ResumeLayout(false);
            gbFormasDePago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTitularDeReserva;
        private GroupBox cbAdicionales;
        private GroupBox gbTipoDeCabania;
        private ComboBox cbPersonas;
        private Label lblPersonas;
        private ComboBox txtTipo;
        private Label lblTipo;
        private GroupBox gbFormasDePago;
        private Label lblDias;
        private TextBox txtDias;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label lblTelefono;
        private Label lblNombre;
        private CheckedListBox Cocina;
        private ComboBox cbTarjetas;
        private Label lblTarjetas;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
    }
}
