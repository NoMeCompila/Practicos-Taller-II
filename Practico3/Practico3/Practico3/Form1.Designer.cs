namespace Practico3
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            lblTitle = new Label();
            panForm = new Panel();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            lblGuardar = new Label();
            lblEliminar = new Label();
            lblSalir = new Label();
            lblNyP = new Label();
            lblModificar = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTel = new Label();
            lblCard = new Label();
            chkNaranja = new CheckBox();
            chkVisa = new CheckBox();
            chkMastercard = new CheckBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTel = new TextBox();
            radHombre = new RadioButton();
            radMujer = new RadioButton();
            picUser = new PictureBox();
            panForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(195, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(198, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nuevo Cliente";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panForm
            // 
            panForm.BackColor = SystemColors.ControlLight;
            panForm.Controls.Add(txtTel);
            panForm.Controls.Add(txtApellido);
            panForm.Controls.Add(txtNombre);
            panForm.Controls.Add(txtDNI);
            panForm.Controls.Add(chkMastercard);
            panForm.Controls.Add(chkVisa);
            panForm.Controls.Add(chkNaranja);
            panForm.Controls.Add(lblCard);
            panForm.Controls.Add(lblTel);
            panForm.Controls.Add(lblApellido);
            panForm.Controls.Add(lblNombre);
            panForm.Controls.Add(lblDNI);
            panForm.Controls.Add(lblModificar);
            panForm.Controls.Add(lblNyP);
            panForm.Location = new Point(21, 91);
            panForm.Name = "panForm";
            panForm.Size = new Size(299, 344);
            panForm.TabIndex = 1;
            panForm.Paint += panel1_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightSkyBlue;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(21, 459);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(54, 48);
            btnGuardar.TabIndex = 2;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.MistyRose;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(142, 459);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(47, 48);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.PaleGreen;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Zoom;
            btnSalir.ImageAlign = ContentAlignment.MiddleRight;
            btnSalir.Location = new Point(266, 459);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(54, 48);
            btnSalir.TabIndex = 4;
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblGuardar
            // 
            lblGuardar.AutoSize = true;
            lblGuardar.Location = new Point(21, 510);
            lblGuardar.Name = "lblGuardar";
            lblGuardar.Size = new Size(49, 15);
            lblGuardar.TabIndex = 5;
            lblGuardar.Text = "Guardar";
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.Location = new Point(142, 510);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(50, 15);
            lblEliminar.TabIndex = 6;
            lblEliminar.Text = "Eliminar";
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.Location = new Point(279, 510);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(29, 15);
            lblSalir.TabIndex = 7;
            lblSalir.Text = "Salir";
            // 
            // lblNyP
            // 
            lblNyP.AutoSize = true;
            lblNyP.Location = new Point(41, 16);
            lblNyP.Name = "lblNyP";
            lblNyP.Size = new Size(107, 15);
            lblNyP.TabIndex = 8;
            lblNyP.Text = "Nombre y Apellido";
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.ForeColor = Color.Red;
            lblModificar.Location = new Point(161, 16);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(58, 15);
            lblModificar.TabIndex = 9;
            lblModificar.Text = "Modificar";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(41, 72);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 10;
            lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 111);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(41, 158);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(41, 194);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(52, 15);
            lblTel.TabIndex = 13;
            lblTel.Text = "Teléfono";
            // 
            // lblCard
            // 
            lblCard.AutoSize = true;
            lblCard.Location = new Point(41, 234);
            lblCard.Name = "lblCard";
            lblCard.Size = new Size(104, 15);
            lblCard.TabIndex = 14;
            lblCard.Text = "Tarjetas de Crédito";
            // 
            // chkNaranja
            // 
            chkNaranja.AutoSize = true;
            chkNaranja.Location = new Point(161, 233);
            chkNaranja.Name = "chkNaranja";
            chkNaranja.Size = new Size(67, 19);
            chkNaranja.TabIndex = 15;
            chkNaranja.Text = "Naranja";
            chkNaranja.UseVisualStyleBackColor = true;
            // 
            // chkVisa
            // 
            chkVisa.AutoSize = true;
            chkVisa.Location = new Point(161, 255);
            chkVisa.Name = "chkVisa";
            chkVisa.Size = new Size(47, 19);
            chkVisa.TabIndex = 16;
            chkVisa.Text = "Visa";
            chkVisa.UseVisualStyleBackColor = true;
            // 
            // chkMastercard
            // 
            chkMastercard.AutoSize = true;
            chkMastercard.Location = new Point(161, 280);
            chkMastercard.Name = "chkMastercard";
            chkMastercard.Size = new Size(85, 19);
            chkMastercard.TabIndex = 17;
            chkMastercard.Text = "Mastercard";
            chkMastercard.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(161, 72);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(161, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 19;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(161, 150);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 20;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(161, 191);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 21;
            // 
            // radHombre
            // 
            radHombre.AutoSize = true;
            radHombre.Location = new Point(422, 282);
            radHombre.Name = "radHombre";
            radHombre.Size = new Size(69, 19);
            radHombre.TabIndex = 8;
            radHombre.TabStop = true;
            radHombre.Text = "Hombre";
            radHombre.UseVisualStyleBackColor = true;
            // 
            // radMujer
            // 
            radMujer.AutoSize = true;
            radMujer.Location = new Point(422, 320);
            radMujer.Name = "radMujer";
            radMujer.Size = new Size(56, 19);
            radMujer.TabIndex = 9;
            radMujer.TabStop = true;
            radMujer.Text = "Mujer";
            radMujer.UseVisualStyleBackColor = true;
            // 
            // picUser
            // 
            picUser.BackgroundImage = (Image)resources.GetObject("picUser.BackgroundImage");
            picUser.BackgroundImageLayout = ImageLayout.Zoom;
            picUser.Location = new Point(410, 107);
            picUser.Name = "picUser";
            picUser.Size = new Size(126, 157);
            picUser.TabIndex = 10;
            picUser.TabStop = false;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(592, 558);
            Controls.Add(picUser);
            Controls.Add(radMujer);
            Controls.Add(radHombre);
            Controls.Add(lblSalir);
            Controls.Add(lblEliminar);
            Controls.Add(lblGuardar);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(panForm);
            Controls.Add(lblTitle);
            Name = "Form";
            Text = "Pequeño Formulario";
            panForm.ResumeLayout(false);
            panForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panForm;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnSalir;
        private Label lblDNI;
        private Label lblModificar;
        private Label lblNyP;
        private Label lblGuardar;
        private Label lblEliminar;
        private Label lblSalir;
        private TextBox txtTel;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private CheckBox chkMastercard;
        private CheckBox chkVisa;
        private CheckBox chkNaranja;
        private Label lblCard;
        private Label lblTel;
        private Label lblApellido;
        private Label lblNombre;
        private RadioButton radHombre;
        private RadioButton radMujer;
        private PictureBox picUser;
    }
}
