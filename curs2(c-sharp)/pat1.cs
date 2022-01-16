using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace curs2_c_sharp_
{
    public partial class pat1 : Form
    {
        public pat1()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            error_spec.Visible = true;
            for (int i = 0; i < comboBox_spec.Items.Count; i++)
            {
                if (comboBox_spec.Text == comboBox_spec.Items[i].ToString())
                {
                    error_spec.Visible = false;
                }
            }
            if (error_spec.Visible == true)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                opr  f = new opr(comboBox_spec.Text,comboBox_pat.Text);
                f.Show();
                this.Close();
            }
        }

        private void create_Click(object sender, EventArgs e)
        {

            error_name.Visible = false;
            error_surname.Visible = false;
            error_otch.Visible = false;
            error_spec.Visible = false;
            Patient pat=new Patient(); string date = dateTimePicker1.Value.ToShortDateString();string str="";
            pat.Name=textBox_name.Text;
            pat.Surname=textBox_surname.Text;
            pat.Otch=textBox_otch.Text;
            for (int i = 0; i < pat.Name.Length; i++)
            {
                if (pat.Name[i] == ' ')
                {
                    error_name.Visible = true; error_name.Text = "Ошибка:\nНедопустимый символ пробел!!!";
                }
            }
            for (int i = 0; i < pat.Surname.Length; i++)
            {
                if (pat.Surname[i] == ' ')
                {
                    error_surname.Visible = true; error_surname.Text = "Ошибка:\nНедопустимый символ пробел!!!";
                }
            }
            for (int i = 0; i < pat.Otch.Length; i++)
            {
                if (pat.Otch[i] == ' ')
                {
                    error_otch.Visible = true; error_otch.Text = "Ошибка:\nНедопустимый символ пробел!!!";
                }
            }
            if (pat.Name.Length==0)
            {
                error_name.Text = "Ошибка: Пустое поле"; error_name.Visible = true;
            }
            if (pat.Surname.Length==0)
            {
               error_surname.Text = "Ошибка: Пустое поле"; error_surname.Visible = true;
            }
            if (pat.Otch.Length==0)
            {
                 error_otch.Text = "Ошибка: Пустое поле"; error_otch.Visible = true;
            }
            string[] mas = date.Split('.');
            pat.DayOfBirth =int.Parse(mas[0]);
            pat.MonthOfBirth = int.Parse(mas[1]);
            pat.YearOfBirth = int.Parse(mas[2]);
            if ((error_name.Visible == false) && (error_surname.Visible == false) && (error_otch.Visible == false))
            {
                if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите создать такой профиль?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    str = pat.Surname + " " + pat.Name + " " + pat.Otch + " " + pat.DayOfBirth + " " + pat.MonthOfBirth + " " + pat.YearOfBirth + "\n"; //char str1[153]; strcpy(str1,str.c_str());
                    File.AppendAllText(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\patients.txt", str, Encoding.GetEncoding(1251));
                    error_name.Visible = false;
                    error_surname.Visible = false;
                    error_otch.Visible = false;
                    textBox_name.Text = "";
                    textBox_surname.Text = "";
                    textBox_otch.Text = "";



                }
            }
            else
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void birth_date_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_pat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            error_spec.Visible = false;
            comboBox_spec.Text = "";
            if (checkBox1.Checked == true)
            {
                comboBox_pat.Text = "";
                checkBox1.Checked = true;
                label1_mode.Visible = true;
                name.Visible = true;
                birth_date.Visible = true;
                surname.Visible = true;
                otch.Visible = true;
                textBox_name.Visible = true;
                textBox_surname.Visible = true;
                textBox_otch.Visible = true;
                textBox_name.Text = "";
                textBox_surname.Text = "";
                textBox_otch.Text = "";
                dateTimePicker1.Visible = true;
                create.Visible = true;

            }
            else if (checkBox1.Checked == false)
            {
                create.Visible = false;
                label1_mode.Visible = false;
                label_doc.Visible = false;
                name.Visible = false;
                birth_date.Visible = false;
                surname.Visible = false;
                otch.Visible = false;
                label_doc.Visible = false;
                textBox_name.Visible = false;
                textBox_surname.Visible = false;
                textBox_otch.Visible = false;
                comboBox_spec.Visible = false;
                textBox_name.Text = "";
                textBox_surname.Text = "";
                textBox_otch.Text = "";
                dateTimePicker1.Visible = false;
                enter.Text = "Пройти опрос";
                enter.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void error_spec_Click(object sender, EventArgs e)
        {

        }

        private void label_doc_Click(object sender, EventArgs e)
        {

        }

        private void error_otch_Click(object sender, EventArgs e)
        {

        }

        private void error_name_Click(object sender, EventArgs e)
        {

        }

        private void error_surname_Click(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_otch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void otch_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void surname_Click(object sender, EventArgs e)
        {

        }

        private void label1_mode_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_spec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_pat_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            create.Visible = false;
            label1_mode.Visible = false;
            label_doc.Visible = false;
            name.Visible = false;
            birth_date.Visible = false;
            surname.Visible = false;
            otch.Visible = false;
            label_doc.Visible = false;
            textBox_name.Visible = false;
            textBox_surname.Visible = false;
            textBox_otch.Visible = false;
            comboBox_spec.Visible = false;
            textBox_name.Text = "";
            textBox_surname.Text = "";
            textBox_otch.Text = "";
            dateTimePicker1.Visible = false;

            enter.Text = "Пройти опрос";
            enter.Visible = false;
            for (int i = 0; i < comboBox_pat.Items.Count; i++)
            {
                if (comboBox_pat.Text == comboBox_pat.Items[i].ToString())
                {
                    enter.Text = "Пройти опрос";
                    enter.Visible = true;
                    label_doc.Visible = true;
                    comboBox_spec.Visible = true;
                    label1_mode.Visible = true;
                }
            }
        }

        private void pat1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\doctors.txt", System.Text.Encoding.GetEncoding(1251)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] mas = line.Split(' ');
                    comboBox_spec.Items.Add(mas[0]+" "+mas[1][0]+"."+mas[2][0]+". "+mas[3]);
                }
            }
            using (StreamReader sr = new StreamReader(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\patients.txt", System.Text.Encoding.GetEncoding(1251)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] mas = line.Split(' ');
                    comboBox_pat.Items.Add(mas[0] + " " + mas[1][0] + "." + mas[2][0] + ". ");
                }
            }



        }
    }
}
