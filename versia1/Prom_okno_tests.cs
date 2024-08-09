using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace versia1
{
    public partial class Prom_okno_tests : Form
    {
        public Prom_okno_tests()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Уважаемый читатель, в поле ответа вводите всё без пробела. \nСтепень вводится через символ ^. Деление и умножения вводятся через символы / и * соотственно. \nДесятичные дроби округляются до сотых и записываются через точку. \nЕсли в результате вычислений получается бесконечность, то в поле ответа запишите 'Бесконечность'.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Prom_okno_tests.ActiveForm.Hide();
            difficult_tests Mydifficult_tests = new difficult_tests();
            Mydifficult_tests.ShowDialog();
            Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.linkLabel1, "Тест с выбором ответов");
            toolTip1.SetToolTip(this.linkLabel2, "Тест с вводом ответов");
            toolTip1.SetToolTip(this.linkLabel3, "Тест с вычислениями");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Prom_okno_tests.ActiveForm.Hide();
            Test_leghii MyTest_leghii = new Test_leghii();
            MyTest_leghii.ShowDialog();
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Prom_okno_tests.ActiveForm.Hide();
            Test_srednii MyTest_srednii = new Test_srednii();
            MyTest_srednii.ShowDialog();
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prom_okno_tests.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }

        private void назадНаНачальноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prom_okno_tests.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }
    }
}
