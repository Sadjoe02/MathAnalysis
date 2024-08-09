
namespace versia1
{
    partial class Primer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Primer));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.razd_spisok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_examples = new System.Windows.Forms.ComboBox();
            this.output_examples = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадНаНачальноеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.output_examples)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // razd_spisok
            // 
            this.razd_spisok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.razd_spisok.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razd_spisok.FormattingEnabled = true;
            this.razd_spisok.Location = new System.Drawing.Point(8, 67);
            this.razd_spisok.Margin = new System.Windows.Forms.Padding(2);
            this.razd_spisok.Name = "razd_spisok";
            this.razd_spisok.Size = new System.Drawing.Size(332, 27);
            this.razd_spisok.TabIndex = 27;
            this.razd_spisok.SelectedIndexChanged += new System.EventHandler(this.razd_spisok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "1. Выбор раздела:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(358, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "2. Выбор лекции:";
            // 
            // list_examples
            // 
            this.list_examples.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.list_examples.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_examples.FormattingEnabled = true;
            this.list_examples.Location = new System.Drawing.Point(356, 66);
            this.list_examples.Margin = new System.Windows.Forms.Padding(2);
            this.list_examples.Name = "list_examples";
            this.list_examples.Size = new System.Drawing.Size(662, 27);
            this.list_examples.TabIndex = 23;
            this.list_examples.SelectedIndexChanged += new System.EventHandler(this.list_examples_SelectedIndexChanged);
            // 
            // output_examples
            // 
            this.output_examples.AllowExternalDrop = true;
            this.output_examples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output_examples.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output_examples.CreationProperties = null;
            this.output_examples.DefaultBackgroundColor = System.Drawing.Color.White;
            this.output_examples.Location = new System.Drawing.Point(37, 111);
            this.output_examples.Name = "output_examples";
            this.output_examples.Size = new System.Drawing.Size(953, 477);
            this.output_examples.TabIndex = 28;
            this.output_examples.ZoomFactor = 1D;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.назадНаНачальноеОкноToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 27);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // назадНаНачальноеОкноToolStripMenuItem
            // 
            this.назадНаНачальноеОкноToolStripMenuItem.Name = "назадНаНачальноеОкноToolStripMenuItem";
            this.назадНаНачальноеОкноToolStripMenuItem.Size = new System.Drawing.Size(189, 23);
            this.назадНаНачальноеОкноToolStripMenuItem.Text = "Назад на начальное окно";
            this.назадНаНачальноеОкноToolStripMenuItem.Click += new System.EventHandler(this.назадНаНачальноеОкноToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Primer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::versia1.Properties.Resources._1675196894_top_fon_com_p_foni_prezentatsii_matematika_nachalnie_kla_116;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 598);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.output_examples);
            this.Controls.Add(this.razd_spisok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_examples);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Primer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Примеры";
            this.Load += new System.EventHandler(this.Primer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.output_examples)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ComboBox razd_spisok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox list_examples;
        private Microsoft.Web.WebView2.WinForms.WebView2 output_examples;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадНаНачальноеОкноToolStripMenuItem;
    }
}