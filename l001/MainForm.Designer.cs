
namespace l001
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelUsers = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableUsers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isadmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obnov = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.75F);
            this.labelUsers.Location = new System.Drawing.Point(428, 26);
            this.labelUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(402, 36);
            this.labelUsers.TabIndex = 89;
            this.labelUsers.Text = "Список всех пользователей";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lavender;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.75F);
            this.btnAdd.Location = new System.Drawing.Point(435, 633);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(436, 53);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "Добавить нового пользователя";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableUsers
            // 
            this.tableUsers.AllowUserToAddRows = false;
            this.tableUsers.AllowUserToDeleteRows = false;
            this.tableUsers.AllowUserToResizeColumns = false;
            this.tableUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tableUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableUsers.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.tableUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.login,
            this.password,
            this.name,
            this.isadmin,
            this.obnov,
            this.delet});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableUsers.DefaultCellStyle = dataGridViewCellStyle10;
            this.tableUsers.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableUsers.Location = new System.Drawing.Point(47, 101);
            this.tableUsers.Margin = new System.Windows.Forms.Padding(5);
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.RowHeadersVisible = false;
            this.tableUsers.RowHeadersWidth = 51;
            this.tableUsers.Size = new System.Drawing.Size(1203, 491);
            this.tableUsers.TabIndex = 91;
            this.tableUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableUsers_CellClick);
            this.tableUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableUsers_CellContentClick);
            // 
            // id
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Silver;
            this.id.DefaultCellStyle = dataGridViewCellStyle8;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Visible = false;
            // 
            // login
            // 
            this.login.HeaderText = "Логин";
            this.login.MinimumWidth = 6;
            this.login.Name = "login";
            // 
            // password
            // 
            this.password.HeaderText = "Пароль";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // isadmin
            // 
            this.isadmin.HeaderText = "Роль";
            this.isadmin.MinimumWidth = 6;
            this.isadmin.Name = "isadmin";
            // 
            // obnov
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            this.obnov.DefaultCellStyle = dataGridViewCellStyle9;
            this.obnov.HeaderText = "Изменить";
            this.obnov.MinimumWidth = 6;
            this.obnov.Name = "obnov";
            this.obnov.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.obnov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.obnov.Text = "Изменить";
            this.obnov.UseColumnTextForButtonValue = true;
            // 
            // delet
            // 
            this.delet.HeaderText = "Удалить";
            this.delet.MinimumWidth = 6;
            this.delet.Name = "delet";
            this.delet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delet.Text = "Удалить";
            this.delet.UseColumnTextForButtonValue = true;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::l001.Properties.Resources.icons8_close_window_48;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(1201, 13);
            this.picExit.Margin = new System.Windows.Forms.Padding(4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(71, 57);
            this.picExit.TabIndex = 125;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1300, 729);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.tableUsers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView tableUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn isadmin;
        private System.Windows.Forms.DataGridViewButtonColumn obnov;
        private System.Windows.Forms.DataGridViewButtonColumn delet;
        private System.Windows.Forms.PictureBox picExit;
    }
}

