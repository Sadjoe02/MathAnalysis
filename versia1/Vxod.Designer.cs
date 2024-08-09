
namespace versia1
{
    partial class Vxod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vxod));
            this.Login = new System.Windows.Forms.TextBox();
            this.Parol = new System.Windows.Forms.TextBox();
            this.Voiti = new System.Windows.Forms.Button();
            this.Zareg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(29, 28);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(262, 26);
            this.Login.TabIndex = 0;
            // 
            // Parol
            // 
            this.Parol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parol.Location = new System.Drawing.Point(29, 90);
            this.Parol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Parol.Name = "Parol";
            this.Parol.Size = new System.Drawing.Size(262, 26);
            this.Parol.TabIndex = 1;
            this.Parol.UseSystemPasswordChar = true;
            // 
            // Voiti
            // 
            this.Voiti.BackColor = System.Drawing.Color.White;
            this.Voiti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Voiti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Voiti.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Voiti.Location = new System.Drawing.Point(74, 123);
            this.Voiti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Voiti.Name = "Voiti";
            this.Voiti.Size = new System.Drawing.Size(190, 27);
            this.Voiti.TabIndex = 2;
            this.Voiti.Text = "Войти";
            this.Voiti.UseVisualStyleBackColor = false;
            this.Voiti.Click += new System.EventHandler(this.Voiti_Click);
            // 
            // Zareg
            // 
            this.Zareg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Zareg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zareg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zareg.Location = new System.Drawing.Point(74, 155);
            this.Zareg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Zareg.Name = "Zareg";
            this.Zareg.Size = new System.Drawing.Size(190, 28);
            this.Zareg.TabIndex = 3;
            this.Zareg.Text = "Зарегистрироваться";
            this.Zareg.UseVisualStyleBackColor = false;
            this.Zareg.Click += new System.EventHandler(this.Zareg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::versia1.Properties.Resources.icons8_показать_пароль_100;
            this.pictureBox1.Location = new System.Drawing.Point(295, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Vxod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::versia1.Properties.Resources.fon4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 188);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zareg);
            this.Controls.Add(this.Voiti);
            this.Controls.Add(this.Parol);
            this.Controls.Add(this.Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Vxod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Parol;
        private System.Windows.Forms.Button Voiti;
        private System.Windows.Forms.Button Zareg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}