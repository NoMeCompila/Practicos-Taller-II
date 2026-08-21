namespace Practico4
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
            openFileDialog1 = new OpenFileDialog();
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblFec = new Label();
            datFec = new DateTimePicker();
            radH = new RadioButton();
            radM = new RadioButton();
            lblSex = new Label();
            txtSaldo = new TextBox();
            lblSaldo = new Label();
            btnFoto = new Button();
            txtFoto = new TextBox();
            datGrid = new DataGridView();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            picFoto = new PictureBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)datGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(64, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Segoe UI", 15F);
            lblApellido.Location = new Point(64, 81);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(90, 28);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(280, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(206, 34);
            txtNombre.TabIndex = 2;
            txtNombre.KeyPress += textBox1_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 15F);
            txtApellido.Location = new Point(280, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(206, 34);
            txtApellido.TabIndex = 3;
            txtApellido.KeyPress += textBox2_KeyPress;
            // 
            // lblFec
            // 
            lblFec.AutoSize = true;
            lblFec.BackColor = Color.Transparent;
            lblFec.Font = new Font("Segoe UI", 15F);
            lblFec.Location = new Point(64, 130);
            lblFec.Name = "lblFec";
            lblFec.Size = new Size(199, 28);
            lblFec.TabIndex = 4;
            lblFec.Text = "Fecha de Nacimiento:";
            // 
            // datFec
            // 
            datFec.CalendarFont = new Font("Segoe UI", 20F);
            datFec.Cursor = Cursors.Hand;
            datFec.Format = DateTimePickerFormat.Short;
            datFec.Location = new Point(280, 135);
            datFec.Name = "datFec";
            datFec.Size = new Size(131, 23);
            datFec.TabIndex = 5;
            // 
            // radH
            // 
            radH.AutoSize = true;
            radH.BackColor = Color.Transparent;
            radH.Cursor = Cursors.Hand;
            radH.Font = new Font("Segoe UI", 15F);
            radH.Location = new Point(283, 179);
            radH.Name = "radH";
            radH.Size = new Size(102, 32);
            radH.TabIndex = 6;
            radH.TabStop = true;
            radH.Text = "Hombre";
            radH.UseVisualStyleBackColor = false;
            // 
            // radM
            // 
            radM.AutoSize = true;
            radM.BackColor = Color.Transparent;
            radM.Cursor = Cursors.Hand;
            radM.Font = new Font("Segoe UI", 15F);
            radM.Location = new Point(422, 179);
            radM.Name = "radM";
            radM.Size = new Size(81, 32);
            radM.TabIndex = 7;
            radM.TabStop = true;
            radM.Text = "Mujer";
            radM.UseVisualStyleBackColor = false;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.BackColor = Color.Transparent;
            lblSex.Font = new Font("Segoe UI", 15F);
            lblSex.Location = new Point(67, 183);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(58, 28);
            lblSex.TabIndex = 8;
            lblSex.Text = "Sexo:";
            // 
            // txtSaldo
            // 
            txtSaldo.Font = new Font("Segoe UI", 15F);
            txtSaldo.Location = new Point(283, 229);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(206, 34);
            txtSaldo.TabIndex = 10;
            txtSaldo.KeyPress += textBox3_KeyPress;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Font = new Font("Segoe UI", 15F);
            lblSaldo.Location = new Point(66, 235);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(66, 28);
            lblSaldo.TabIndex = 9;
            lblSaldo.Text = "Saldo:";
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.DodgerBlue;
            btnFoto.Cursor = Cursors.Hand;
            btnFoto.Font = new Font("Segoe UI", 15F);
            btnFoto.ForeColor = SystemColors.ButtonHighlight;
            btnFoto.Location = new Point(67, 290);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(76, 42);
            btnFoto.TabIndex = 11;
            btnFoto.Text = "Foto";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // txtFoto
            // 
            txtFoto.Font = new Font("Segoe UI", 15F);
            txtFoto.Location = new Point(283, 294);
            txtFoto.Name = "txtFoto";
            txtFoto.Size = new Size(206, 34);
            txtFoto.TabIndex = 12;
            // 
            // datGrid
            // 
            datGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datGrid.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, Fecha, Sexo, Eliminar, Saldo, Foto, Ruta });
            datGrid.Dock = DockStyle.Bottom;
            datGrid.Location = new Point(0, 397);
            datGrid.Name = "datGrid";
            datGrid.RowTemplate.Height = 50;
            datGrid.RowTemplate.Resizable = DataGridViewTriState.True;
            datGrid.Size = new Size(1032, 198);
            datGrid.TabIndex = 13;
            datGrid.CellContentClick += datGrid_CellContentClick;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 124;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 123;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fec. de Nac.";
            Fecha.Name = "Fecha";
            Fecha.Width = 124;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.Width = 124;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 123;
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            Saldo.Width = 124;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Foto.Name = "Foto";
            Foto.Resizable = DataGridViewTriState.True;
            Foto.SortMode = DataGridViewColumnSortMode.Automatic;
            Foto.Width = 123;
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            Ruta.Width = 124;
            // 
            // picFoto
            // 
            picFoto.BackgroundImageLayout = ImageLayout.Zoom;
            picFoto.Location = new Point(509, 24);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(511, 282);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 14;
            picFoto.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Segoe UI", 15F);
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(67, 338);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 42);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackGImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1032, 595);
            Controls.Add(btnGuardar);
            Controls.Add(picFoto);
            Controls.Add(datGrid);
            Controls.Add(txtFoto);
            Controls.Add(btnFoto);
            Controls.Add(txtSaldo);
            Controls.Add(lblSaldo);
            Controls.Add(lblSex);
            Controls.Add(radM);
            Controls.Add(radH);
            Controls.Add(datFec);
            Controls.Add(lblFec);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Formulario con Datagrid";
            ((System.ComponentModel.ISupportInitialize)datGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblFec;
        private DateTimePicker datFec;
        private RadioButton radH;
        private RadioButton radM;
        private Label lblSex;
        private TextBox txtSaldo;
        private Label lblSaldo;
        private Button btnFoto;
        private TextBox txtFoto;
        private DataGridView datGrid;
        private PictureBox picFoto;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
    }
}
