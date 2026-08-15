using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practico3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            $"¿Está seguro de que desea salir del programa?",
            "Salir",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
                this.Close();
            else
                return;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTel.Text))
            {

                MessageBox.Show(
                    "Todos los campos deben estar completos.",
                    "Campos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            else
            {
                string apellido = txtApellido.Text;
                string nombre = txtNombre.Text;
                this.lblModificar.Text = $"{nombre} {apellido}";

                MessageBox.Show(
                    "Los datos se han guardado correctamente.",
                    "Datos guardados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.txtApellido.Clear();
                this.txtNombre.Clear();
                this.txtDNI.Clear();
                this.txtTel.Clear();
                this.chkMastercard.Checked = false;
                this.chkNaranja.Checked = false;
                this.chkVisa.Checked = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            $"¿Está seguro de que desea eliminar a {this.lblModificar.Text}?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
            {
                txtApellido.Clear();
                txtNombre.Clear();
                txtDNI.Clear();
                txtTel.Clear();
                chkMastercard.Checked = false;
                chkNaranja.Checked = false;
                chkVisa.Checked = false;
                lblModificar.Text = "Modificar";
                MessageBox.Show(
                    $"el usuario ha sido eliminado.",
                    "Eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                return;
            }
        }

        private void radHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radHombre.Checked)
            {
                // Asigna la imagen de hombre desde los recursos
                this.picUser.BackgroundImage = Properties.Resources.male_user;
            }
        }

        private void radMujer_CheckedChanged(object sender, EventArgs e)
        {
            this.picUser.BackgroundImage = Properties.Resources.female_user;
        }
    }
}
