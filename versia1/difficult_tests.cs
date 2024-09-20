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
using System.IO;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;

namespace versia1
{
    public partial class difficult_tests : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";

        public difficult_tests()
        {
            InitializeComponent();
            id_yrov = 3;
            combobox_raz();
        }

        int id_user = Vxod.Id_user1;
        int id_tests;
        int shet, shet1;
        DateTime start_test, end_test;
        int[] id_vop_dla_osh = new int[6];
        int nomer_poptk;
        int id_popit, id_yrov;
        int[] mas_id_vopr;
        string[] m_voprosi;
        int prog;
        int shet_dl_dob1, min_ball, id_jyrn, id_temi;
        int[] itogovoe, id_testov;
        TextBox[] mass_TextBox = new TextBox[6];
        Label[] mass_Label_numder = new Label[6];
        Label[] mass_Label_status = new Label[6];
        PictureBox[] mass_image = new PictureBox[6];
        string razdel;

        #region Обработчики событий
        private void Spisok_tem_SelectedIndexChanged(object sender, EventArgs e) // Вывод вопросов и отображение элементов
        {
            start_test = DateTime.Now;
            if (Spisok_razdel.Text == "Производные")
            {
                label3.Visible = true;
            } 
            else
            {
                label3.Visible = false;
            }
            mass_TextBox[0] = answer_field_1;
            mass_TextBox[1] = answer_field_2;
            mass_TextBox[2] = answer_field_3;
            mass_TextBox[3] = answer_field_4;
            mass_TextBox[4] = answer_field_5;
            mass_TextBox[5] = answer_field_6;

            mass_Label_numder[0] = task_number_1;
            mass_Label_numder[1] = task_number_2;
            mass_Label_numder[2] = task_number_3;
            mass_Label_numder[3] = task_number_4;
            mass_Label_numder[4] = task_number_5;
            mass_Label_numder[5] = task_number_6;

            mass_Label_status[0] = status_result_1;
            mass_Label_status[1] = status_result_2;
            mass_Label_status[2] = status_result_3;
            mass_Label_status[3] = status_result_4;
            mass_Label_status[4] = status_result_5;
            mass_Label_status[5] = status_result_6;

            mass_image[0] = task_image_1;
            mass_image[1] = task_image_2;
            mass_image[2] = task_image_3;
            mass_image[3] = task_image_4;
            mass_image[4] = task_image_5;
            mass_image[5] = task_image_6;
            for (int i = 0; i < mass_TextBox.Length; i++)
            {
                mass_TextBox[i].Text = "";
                mass_Label_status[i].Text = "Состояние результата";
                mass_Label_status[i].BackColor = Color.Tan;
                mass_image[i].Image = null;
            }
            mas_id_vopr = null;
            string test = Spisok_tem.Text;
            id_temi = search_id_temi(test);
            string name_temi = search_name_temi(id_temi);
            id_jyrn = id_jyr(id_user, id_temi);
            id_testov = dl_id_tests(id_temi);
            if (id_jyrn == 0)
            {
                MessageBox.Show($"Не найдено журнальной записи для данной темы и пользователя. Изучите сначала теорию по данной теме: {name_temi}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                shet = 0;
                shet1 = 0;
                shet_dl_dob1 = 0;
                switch (test)
                {
                    case string value when value == test:
                        id_tests = f_id_test(test, id_yrov);
                        shet = 0;
                        shet1 = 0;
                        mas_id_vopr = mass_id_vop(test, id_yrov);
                        output_tasks(test, id_tests);
                        Proverka.Visible = true;
                        break;

                    default:
                        MessageBox.Show("Вы не выбрали тему!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }
        private void Proverka_Click(object sender, EventArgs e)
        {
            string test = Spisok_tem.Text;
            switch (test)
            {
                case string value when value == test:
                    id_tests = f_id_test(test, id_yrov);
                    nomer_poptk = nomer_popitki(id_tests, id_user);
                    proverka(test, id_tests, mas_id_vopr, mass_TextBox, mass_Label_status);
                    mas_id_vopr = null;
                    Proverka.Visible = false;
                    break;

                default:
                    MessageBox.Show("Вы не выбрали тему!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }

        private void назадНаНачальноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficult_tests.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficult_tests.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }

        private void назадКВыборуУровняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficult_tests.ActiveForm.Hide();
            Prom_okno_tests MyProm_okno_tests = new Prom_okno_tests();
            MyProm_okno_tests.ShowDialog();
            Close();
        }
        private void Spisok_razdel_SelectedIndexChanged(object sender, EventArgs e)
        {
            razdel = Spisok_razdel.Text;
            combobox_lec(razdel, id_yrov);
        }

        #endregion

        #region Запросы к базе данных
        private int[] dl_id_tests(int id_temi) // Поиск ID теста
        {
            int[] id_testss = null;
            string query = "SELECT id_test FROM dla_id_tests WHERE id_temi = @id_temi";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_temi", id_temi);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<int> id_testss_l = new List<int>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id_test");
                            id_testss_l.Add(id);
                        }
                        id_testss = id_testss_l.ToArray();
                    }
                }
            }

            return id_testss;
        }
        
        private string search_name_temi(int id_temi) // Поиск названия темы
        {
            string tema;

            string tem = "SELECT name_temi FROM temi WHERE id_temi = @id_temi";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(tem, connection))
                {
                    command.Parameters.AddWithValue("@id_temi", id_temi);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tema = reader.GetString("name_temi");
                        }
                        else
                        {
                            tema = "Такой темы нет";
                        }
                    }
                }
            }
            return tema;
        }
        
        private int search_id_temi(string test) // Поиск ID темы
        {
            int id_tem = 0;

            string tem = "SELECT id_temi FROM dla_vivoda_vopr WHERE name_test = @test";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(tem, connection))
                {
                    command.Parameters.AddWithValue("@test", test);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_tem = reader.GetInt32("id_temi");
                        }
                        else
                        {
                            id_tem = 0;
                        }
                    }
                }
            }
            return id_tem;
        }

        private int id_jyr(int id_user, int id_tema) // Поиск ID журнальной записи
        {
            int id_j = 0;

            string vopr = "SELECT id_jyr FROM dla_id_jyr WHERE id_temi = @id_tema AND id_users = @id_user";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@id_user", id_user);
                    command.Parameters.AddWithValue("@id_tema", id_tema);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_j = reader.GetInt32("id_jyr");
                        }
                        else
                        {
                            id_j = 0;
                        }
                    }
                }
            }
            return id_j;
        }
        private void dobav_osh(int id_popit, int[] id_vop_dla_osh) // Добавление данных об ошибках
        {
            for (int i = 0; i < id_vop_dla_osh.Length; i++)
            {
                if (id_vop_dla_osh[i] != 0)
                {
                    string dobav = "INSERT INTO oshibki (id_popitka, id_vopr) " +
                        "VALUES (@id_popit, @id_vopr)";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(dobav, connection))
                        {
                            command.Parameters.AddWithValue("@id_popit", id_popit);
                            command.Parameters.AddWithValue("@id_vopr", id_vop_dla_osh[i]);
                            command.ExecuteNonQuery();
                        }
                    }

                }
            }
        }

        private int id_pop(int nomer_pop, int id_user, int id_tests) // Поиск ID попытки
        {
            int id_popit = 0;

            string vopr = "SELECT id_popitka FROM popitki WHERE Nomer_popitki = @nomer_pop AND id_users = @id_user AND id_tests = @id_tests";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@nomer_pop", nomer_pop);
                    command.Parameters.AddWithValue("@id_user", id_user);
                    command.Parameters.AddWithValue("@id_tests", id_tests);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_popit = reader.GetInt32("id_popitka");
                        }
                    }
                }
            }

            return id_popit;
        }

        private int min_kolvo_ball(int id_tests) // Поиск минимального количества баллов за тест
        {
            int min_ball = 0;

            string vopr = "SELECT min_colvo_ball FROM dla_vivoda_vopr WHERE id_tests = @id_tests";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@id_tests", id_tests);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            min_ball = reader.GetInt32("min_colvo_ball");
                        }
                    }
                }
            }

            return min_ball;
        }
        
        private void dob_date_kon(DateTime end_test, int shet_dl_dob1, int id_jyr, int[] id_testov) // Добавление даты окончания прохождения теста
        {

            if (shet_dl_dob1 >= id_testov.Length)
            {
                string query = "UPDATE jyrnal_izychenia SET data_konca_temi = @end_test WHERE id_jyr = @id_jyr";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@end_test", end_test);
                        command.Parameters.AddWithValue("@id_jyr", id_jyr);

                        command.ExecuteNonQuery();
                    }
                }
            }
            else
                return;

        }
        
        private int[] itog(int id_test, int id_user) // Поиск итогового количества баллов
        {
            int[] itog = null;
            string query = "SELECT Itog_kolvo_ballov FROM popitki WHERE id_tests = @id_test AND id_users = @id_user";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_user", id_user);
                    command.Parameters.AddWithValue("@id_test", id_test);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<int> itog_l = new List<int>();
                        while (reader.Read())
                        {
                            int itogg = reader.GetInt32("Itog_kolvo_ballov");
                            itog_l.Add(itogg);
                        }
                        itog = itog_l.ToArray();
                    }
                }
            }

            return itog;
        }

        private void Update_Attempts(int shet, int id_tests, DateTime start_test, DateTime end_test, int nomer_poptk) // Вставка данных о попытке прохождения теста
        {
            string dobavlenie = "INSERT INTO popitki (id_tests, data_nachala, data_konca, Nomer_popitki, Itog_kolvo_ballov, id_users) " +
             "VALUES (@id_tests, @start_test, @end_test, @nomer_poptk, @shet, @id_user)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(dobavlenie, connection))
                {
                    command.Parameters.AddWithValue("@id_tests", id_tests);
                    command.Parameters.AddWithValue("@start_test", start_test);
                    command.Parameters.AddWithValue("@end_test", end_test);
                    command.Parameters.AddWithValue("@nomer_poptk", nomer_poptk);
                    command.Parameters.AddWithValue("@shet", shet);
                    command.Parameters.AddWithValue("@id_user", id_user);
                    command.ExecuteNonQuery();
                }
            }
        }
       
        private string[] Answers(int id_vopr) // Поиск ответов
        {
            string[] otvet = null;

            string query = "SELECT otvet FROM otveti WHERE id_vopr = @id_vopr";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_vopr", id_vopr);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> otvet_l = new List<string>();
                        while (reader.Read())
                        {
                            string otveti = reader.GetString("otvet");
                            otvet_l.Add(otveti);
                        }
                        otvet = otvet_l.ToArray();
                    }
                }
            }

            return otvet;
        }

        private int[] mass_id_vop(string tema, int id_yr) // Поиск ID вопросов
        {
            int[] id_vop = null;

            string vopr = "SELECT id_vopr FROM dla_vivoda_vopr WHERE name_test = @tema AND id_yrovni = @id_yr";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@tema", tema);
                    command.Parameters.AddWithValue("@id_yr", id_yr);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<int> id_vopList = new List<int>();
                        while (reader.Read())
                        {
                            int id_vopr = reader.GetInt32("id_vopr");
                            id_vopList.Add(id_vopr);
                        }
                        Random rnd = new Random();
                        id_vop = id_vopList.OrderBy(x => rnd.Next()).Take(6).ToArray();
                        Console.WriteLine("Выбранные id_vopr: " + string.Join(", ", id_vop));

                    }
                }
            }

            return id_vop;
        }

        public int nomer_popitki(int id_tests, int id_user) // Поиск последнего номера попытки
        {
            int nomer_popitki;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string nomer = "SELECT MAX(Nomer_popitki) FROM popitki WHERE id_tests = @id_tests AND id_users = @id_user";
                MySqlCommand command = new MySqlCommand(nomer, connection);
                command.Parameters.AddWithValue("@id_tests", id_tests);
                command.Parameters.AddWithValue("@id_user", id_user);

                object result = command.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    nomer_popitki = Convert.ToInt32(result) + 1;
                }
                else
                {
                    nomer_popitki = 1;
                }
            }

            return nomer_popitki;
        }
        
        private void output_tasks(string testName, int testId) // Вывод вопросов
        {
            for (int i = 0; i < mass_image.Length; i++)
            {
                mass_TextBox[i].Visible = false;
                mass_Label_numder[i].Visible = false;
                mass_Label_status[i].Visible = false;
                mass_image[i].Visible = false;
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                for (int i = 0; i < mas_id_vopr.Length; i++)
                {
                    string query = @"
                    SELECT
                      question_for_difficult_test AS question,
                      id_vopr AS id_vopr
                    FROM dla_vivoda_vopr
                    WHERE id_tests = @testId AND id_vopr = @id_vop";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@testId", testId);
                        command.Parameters.AddWithValue("@id_vop", mas_id_vopr[i]);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int index = 0; 
                            while (reader.Read())
                            {
                                if (!(reader["question"] is DBNull))
                                {
                                    byte[] imageBytes = (byte[])reader["question"];
                                    using (var ms = new MemoryStream(imageBytes))
                                    {
                                        Image questionImage = Image.FromStream(ms);
                                        mass_image[i].Image = questionImage; 
                                    }
                                }
                                else
                                {
                                    mass_image[i].Image = null; 
                                }

                                mass_TextBox[i].Visible = true;
                                mass_Label_numder[i].Visible = true;
                                mass_Label_status[i].Visible = true;
                                mass_image[i].Visible = true;
                            }
                        }

                    }

                }
            }
        }

        private int f_id_test(string tema, int id_yr) // Поиск ID теста
        {
            int id_tes = 0;

            string vopr = "SELECT id_tests FROM dla_vivoda_vopr WHERE name_test = @tema AND id_yrovni = @id_yr";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@tema", tema);
                    command.Parameters.AddWithValue("@id_yr", id_yr);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_tes = reader.GetInt32("id_tests");
                        }
                    }
                }
            }

            return id_tes;
        }
        #endregion

        #region Функции
        private void proverka(string test, int id_tests, int[] id_vopr, TextBox[] mass_TextBox, Label[] mass_Label_status) // Функция для проверки ответов
        {
            string text_answer;

            for (int i = 0; i < id_vopr.Length; i++)
            {
                string[] answers = Answers(id_vopr[i]);
                text_answer = mass_TextBox[i].Text;
                if (text_answer != "")
                {
                    shet1 = accuracy(answers, text_answer, shet);
                    id_vop_dla_osh[i] = incorrect(id_vopr[i], shet, shet1, mass_Label_status[i]);
                    shet = shet1;
                }
            }
            result(shet, test, id_tests);
            id_popit = id_pop(nomer_poptk, id_user, id_tests);
            dobav_osh(id_popit, id_vop_dla_osh);
            shet = 0;
            shet1 = 0;
        }
        private void result(int shet, string test, int id_tests) // Вывод результатов и переход к записи
        {
            end_test = DateTime.Now;
            TimeSpan raznica = end_test.Subtract(start_test);
            string raznica_v_dr_form = raznica.ToString("hh\\:mm\\:ss");

            int min;
            min = min_kolvo_ball(id_tests);

            if (shet >= min)
            {
                MessageBox.Show("Тест пройден! Ваше количество баллов: " + shet + "\nНачало теста: " + start_test + "\nОкончание теста: " + end_test + "\nПродолжительность теста: " + raznica_v_dr_form + "\nПройдите следующий тест выбрав тест", "Вы справились", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Тест не пройден. Попытайтесь снова. Ваше количество баллов: " + shet + "\nНачало теста: " + start_test + "\nОкончание теста: " + end_test + "\nПродолжительность теста: " + raznica_v_dr_form + "\nПройдите тест заново выбрав его из списка.", "Вы не справились", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Update_Attempts(shet, id_tests, start_test, end_test, nomer_poptk);
            int prom = 0;
            for (int i = 0; i < id_testov.Length; i++)
            {
                prom = dla_dob_date_kon(id_testov[i], id_user);
                if (prom >= 1)
                {
                    shet_dl_dob1 ++;
                }
            }

            dob_date_kon(end_test, shet_dl_dob1, id_jyrn, id_testov);
        }
        private int dla_dob_date_kon(int id_test, int id_user) // Функция для решения, добавлять ли запись даты конца в журнал изучения
        {
            itogovoe = itog(id_test, id_user);
            min_ball = min_kolvo_ball(id_test);
            int prom = 0;
            for (int i = 0; i < itogovoe.Length; i++)
            {
                prom = shet_dl_dob(itogovoe[i], min_ball, shet_dl_dob1);
                shet_dl_dob1 += prom;
            }
            return shet_dl_dob1;
        }

        private int shet_dl_dob(int itog, int min_colvo_ballov, int shet_dl_dob) // Подсчет удачно пройденных тестов
        {
            if (itog < min_colvo_ballov)
                return shet_dl_dob;
            else if (itog >= min_colvo_ballov)
                shet_dl_dob++;
            return shet_dl_dob;
        }
       
        private string Replace_Trigonometric_Functions(string expression) //Замена записи тригонометрических функций для того, чтобы библиотека смогла их понять
        {
            expression = expression.Replace("sh", "sinh");
            expression = expression.Replace("ch", "cosh");
            expression = expression.Replace("tgh", "tanh");
            expression = expression.Replace("arcsin", "asin");
            expression = expression.Replace("arccos", "acos");
            expression = expression.Replace("arctg", "atan");
            expression = expression.Replace("arccrg", "acot");  
            expression = expression.Replace("ctg", "cot");
            expression = expression.Replace("tg", "tan");
            expression = expression.Replace(",", ".");

            return expression;
        }

        private int incorrect(int id_vop, int shet, int shet1, Label mass_Label_status) // Проверка правильности ответов
        {
            int id_vop1 = 0;
            if (shet1 == shet)
            {
                id_vop1 = id_vop;
                mass_Label_status.Text = "Неверно!";
                mass_Label_status.BackColor = Color.Salmon;
            }
            else if (shet < shet1)
            {
                id_vop1 = 0;
                mass_Label_status.Text = "Верно!";
                mass_Label_status.BackColor = Color.LightGreen;
            }
            return id_vop1;
        }

        private int accuracy(string[] answers, string text_answer, int shet) // Подсчет баллов
        {
            try
            {
                text_answer = Replace_Trigonometric_Functions(text_answer);
                var textExpr = Expr.Parse(text_answer).Expand().ToString();

                foreach (var answer in answers)
                {
                    var answer_1 = Replace_Trigonometric_Functions(answer);
                    var answerExpr = Expr.Parse(answer_1).Expand().ToString();
                    Console.WriteLine(textExpr);
                    Console.WriteLine(answerExpr);

                    if (textExpr.Equals(answerExpr))
                    {
                        shet++;  
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return shet;
        }

        #endregion

        #region Заполнение комбобоксов
        private void combobox_raz()
        {
            Spisok_razdel.Items.Clear();

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

                                if (!Spisok_razdel.Items.Contains(value))
                                {
                                    Spisok_razdel.Items.Add(value);
                                    has_sections = true;
                                }
                            }
                        }

                        if (!has_sections)
                        {
                            Spisok_razdel.Text = "Разделов ещё нет";
                        }
                    }
                }
            }
        }

        private void combobox_lec(string raz_name, int id_yrov)
        {
            Spisok_tem.Text = "";
            Spisok_tem.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name_test FROM dla_vivoda_vopr WHERE name_razdel = @raz_name AND id_yrovni = @id_yrov";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@raz_name", raz_name);
                    command.Parameters.AddWithValue("@id_yrov", id_yrov);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        bool has_themes = false;
                        int name_testIndex = reader.GetOrdinal("name_test");

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(name_testIndex))
                            {
                                string value = reader.GetString(name_testIndex);

                                if (!Spisok_tem.Items.Contains(value))
                                {
                                    Spisok_tem.Items.Add(value);
                                    has_themes = true;
                                }
                            }

                        }
                        if (!has_themes)
                        {
                            Spisok_tem.Text = "В данном разделе ещё нет тестов.";
                        }
                    }
                }
            }

        }
        #endregion
    }
}
