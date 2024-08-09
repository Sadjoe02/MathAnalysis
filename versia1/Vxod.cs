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
    public partial class Vxod : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";

        public Vxod()
        {
            InitializeComponent();
        }
        public static string Login1 { get; private set; }
        public static string Parol1 { get; private set; }
        public static int Id_user1 { get; private set; }
        public static int Flag { get; private set; }



        int a =1;
        bool prov;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                Parol.UseSystemPasswordChar = false;
                a = 0;
            }
            else if (a == 0)
            {
                Parol.UseSystemPasswordChar = true;
                a = 1;

            }
        }

        public bool proverka_yhet_zap(string login, string parol)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                bool proverka;
                string sql = "SELECT COUNT(*) FROM users WHERE user_name = @login AND parol = @parol";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@parol", parol);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                        proverka = true;
                    else
                        proverka = false;
                    return proverka;
                }
            }
        }

        private int poisk_id_users(string login, string parol)
        {
            int id_user = 0;

            string vopr = "SELECT id_users FROM users WHERE user_name = @login AND parol = @parol";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@parol", parol);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_user = reader.GetInt32("id_users");
                        }
                    }
                }
            }

            return id_user;
        }

        private int checking_flag(string login, string parol)
        {
            int flag = 0;

            string vopr = "SELECT teacher_flag FROM users WHERE user_name = @login AND parol = @parol";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@parol", parol);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            flag = reader.GetInt32("teacher_flag");
                        }
                    }
                }
            }

            return flag;
        }


        private void Zareg_Click(object sender, EventArgs e)
        {
            Vxod.ActiveForm.Hide();
            Registracia MyRegistracia = new Registracia();
            MyRegistracia.ShowDialog();
            Close();
        }

        private void Voiti_Click(object sender, EventArgs e)
        {
            Login1 = Convert.ToString(Login.Text);
            Parol1 = Convert.ToString(Parol.Text);
            Parol1 = ComputeSHA256(Parol1);
            if (Parol1 == "" && Login1 == "")
            {
                MessageBox.Show("Вы не ввели логин и пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Parol1 == "")
            {
                MessageBox.Show("Вы не ввели пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Parol1 == "")
            {
                MessageBox.Show("Вы не ввели логин!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                prov = proverka_yhet_zap(Login1, Parol1);
                Id_user1 = poisk_id_users(Login1, Parol1);
                Flag = checking_flag(Login1, Parol1);
                if (prov == false)
                    MessageBox.Show("У вас нет учетной записи либо данные введены неверно. Нажмите «Зарегистрироваться» или проверьте введённые данные.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (prov == true)
                {
                    Vxod.ActiveForm.Hide();
                    Nachalo MyNachalo = new Nachalo();
                    MyNachalo.ShowDialog();
                    Close();
                }
            }

        }
    }
}
