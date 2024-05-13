using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace FormsTestACS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string age = txt_Age.Text;
            int iAge=int.Parse(age);
            string user = txt_User.Text;
            string password = txt_Password.Text;
            string dni = txt_Dni.Text;
            int iDni=int.Parse(dni);
            Usuario usuario = new Usuario(name, iAge, user, password, iDni);
            List<Usuario> list=usuario.listadeUsuarios(usuario);
            usuario.SerializarJson(list);
            DB.InsertUsuario(usuario);
            
            

            MessageBox.Show("Se ha creado exitosamente el Usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            FormularioAdmin formAdmin = new FormularioAdmin();
            formAdmin.Show();


        }

        private void txt_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
