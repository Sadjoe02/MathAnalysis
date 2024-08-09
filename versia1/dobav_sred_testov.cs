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
    public partial class dobav_sred_testov : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";

        public dobav_sred_testov()
        {
            InitializeComponent();
            combobox_sections(razdel);
            id_yrov = 2;
        }

        string razd, tema, n_test, vopr, section;
        int id_yrov, id_temi, min_ballov, id_test, id_query, id_quest, id_answer;
        string action_type = "test";

        #region Обработчики событий
        private void min_colvo_ballov_KeyPress(object sender, KeyPressEventArgs e)
        {
            char digit = e.KeyChar;
            if (!Char.IsDigit(digit) && digit != 8)
                e.Handled = true;
        }

        private void OK_test_Click(object sender, EventArgs e) // Добавление данных о тесте
        {
            if (text_name_test.Text == "")
            {
                MessageBox.Show("Вы не ввели название теста.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (min_colvo_ballov.Text == "")
            {
                MessageBox.Show("Вы не ввели минимальное количество баллов.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((text_name_test.Text == "") && (min_colvo_ballov.Text == ""))
            {
                MessageBox.Show("Вы не ввели название теста и минимальное количество баллов.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                n_test = text_name_test.Text;
                min_ballov = Convert.ToInt32(min_colvo_ballov.Text);
                string dobavlenie = "INSERT INTO tests (id_temi, id_yrovni, name_test, min_colvo_ball) " +
        "VALUES (@id_temi, @id_yrov, @n_test, @min_ballov)";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(dobavlenie, connection))
                    {
                        command.Parameters.AddWithValue("@id_temi", id_temi);
                        command.Parameters.AddWithValue("@id_yrov", id_yrov);
                        command.Parameters.AddWithValue("@n_test", n_test);
                        command.Parameters.AddWithValue("@min_ballov", min_ballov);
                        command.ExecuteNonQuery();
                    }
                }
                id_test = search_id_test(n_test);
                MessageBox.Show("Наименование теста и минимальное количество баллов успешно добавлены.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Vvod_cled_vop_Click(object sender, EventArgs e) // Переход к функции добавления
        {
            dobavleni();
        }

        private void Stop_Click(object sender, EventArgs e) // Конец ввода теста
        {
            if (Vopros.Text == "")
            {
                MessageBox.Show("Тест успешно добавлен.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                razdel.Text = "";
                spisok_tem.Items.Clear();
                spisok_tem.Text = "";
                text_name_test.Text = "";
                min_colvo_ballov.Text = "";
                Otvet.Clear();
                list_answers.Items.Clear();
            }
            else
            {
                dobavleni();
                MessageBox.Show("Тест успешно добавлен.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                razdel.Text = "";
                spisok_tem.Items.Clear();
                spisok_tem.Text = "";
                text_name_test.Text = "";
                min_colvo_ballov.Text = "";
                Otvet.Clear();
                list_answers.Items.Clear();
                Vopros.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editor MyEditor = new Editor
            {
                Action_Type = action_type,
            };
            MyEditor.Show();
        }

        private void add_but_Click(object sender, EventArgs e) // Ввод ответа
        {
            string answer_text = Otvet.Text;
            bool correct_t = true;
            var answer = new Answer { text = answer_text, correct = correct_t };
            list_answers.Items.Add(answer);
            Otvet.Clear();
        }

        private void razdel_SelectedIndexChanged(object sender, EventArgs e) // Выбор раздела и переход к заполнению тем
        {
            razd = razdel.Text;
            combobox_theme(razd, spisok_tem);
        }

        private void spisok_tem_SelectedIndexChanged(object sender, EventArgs e) // Выбор темы и переход к поиску ID темы
        {
            tema = spisok_tem.Text;
            id_temi = f_id_temit(tema);
        }

        private void change_sections_SelectedIndexChanged(object sender, EventArgs e) // Выбор раздела и поиск средних тестов
        {
            section = change_sections.Text;
            combobox_test(section, "Средний", list_test);
            changing_question.Clear();
            changing_answers.Clear();
            list_test.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) // Заполнение комбобоксов в зависимости от вкладки
        {
            if (tabControl1.SelectedTab == Add_test)
            {
                combobox_sections(razdel);
            }
            else if (tabControl1.SelectedTab == Change_test)
            {
                combobox_sections(change_sections);
                id_quest = 0;
                id_answer = 0;
            }
            else if (tabControl1.SelectedTab == adding_or_removing)
            {
                combobox_sections(adding_or_removing_sections);
                id_quest = 0;
                id_answer = 0;
            }
        }
        
        private void save_modified_question_Click(object sender, EventArgs e) // Сохранение изменённого вопроса
        {
            if (changing_question.Text == "")
            {
                MessageBox.Show("Выберите вопрос.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string modified_question = changing_question.Text;
                string query = "UPDATE voprosi SET vopros = @modified_question WHERE id_vopr = @id_quest";
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_quest", id_quest);
                            command.Parameters.AddWithValue("@modified_question", modified_question);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Вопрос успешно обновлён", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string selected_test = list_test.SelectedItem.ToString();
                    int id_test = search_id_test(selected_test);
                    filling_questions(id_test, dataGrid_view_questions);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении вопроса: " + ex.Message);
                }

            }
        }

        private void save_modified_answer_Click(object sender, EventArgs e) // Сохранение изменённого ответа
        {
            if (changing_answers.Text == "")
            {
                MessageBox.Show("Выберите вопрос.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (changing_answers.Text == "1" || changing_answers.Text == "0")
                {
                    MessageBox.Show("Вы пытаетесь обновить верность ответа, чего в данном тесте сделать нельзя. Если вам нужно удалить ответ, перейдите в соответствующую вкладку.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string modified_answers = changing_answers.Text;
                    string query = "UPDATE otveti SET otvet = @modified_answers WHERE id_otvet = @id_answer";
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@id_answer", id_answer);
                                command.Parameters.AddWithValue("@modified_answers", modified_answers);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Ответ успешно обновлён", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        search_answers(id_quest, dataGridView_answers);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при обновлении ответа: " + ex.Message);
                    }
                }
            }

        }

        private void dataGrid_view_questions_SelectionChanged(object sender, EventArgs e) // Вывод ответа в соответствии с выбранным вопросом
        {
            if (dataGrid_view_questions.CurrentRow != null && dataGrid_view_questions.CurrentRow.Cells["Question"] != null)
            {
                object value = dataGrid_view_questions.CurrentRow.Cells["Question"].Value;
                if (value != null)
                {
                    if (dataGrid_view_questions.SelectedRows.Count > 0)
                    {
                        int index = dataGrid_view_questions.SelectedRows[0].Index;

                        if (index >= 0 && index < dataGrid_view_questions.Rows.Count)
                        {
                            string question = dataGrid_view_questions.Rows[index].Cells["Question"].Value.ToString();

                            changing_question.Text = question;

                            id_quest = f_id_question(question);
                            search_answers(id_quest, dataGridView_answers);
                            changing_answers.Text = "";
                        }
                    }
                }
            }
        }

        private void dataGridView_answers_CellClick(object sender, DataGridViewCellEventArgs e) // Вывод ответа в текстовое поле
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = dataGridView_answers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (cellValue != null)
                {
                    changing_answers.Text = cellValue.ToString();
                    id_answer = Convert.ToInt32(dataGridView_answers.Rows[e.RowIndex].Cells["Id_answer_dgv"].Value.ToString());
                }
            }
        }

        private void dataGridView_answers_SelectionChanged(object sender, EventArgs e) // Вывод ответа в текстовое поле
        {
            if (dataGridView_answers.CurrentRow != null && dataGridView_answers.CurrentRow.Cells["Answers"] != null)
            {
                object value = dataGridView_answers.CurrentRow.Cells["Answers"].Value;
                if (value != null)
                {
                    if (dataGridView_answers.SelectedRows.Count > 0)
                    {
                        int index = dataGridView_answers.SelectedRows[0].Index;

                        if (index >= 0 && index < dataGridView_answers.Rows.Count)
                        {
                            string answers = dataGridView_answers.Rows[index].Cells["Answers"].Value.ToString();

                            changing_answers.Text = answers;

                            id_answer = f_id_answer(answers);
                        }
                    }

                }
            }
        }

        private void adding_or_removing_sections_SelectedIndexChanged(object sender, EventArgs e) // Заполнение комбобокса тестами 
        {
            section = adding_or_removing_sections.Text;
            combobox_test(section, "Средний", adding_or_removing_themes);
            adding_or_removing_questions.Clear();
            adding_or_removing_answers.Clear();
            adding_or_removing_themes.Text = "";
        }

        private void adding_or_removing_themes_SelectedIndexChanged(object sender, EventArgs e) // Переход к заполнению DataGridView вопросами 
        {
            string selected_test = adding_or_removing_themes.SelectedItem.ToString();
            int id_test = search_id_test(selected_test);
            filling_questions(id_test, add_or_delete_question_detgrview);
            adding_or_removing_questions.Clear();
            adding_or_removing_answers.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editor MyEditor = new Editor
            {
                Action_Type = action_type,
            };
            MyEditor.Show();
        }

        private void add_or_delete_question_detgrview_SelectionChanged(object sender, EventArgs e) // Переход к заполнению DataGridView ответами
        {
            if (add_or_delete_question_detgrview.CurrentRow != null && add_or_delete_question_detgrview.CurrentRow.Cells["Question_add_del"] != null)
            {
                object value = add_or_delete_question_detgrview.CurrentRow.Cells["Question_add_del"].Value;
                if (value != null)
                {
                    if (add_or_delete_question_detgrview.SelectedRows.Count > 0)
                    {
                        int index = add_or_delete_question_detgrview.SelectedRows[0].Index;

                        if (index >= 0 && index < add_or_delete_question_detgrview.Rows.Count)
                        {
                            string question = add_or_delete_question_detgrview.Rows[index].Cells["Question_add_del"].Value.ToString();

                            adding_or_removing_questions.Text = question;

                            id_quest = f_id_question(question);
                            search_answers(id_quest, add_or_delete_answer_detgrview);
                            adding_or_removing_answers.Text = "";
                        }
                    }
                }
            }

        }

        private void add_or_delete_answer_detgrview_CellClick(object sender, DataGridViewCellEventArgs e) // Переход к заполнению DataGridView ответами
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = add_or_delete_answer_detgrview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (cellValue != null)
                {
                    string answer = add_or_delete_answer_detgrview.Rows[e.RowIndex].Cells["Answers_add_del"].Value.ToString();
                    id_answer = Convert.ToInt32(add_or_delete_answer_detgrview.Rows[e.RowIndex].Cells["Id_answer_add_del"].Value.ToString());

                    adding_or_removing_answers.Text = answer;
                }
            }
        }

        private void add_or_delete_answer_detgrview_SelectionChanged(object sender, EventArgs e) // Вывод ответа в текстовое поле
        {
            if (add_or_delete_answer_detgrview.CurrentRow != null && add_or_delete_answer_detgrview.CurrentRow.Cells["Answers_add_del"] != null)
            {
                object value = add_or_delete_answer_detgrview.CurrentRow.Cells["Answers_add_del"].Value;
                if (value != null)
                {
                    if (add_or_delete_answer_detgrview.SelectedRows.Count > 0)
                    {
                        int index = add_or_delete_answer_detgrview.SelectedRows[0].Index;

                        if (index >= 0 && index < add_or_delete_answer_detgrview.Rows.Count)
                        {
                            string answer = add_or_delete_answer_detgrview.Rows[index].Cells["Answers_add_del"].Value.ToString();

                            adding_or_removing_answers.Text = answer;
                            id_answer = Convert.ToInt32(add_or_delete_answer_detgrview.Rows[index].Cells["Id_answer_add_del"].Value.ToString());
                        }
                    }
                }
            }
        }

        private void add_question_Click(object sender, EventArgs e) // Переход к добавлению вопроса
        {
            if (adding_or_removing_questions.Text == "")
            {
                MessageBox.Show("Вы не выбрали вопрос.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string question = adding_or_removing_questions.Text;
                string name_test = adding_or_removing_themes.Text;
                int id_test = search_id_test(name_test);
                save_query(question, id_test);
                filling_questions(id_test, add_or_delete_question_detgrview);
            }
        }

        private void delete_question_Click(object sender, EventArgs e) // Удаление вопроса
        {
            if (adding_or_removing_questions.Text == "")
            {
                MessageBox.Show("Вы не выбрали вопрос.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить вопрос и связанные с ним ответы?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string question = adding_or_removing_questions.Text;
                    int id_question = Convert.ToInt32(add_or_delete_question_detgrview.CurrentRow.Cells["id_question_add_or_delete"].Value);

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM voprosi WHERE id_vopr = @id_question";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_question", id_question);

                            try
                            {
                                command.ExecuteNonQuery();
                                string selected_test = adding_or_removing_themes.SelectedItem.ToString();
                                int id_test = search_id_test(selected_test);
                                filling_questions(id_test, add_or_delete_question_detgrview);
                                adding_or_removing_questions.Clear();
                                MessageBox.Show("Вопрос успешно удален.", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show("Ошибка при удалении вопроса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void add_answer_Click(object sender, EventArgs e) // Добавление ответа
        {
            if (adding_or_removing_answers.Text == "")
            {
                MessageBox.Show("Вы не выбрали ответ.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string question = adding_or_removing_questions.Text;
                id_quest = f_id_question(question);
                int id_question = Convert.ToInt32(add_or_delete_question_detgrview.CurrentRow.Cells["id_question_add_or_delete"].Value);

                string answer = adding_or_removing_answers.Text;
                string query = "INSERT INTO otveti (id_vopr, otvet, vernost) VALUES (@id_question, @answer, @correct);";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_question", id_question);
                        command.Parameters.AddWithValue("@answer", answer);
                        command.Parameters.AddWithValue("@correct", 1);
                        command.ExecuteNonQuery();
                    }
                }
                search_answers(id_quest, add_or_delete_answer_detgrview);
                MessageBox.Show("Ответ успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adding_or_removing_answers.Text = "";
            }

        }

        private void delete_answer_Click(object sender, EventArgs e) // Удаление ответа
        {
            if (adding_or_removing_answers.Text == "")
            {
                MessageBox.Show("Вы не выбрали ответ.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить ответ?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id_answer = Convert.ToInt32(add_or_delete_answer_detgrview.CurrentRow.Cells["Id_answer_add_del"].Value);

                    string answer = adding_or_removing_answers.Text;
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM otveti WHERE otvet = @answer AND id_otvet = @id_answer";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@answer", answer);
                            command.Parameters.AddWithValue("@id_answer", id_answer);
                            try
                            {
                                command.ExecuteNonQuery();
                                search_answers(id_quest, add_or_delete_answer_detgrview);
                                adding_or_removing_answers.Clear();
                                MessageBox.Show("Ответ успешно удален.", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show("Ошибка при удалении ответа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void add_or_delete_question_detgrview_CellClick(object sender, DataGridViewCellEventArgs e) // Переход к заполнению DataGridView ответами
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = add_or_delete_question_detgrview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (cellValue != null)
                {
                    string question = add_or_delete_question_detgrview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    adding_or_removing_questions.Text = question;
                    id_quest = f_id_question(question);
                    search_answers(id_quest, add_or_delete_answer_detgrview);
                    adding_or_removing_answers.Text = "";
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
            dobav_sred_testov.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dobav_sred_testov.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }

        private void dataGrid_view_questions_CellClick(object sender, DataGridViewCellEventArgs e) // Переход к заполнению DataGridView ответами
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = dataGrid_view_questions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (cellValue != null)
                {
                    string question = dataGrid_view_questions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    changing_question.Text = question;
                    id_quest = f_id_question(question);
                    search_answers(id_quest, dataGridView_answers);
                    changing_answers.Text = "";
                }

            }
        }

        private void list_test_SelectedIndexChanged(object sender, EventArgs e) // Переход к заполнению DataGridView вопросами
        {
            string selected_test = list_test.SelectedItem.ToString();
            int id_test = search_id_test(selected_test);
            filling_questions(id_test, dataGrid_view_questions);
            changing_question.Clear();
            changing_answers.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Editor MyEditor = new Editor
            {
                Action_Type = action_type,
            };
            MyEditor.Show();
        }
        #endregion

        #region Заполнение комбобоксов
        private void combobox_sections(ComboBox combobox_name) // Заполнение комбобокса разделами
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

        private void combobox_theme(string sections_name, ComboBox combobox_name) // Заполнение комбобокса темами
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

        private void combobox_test(string sections_name, string level_name, ComboBox combobox_name) // Заполнение комбобокса тестами
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
        #endregion

        #region Функции
        private void dobavleni() // Добавление вопросов с ответами
        {
            if (!test_exists(n_test))
            {
                MessageBox.Show("Вы не нажали ОК при добавлении наименования теста.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Vopros.Text == "")
                {
                    MessageBox.Show("Вы не ввели вопрос.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (list_answers.Items.Count == 0)
                {
                    MessageBox.Show("Вы не ввели ответы.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    vopr = Vopros.Text;
                    n_test = text_name_test.Text;
                    id_test = search_id_test(n_test);
                    save_query(vopr, id_test);
                    foreach (Answer answer in list_answers.Items)
                    {
                        save_answer(id_query, answer.text, answer.correct);
                    }
                    Vopros.Clear();
                    list_answers.Items.Clear();
                    Otvet.Clear();
                }
            }
        }

        #endregion

        #region Запросы к базе данных
        private int f_id_temit(string tema) // Поиск ID темы
        {

            int id_tem = 0;

            string vopr = "SELECT id_temi FROM temi WHERE name_temi = @tema";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@tema", tema);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_tem = reader.GetInt32("id_temi");
                        }
                    }
                }
            }

            return id_tem;
        }

        private int f_id_question(string question) // Поиск ID вопроса
        {

            int id_question = 0;

            string vopr = "SELECT id_vopr FROM voprosi WHERE vopros = @question";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@question", question);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_question = reader.GetInt32("id_vopr");
                        }
                    }
                }
            }

            return id_question;
        }

        private int search_id_test(string test_name) // Поиск ID теста
        {
            int id_test = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_test FROM tests WHERE name_test = @test_name";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@test_name", test_name);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_test = reader.GetInt32("id_test");
                        }
                    }
                }
            }

            return id_test;
        }

        private bool test_exists(string test_name) // Проверка на наличие теста
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM tests WHERE name_test = @test_name";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@test_name", test_name);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void filling_questions(int id_test, DataGridView dataGridView_name) // Заполнение DataGridView вопросами
        {
            dataGridView_name.Rows.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT voprosi.vopros, voprosi.id_vopr
            FROM voprosi_testov
            JOIN voprosi ON voprosi.id_vopr = voprosi_testov.id_vopr
            WHERE voprosi_testov.id_tests = @id_test";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_test", id_test);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id_vopr = reader.GetInt32("id_vopr");
                            string question = reader["vopros"].ToString();
                            dataGridView_name.Rows.Add(question, id_vopr);
                        }
                    }
                }
            }
        }

        private void search_answers(int id_question, DataGridView dataGridView_name) // Заполнение DataGridView ответами
        {
            dataGridView_name.Rows.Clear();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_otvet, otvet, vernost FROM otveti WHERE id_vopr = @id_question";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_question", id_question);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id_аnswer = reader.GetInt32("id_otvet");
                            string answer = reader.GetString("otvet");
                            int correct_dgv = reader.GetInt32("vernost");

                            dataGridView_name.Rows.Add(new object[] { answer, correct_dgv, id_аnswer });
                        }
                    }
                }
            }
        }
       
        private int f_id_answer(string answer) // Поиск ID ответа
        {

            int id_answer = 0;

            string vopr = "SELECT id_otvet FROM otveti WHERE otvet = @answer";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@answer", answer);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_answer = reader.GetInt32("id_otvet");
                        }
                    }
                }
            }

            return id_answer;
        }

        private int save_query(string question, int id_test) // Сохранение вопроса
        {
            string query = "INSERT INTO voprosi (vopros) VALUES (@question); SELECT LAST_INSERT_ID();";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@question", question);
                    id_query = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            string dobavlenie3 = "INSERT INTO voprosi_testov (id_tests, id_vopr) " +
                "VALUES (@id_test, @id_vop)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(dobavlenie3, connection))
                {
                    command.Parameters.AddWithValue("@id_test", id_test);
                    command.Parameters.AddWithValue("@id_vop", id_query);
                    command.ExecuteNonQuery();
                }
            }
            return id_query;
        }

        private void save_answer(int id_vop, string answer_text, bool correct_bd) // Сохранение ответа
        {
            string query = "INSERT INTO otveti (id_vopr, otvet, vernost) VALUES (@id_vop, @otvet, @vernos);";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_vop", id_vop);
                    command.Parameters.AddWithValue("@otvet", answer_text);
                    command.Parameters.AddWithValue("@vernos", correct_bd ? 1 : 0);
                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion

        public class Answer
        {
            public string text { get; set; }
            public bool correct { get; set; }

            public override string ToString()
            {
                return $"{text} ({(correct ? "Верный" : "Неверный")})";
            }
        }

    }
}
