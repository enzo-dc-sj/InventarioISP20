namespace Desktop.Views
{
    partial class IniciarSesionView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            labelUsuario = new Label();
            textUsuario = new TextBox();
            btnIniciarSesion = new Button();
            labelPassword = new Label();
            textPassword = new TextBox();
            btnCancelar = new Button();
            checkPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_ISP20;
            pictureBox1.Location = new Point(34, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(385, 52);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(59, 20);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(474, 49);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(291, 27);
            textUsuario.TabIndex = 2;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(385, 301);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(132, 42);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click_1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(385, 139);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(83, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Contraseña";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(474, 139);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(291, 27);
            textPassword.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(590, 301);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(148, 42);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // checkPassword
            // 
            checkPassword.AutoSize = true;
            checkPassword.Location = new Point(474, 242);
            checkPassword.Name = "checkPassword";
            checkPassword.Size = new Size(130, 24);
            checkPassword.TabIndex = 7;
            checkPassword.Text = "Ver Contraseña";
            checkPassword.UseVisualStyleBackColor = true;
            checkPassword.CheckedChanged += checkPassword_CheckedChanged;
            // 
            // IniciarSesionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkPassword);
            Controls.Add(btnCancelar);
            Controls.Add(textPassword);
            Controls.Add(labelPassword);
            Controls.Add(btnIniciarSesion);
            Controls.Add(textUsuario);
            Controls.Add(labelUsuario);
            Controls.Add(pictureBox1);
            Name = "IniciarSesionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IniciarSesionView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelUsuario;
        private TextBox textUsuario;
        private Button btnIniciarSesion;
        private Label labelPassword;
        private TextBox textPassword;
        private Button btnCancelar;
        private CheckBox checkPassword;
    }
}