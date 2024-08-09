using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace versia1
{
    public partial class Registracia : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";

        public Registracia()
        {
            InitializeComponent();
        }

        string login, parol, familia, name, otchestvo, pov_parol;

        private void button2_Click(object sender, EventArgs e)
        {
            Registracia.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = G_login.Text;
            parol = G_parol.Text;
            pov_parol = G_pov_parol.Text;
            familia = G_familia.Text;
            name = G_name.Text;
            otchestvo = G_otches.Text;

            if (login=="" && parol==""&& pov_parol==""&& familia==""&& name==""&& otchestvo=="")
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (login == "")
                MessageBox.Show("Заполните поле «Логин»!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (parol == "")
                MessageBox.Show("Заполните поле «Пароль»!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(pov_parol == "")
                MessageBox.Show("Введите повторно пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (familia == "")
                MessageBox.Show("Заполните поле «Фамилия»!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (name == "")
                MessageBox.Show("Заполните поле «Имя»!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (otchestvo == "")
                MessageBox.Show("Заполните поле «Отчество»!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (parol != pov_parol)
                MessageBox.Show("Пароли должны совпадать!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                registracia(login, parol, familia, name, otchestvo);
                Registracia.ActiveForm.Hide();
                Vxod MyVxod = new Vxod();
                MyVxod.ShowDialog();
                Close();

            }
        }

        private void registracia(string login, string parol, string familia, string name, string otchestvo)
        {
            parol = ComputeSHA256(parol);
            string zapros = "INSERT INTO users (user_name, parol, familia, name, otchestvo, teacher_flag) " +
                           "VALUES (@login, @parol, @familia, @name, @otchestvo, @flag)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(zapros, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@parol", parol);
                    command.Parameters.AddWithValue("@familia", familia);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@otchestvo", otchestvo);
                    command.Parameters.AddWithValue("@flag", 0);

                    command.ExecuteNonQuery();
                }
            }
        }

        private static string ComputeSHA256(string password)
        {
            string hash = String.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }

    }
}
