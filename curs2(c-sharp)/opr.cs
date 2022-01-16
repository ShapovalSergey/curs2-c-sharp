using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs2_c_sharp_
{
    public partial class opr : Form
    {
        string d1, p1;
        public opr(string d,string p)
        {
            InitializeComponent();
            d1 = d;p1 = p;
        }

        private void back_Click(object sender, EventArgs e)
        {
			if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите покинуть опрос?\nВсе несохраненные данные будут утеряны!!!", "Покинуть опрос?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
			{
				this.Close();
			}
		}

        private void save_Click(object sender, EventArgs e)
        {
			error_tmp.Visible = false;
			double tmp;
			
			if (double.TryParse(textBox_tmp.Text,out tmp))
			{
				textBox_tmp.Text = "";
				error_tmp.Text = "Ошибка: Неверный формат \nили пустое поле";
			}
			else
			{
				if ((tmp < 25) || (tmp > 45))
				{
					textBox_tmp.Text = "";
				}
			}

			//MessageBox.Show(""+temperature, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

			if ((checkBox1.Text == "Насморк") && (textBox_tmp.Text.Length == 0))
			{
				error_tmp.Visible = true;
				//MessageBox.Show(textBox_tmp.Text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите сохранить опрос?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
				{
					string s1 = d1 + " " + p1 + " ";
					//MessageBox.Show(s1, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					if (checkBox1.Text == "Онемения")
					{
						Opros2 opr=new Opros2(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked, checkBox8.Checked, checkBox9.Checked);
						opr.saveopros(d1, p1);
					}
					else if (checkBox1.Text == "Насморк")
					{
						Opros1 opr=new Opros1(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked, checkBox8.Checked, tmp);
						opr.saveopros(d1, p1);
					}
					else if (checkBox1.Text == "Жидкий стул")
					{
						Opros3 opr = new Opros3(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked, checkBox8.Checked, checkBox9.Checked );
						opr.saveopros(d1, p1);
					}
					this.Close();
				}
			}
		}

        private void opr_Load(object sender, EventArgs e)
        {
			patient.Text = "Пациент:\n" +p1;
			doctor.Text = "Доктор:\n" + d1;
			string[] mas = d1.Split(' ');
			//MessageBox.Show(context.marshal_as<String^>(ptr), "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (mas[2] == "Невролог")
			{
				tmp.Visible = false;
				textBox_tmp.Visible = false;
				checkBox1.Text = "Онемения";
				checkBox2.Text = "Кружится голова";
				checkBox3.Text = "Мышечная слабость";
				checkBox4.Text = "Покалывания";
				checkBox5.Text = "Подергивания мышц";
				checkBox6.Text = "Болит голова";
				checkBox7.Text = "Эпилептические припадки";
				checkBox8.Text = "Шатает при ходьбе";
				checkBox9.Text = "Болит спина";
			}
			else if (mas[2] == "Оториноларинголог")
			{
				checkBox9.Visible = false;
				checkBox1.Text = "Насморк";
				checkBox2.Text = "Кашель";
				checkBox3.Text = "Болит горло";
				checkBox4.Text = "Заложен нос";
				checkBox5.Text = "Боль в ушах";
				checkBox6.Text = "Болит голова";
				checkBox7.Text = "Озноб";
				checkBox8.Text = "Жар";
			}
			else if (mas[2] == "Гастроэнтеролог")
			{
				tmp.Visible = false;
				textBox_tmp.Visible = false;
				checkBox1.Text = "Жидкий стул";
				checkBox2.Text = "Изжога";
				checkBox3.Text = "Запор";
				checkBox4.Text = "Потеря аппетита";
				checkBox5.Text = "Снижение веса";
				checkBox6.Text = "Тошнота";
				checkBox7.Text = "Рвота";
				checkBox8.Text = "Спазм в животе";
				checkBox9.Text = "Боль в животе";
			}

		}
	}
}
