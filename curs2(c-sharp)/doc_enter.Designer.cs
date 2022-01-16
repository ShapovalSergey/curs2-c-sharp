
namespace curs2_c_sharp_
{
    partial class doc_enter
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
            this.error_spec = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_pat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_login = new System.Windows.Forms.Label();
            this.error_pass = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.label1_mode = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // error_spec
            // 
            this.error_spec.AutoSize = true;
            this.error_spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_spec.ForeColor = System.Drawing.Color.Red;
            this.error_spec.Location = new System.Drawing.Point(325, 345);
            this.error_spec.Name = "error_spec";
            this.error_spec.Size = new System.Drawing.Size(166, 16);
            this.error_spec.TabIndex = 59;
            this.error_spec.Text = "Ошибка: Пустое поле";
            this.error_spec.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(557, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 21);
            this.button1.TabIndex = 58;
            this.button1.Text = "Посмотреть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_pat
            // 
            this.comboBox_pat.FormattingEnabled = true;
            this.comboBox_pat.Location = new System.Drawing.Point(304, 321);
            this.comboBox_pat.Name = "comboBox_pat";
            this.comboBox_pat.Size = new System.Drawing.Size(223, 21);
            this.comboBox_pat.TabIndex = 57;
            this.comboBox_pat.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(85, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Выберите опрос из списка";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(85, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // error_login
            // 
            this.error_login.AutoSize = true;
            this.error_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_login.ForeColor = System.Drawing.Color.Red;
            this.error_login.Location = new System.Drawing.Point(159, 273);
            this.error_login.Name = "error_login";
            this.error_login.Size = new System.Drawing.Size(194, 16);
            this.error_login.TabIndex = 54;
            this.error_login.Text = "Ошибка: Неверный логин";
            this.error_login.Visible = false;
            // 
            // error_pass
            // 
            this.error_pass.AutoSize = true;
            this.error_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_pass.ForeColor = System.Drawing.Color.Red;
            this.error_pass.Location = new System.Drawing.Point(479, 273);
            this.error_pass.Name = "error_pass";
            this.error_pass.Size = new System.Drawing.Size(204, 16);
            this.error_pass.TabIndex = 53;
            this.error_pass.Text = "Ошибка: Неверный пароль";
            this.error_pass.Visible = false;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(392, 246);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(84, 24);
            this.password.TabIndex = 52;
            this.password.Text = "Пароль:";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(85, 246);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(71, 29);
            this.login.TabIndex = 51;
            this.login.Text = "Логин:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(482, 250);
            this.textBox_password.MaxLength = 60;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(158, 20);
            this.textBox_password.TabIndex = 50;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(162, 250);
            this.textBox_login.MaxLength = 30;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(158, 20);
            this.textBox_login.TabIndex = 49;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enter.Location = new System.Drawing.Point(622, 499);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(150, 50);
            this.enter.TabIndex = 48;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // label1_mode
            // 
            this.label1_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_mode.Location = new System.Drawing.Point(285, 150);
            this.label1_mode.Name = "label1_mode";
            this.label1_mode.Size = new System.Drawing.Size(232, 24);
            this.label1_mode.TabIndex = 47;
            this.label1_mode.Text = "Введите логин и пароль\r\n";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.back.Location = new System.Drawing.Point(12, 499);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(150, 50);
            this.back.TabIndex = 46;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // doc_enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.error_spec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_pat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error_login);
            this.Controls.Add(this.error_pass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label1_mode);
            this.Controls.Add(this.back);
            this.Name = "doc_enter";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error_spec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_pat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error_login;
        private System.Windows.Forms.Label error_pass;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label label1_mode;
        private System.Windows.Forms.Button back;
    }
}