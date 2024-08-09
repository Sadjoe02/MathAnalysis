using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace versia1
{
    public partial class Info : Form
    {
    private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";

        public Info()
        {
            InitializeComponent();
            combobox_raz();
            combobox_test(comboBox1);
            combobox_test(Tests);
        }

        int id_user = Vxod.Id_user1;

        private void combobox_raz()
        {
            Sections.Items.Clear();

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

                                if (!Sections.Items.Contains(value))
                                {
                                    Sections.Items.Add(value);
                                    has_sections = true;
                                }
                            }
                        }

                        if (!has_sections)
                        {
                            Sections.Text = "Разделов ещё нет";
                        }
                    }
                }
            }
        }

        private void combobox_test(ComboBox comboBox_name)
        {
            comboBox_name.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name_test FROM tests";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        bool has_tests = false;
                        int name_tests_index = reader.GetOrdinal("name_test");

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(name_tests_index))
                            {
                                string value = reader.GetString(name_tests_index);

                                if (!comboBox_name.Items.Contains(value))
                                {
                                    comboBox_name.Items.Add(value);
                                    has_tests = true;
                                }
                            }
                        }

                        if (!has_tests)
                        {
                            comboBox_name.Text = "Тестов ещё нет";
                        }
                    }
                }
            }
        }

        private string type(string name_test)
        {
            string type = "";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name_yrov FROM oshib WHERE name_test = @name_test LIMIT 1";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name_test", name_test);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        type = Convert.ToString(result);
                    }
                }
            }
            return type;
        }


        private void Info_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }

        private DataTable GetTableFromDatabase(string tableName)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = $"SELECT * FROM {tableName} WHERE id_users = @id_user";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_user", id_user);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable); 
                    }
                }
            }
            return dataTable;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name_test = comboBox1.Text;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent; 
            reportViewer1.ZoomPercent = 100;
            reportViewer1.LocalReport.ReportEmbeddedResource = "versia1.completed_tests.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            DataTable view2Table = GetTableFromDatabase("view2");

            ReportDataSource rds = new ReportDataSource("DataSet1", view2Table);
            reportViewer1.LocalReport.DataSources.Add(rds);

            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("Id_User", id_user.ToString()),
                new ReportParameter("Name_Test", name_test)
            };

            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        private void Tests_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name_test = Tests.Text;
            string Type = type(name_test);
            if (Type == "Лёгкий" || Type == "Средний")
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent; 
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.ReportEmbeddedResource = "versia1.mistakes.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                DataTable view2Table = GetTableFromDatabase("oshib");

                ReportDataSource rds = new ReportDataSource("DataSet1", view2Table);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter[] reportParameters = new ReportParameter[]
                {
                new ReportParameter("Id_User", id_user.ToString()),
                new ReportParameter("Name_Test", name_test),
                };

                reportViewer1.LocalReport.SetParameters(reportParameters);
            } else
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent; 
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.ReportEmbeddedResource = "versia1.errors_complex_tests.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                DataTable view2Table = GetTableFromDatabase("oshib");

                ReportDataSource rds = new ReportDataSource("DataSet1", view2Table);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter[] reportParameters = new ReportParameter[]
                {
                new ReportParameter("Id_User", id_user.ToString()),
                new ReportParameter("Name_Test", name_test),
                };

                reportViewer1.LocalReport.SetParameters(reportParameters);
            }
            reportViewer1.RefreshReport();
        }

        private void Sections_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name_section = Sections.Text;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent; 
            reportViewer1.ZoomPercent = 100;
            reportViewer1.LocalReport.ReportEmbeddedResource = "versia1.journal_study.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            DataTable view2Table = GetTableFromDatabase("journal");

            ReportDataSource rds = new ReportDataSource("DataSet1", view2Table);
            reportViewer1.LocalReport.DataSources.Add(rds);

            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("Id_User", id_user.ToString()),
                new ReportParameter("Name_Section", name_section)
            };

            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }

        private void назадНаНачальноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }
    }
}
