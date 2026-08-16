namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string myName = this.textBox2.Text;
            string myLastName = this.textBox1.Text;

            this.txtMultiline.Text = $"{myName} {myLastName}";
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            this.txtMultiline.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true; // Evita el sonido de alerta del sistema
                Application.Exit();       // Equivalente en C# a finalizar la aplicación
            }
        }
    }
}
