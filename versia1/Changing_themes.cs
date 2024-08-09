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
    public partial class Changing_themes : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";

        public Changing_themes()
        {
            InitializeComponent();
            Combobox_raz();
        }
        string sections, name_lec, type_input;
        string action_type = "change";
        static public Changing_themes MyChanging_themes = new Changing_themes();

        #region Обработчики событий
        private void change_examples_Click(object sender, EventArgs e) 
        {
            type_input = "examples";
            Editor MyEditor = new Editor
            {
                Type_Input = type_input,
                Action_Type = action_type,
                Name_Lec = name_lec
            };
            MyEditor.Show();
        }

        private void List_sections_SelectedIndexChanged(object sender, EventArgs e)
        {
            sections = list_sections.Text;
            if (sections == "")
            {
                MessageBox.Show("Вы не выбрали раздел!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                Combobox_lec(sections);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changing_themes.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }

        private void назадНаНачальнокОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changing_themes.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }

        private void change_lecture_Click(object sender, EventArgs e)
        {
            type_input = "lecture";
            Editor MyEditor = new Editor
            {
                Type_Input = type_input,
                Action_Type = action_type,
                Name_Lec = name_lec
            };
            MyEditor.Show();
        }

        private void list_themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            name_lec = list_themes.Text;
            change_lecture.Enabled = true;
            change_examples.Enabled = true;
        }

        #endregion

        #region Заполнение комбобоксов
        private void Combobox_raz()
        {
            list_sections.Items.Clear();
            list_sections.Text = "";
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

                                if (!list_sections.Items.Contains(value))
                                {
                                    list_sections.Items.Add(value);
                                    has_sections = true;
                                }
                            }
                        }

                        if (!has_sections)
                        {
                            list_sections.Text = "Разделов ещё нет";
                        }
                    }
                }
            }
        }

        private void Combobox_lec(string sections_name)
        {
            list_themes.Text = "";
            list_themes.Items.Clear();
            int id_sec = Id_razd(sections_name);
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name_temi FROM temi WHERE id_razdel = @id_sec";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_sec", id_sec);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        bool has_themes = false;

                        int name_temiIndex = reader.GetOrdinal("name_temi");

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(name_temiIndex))
                            {
                                string value = reader.GetString(name_temiIndex);

                                if (!list_themes.Items.Contains(value))
                                {
                                    list_themes.Items.Add(value);
                                    has_themes = true;
                                }
                            }
                        }

                        if (!has_themes)
                        {
                            list_themes.Text = "В данном разделе ещё нет тем.";
                        }

                    }
                }
            }

        }

        #endregion

        #region Запросы к базе данных
        private int Id_razd(string name_raz)
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
