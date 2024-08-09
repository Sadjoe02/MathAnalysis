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
    public partial class Removal : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";

        public Removal()
        {
            InitializeComponent();
            combobox_sections(list_sections);
            this.Size = new Size(983, 252);
        }

        string name_sections;

        private void combobox_sections(ComboBox combobox_name)
        {
            combobox_name.Items.Clear();

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

                                if (!combobox_name.Items.Contains(value))
                                {
                                    combobox_name.Items.Add(value);
                                    has_sections = true;
                                }
                            }
                        }

                        if (!has_sections)
                        {
                            combobox_name.Text = "Разделов ещё нет";
                        }

                    }
                }
            }
        }

        private void combobox_levels(ComboBox combobox_name)
        {
            combobox_name.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name_yrov FROM yrovni";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        bool has_sections = false;
                        int name_sections_index = reader.GetOrdinal("name_yrov");

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(name_sections_index))
                            {
                                string value = reader.GetString(name_sections_index);

                                if (!combobox_name.Items.Contains(value))
                                {
                                    combobox_name.Items.Add(value);
                                    has_sections = true;
                                }
                            }
                        }

                        if (!has_sections)
                        {
                            combobox_name.Text = "Уровней ещё нет";
                        }

                    }
                }
            }
        }

        private void combobox_theme(string sections_name, ComboBox combobox_name)
        {
            combobox_name.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name_temi FROM konsp WHERE name_razdel = @sections_name";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sections_name", sections_name);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        bool has_themes = false; 

                        int name_temiIndex = reader.GetOrdinal("name_temi");

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(name_temiIndex))
                            {
                                string value = reader.GetString(name_temiIndex);

                                if (!combobox_name.Items.Contains(value))
                                {
                                    combobox_name.Items.Add(value);
                                    has_themes = true; 
                                }
                            }
                        }

                        if (!has_themes)
                        {
                            combobox_name.Text = "В данном разделе ещё нет тем.";
                        }

                    }
                }
            }

        }

        private void combobox_test(string sections_name, string level_name, ComboBox combobox_name)
        {
            combobox_name.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name_test FROM tests_with_sections WHERE name_razdel = @sections_name AND name_yrov = @level_name";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sections_name", sections_name);
                    command.Parameters.AddWithValue("@level_name", level_name);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        bool has_test = false;

                        int name_test_index = reader.GetOrdinal("name_test");

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(name_test_index))
                            {
                                string value = reader.GetString(name_test_index);

                                if (!combobox_name.Items.Contains(value))
                                {
                                    combobox_name.Items.Add(value);
                                    has_test = true;
                                }
                            }
                        }

                        if (!has_test)
                        {
                            combobox_name.Text = "Тестов ещё нет.";
                        }
                    }
                }
            }
        }



        private void delete_section_Click(object sender, EventArgs e)
        {
            if (list_sections.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите раздел для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selected_section = list_sections.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить раздел и все связанные данные?","Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM razdel WHERE name_razdel = @selected_section";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@selected_section", selected_section);

                        try
                        {
                            command.ExecuteNonQuery();
                            list_sections.Text = "";
                            combobox_sections(list_sections);
                            MessageBox.Show("Раздел успешно удален.", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Ошибка при удалении раздела: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == delete_sections)
            {
                this.Size = new Size(983, 252);
                combobox_sections(list_sections);
            }
            else if (tabControl1.SelectedTab == delete_themes)
            {
                this.Size = new Size(983, 294);
                combobox_sections(list_sections_in_th);
            }
            else if (tabControl1.SelectedTab == lecture_notes)
            {
                this.Size = new Size(983, 294);
                combobox_sections(list_sections_lecture_notes);
            }
            else if (tabControl1.SelectedTab == summaries_examples)
            {
                this.Size = new Size(983, 294);
                combobox_sections(list_sections_summary_examples);
            }
            else if (tabControl1.SelectedTab == deleting_tests)
            {
                this.Size = new Size(983, 316);
                combobox_sections(list_sections_tests);
                combobox_levels(list_test_levels);
            }
        }

        private void delete_theme_Click(object sender, EventArgs e)
        {
            if (list_themes.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите тему для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selected_themes = list_themes.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить тему и все связанные данные?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM temi WHERE name_temi = @selected_themes";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@selected_themes", selected_themes);

                        try
                        {
                            command.ExecuteNonQuery();
                            list_themes.Text = "";
                            combobox_theme(name_sections, list_themes);
                            MessageBox.Show("Тема успешно удалена.", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Ошибка при удалении темы: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void list_sections_in_th_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_sections_in_th.SelectedItem != null)
            {
                list_themes.Text = "";
                name_sections = list_sections_in_th.Text;
                combobox_theme(name_sections, list_themes);
            }
        }

        private void list_sections_lecture_notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_sections_lecture_notes.SelectedItem != null)
            {
                list_themes_lecture_notes.Text = "";
                name_sections = list_sections_lecture_notes.Text;
                combobox_theme(name_sections, list_themes_lecture_notes);
            }
        }

        private int poisk_id_themes(string name)
        {
            int idKonsp = 0;

            string zapros = $"SELECT id_temi FROM temi WHERE name_temi = '{name}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(zapros, connection);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    idKonsp = Convert.ToInt32(result);
                }
            }
            return idKonsp;
        }

        private int poisk_id_test(string name_test)
        {
            int id_test = 0;

            string zapros = $"SELECT id_test FROM tests WHERE name_test = '{name_test}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(zapros, connection);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    id_test = Convert.ToInt32(result);
                }
            }
            return id_test;
        }

        private void delete_lecture_notes_Click(object sender, EventArgs e)
        {
            if (list_themes_lecture_notes.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите тему конспекта лекций для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selected_themes = list_themes_lecture_notes.SelectedItem.ToString();
            int id_theme = poisk_id_themes(selected_themes);
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить конспект лекции?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM konspect_lekcii WHERE id_temi = @id_theme";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_theme", id_theme);

                        try
                        {
                            command.ExecuteNonQuery();
                            list_themes_lecture_notes.Text = "";
                            combobox_theme(name_sections, list_themes_lecture_notes);
                            MessageBox.Show("Конспект лекции успешно удалён.", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Ошибка при удалении конспекта лекции: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void list_sections_summary_examples_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_sections_summary_examples.SelectedItem != null)
            {
                list_themes_summary_examples.Text = "";
                name_sections = list_sections_summary_examples.Text;
                combobox_theme(name_sections, list_themes_summary_examples);
            }
        }

        private void delete_summaries_examples_Click(object sender, EventArgs e)
        {
            if (list_themes_summary_examples.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите тему конспекта примеров для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selected_themes = list_themes_summary_examples.SelectedItem.ToString();
            int id_theme = poisk_id_themes(selected_themes);
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить конспект примеров?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM konspetti_primerov WHERE id_temi = @id_theme";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_theme", id_theme);

                        try
                        {
                            command.ExecuteNonQuery();
                            list_themes_summary_examples.Text = "";
                            combobox_theme(name_sections, list_themes_summary_examples);
                            MessageBox.Show("Конспект примеров успешно удалён.", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Ошибка при удалении конспекта примеров: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        string level;
        private void list_sections_tests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_sections_tests.SelectedItem != null)
            {
                if (list_test_levels.SelectedItem != null)
                {
                    list_tests.Text = "";
                    level = list_test_levels.Text;
                    name_sections = list_sections_tests.Text;
                    combobox_test(name_sections, level, list_tests);
                }
            }
        }

        private void list_test_levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_test_levels.SelectedItem != null)
            {
                if (list_sections_tests.SelectedItem != null)
                {
                    list_tests.Text = "";
                    level = list_test_levels.Text;
                    name_sections = list_sections_tests.Text;
                    combobox_test(name_sections, level, list_tests);
                }
            }
        }

        private void delete_test_Click(object sender, EventArgs e)
        {
            if (list_tests.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите тест для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selected_test = list_tests.SelectedItem.ToString();
            int id_test = poisk_id_test(selected_test);
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить тест?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM tests WHERE id_test = @id_test";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_test", id_test);

                        try
                        {
                            command.ExecuteNonQuery();
                            list_tests.Text = "";
                            combobox_test(name_sections, level, list_tests);
                            MessageBox.Show("Тест успешно удалён.", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Ошибка при удалении теста: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }

        private void назадНаНачальнокОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Removal.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Removal.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }
    }
}
