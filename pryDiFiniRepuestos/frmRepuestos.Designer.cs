namespace pryDiFiniRepuestos
{
    partial class frmRepuestos
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
            lblMarca = new Label();
            grpRepuesto = new GroupBox();
            txtRepuesto = new TextBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            lblNRepuesto = new Label();
            cmbOrigen = new ComboBox();
            lblOrigen = new Label();
            cmbMarcas = new ComboBox();
            grpConsulta = new GroupBox();
            lstResultados = new ListBox();
            btnConsultar = new Button();
            optImportado = new RadioButton();
            optNacional = new RadioButton();
            lblElegirOrigen = new Label();
            cmbElegirMarca = new ComboBox();
            lblElegirMarca = new Label();
            grpRepuesto.SuspendLayout();
            grpConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(13, 34);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(108, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca del repuesto";
            // 
            // grpRepuesto
            // 
            grpRepuesto.Controls.Add(txtRepuesto);
            grpRepuesto.Controls.Add(btnRegistrar);
            grpRepuesto.Controls.Add(btnSalir);
            grpRepuesto.Controls.Add(txtPrecio);
            grpRepuesto.Controls.Add(lblPrecio);
            grpRepuesto.Controls.Add(txtDescripcion);
            grpRepuesto.Controls.Add(lblDescripcion);
            grpRepuesto.Controls.Add(lblNRepuesto);
            grpRepuesto.Controls.Add(cmbOrigen);
            grpRepuesto.Controls.Add(lblOrigen);
            grpRepuesto.Controls.Add(cmbMarcas);
            grpRepuesto.Controls.Add(lblMarca);
            grpRepuesto.Location = new Point(18, 18);
            grpRepuesto.Margin = new Padding(3, 2, 3, 2);
            grpRepuesto.Name = "grpRepuesto";
            grpRepuesto.Padding = new Padding(3, 2, 3, 2);
            grpRepuesto.Size = new Size(664, 219);
            grpRepuesto.TabIndex = 2;
            grpRepuesto.TabStop = false;
            grpRepuesto.Text = "Ingresa el repuesto";
            // 
            // txtRepuesto
            // 
            txtRepuesto.Location = new Point(171, 113);
            txtRepuesto.Name = "txtRepuesto";
            txtRepuesto.Size = new Size(133, 23);
            txtRepuesto.TabIndex = 11;
            txtRepuesto.KeyPress += txtRepuesto_KeyPress;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(501, 166);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(128, 26);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(367, 166);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(128, 26);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(501, 71);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(133, 23);
            txtPrecio.TabIndex = 10;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(344, 73);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(108, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio del repuesto";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(497, 28);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(133, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(340, 31);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(137, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripcion del repuesto";
            // 
            // lblNRepuesto
            // 
            lblNRepuesto.AutoSize = true;
            lblNRepuesto.Location = new Point(13, 116);
            lblNRepuesto.Name = "lblNRepuesto";
            lblNRepuesto.Size = new Size(116, 15);
            lblNRepuesto.TabIndex = 5;
            lblNRepuesto.Text = "Numero de repuesto";
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "N", "I" });
            cmbOrigen.Location = new Point(171, 72);
            cmbOrigen.Margin = new Padding(3, 2, 3, 2);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(133, 23);
            cmbOrigen.TabIndex = 4;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(13, 74);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(111, 15);
            lblOrigen.TabIndex = 3;
            lblOrigen.Text = "Origen del repuesto";
            // 
            // cmbMarcas
            // 
            cmbMarcas.FormattingEnabled = true;
            cmbMarcas.Items.AddRange(new object[] { "P", "F", "R" });
            cmbMarcas.Location = new Point(171, 34);
            cmbMarcas.Margin = new Padding(3, 2, 3, 2);
            cmbMarcas.Name = "cmbMarcas";
            cmbMarcas.Size = new Size(133, 23);
            cmbMarcas.TabIndex = 2;
            cmbMarcas.SelectedIndexChanged += cmbMarcas_SelectedIndexChanged;
            // 
            // grpConsulta
            // 
            grpConsulta.Controls.Add(lstResultados);
            grpConsulta.Controls.Add(btnConsultar);
            grpConsulta.Controls.Add(optImportado);
            grpConsulta.Controls.Add(optNacional);
            grpConsulta.Controls.Add(lblElegirOrigen);
            grpConsulta.Controls.Add(cmbElegirMarca);
            grpConsulta.Controls.Add(lblElegirMarca);
            grpConsulta.Location = new Point(18, 264);
            grpConsulta.Margin = new Padding(3, 2, 3, 2);
            grpConsulta.Name = "grpConsulta";
            grpConsulta.Padding = new Padding(3, 2, 3, 2);
            grpConsulta.Size = new Size(664, 221);
            grpConsulta.TabIndex = 3;
            grpConsulta.TabStop = false;
            grpConsulta.Text = "Consulta";
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(314, 34);
            lstResultados.Margin = new Padding(3, 2, 3, 2);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(324, 169);
            lstResultados.TabIndex = 16;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(120, 133);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(128, 26);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // optImportado
            // 
            optImportado.AutoSize = true;
            optImportado.Location = new Point(134, 100);
            optImportado.Margin = new Padding(3, 2, 3, 2);
            optImportado.Name = "optImportado";
            optImportado.Size = new Size(81, 19);
            optImportado.TabIndex = 14;
            optImportado.TabStop = true;
            optImportado.Text = "Importado";
            optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            optNacional.AutoSize = true;
            optNacional.Location = new Point(134, 78);
            optNacional.Margin = new Padding(3, 2, 3, 2);
            optNacional.Name = "optNacional";
            optNacional.Size = new Size(72, 19);
            optNacional.TabIndex = 13;
            optNacional.TabStop = true;
            optNacional.Text = "Nacional";
            optNacional.UseVisualStyleBackColor = true;
            // 
            // lblElegirOrigen
            // 
            lblElegirOrigen.AutoSize = true;
            lblElegirOrigen.Location = new Point(5, 78);
            lblElegirOrigen.Name = "lblElegirOrigen";
            lblElegirOrigen.Size = new Size(111, 15);
            lblElegirOrigen.TabIndex = 12;
            lblElegirOrigen.Text = "Origen del repuesto";
            // 
            // cmbElegirMarca
            // 
            cmbElegirMarca.FormattingEnabled = true;
            cmbElegirMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbElegirMarca.Location = new Point(116, 34);
            cmbElegirMarca.Margin = new Padding(3, 2, 3, 2);
            cmbElegirMarca.Name = "cmbElegirMarca";
            cmbElegirMarca.Size = new Size(133, 23);
            cmbElegirMarca.TabIndex = 11;
            // 
            // lblElegirMarca
            // 
            lblElegirMarca.AutoSize = true;
            lblElegirMarca.Location = new Point(5, 36);
            lblElegirMarca.Name = "lblElegirMarca";
            lblElegirMarca.Size = new Size(95, 15);
            lblElegirMarca.TabIndex = 0;
            lblElegirMarca.Text = "Elegir una marca";
            // 
            // frmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 494);
            Controls.Add(grpConsulta);
            Controls.Add(grpRepuesto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repuestos";
            grpRepuesto.ResumeLayout(false);
            grpRepuesto.PerformLayout();
            grpConsulta.ResumeLayout(false);
            grpConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMarca;
        private GroupBox grpRepuesto;
        private Label lblOrigen;
        private ComboBox cmbMarcas;
        private ComboBox cmbOrigen;
        private Label lblNRepuesto;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Button btnRegistrar;
        private Button btnSalir;
        private GroupBox grpConsulta;
        private Label lblElegirMarca;
        private RadioButton optImportado;
        private RadioButton optNacional;
        private Label lblElegirOrigen;
        private ComboBox cmbElegirMarca;
        private Button btnConsultar;
        private ListBox lstResultados;
        private TextBox txtRepuesto;
    }
}
