namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TDNI.Text) || 
                string.IsNullOrEmpty(this.TApellido.Text) || 
                string.IsNullOrEmpty(this.TNombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return;
            }
            string nombre = this.TNombre.Text;
            string apellido = this.TApellido.Text;
            this.LModificar.Text = $"{nombre} {apellido}";

            MessageBox.Show("Confirmar Inserción?", "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            string nombre = this.TNombre.Text;
            string apellido = this.TApellido.Text;
            DialogResult respuesta = MessageBox.Show(
            $"¿Está seguro de que desea eliminar al alumno {nombre} {apellido}?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);


            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show($"Alumno {nombre} {apellido} eliminado.", "Eliminación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.TNombre.Clear();
                this.TApellido.Clear();
                this.TDNI.Clear();
                this.LModificar.Text = "Modificar";
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.", "Cancelado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
