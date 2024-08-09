
namespace versia1
{
    partial class Test_srednii
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_srednii));
            this.Sled_zadanie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Vopros = new System.Windows.Forms.RichTextBox();
            this.Spisok_tem = new System.Windows.Forms.ComboBox();
            this.label_vopros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Spisok_razdel = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадКВыборуУровняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадНаНачальнокОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sled_zadanie
            // 
            this.Sled_zadanie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Sled_zadanie.BackColor = System.Drawing.Color.Wheat;
            this.Sled_zadanie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sled_zadanie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sled_zadanie.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sled_zadanie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sled_zadanie.Location = new System.Drawing.Point(437, 450);
            this.Sled_zadanie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sled_zadanie.Name = "Sled_zadanie";
            this.Sled_zadanie.Size = new System.Drawing.Size(303, 50);
            this.Sled_zadanie.TabIndex = 39;
            this.Sled_zadanie.Text = "Следующее задание";
            this.Sled_zadanie.UseVisualStyleBackColor = false;
            this.Sled_zadanie.Visible = false;
            this.Sled_zadanie.Click += new System.EventHandler(this.Sled_zadanie_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Введите ответ:";
            this.label1.Visible = false;
            // 
            // Vvod
            // 
            this.Vvod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vvod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Vvod.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vvod.Location = new System.Drawing.Point(31, 396);
            this.Vvod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(1069, 30);
            this.Vvod.TabIndex = 37;
            this.Vvod.Visible = false;
            // 
            // Vopros
            // 
            this.Vopros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vopros.BackColor = System.Drawing.SystemColors.Menu;
            this.Vopros.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vopros.Location = new System.Drawing.Point(5, 137);
            this.Vopros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vopros.Name = "Vopros";
            this.Vopros.ReadOnly = true;
            this.Vopros.Size = new System.Drawing.Size(1119, 207);
            this.Vopros.TabIndex = 36;
            this.Vopros.Text = "";
            this.Vopros.Visible = false;
            // 
            // Spisok_tem
            // 
            this.Spisok_tem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spisok_tem.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spisok_tem.FormattingEnabled = true;
            this.Spisok_tem.Location = new System.Drawing.Point(355, 73);
            this.Spisok_tem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Spisok_tem.Name = "Spisok_tem";
            this.Spisok_tem.Size = new System.Drawing.Size(769, 30);
            this.Spisok_tem.TabIndex = 34;
            this.Spisok_tem.SelectedIndexChanged += new System.EventHandler(this.Spisok_tem_SelectedIndexChanged);
            // 
            // label_vopros
            // 
            this.label_vopros.AutoSize = true;
            this.label_vopros.BackColor = System.Drawing.Color.Wheat;
            this.label_vopros.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vopros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_vopros.Location = new System.Drawing.Point(13, 112);
            this.label_vopros.Name = "label_vopros";
            this.label_vopros.Size = new System.Drawing.Size(47, 22);
            this.label_vopros.TabIndex = 42;
            this.label_vopros.Text = "NaN";
            this.label_vopros.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(357, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "2. Выберите тест:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "1. Выберите раздел:";
            // 
            // Spisok_razdel
            // 
            this.Spisok_razdel.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spisok_razdel.FormattingEnabled = true;
            this.Spisok_razdel.Items.AddRange(new object[] {
            "Предел функции. Бесконечно большие и бесконечно малые функции",
            "Непосредственное вычисление пределов",
            "Раскрытие неопределённостей вида ∞/∞, при x→∞",
            "Неопределённости вида ∞ – ∞  и 0 * ∞"});
            this.Spisok_razdel.Location = new System.Drawing.Point(11, 73);
            this.Spisok_razdel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Spisok_razdel.Name = "Spisok_razdel";
            this.Spisok_razdel.Size = new System.Drawing.Size(337, 30);
            this.Spisok_razdel.TabIndex = 44;
            this.Spisok_razdel.SelectedIndexChanged += new System.EventHandler(this.Spisok_razdel_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.назадКВыборуУровняToolStripMenuItem,
            this.назадНаНачальнокОкноToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 30);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // назадКВыборуУровняToolStripMenuItem
            // 
            this.назадКВыборуУровняToolStripMenuItem.Name = "назадКВыборуУровняToolStripMenuItem";
            this.назадКВыборуУровняToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.назадКВыборуУровняToolStripMenuItem.Text = "Назад к выбору уровня";
            this.назадКВыборуУровняToolStripMenuItem.Click += new System.EventHandler(this.назадКВыборуУровняToolStripMenuItem_Click);
            // 
            // назадНаНачальнокОкноToolStripMenuItem
            // 
            this.назадНаНачальнокОкноToolStripMenuItem.Name = "назадНаНачальнокОкноToolStripMenuItem";
            this.назадНаНачальнокОкноToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.назадНаНачальнокОкноToolStripMenuItem.Text = "Назад на начальное окно";
            this.назадНаНачальнокОкноToolStripMenuItem.Click += new System.EventHandler(this.назадНаНачальнокОкноToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Test_srednii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::versia1.Properties.Resources._1675196894_top_fon_com_p_foni_prezentatsii_matematika_nachalnie_kla_116;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 526);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Spisok_razdel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_vopros);
            this.Controls.Add(this.Sled_zadanie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Vopros);
            this.Controls.Add(this.Spisok_tem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Test_srednii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Средний уровень";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sled_zadanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.RichTextBox Vopros;
        private System.Windows.Forms.ComboBox Spisok_tem;
        private System.Windows.Forms.Label label_vopros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Spisok_razdel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадКВыборуУровняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадНаНачальнокОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}