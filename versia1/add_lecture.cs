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

namespace versia1
{
    public partial class add_lecture : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";
        public add_lecture()
        {
            InitializeComponent();
            combobox_raz();
        }
        string type_input;
        string name_raz, name_lec;
        int id_raz, id_nam_lec;
        #region Обработчики событий
        private void introduce_lecture_Click(object sender, EventArgs e) // Ввод лекции с помощью текстового редактора
        {
            type_input = "lecture";
            Editor MyEditor = new Editor
            {
                Type_Input = type_input,
                Name_Lec = name_lec
            };
            MyEditor.Show();
        }

        private void OK_vvod_name_lec_Click(object sender, EventArgs e) // Добавление новой темы
        {
            name_lec = text_name_lec.Text;
            name_raz = razdel_lec.Text;
            id_raz = id_razd(name_raz); 

            if (name_lec == "")
            {
                MessageBox.Show($"Введите название темы.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string dobavlenie = "INSERT INTO temi (name_temi, id_razdel) " +
                    "VALUES (@name_lec, @id_raz)";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(dobavlenie, connection))
                    {
                        command.Parameters.AddWithValue("@name_lec", name_lec);
                        command.Parameters.AddWithValue("@id_raz", id_raz); 
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Тема успешно добавлена.", "Добавление темы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                introduce_lecture.Enabled = true;
                introduce_examples.Enabled = true;
            }
        }

        private void introduce_examples_Click(object sender, EventArgs e) // Ввод примеров с помощью текстового редактора
        {
            type_input = "examples";
            Editor MyEditor = new Editor
            {
                Type_Input = type_input,
                Name_Lec = name_lec
            };
            MyEditor.Show();
        }
        private void OK_razdel_Click(object sender, EventArgs e) // Добавление нового раздела
        {
            name_raz = name_razdel_text.Text;
            if (name_raz == "")
            {
                MessageBox.Show($"Введите название раздела.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string dobavlenie = "INSERT INTO razdel (name_razdel) " +
                    "VALUES (@name_raz)";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(dobavlenie, connection))
                    {
                        command.Parameters.AddWithValue("@name_raz", name_raz);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Раздел успешно добавлен.", "Добавление раздела", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            combobox_raz();
            razdel_lec.Text = name_raz;
            name_razdel_text.Clear();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            add_lecture.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }
        private void назадНаНачальнокОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_lecture.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }
        #endregion
        #region Заполнение комбобоксов
        private void combobox_raz() // Заполнение комбобокса названиями разделов
        {
            razdel_lec.Items.Clear();
            razdel_lec.Text = "";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name_razdel FROM razdel";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        bool has_sections = false;
                        int name_sections_index = reader.GetOrdinal("name_razdel");

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(name_sections_index))
                            {
                                string value = reader.GetString(name_sections_index);

                                if (!razdel_lec.Items.Contains(value))
                                {
                                    razdel_lec.Items.Add(value);
                                    has_sections = true;
                                }
                            }
                        }

                        if (!has_sections)
                        {
                            razdel_lec.Text = "Разделов ещё нет";
                        }
                    }
                }
            }
        }
        #endregion
        #region Запросы к базе данных
        private int id_razd(string name_raz) // Запрос на получение ID раздела
        {
            int id_ra = 0;

            string vopr = "SELECT id_razdel FROM razdel WHERE name_razdel = @name_raz";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@name_raz", name_raz);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_ra = reader.GetInt32("id_razdel");
                        }
                    }
                }
            }

            return id_ra;
        }
        #endregion
    }
}
