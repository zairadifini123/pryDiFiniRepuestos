namespace pryDiFiniRepuestos
{
    public partial class frmRepuestos : Form
    {
        struct Repuesto
        {
            public string marca;       // P, F, R
            public string origen;      // N o I
            public int numero;
            public string descripcion;
            public float precio;
        }

        Repuesto[] repuestos = new Repuesto[100];
        int indice = 0; // cuántos repuestos llevo cargados
        int cantidad = 0; // controla cuántos repuestos hay cargados 
        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verifico que haya espacio en el arreglo
            if (indice >= 100)
            {
                MessageBox.Show("Ya se cargaron 100 repuestos.");
                return;
            }

            // Creo un repuesto y le asigno los datos
            Repuesto r = new Repuesto();
            r.marca = cmbMarcas.Text;
            r.origen = cmbOrigen.Text;
            r.numero = int.Parse(txtNRegistro.Text);
            r.descripcion = txtDescripcion.Text;
            r.precio = float.Parse(txtPrecio.Text);

            // Lo guardo en el arreglo
            repuestos[indice] = r;
            indice++;

            MessageBox.Show("Repuesto registrado.");

            // Limpio los controles para el siguiente ingreso
            cmbMarcas.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            txtNRegistro.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            string marca = cmbElegirMarca.Text;
            string origen = optNacional.Checked ? "N" : optImportado.Checked ? "I" : "";

            if (marca == "" || origen == "")
            {
                MessageBox.Show("Seleccione marca y origen.");
                return;
            }

            for (int i = 0; i < indice; i++)
            {
                if (repuestos[i].marca == marca && repuestos[i].origen == origen)
                {
                    lstResultados.Items.Add(
                        repuestos[i].numero + " - " +
                        repuestos[i].descripcion + " - $" +
                        repuestos[i].precio
                    );
                }
            }
        }
    }
}