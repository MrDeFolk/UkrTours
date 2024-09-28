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

namespace Ukr_TourOp
{
    public partial class Authorization_form : Form
    {
        public Authorization_form()
        {
            InitializeComponent();
        }

        private void pictureBox_EyePass_Click(object sender, EventArgs e)
        {
            if (textBox_enterPassword.UseSystemPasswordChar)
            {
                // Якщо textBox_enterPassword.UseSystemPasswordChar = true, змінити зображення на "SeePass"
                pictureBox_EyePass.Image = Properties.Resources.SeePass;
            }
            else
            {
                // Якщо textBox_enterPassword.UseSystemPasswordChar = false, змінити зображення на "NoSeePass"
                pictureBox_EyePass.Image = Properties.Resources.NoSeePass;
            }

            // Змінити textBox_enterPassword.UseSystemPasswordChar на протилежне значення
            textBox_enterPassword.UseSystemPasswordChar = !textBox_enterPassword.UseSystemPasswordChar;
        }

        private void button_authorization_Click(object sender, EventArgs e)
        {
            // Зчитування значень з полів введення
            string Login_user = textBox_enterLogin.Text;
            string Password_user = textBox_enterPassword.Text; // Пароль повинен зчитуватися з відповідного поля

            // Створення об'єктів для виконання запиту та отримання результатів
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();

            // Створення рядка SQL-запиту з параметрами
            string queryString = "SELECT * FROM authorization_user WHERE login = @Login AND password = @Password";

            // Встановлення параметрів для SQL-запиту
            using (SqlConnection connection = new SqlConnection(@"Data Source=MRDEFOLK-DESKTO;Initial Catalog=Ukrainets_tour_op;Integrated Security=true"))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Login", Login_user);
                command.Parameters.AddWithValue("@Password", Password_user);

                // Виконання запиту та отримання результатів
                connection.Open();
                adapter.SelectCommand = command;
                adapter.Fill(Table);
            }

            if (Table.Rows.Count == 1)
            {
                MessageBox.Show("Вітаємо в програмі ТУР-ОПЕРАТОР", "Вхід здійснено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_form Main_Form = new Main_form();
                this.Hide();
                Main_Form.ShowDialog();
                Application.Exit();
            }
            else
                MessageBox.Show("Перевірьте введені дані", "Вхід не здійснено.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
