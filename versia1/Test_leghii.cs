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
    public partial class Test_leghii : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";

        public Test_leghii()
        {
            InitializeComponent();
            combobox_raz();
            id_yrov = 1;
        }


        int shet, shet1, id_yrov;
        RadioButton[] mass_radoubut = new RadioButton[10];
        int id_vop;
        int id_tests;
        DateTime start_test, end_test;
        int[] id_vop_dla_osh;
        int nomer_poptk;
        int id_popit, ostanovka;
        int id_user = Vxod.Id_user1;
        string razdel;
        int[] mas_id_vop;

        #region Заполнение комбобоксов
        private void combobox_raz()
        {
            spisok_razdel.Items.Clear();

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

                                if (!spisok_razdel.Items.Contains(value))
                                {
                                    spisok_razdel.Items.Add(value);
                                    has_sections = true;
                                }
                            }
                        }

                        if (!has_sections)
                        {
                            spisok_razdel.Text = "Разделов ещё нет";
                        }
                    }
                }
            }

        }

        private void combobox_lec(string raz_name, int id_yrov)
        {
            Spisok_tem.Text = "";
            Vopros.Clear();
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

        #region SQL-Запросы

        private string vopros_ot_temi(string tema, int id_tests, int id_vop)
        {
            string vopros = "";

            string vopr = "SELECT vopros FROM dla_vivoda_vopr WHERE id_tests = @id_tests AND id_vopr = @id_vop";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@id_tests", id_tests);
                    command.Parameters.AddWithValue("@id_vop", id_vop);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            vopros = reader.GetString("vopros");
                        }
                    }
                }
            }

            return vopros;
        }


        private string[] Poist_otvetov_po_vopr(int id_vop)
        {
            string[] otveti = null;

            string zapros_otvetov = "SELECT otvet FROM otveti WHERE id_vopr = @id_vop";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(zapros_otvetov, connection))
                {
                    command.Parameters.AddWithValue("@id_vop", id_vop);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        otveti = new string[11];

                        int index = 0;
                        while (reader.Read())
                        {
                            string otvet = reader.GetString("otvet");
                            otveti[index] = otvet;
                            index++;
                        }
                    }
                }
            }

            return otveti;
        }

        private int[] mass_id_vop(string tema, int id_yr)
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

        private int[] Vernost_otvetov(int id_vop)
        {
            int[] vernost = null;
            string zapros_vern = "SELECT vernost FROM otveti WHERE id_vopr = @id_vop";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(zapros_vern, connection))
                {
                    command.Parameters.AddWithValue("@id_vop", id_vop);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        vernost = new int[11];

                        int count = 0;
                        while (reader.Read())
                        {
                            int otv_ver = reader.GetInt32("vernost");
                            vernost[count] = otv_ver;
                            count++;
                        }
                    }

                    return vernost;
                }
            }
        }

        private int min_kolvo_ball(string tema, int id_tests)
        {
            int min_ball = 0;

            string vopr = "SELECT min_colvo_ball FROM dla_vivoda_vopr WHERE name_test = @tema AND id_tests = @id_tests";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@tema", tema);
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

        private int vernost(int id_vop, int shet, string text_otveta)
        {
            string[] otveti = Poist_otvetov_po_vopr(id_vop);
            int[] vernost = Vernost_otvetov(id_vop);
            for (int i = 0; i < vernost.Length; i++)
            {
                if (vernost[i] == 1 && text_otveta == otveti[i])
                    shet++;
            }
            return shet;
        }



        private int vernost_if_neverno(int id_vop, int shet, int shet1)
        {
            int id_vop1 = 0;
            if (shet1 == shet)
                id_vop1 = id_vop;
            else if (shet < shet1)
                id_vop1 = 0;
            return id_vop1;
        }

        private int nomer_popitki(int id_tests, int id_user)
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

        private int f_id_test(string tema, int id_yr)
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

        private int id_pop(int nomer_pop, int id_user, int id_tests)
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

        private void dobav_osh(int id_popit, int[] id_vop_dla_osh)
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

        #endregion

        private void Sled_Click(object sender, EventArgs e)
        {
            string tema = Spisok_tem.Text;
            ostanovka++;
            switch (tema)
            {
                case string value when value == tema:
                    nomer_poptk = nomer_popitki(id_tests, id_user);
                    dla_sled_vop(tema, id_tests, mas_id_vop, id_vop_dla_osh, ostanovka);
                    break;

                default:
                    MessageBox.Show("Вы не выбрали тест!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
        }

        private void spisok_razdel_SelectedIndexChanged(object sender, EventArgs e)
        {
            razdel = spisok_razdel.Text;
            label_vopros.Visible = false;
            combobox_lec(razdel, id_yrov);
            mass_radoubut[0] = A_r;
            mass_radoubut[1] = B_r;
            mass_radoubut[2] = V_r;
            mass_radoubut[3] = G_r;
            mass_radoubut[4] = D_r;
            mass_radoubut[5] = E_r;
            mass_radoubut[6] = J_r;
            mass_radoubut[7] = Z_r;
            mass_radoubut[8] = I_r;
            mass_radoubut[9] = K_r;
            for (int i = 0; i < mass_radoubut.Length; i++)
            {
                mass_radoubut[i].Visible = false;
            }
        }

        private void назадНаНачальнокОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test_leghii.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }

        private void назадКВыборуУровняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test_leghii.ActiveForm.Hide();
            Prom_okno_tests MyProm_okno_tests = new Prom_okno_tests();
            MyProm_okno_tests.ShowDialog();
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test_leghii.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }
        int id_temi, id_jyrn;
        string name_temi;
        private void Spisok_tem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tema = Spisok_tem.Text;
            id_temi = search_id_temi(tema);
            name_temi = search_name_temi(id_temi);
            id_jyrn = id_jyr(id_user, id_temi);
            if (id_jyrn == 0)
            {
                MessageBox.Show($"Не найдено журнальной записи для данной темы и пользователя. Изучите сначала теорию по данной теме: {name_temi}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {

                switch (tema)
                {
                    case string value when value == tema:
                        start_test = DateTime.Now;
                        mas_id_vop = mass_id_vop(tema, id_yrov);
                        id_vop_dla_osh = new int[mas_id_vop.Length];
                        id_tests = f_id_test(tema, id_yrov);
                        id_vop = mas_id_vop[0];
                        vop_case_1(tema, id_tests, id_vop);
                        Sled.Text = "Следующее задание";
                        shet = 0;
                        shet1 = 0;
                        Vopros.Visible = true;
                        Sled.Visible = true;
                        ostanovka = 1;
                        label_vopros.Visible = true;
                        label_vopros.Text = "";
                        label_vopros.Text += "Вопрос 1 из " + mas_id_vop.Length;

                        break;

                    default:
                        MessageBox.Show("Вы не выбрали тему!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                }
            }
        }
        private void dla_sled_vop(string tema, int id_tests, int[] mas_id_vop, int[] id_vop_dla_osh, int ostanovkaa)
        {
            string text_otveta;
            for (int i=0; i < mas_id_vop.Length; i++)
            {
                if (mas_id_vop[i] == id_vop)
                {
                    label_vopros.Text = "";
                    label_vopros.Text += "Вопрос " + ostanovka + " из " + mas_id_vop.Length;

                    for (int j = 0; j < mass_radoubut.Length; j++)
                    {
                        if (mass_radoubut[j].Checked)
                        {
                            text_otveta = mass_radoubut[j].Text;
                            shet1 = vernost(id_vop, shet, text_otveta);
                        }
                    }
                    if (ostanovkaa > mas_id_vop.Length)
                    {
                        id_vop = mas_id_vop[i];
                    }
                    else
                    {
                        id_vop = mas_id_vop[i + 1];
                        if (ostanovkaa == mas_id_vop.Length)
                        {
                            label_vopros.Text = "";
                            label_vopros.Text += "Вопрос " + mas_id_vop.Length + " из " + mas_id_vop.Length;

                            Sled.Text = "Закончить";
                        }


                        id_vop_dla_osh[i] = vernost_if_neverno(id_vop, shet, shet1);
                        shet = shet1;


                        vop_case_1(tema, id_tests, id_vop);

                        break;
                    }
                }

            }

            if (ostanovkaa > mas_id_vop.Length)
            {
                Sled.Visible = false;
                for (int i = 0; i < mass_radoubut.Length; i++)
                {
                    mass_radoubut[i].Visible = false;
                }
                shet = shet1;
                label_vopros.Text = "";

                rezul_1(shet, tema, id_tests);
                id_popit = id_pop(nomer_poptk, id_user, id_tests);
                dobav_osh(id_popit, id_vop_dla_osh);
                return;
            }

        }


        #region Vop_case_1
        void vop_case_1(string tema, int id_tests, int id_vop)
        {
                Vopros.Clear();
                string vopros = vopros_ot_temi(tema, id_tests, id_vop);
                string[] otveti = Poist_otvetov_po_vopr(id_vop);
                Vopros.Text += vopros;
                for (int i = 0; i < mass_radoubut.Length; i++)
                {
                    if (otveti[i] == null)
                        mass_radoubut[i].Visible = false;
                    else
                    {
                        mass_radoubut[i].Text = "";
                        mass_radoubut[i].Visible = true;
                    }
                }

                for (int i = 0; i < mass_radoubut.Length; i++)
                {
                    RadioButton radioButton = mass_radoubut[i];
                    radioButton.Text = otveti[i];
                }
        }
        #endregion
        #region rezul_1
        private void rezul_1(int shet, string tema, int id_tests)
        {
            end_test = DateTime.Now;
            TimeSpan raznica = end_test.Subtract(start_test);
            string raznica_v_dr_form = raznica.ToString("hh\\:mm\\:ss");
            Vopros.Clear();
            int min;
            min = min_kolvo_ball(tema, id_tests);
            if (shet >= min)
            {
                Vopros.Text += "Тест пройден! Ваше количество баллов: " + shet + "\nНачало теста: " + start_test + "\nОкончание теста: " + end_test + "\nПродолжительность теста: " + raznica_v_dr_form + "\nПройдите следующий тест выбрав тему из списка и нажав на кнопку «Открыть».";
            }
            else
            {
                Vopros.Text += "Тест не пройден. Попытайтесь снова. Ваше количество баллов: " + shet + "\nНачало теста: " + start_test + "\nОкончание теста: " + end_test + "\nПродолжительность теста: " + raznica_v_dr_form + "\nПройдите тест заново нажав на кнопку «Открыть».";
            }
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
                int shet_dl_dob1 = 0;
                int[] id_testov;
                id_testov = dl_id_tests(id_temi);
                int prom = 0;
                for (int i = 0; i < id_testov.Length; i++)
                {
                    prom = dla_dob_date_kon(id_testov[i], id_user);
                    if (prom >= 1)
                    {
                        shet_dl_dob1++;
                    }
                }
                dob_date_kon(end_test, shet_dl_dob1, id_jyrn, id_testov);

            

        }
        #endregion

        private void dob_date_kon(DateTime end_test, int shet_dl_dob1, int id_jyr, int[] id_testov)
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


        private int dla_dob_date_kon(int id_test, int id_user)
        {
            int[] itogovoe = itog(id_test, id_user);
            int shet_dl_dob1 = 0;
            int min_ball = min_kolvo_ball(id_test);
            int prom = 0;
            for (int i = 0; i < itogovoe.Length; i++)
            {
                prom = shet_dl_dob(itogovoe[i], min_ball, shet_dl_dob1);
                shet_dl_dob1 += prom;
            }
            return shet_dl_dob1;
        }

        private int shet_dl_dob(int itog, int min_colvo_ballov, int shet_dl_dob)
        {
            if (itog < min_colvo_ballov)
                return shet_dl_dob;
            else if (itog >= min_colvo_ballov)
                shet_dl_dob++;
            return shet_dl_dob;
        }

        private int min_kolvo_ball(int id_tests)
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


        private int[] itog(int id_test, int id_user)
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


        private int[] dl_id_tests(int id_temi)
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


        private string search_name_temi(int id_temi)
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


        private int id_jyr(int id_user, int id_tema)
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

        private int search_id_temi(string test)
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
    }
}