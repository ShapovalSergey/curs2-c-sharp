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
    public partial class oproscheck : Form
    {
        string op;
        public oproscheck(string str)
        {
            op = str;
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_tmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmp_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void oproscheck_Load(object sender, EventArgs e)
        {
			string vivod="",spec="";string[] mas = op.Split(' ');




			vivod += "Доктор: "; vivod += mas[0]; vivod += ' ';  vivod += mas[1]; vivod += " - ";  vivod += mas[2]; spec += mas[2]; vivod += '\n';
			vivod += "Пациент: ";  vivod += mas[3]; vivod += ' ';  vivod += mas[4]; vivod += '\n';
			vivod += "Дата и время: ";  vivod += mas[6];

			if (spec == "Невролог")
			{
				label1.Text = vivod;
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

				if (mas[6]== "1")
				{
					checkBox1.Checked = true;
				}
				if (mas[7]== "1")
				{
					checkBox2.Checked = true;
				}
				if (mas[8]== "1")
				{
					checkBox3.Checked = true;
				}
				if (mas[9]== "1")
				{
					checkBox4.Checked = true;
				}
				if (mas[10]== "1")
				{
					checkBox5.Checked = true;
				}
				if (mas[11]== "1")
				{
					checkBox6.Checked = true;
				}
				if (mas[12]== "1")
				{
					checkBox7.Checked = true;
				}
				if (mas[13]== "1")
				{
					checkBox8.Checked = true;
				}
				if (mas[14]== "1")
				{
					checkBox9.Checked = true;
				}
			}
			else if (spec == "Оториноларинголог")
			{
				label1.Text = vivod;
				checkBox9.Visible = false;
				checkBox1.Text = "Насморк";
				checkBox2.Text = "Кашель";
				checkBox3.Text = "Болит горло";
				checkBox4.Text = "Заложен нос";
				checkBox5.Text = "Боль в ушах";
				checkBox6.Text = "Болит голова";
				checkBox7.Text = "Озноб";
				checkBox8.Text = "Жар";
				if (mas[6] == "1")
				{
					checkBox1.Checked = true;
				}
				if (mas[7] == "1")
				{
					checkBox2.Checked = true;
				}
				if (mas[8] == "1")
				{
					checkBox3.Checked = true;
				}
				if (mas[9] == "1")
				{
					checkBox4.Checked = true;
				}
				if (mas[10] == "1")
				{
					checkBox5.Checked = true;
				}
				if (mas[11] == "1")
				{
					checkBox6.Checked = true;
				}
				if (mas[12] == "1")
				{
					checkBox7.Checked = true;
				}
				if (mas[13] == "1")
				{
					checkBox8.Checked = true;
				}
				textBox_tmp.Text = mas[14];
			}
			else if (spec == "Гастроэнтеролог")
			{
				label1.Text = vivod;
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
				if (mas[6] == "1")
				{
					checkBox1.Checked = true;
				}
				if (mas[7] == "1")
				{
					checkBox2.Checked = true;
				}
				if (mas[8] == "1")
				{
					checkBox3.Checked = true;
				}
				if (mas[9] == "1")
				{
					checkBox4.Checked = true;
				}
				if (mas[10] == "1")
				{
					checkBox5.Checked = true;
				}
				if (mas[11] == "1")
				{
					checkBox6.Checked = true;
				}
				if (mas[12] == "1")
				{
					checkBox7.Checked = true;
				}
				if (mas[13] == "1")
				{
					checkBox8.Checked = true;
				}
				if (mas[14] == "1")
				{
					checkBox9.Checked = true;
				}
			}
		}
    }
}
