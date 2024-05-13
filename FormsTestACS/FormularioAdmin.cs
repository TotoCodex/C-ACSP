using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTestACS
{
    public partial class FormularioAdmin : Form
    {
        public FormularioAdmin()
        {
            InitializeComponent();
        }

        private void FormularioAdmin_Load(object sender, EventArgs e)
        {
            string listoofUser = DB.SelectDB();
            DataTable table = new DataTable();
            
            table.Columns.Add("Name",typeof(string));
            table.Columns.Add("Age",typeof(int));
            table.Columns.Add("User",typeof(string));
            table.Columns.Add("Password",typeof(string));
            table.Columns.Add("DNI", typeof(int));


            try {

                List<Usuario> deserializedList = JsonConvert.DeserializeObject<List<Usuario>>(listoofUser);
                foreach (Usuario user in deserializedList) {

                    table.Rows.Add(user.Name,user.Age,user.User,user.Password,user.Dni);
                }
                dataGridView1.DataSource = table;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string editedUser = txt_UserEdit.Text;
                string editedPassword = txt_PasswordEdit.Text;
                string readDni = txt_ReadDni.Text;
                int num_readDni= int.Parse(readDni);
                DB.UpdateDatagrid(num_readDni,editedUser, editedPassword);

                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) { 
            
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_UserEdit.Text = row.Cells[2].Value.ToString();
                txt_PasswordEdit.Text = row.Cells[3].Value.ToString();
                txt_ReadDni.Text = row.Cells[4].Value.ToString();


            } 
                
        }
    }
}
