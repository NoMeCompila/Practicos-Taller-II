namespace Practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtNombre.SelectionStart == 0)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else
            {
                e.KeyChar = char.ToLower(e.KeyChar);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] caracteresValidos = { '.', ',', '$' };

            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !caracteresValidos.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor, complete al menos el Nombre y el Apellido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string fechaNac = datFec.Value.ToShortDateString();
            string sexo = radH.Checked ? "Hombre" : (radM.Checked ? "Mujer" : "No especificado");
            string saldo = txtSaldo.Text;
            string rutaFoto = txtFoto.Text;
            Image foto = picFoto.Image;

            datGrid.Rows.Insert(0, apellido, nombre, fechaNac, sexo, "Eliminar", saldo, foto, rutaFoto);
            string saldoLimpio = txtSaldo.Text.Replace("$", "").Trim();

            if (decimal.TryParse(saldoLimpio, out decimal saldoNumerico))
            {
                if (saldoNumerico < 50)
                {
                    // Pinta toda la fila de rojo
                    datGrid.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                    datGrid.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                }
            }


            LimpiarCampos();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string rutaCarpeta = Path.Combine(Application.StartupPath, "Fotos");

                openFileDialog.InitialDirectory = rutaCarpeta;
                openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Seleccionar Foto";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtFoto.Text = openFileDialog.FileName;

                    this.picFoto.ImageLocation = openFileDialog.FileName;
                    this.picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtSaldo.Clear();
            txtFoto.Clear();
            radH.Checked = false;
            radM.Checked = false;
            datFec.Value = DateTime.Today;
            picFoto.Image = null;
        }

        private void datGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (datGrid.Columns[e.ColumnIndex].Name == "Eliminar" || datGrid.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    datGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}