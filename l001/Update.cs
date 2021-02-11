using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace l001
{
    public partial class Update : Form
    {
        string ID;

        public Update(string id)
        {
            InitializeComponent();
            ID = id;
        }
        public void TableLoad()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=I001;User ID=student;Password=Passw0rd"))
            {
                string query = "SELECT id, login, password, name, isadmin FROM users";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtLogin.Text = Convert.ToString(String.Format("{0}", reader[1]));
                        txtPassword.Text = Convert.ToString(String.Format("{0}", reader[2]));
                        txtName.Text = Convert.ToString(String.Format("{0}", reader[3]));
                        if (Convert.ToString(String.Format("{0}", reader[4])) == "True")
                        {
                            comboBoxRolead.Text = "admin";
                        }
                        else
                        {
                            comboBoxRolead.Text = "user";
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
                finally
                {
                    conn.Close();
                }
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

        private void Update_Load(object sender, EventArgs e)
        {
            TableLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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


                    cmd.CommandText = "UPDATE [users] SET login='" + txtLogin.Text + "', password='" + txtPassword.Text + "', name='" + txtName.Text + "', isadmin='" + rolead + "' WHERE [users].id=" + ID;
                    cmd.ExecuteScalar();
                    MessageBox.Show("Запись успешно изменена!", "Изменение записи");
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
    }
}

