
namespace curs2_c_sharp_
{
    partial class pat1
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
            this.create = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.birth_date = new System.Windows.Forms.Label();
            this.comboBox_pat = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.error_spec = new System.Windows.Forms.Label();
            this.label_doc = new System.Windows.Forms.Label();
            this.error_otch = new System.Windows.Forms.Label();
            this.error_name = new System.Windows.Forms.Label();
            this.error_surname = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_otch = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.otch = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.label1_mode = new System.Windows.Forms.Label();
            this.comboBox_spec = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.create.Location = new System.Drawing.Point(631, 96);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(150, 25);
            this.create.TabIndex = 66;
            this.create.Text = "Создать профиль";
            this.create.UseVisualStyleBackColor = false;
            this.create.Visible = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enter.Location = new System.Drawing.Point(622, 499);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(150, 50);
            this.enter.TabIndex = 65;
            this.enter.Text = "Пройти опрос";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Visible = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.back.Location = new System.Drawing.Point(12, 499);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(150, 50);
            this.back.TabIndex = 64;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // birth_date
            // 
            this.birth_date.AutoSize = true;
            this.birth_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_date.Location = new System.Drawing.Point(76, 350);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(238, 20);
            this.birth_date.TabIndex = 63;
            this.birth_date.Text = "Введите вашу дату рождения";
            this.birth_date.Visible = false;
            this.birth_date.Click += new System.EventHandler(this.birth_date_Click);
            // 
            // comboBox_pat
            // 
            this.comboBox_pat.FormattingEnabled = true;
            this.comboBox_pat.Location = new System.Drawing.Point(375, 66);
            this.comboBox_pat.Name = "comboBox_pat";
            this.comboBox_pat.Size = new System.Drawing.Size(223, 21);
            this.comboBox_pat.TabIndex = 62;
            this.comboBox_pat.SelectedIndexChanged += new System.EventHandler(this.comboBox_pat_SelectedIndexChanged);
            this.comboBox_pat.TextChanged += new System.EventHandler(this.comboBox_pat_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(631, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 24);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "Новый профиль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 50);
            this.label1.TabIndex = 60;
            this.label1.Text = "Выберите пациента из списка \r\nили создайте новый профиль";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(319, 350);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(75, 20);
            this.dateTimePicker1.TabIndex = 59;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // error_spec
            // 
            this.error_spec.AutoSize = true;
            this.error_spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_spec.ForeColor = System.Drawing.Color.Red;
            this.error_spec.Location = new System.Drawing.Point(548, 150);
            this.error_spec.Name = "error_spec";
            this.error_spec.Size = new System.Drawing.Size(166, 16);
            this.error_spec.TabIndex = 58;
            this.error_spec.Text = "Ошибка: Пустое поле";
            this.error_spec.Visible = false;
            this.error_spec.Click += new System.EventHandler(this.error_spec_Click);
            // 
            // label_doc
            // 
            this.label_doc.AutoSize = true;
            this.label_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_doc.Location = new System.Drawing.Point(79, 151);
            this.label_doc.Name = "label_doc";
            this.label_doc.Size = new System.Drawing.Size(194, 20);
            this.label_doc.TabIndex = 57;
            this.label_doc.Text = "Выберите вашего врача";
            this.label_doc.Visible = false;
            this.label_doc.Click += new System.EventHandler(this.label_doc_Click);
            // 
            // error_otch
            // 
            this.error_otch.AutoSize = true;
            this.error_otch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_otch.ForeColor = System.Drawing.Color.Red;
            this.error_otch.Location = new System.Drawing.Point(546, 300);
            this.error_otch.Name = "error_otch";
            this.error_otch.Size = new System.Drawing.Size(166, 16);
            this.error_otch.TabIndex = 56;
            this.error_otch.Text = "Ошибка: Пустое поле";
            this.error_otch.Visible = false;
            this.error_otch.Click += new System.EventHandler(this.error_otch_Click);
            // 
            // error_name
            // 
            this.error_name.AutoSize = true;
            this.error_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_name.ForeColor = System.Drawing.Color.Red;
            this.error_name.Location = new System.Drawing.Point(546, 250);
            this.error_name.Name = "error_name";
            this.error_name.Size = new System.Drawing.Size(166, 16);
            this.error_name.TabIndex = 55;
            this.error_name.Text = "Ошибка: Пустое поле";
            this.error_name.Visible = false;
            this.error_name.Click += new System.EventHandler(this.error_name_Click);
            // 
            // error_surname
            // 
            this.error_surname.AutoSize = true;
            this.error_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_surname.ForeColor = System.Drawing.Color.Red;
            this.error_surname.Location = new System.Drawing.Point(546, 200);
            this.error_surname.Name = "error_surname";
            this.error_surname.Size = new System.Drawing.Size(166, 16);
            this.error_surname.TabIndex = 54;
            this.error_surname.Text = "Ошибка: Пустое поле";
            this.error_surname.Visible = false;
            this.error_surname.Click += new System.EventHandler(this.error_surname_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(319, 250);
            this.textBox_name.MaxLength = 40;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(158, 20);
            this.textBox_name.TabIndex = 53;
            this.textBox_name.Visible = false;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_otch
            // 
            this.textBox_otch.Location = new System.Drawing.Point(319, 300);
            this.textBox_otch.MaxLength = 40;
            this.textBox_otch.Name = "textBox_otch";
            this.textBox_otch.Size = new System.Drawing.Size(158, 20);
            this.textBox_otch.TabIndex = 52;
            this.textBox_otch.Visible = false;
            this.textBox_otch.TextChanged += new System.EventHandler(this.textBox_otch_TextChanged);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(319, 200);
            this.textBox_surname.MaxLength = 40;
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(158, 20);
            this.textBox_surname.TabIndex = 51;
            this.textBox_surname.Visible = false;
            this.textBox_surname.TextChanged += new System.EventHandler(this.textBox_surname_TextChanged);
            // 
            // otch
            // 
            this.otch.AutoSize = true;
            this.otch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otch.Location = new System.Drawing.Point(76, 300);
            this.otch.Name = "otch";
            this.otch.Size = new System.Drawing.Size(195, 20);
            this.otch.TabIndex = 50;
            this.otch.Text = "Введите ваше отчество";
            this.otch.Visible = false;
            this.otch.Click += new System.EventHandler(this.otch_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(79, 250);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(153, 20);
            this.name.TabIndex = 49;
            this.name.Text = "Введите ваше имя";
            this.name.Visible = false;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(79, 200);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(197, 20);
            this.surname.TabIndex = 48;
            this.surname.Text = "Введите вашу фамилию";
            this.surname.Visible = false;
            this.surname.Click += new System.EventHandler(this.surname_Click);
            // 
            // label1_mode
            // 
            this.label1_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_mode.Location = new System.Drawing.Point(315, 111);
            this.label1_mode.Name = "label1_mode";
            this.label1_mode.Size = new System.Drawing.Size(156, 24);
            this.label1_mode.TabIndex = 47;
            this.label1_mode.Text = "Заполните поля";
            this.label1_mode.Visible = false;
            this.label1_mode.Click += new System.EventHandler(this.label1_mode_Click);
            // 
            // comboBox_spec
            // 
            this.comboBox_spec.FormattingEnabled = true;
            this.comboBox_spec.Location = new System.Drawing.Point(319, 150);
            this.comboBox_spec.Name = "comboBox_spec";
            this.comboBox_spec.Size = new System.Drawing.Size(223, 21);
            this.comboBox_spec.TabIndex = 46;
            this.comboBox_spec.Visible = false;
            this.comboBox_spec.SelectedIndexChanged += new System.EventHandler(this.comboBox_spec_SelectedIndexChanged);
            // 
            // pat1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.create);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.back);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.comboBox_pat);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.error_spec);
            this.Controls.Add(this.label_doc);
            this.Controls.Add(this.error_otch);
            this.Controls.Add(this.error_name);
            this.Controls.Add(this.error_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_otch);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.otch);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label1_mode);
            this.Controls.Add(this.comboBox_spec);
            this.Name = "pat1";
            this.Text = "Пациент";
            this.Load += new System.EventHandler(this.pat1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label birth_date;
        private System.Windows.Forms.ComboBox comboBox_pat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label error_spec;
        private System.Windows.Forms.Label label_doc;
        private System.Windows.Forms.Label error_otch;
        private System.Windows.Forms.Label error_name;
        private System.Windows.Forms.Label error_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_otch;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label otch;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label label1_mode;
        private System.Windows.Forms.ComboBox comboBox_spec;
    }
}