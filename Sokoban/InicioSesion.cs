using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sokoban
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        SqlConnection cnt;
        int intentos = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            cnt = new SqlConnection("Server=.\\SQLEXPRESS; Database=Sokoban; Trusted_Connection=True");
            cnt.Open();
            string consulta = "SELECT idUsuario FROM Usuario WHERE nombre='" + txtUser.Text + "'and clave=HASHBYTES('MD4', '" + txtPass.Text + "')";
            SqlCommand cmd = new SqlCommand(consulta, cnt);
            SqlDataReader dr = cmd.ExecuteReader();
            if (intentos < 10)
            {
                if (dr.Read())
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Favor de verificar los datos");
                    txtUser.Clear();
                    txtPass.Clear();
                    txtUser.Focus();
                    intentos++;
                }
            }
            else
            {
                MessageBox.Show("¡Ha excedido el número de intentos, la aplicación se cerrará!");
                Application.OpenForms["Form1"].Close();
            }
            dr.Close();
            cnt.Close();
        }
    }
}
