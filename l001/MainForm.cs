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
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
        } 

        private void MainForm_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
            Create update = new Create
            {
                Visible = true,
                ShowInTaskbar = true
            };
        }

        //метод для открытия формы просмотра подробной информации о пользователе
        private void tableUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4)
                {
                    string ID = Convert.ToString(tableUsers.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);
                    string login = Convert.ToString(tableUsers.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[1].Value);
                    string password = Convert.ToString(tableUsers.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[2].Value);
                    string name = Convert.ToString(tableUsers.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[3].Value);
                    string rolead = Convert.ToString(tableUsers.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[4].Value);
                    this.Hide();
                    Read update = new Read(ID, login, password, name, rolead)
                    {
                        Visible = true,
                        ShowInTaskbar = true
                    };
                }
            }
            catch { }
        }

        private void tableUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //изменение записи при нажатии на соответствующую кнопку
                if (e.ColumnIndex == 5)
                {
                    string ID = Convert.ToString(tableUsers.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);
                    this.Hide();
                    Update update = new Update(ID)
                    {
                     Visible = true,
                       ShowInTaskbar = true
                    };
                    
                }

                //удаление записи при нажатии на соответствующую кнопку
                if (e.ColumnIndex == 6)
                {
                    string ID = Convert.ToString(tableUsers.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);
                    string message = $"Вы действительно хотите удалить данную запись?\nОтменить это действие будет невозможно!";
                    string caption = "Удаление записи";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=I001;User ID=student;Password=Passw0rd"))
                        {
                            try
                            {
                                conn.Open();
                                SqlCommand cmd = conn.CreateCommand();
                                cmd.CommandText = "DELETE FROM users WHERE id=@ID";
                                cmd.Parameters.AddWithValue(@"ID", ID);
                                cmd.ExecuteScalar();
                                conn.Close();
                                tableLoad();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(Convert.ToString(ex));
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Запись не удалена!");
                    }
                }
            }
            catch { }
        }

        void tableLoad()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=I001;User ID=student;Password=Passw0rd"))
            {
                string query = "SELECT id, login, password, name, isadmin FROM users";
                try
                {
                    tableUsers.Rows.Clear();
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    int j = 0;
                    while (reader.Read())
                    {
                        tableUsers.Rows.Add();
                        tableUsers.Rows[j].Cells[0].Value = Convert.ToString(String.Format("{0}", reader[0]));
                        tableUsers.Rows[j].Cells[1].Value = Convert.ToString(String.Format("{0}", reader[1]));
                        tableUsers.Rows[j].Cells[2].Value = Convert.ToString(String.Format("{0}", reader[2]));
                        tableUsers.Rows[j].Cells[3].Value = Convert.ToString(String.Format("{0}", reader[3]));
                        tableUsers.Rows[j].Cells[4].Value = Convert.ToString(String.Format("{0}", reader[4]));

                        if (tableUsers.Rows[j].Cells[4].Value.ToString() == "False")
                        {
                            tableUsers.Rows[j].Cells[4].Value = "user";
                        }
                        else
                        {
                            tableUsers.Rows[j].Cells[4].Value = "admin";
                        }
                        j++;
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

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
