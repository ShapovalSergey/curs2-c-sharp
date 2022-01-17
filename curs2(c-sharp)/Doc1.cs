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
    public partial class Doc1 : Form
    {
        public Doc1()
        {
            InitializeComponent();
        }
		char[] en =new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z' };
		char[] ru = new char[]{ 'а', 'А', 'б', 'Б', 'в', 'В', 'г', 'Г', 'д', 'Д', 'е', 'Е', 'ё', 'Ё', 'ж', 'Ж', 'з', 'З', 'и', 'И', 'й', 'Й', 'к', 'К', 'л', 'Л', 'м', 'М', 'н', 'Н', 'о', 'О', 'п', 'П', 'р', 'Р', 'с', 'С', 'т', 'Т', 'у', 'У', 'ф', 'Ф', 'х', 'Х', 'ц', 'Ц', 'ч', 'Ч', 'ш', 'Ш', 'щ', 'Щ', 'ъ', 'Ъ', 'ы', 'Ы', 'ь', 'Ь', 'э', 'Э', 'ю', 'Ю', 'я', 'Я' };
		string kod(string par)
		{
			string k = ""; string parol = "";
			for (int i = 0; i < par.Length; i++)
			{
				for (int j = 0; j < 62; j++)
				{
					if (par[i] == en[j])
					{
						k += '0';
						if (j + i < 66)
						{
							parol += ru[i + j];
						}
						else
						{
							parol += ru[i + j - 66];
						}
					}
				}
				for (int z = 0; z < 66; z++)
				{
					if (par[i] == ru[z])
					{
						k += '1';
						if (z + i < 62)
						{
							parol += en[i + z];
						}
						else
						{
							parol += en[i + z - 62];
						}
					}
				}
			}
			return parol + " " + k;
		}
		private void create_Click(object sender, EventArgs e)
        {

			label1_mode.Location = new Point(label1_mode.Location.X, 50); ;
			label1_mode.Text = "Создание нового профиля";
			create.Visible = false;
			enter.Visible = false;
			name.Visible = true;
			surname.Visible = true;
			otch.Visible = true;
			speciality.Visible = true;
			textBox_name.Visible = true;
			textBox_surname.Visible = true;
			textBox_otch.Visible = true;
			comboBox_spec.Visible = true;
			login.Visible = true;
			password.Visible = true;
			password2.Visible = true;
			textBox_login.Visible = true;
			textBox_password.Visible = true;
			textBox_password2.Visible = true;
			accept.Visible = true;
			back.Visible = true;
			textBox_name.Text = "";
			textBox_surname.Text = "";
			textBox_otch.Text = "";
			comboBox_spec.Text = "";
			textBox_login.Text = "";
			textBox_password.Text = "";
			textBox_password2.Text = "";
		}

        private void back_Click(object sender, EventArgs e)
        {
			if (label1_mode.Text == "Создание нового профиля")
			{
				label1_mode.Location = new Point(label1_mode.Location.X, 150); ;
				label1_mode.Text = "Выберите, что вы хотите сделать";
				create.Visible = true;
				enter.Visible = true;
				name.Visible = false;
				surname.Visible = false;
				otch.Visible = false;
				speciality.Visible = false;
				textBox_name.Visible = false;
				textBox_surname.Visible = false;
				textBox_otch.Visible = false;
				comboBox_spec.Visible = false;
				login.Visible = false;
				password.Visible = false;
				password2.Visible = false;
				textBox_login.Visible = false;
				textBox_password.Visible = false;
				textBox_password2.Visible = false;
				accept.Visible = false;
				error_login.Visible = false;
				error_name.Visible = false;
				error_surname.Visible = false;
				error_otch.Visible = false;
				error_pass.Visible = false;
				error_pass2.Visible = false;
				error_spec.Visible = false;
			}
			else if (label1_mode.Text == "Выберите, что вы хотите сделать")
			{
				this.Hide();
			}

		}

        private void accept_Click(object sender, EventArgs e)
        {
			error_login.Visible = false;
			error_name.Visible = false;
			error_surname.Visible = false;
			error_otch.Visible = false;
			error_pass.Visible = false;
			error_pass2.Visible = false;
			error_spec.Visible = false;
			Doctor doc=new Doctor(); string str,str1,stroka; 
			/*string path = @"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\doctors.txt";
			File.AppendAllText(path, "asd asd\n");
			File.AppendAllText(path, "asd asd\n");
			File.AppendAllText(path, "asd asd\n");
			File.AppendAllText(path, "asd asd\n");
			using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					MessageBox.Show(line);
				}
			}*/

			doc.Name=textBox_name.Text;
			doc.Surname=textBox_surname.Text;
			doc.Otch=textBox_otch.Text;
			for (int i = 0; i < doc.Name.Length; i++)
			{
				if (doc.Name[i] == ' ')
				{
					error_name.Visible = true; error_name.Text = "Ошибка:\nНедопустимый символ пробел!!!";
				}
			}
			for (int i = 0; i < doc.Surname.Length; i++)
			{
				if (doc.Surname[i] == ' ')
				{
					error_surname.Visible = true; error_surname.Text = "Ошибка:\nНедопустимый символ пробел!!!";
				}
			}
			for (int i = 0; i < doc.Otch.Length; i++)
			{
				if (doc.Otch[i] == ' ')
				{
					error_otch.Visible = true; error_otch.Text = "Ошибка:\nНедопустимый символ пробел!!!";
				}
			}
			for (int i = 0; i < textBox_login.Text.Length; i++)
			{
				if (textBox_login.Text[i] == ' ')
				{
					error_login.Visible = true; error_login.Text = "Ошибка:\nНедопустимый символ пробел!!!";
				}
			}
			for (int i = 0; i < textBox_password.Text.Length; i++)
			{
				error_pass.Visible = true; error_pass.Text = "Ошибка:\nНедопустимый символ!!!";
				for (int j = 0; j < 66; j++)
				{
					if (textBox_password.Text[i] == ru[j])
					{
						error_pass.Visible = false;
					}
				}
				for (int j = 0; j < 62; j++)
				{
					if (textBox_password.Text[i] == en[j])
					{
						error_pass.Visible = false;// error_pass.Text = "Ошибка:\nНедопустимый символ\n!!!";
					}
				}
				if (error_pass.Visible == true)
				{
					i = textBox_password.Text.Length + 1;
				}

			}
			if (comboBox_spec.Text == "Гастроэнтеролог")
			{
				doc.Speciality="Гастроэнтеролог"; 
			}
			else if (comboBox_spec.Text == "Невролог")
			{
				doc.Speciality="Невролог"; 
			}
			else if (comboBox_spec.Text == "Оториноларинголог")
			{
				doc.Speciality="Оториноларинголог"; 
			}
			else if ((comboBox_spec.Text != "Гастроэнтеролог") && (comboBox_spec.Text != "Невролог") && (comboBox_spec.Text != "Оториноларинголог"))
			{
				error_spec.Visible = true;
			}
			if (doc.Name.Length==0)
			{
				 error_name.Text = "Ошибка: Пустое поле"; error_name.Visible = true;
			}
			if (doc.Surname.Length == 0)
			{
			 error_surname.Text = "Ошибка: Пустое поле"; error_surname.Visible = true;
			}
			if (doc.Otch.Length == 0)
			{
			 error_otch.Text = "Ошибка: Пустое поле"; error_otch.Visible = true;
			}
            if (!File.Exists(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\logins.txt"))
            {
				File.Create(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\logins.txt");
            }
			//(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\logins.txt");
			using (StreamReader sr = new StreamReader(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\logins.txt", System.Text.Encoding.GetEncoding(1251)))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					string[] mas = line.Split(' ')  ;
                    if (mas[0]==textBox_login.Text)
                    {
						error_login.Visible = true;
                    }
				}
			}
			if (!textBox_password.Text.Equals(textBox_password2.Text))
			{
				
				error_pass2.Visible = true;
			}
			if (textBox_password.Text.Length == 0)
			{
				
				error_pass.Visible = true;
			}

			
			if ((error_login.Visible == false) && (error_name.Visible == false) && (error_surname.Visible == false) && (error_otch.Visible == false) && (error_pass.Visible == false) && (error_pass2.Visible == false) && (error_spec.Visible == false))
			{

				if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите создать такой профиль?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
				{
					str = doc.Surname + " " + doc.Name + " " + doc.Otch + " " + doc.Speciality + " " + textBox_login.Text+"\n"; //char str1[153]; strcpy(str1,str.c_str());
					File.AppendAllText(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\doctors.txt", str, Encoding.GetEncoding(1251));
					File.AppendAllText(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\logins.txt", textBox_login.Text+" "+kod(textBox_password.Text)+"\n",Encoding.GetEncoding(1251));
					label1_mode.Location = new Point(label1_mode.Location.X, 150); ;
					label1_mode.Text = "Выберите, что вы хотите сделать";
					create.Visible = true;
					enter.Visible = true;
					name.Visible = false;
					surname.Visible = false;
					otch.Visible = false;
					speciality.Visible = false;
					textBox_name.Visible = false;
					textBox_surname.Visible = false;
					textBox_otch.Visible = false;
					comboBox_spec.Visible = false;
					login.Visible = false;
					password.Visible = false;
					password2.Visible = false;
					textBox_login.Visible = false;
					textBox_password.Visible = false;
					textBox_password2.Visible = false;
					accept.Visible = false;
					error_login.Visible = false;
					error_name.Visible = false;
					error_surname.Visible = false;
					error_otch.Visible = false;
					error_pass.Visible = false;
					error_pass2.Visible = false;
					error_spec.Visible = false;
				}

			}
			else
			{
				MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void enter_Click(object sender, EventArgs e)
        {
			doc_enter f = new doc_enter();
			f.Show();
			this.Close();
        }
    }
}
