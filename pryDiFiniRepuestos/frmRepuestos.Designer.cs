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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuestos));
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
            lblMarca.Location = new Point(15, 45);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(137, 20);
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
            grpRepuesto.Location = new Point(21, 24);
            grpRepuesto.Name = "grpRepuesto";
            grpRepuesto.Size = new Size(759, 292);
            grpRepuesto.TabIndex = 2;
            grpRepuesto.TabStop = false;
            grpRepuesto.Text = "Ingresa el repuesto";
            // 
            // txtRepuesto
            // 
            txtRepuesto.Enabled = false;
            txtRepuesto.Location = new Point(195, 151);
            txtRepuesto.Margin = new Padding(3, 4, 3, 4);
            txtRepuesto.Name = "txtRepuesto";
            txtRepuesto.Size = new Size(151, 27);
            txtRepuesto.TabIndex = 11;
            txtRepuesto.TextChanged += txtRepuesto_TextChanged;
            txtRepuesto.KeyPress += txtRepuesto_KeyPress;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(573, 221);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(146, 35);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(419, 221);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(146, 35);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(573, 95);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(151, 27);
            txtPrecio.TabIndex = 10;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(393, 97);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(137, 20);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio del repuesto";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(568, 37);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(151, 27);
            txtDescripcion.TabIndex = 8;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(389, 41);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(174, 20);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción del repuesto";
            // 
            // lblNRepuesto
            // 
            lblNRepuesto.AutoSize = true;
            lblNRepuesto.Location = new Point(15, 155);
            lblNRepuesto.Name = "lblNRepuesto";
            lblNRepuesto.Size = new Size(146, 20);
            lblNRepuesto.TabIndex = 5;
            lblNRepuesto.Text = "Número de repuesto";
            // 
            // cmbOrigen
            // 
            cmbOrigen.Enabled = false;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "N", "I" });
            cmbOrigen.Location = new Point(195, 96);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(151, 28);
            cmbOrigen.TabIndex = 4;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(15, 99);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(141, 20);
            lblOrigen.TabIndex = 3;
            lblOrigen.Text = "Origen del repuesto";
            // 
            // cmbMarcas
            // 
            cmbMarcas.FormattingEnabled = true;
            cmbMarcas.Items.AddRange(new object[] { "P", "F", "R" });
            cmbMarcas.Location = new Point(195, 45);
            cmbMarcas.Name = "cmbMarcas";
            cmbMarcas.Size = new Size(151, 28);
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
            grpConsulta.Location = new Point(21, 352);
            grpConsulta.Name = "grpConsulta";
            grpConsulta.Size = new Size(759, 295);
            grpConsulta.TabIndex = 3;
            grpConsulta.TabStop = false;
            grpConsulta.Text = "Consulta";
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(359, 45);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(370, 224);
            lstResultados.TabIndex = 16;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(137, 177);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(146, 35);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // optImportado
            // 
            optImportado.AutoSize = true;
            optImportado.Location = new Point(153, 133);
            optImportado.Name = "optImportado";
            optImportado.Size = new Size(101, 24);
            optImportado.TabIndex = 14;
            optImportado.TabStop = true;
            optImportado.Text = "Importado";
            optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            optNacional.AutoSize = true;
            optNacional.Location = new Point(153, 104);
            optNacional.Name = "optNacional";
            optNacional.Size = new Size(89, 24);
            optNacional.TabIndex = 13;
            optNacional.TabStop = true;
            optNacional.Text = "Nacional";
            optNacional.UseVisualStyleBackColor = true;
            // 
            // lblElegirOrigen
            // 
            lblElegirOrigen.AutoSize = true;
            lblElegirOrigen.Location = new Point(6, 104);
            lblElegirOrigen.Name = "lblElegirOrigen";
            lblElegirOrigen.Size = new Size(141, 20);
            lblElegirOrigen.TabIndex = 12;
            lblElegirOrigen.Text = "Origen del repuesto";
            // 
            // cmbElegirMarca
            // 
            cmbElegirMarca.FormattingEnabled = true;
            cmbElegirMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbElegirMarca.Location = new Point(133, 45);
            cmbElegirMarca.Name = "cmbElegirMarca";
            cmbElegirMarca.Size = new Size(151, 28);
            cmbElegirMarca.TabIndex = 11;
            // 
            // lblElegirMarca
            // 
            lblElegirMarca.AutoSize = true;
            lblElegirMarca.Location = new Point(6, 48);
            lblElegirMarca.Name = "lblElegirMarca";
            lblElegirMarca.Size = new Size(120, 20);
            lblElegirMarca.TabIndex = 0;
            lblElegirMarca.Text = "Elegir una marca";
            // 
            // frmRepuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 659);
            Controls.Add(grpConsulta);
            Controls.Add(grpRepuesto);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
