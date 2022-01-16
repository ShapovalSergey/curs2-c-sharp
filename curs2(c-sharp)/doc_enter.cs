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
	
    public partial class doc_enter : Form
    {
        public doc_enter()
        {
            InitializeComponent();
        }
		List<string> valera = new List<string>() { "Настало твое время"};
		string dekod(string par1, string kod1)
		{
			char[] en1 =new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z' };
			char[] ru1 = new char[] { 'а', 'А', 'б', 'Б', 'в', 'В', 'г', 'Г', 'д', 'Д', 'е', 'Е', 'ё', 'Ё', 'ж', 'Ж', 'з', 'З', 'и', 'И', 'й', 'Й', 'к', 'К', 'л', 'Л', 'м', 'М', 'н', 'Н', 'о', 'О', 'п', 'П', 'р', 'Р', 'с', 'С', 'т', 'Т', 'у', 'У', 'ф', 'Ф', 'х', 'Х', 'ц', 'Ц', 'ч', 'Ч', 'ш', 'Ш', 'щ', 'Щ', 'ъ', 'Ъ', 'ы', 'Ы', 'ь', 'Ь', 'э', 'Э', 'ю', 'Ю', 'я', 'Я' };

			string par="";
			for (int i = 0; i < par1.Length; i++)
			{
				if (kod1[i] == '0')
				{
					for (int j = 0; j < 66; j++)
					{
						if (par1[i] == ru1[j])
						{
							if (j - i > -1)
							{
								par += en1[j - i];
							}
							else
							{
								par += en1[62 - j - i];
							}
						}
					}
				}
				else if (kod1[i] == '1')
				{
					for (int z = 0; z < 62; z++)
					{
						if (par1[i] == en1[z])
						{
							if (z - i > -1)
							{
								par += ru1[z - i];
							}
							else
							{
								par += ru1[66 - z - i];
							}
						}
					}
				}
			}
			return par;
		}

		private void back_Click(object sender, EventArgs e)
        {
            if (back.Text == "Выйти")
            {
                if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
			error_login.Visible = true; error_pass.Visible = false;
			string str, par, kod,log,stroka, pass;int n = 0, k = 0;log = "";
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
					string[] mas = line.Split(' ');n++;
					if (mas[0] == textBox_login.Text)
					{
						k++;log = mas[0];
                        if (dekod(mas[1],mas[2])!=textBox_password.Text)
                        {
							error_pass.Visible = true;
                        }
						error_login.Visible = false;
					}
				}
			}
			if ((k == n) || (n == 0))
			{
				error_login.Visible = true;
			}
			if ((error_pass.Visible == false) && (error_login.Visible == false))
			{
				string  spec1="",  name1="" ;
				login.Visible = false;
				password.Visible = false;
				label1_mode.Visible = false;
				textBox_login.Visible = false;
				textBox_password.Visible = false;
				enter.Visible = false;
				label2.Visible = true;
				button1.Visible = true;
				comboBox_pat.Visible = true;
				back.Text = "Выйти";
				label1.Visible = true;

				using (StreamReader sr = new StreamReader(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\doctors.txt", System.Text.Encoding.GetEncoding(1251)))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						string[] mas = line.Split(' '); n++;
						if (mas[4] == log)
						{
							label1.Text = mas[0] + "\n" + mas[1] + "\n" + mas[2] + "\n" + mas[3] + "\n";
							spec1 = mas[3];name1 = mas[0] + " " + mas[1][0] + "." + mas[2][0] + ".";
						}
					}
				}
				if (spec1 == "Гастроэнтеролог")
				{
					using (StreamReader sr = new StreamReader(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\opros3.txt", System.Text.Encoding.GetEncoding(1251)))
					{
						string line;
						while ((line = sr.ReadLine()) != null)
						{
							string[] mas = line.Split(' '); n++;
							if (mas[0]+" "+mas[1]==name1)
							{
								valera.Add(line);comboBox_pat.Items.Add(mas[3]+" "+mas[4]+" "+mas[5] + " " + mas[6]);
							}
						}
					}
				}
				else if (spec1 == "Невролог")
				{

					using (StreamReader sr = new StreamReader(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\opros2.txt", System.Text.Encoding.GetEncoding(1251)))
					{
						string line;
						while ((line = sr.ReadLine()) != null)
						{
							string[] mas = line.Split(' '); n++;
							if (mas[0]+" "+mas[1]==name1)
							{
								valera.Add(line);comboBox_pat.Items.Add(mas[3]+" "+mas[4] + " " + mas[5] + " " + mas[6]);
							}
						}
					}
				}
				
				else if (spec1 == "Оториноларинголог")
				{
					using (StreamReader sr = new StreamReader(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\opros1.txt", System.Text.Encoding.GetEncoding(1251)))
					{
						string line;
						while ((line = sr.ReadLine()) != null)
						{
							string[] mas = line.Split(' '); n++;
							if (mas[0]+" "+mas[1]==name1)
							{
								valera.Add(line);comboBox_pat.Items.Add(mas[3]+" "+mas[4]+" "+mas[5] + " " + mas[6]);
							}
						}
					}
				}
			}
			
				else
				{
				MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			error_spec.Visible = true; 
			for (int i = 0; i < comboBox_pat.Items.Count; i++)
			{
				if (comboBox_pat.Text == comboBox_pat.Items[i].ToString())
				{
					error_spec.Visible = false;
				}
			}
			if (error_spec.Visible == false)
			{
				oproscheck f = new oproscheck(valera[comboBox_pat.SelectedIndex+1]);
				f.Show();
			}
			else
			{
				MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
    }
    
}
