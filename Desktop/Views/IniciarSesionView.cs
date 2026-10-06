using Firebase.Auth;
using Firebase.Auth.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class IniciarSesionView : Form
    {
        FirebaseAuthClient FirebaseAuthClient;
        int intentos = 0;
        public IniciarSesionView()
        {
            InitializeComponent();
            ConfiguracionFirebaseAuthClient();
        }
        private void ConfiguracionFirebaseAuthClient()
        {
            var configAuthClient = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyBaZ4GfJnp607mZ5WyD4V5rHKoNx57Rmts",
                AuthDomain = "inventarioisp20enzo.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
            };

            FirebaseAuthClient = new FirebaseAuthClient(configAuthClient);
        }


        private async void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            try
            {
                var user = await FirebaseAuthClient!
                            .SignInWithEmailAndPasswordAsync(textUsuario.Text, textPassword.Text);
                if (user == null)
                {
                    MessageBox.Show($"Usuario o contraseña incorrectos");
                    intentos++;
                    return;
                }
                MessageBox.Show($"Bienvenido");
                this.Hide();
                var mainView = new MenuPrincipalView();
                mainView.ShowDialog();
                this.Close();

            }
            catch (FirebaseAuthException error)
            {

                MessageBox.Show($"Ha ocurrido un error: {error.Reason}");
                intentos++;

            }
            if (intentos >= 3)
            {
                MessageBox.Show($"Ha superado el número de intentos permitidos");
                Application.Exit();
            }
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
   
            {
                textPassword.PasswordChar = checkPassword.Checked ? '\0' : '*';
            }
           

        }

    }
}
