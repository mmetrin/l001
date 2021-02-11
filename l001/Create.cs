using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l001
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtPassword.Text != "" && txtName.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=I001;User ID=student;Password=Passw0rd"))
                {
                    bool rolead;
                    if (comboBoxRolead.SelectedIndex == 0)
                    {
                        rolead = true;
                    }
                    else rolead = false;
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT users (login, password, name, isadmin) VALUES ('" + txtLogin.Text + "','" + txtPassword.Text + "','" + txtName.Text + "','" + rolead + "')";
                        cmd.ExecuteScalar();
                        MessageBox.Show("Запись успешно добавлена!", "Добавление записи");
                        Close();
                        GC.Collect();
                        MainForm main = new MainForm
                        {
                            Visible = true,
                            ShowInTaskbar = true
                        };
                    }
                    catch (Exception ex)
                    {
                        if ("-2146232060" == Convert.ToString(ex.HResult))
                        {
                            MessageBox.Show("Логин занят");
                            txtLogin.Focus();
                        }
                        else
                        {
                            MessageBox.Show(Convert.ToString(ex));
                        }
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка заполнения");
                txtLogin.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
            MainForm main = new MainForm()
            {
                Visible = true,
                ShowInTaskbar = true
            };
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
