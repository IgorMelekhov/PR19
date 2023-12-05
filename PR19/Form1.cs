using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void вычислитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Date1.Clear();
            textBox_Date2.Clear();
            textBox_Result1.Clear();
        }

        private void textBox_Date1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox_Date1, "Введите число!");
        }
        private void textBox_Result1_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox_Result1, "Сюда будет введен результат");
        }

        private void textBox_Date2_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox_Date2, "Введите число!");
        }

        private void btn_Math1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_Math1, "Выполнить расчет");
        }

        private void btn_Close1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_Close1, "Выход из приложения");
        }

        private void btn_Math1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    Double m, n, x;
                    m=Convert.ToDouble(textBox_Date1.Text);
                    if (m == 0)
                    {
                        MessageBox.Show("Деление на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox_Date1.Clear();
                        textBox_Result1.Clear();
                    }
                    n = Convert.ToDouble(textBox_Date2.Text);
                    if (n == 0)
                    {
                        MessageBox.Show("Деление на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox_Date1.Clear();
                        textBox_Result1.Clear();
                    }
                    Double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24;
                    v1 = m * n;
                    v2 = Math.Pow(v1, 2);
                    v3 = Math.Pow(v2, 1 / 3.0);
                    v4 = Math.Pow(m, 2);
                    v5 = v4 * n;
                    v6 = Math.Pow(v5, 1 / 3.0);
                    v7 = v6 + v3; 
                    v8 = Math.Pow(v4, 1 / 3.0);
                    v9 = Math.Pow(v1, 1 / 3.0);
                    v10 = v9 * 2;
                    v11 = Math.Pow(n, 2);
                    v12 = Math.Pow(v11, 1 / 3.0);
                    v13 = v12 + v10 + v8; 
                    v14 = v7 / v13; 
                    v15 = Math.Pow(n, 1 / 3.0);
                    v16 = v15 * 2;
                    v17 = Math.Abs(m - n);
                    v18 = v8 - v12;
                    v19 = v17 / v18;
                    v20 = v14 - v16 + v19; 
                    v21 = Math.Pow(m, 1 / 6.0);
                    v22 = Math.Pow(n, 1 / 6.0);
                    v23 = v21 + v22;
                    v24 = 1 / v23;
                    x = v20 * v24;
                    x=Math.Round(x,3, MidpointRounding.AwayFromZero);
                    textBox_Result1.Text = x.ToString();
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Date1.Clear();
                    textBox_Result1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Date1.Clear();
                textBox_Result1.Clear();
            };
        }

        private void программаРасчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Math1_Click(sender, e);
        }

    }
}
