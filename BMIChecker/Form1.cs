using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIChecker
{
    public partial class FormBMIChecker : Form
    {
        double normalWeight;

        public FormBMIChecker()
        {
            InitializeComponent();
            標準体重SToolStripMenuItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcBMI();
        }

        private void clearResult()
        {
            MessageBox.Show("数値を入力してください。", "入力エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            textBoxBMI.Text = "";
            textBoxJudgment.Text = "";
        }
        private void calcBMI()
        {
            double weight, height;

            try
            {
                height = Convert.ToDouble(textBoxHeight.Text) / 100;    // 「cm」を「m」に変換
            }
            catch
            {
                clearResult();
                textBoxHeight.Text = "";
                return;
            }

            try
            {
                weight = Convert.ToDouble(textBoxWeight.Text);
            }
            catch
            {
                clearResult();
                textBoxWeight.Text = "";
                return;
            }

            double bmi = weight / (height * height);
            normalWeight = 22.0 * height * height;
            textBoxBMI.Text = string.Format("{0:0.0}", bmi);
            if (bmi < 18.5)
            {
                textBoxJudgment.Text = "低体重";
            }
            else if (bmi <= 25.0)
            {
                textBoxJudgment.Text = "普通体重";
            }
            else
            {
                textBoxJudgment.Text = "肥満";
            }
            標準体重SToolStripMenuItem.Enabled = true;
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bMI計算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calcBMI();
        }

        private void 入力クリアNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearResult();
            textBoxHeight.Text = "";
            textBoxWeight.Text = "";
            textBoxHeight.Focus();
        }

        private void 標準体重SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("標準体重は" + string.Format("{0:0.0}",normalWeight) + "Kgです","Normal Weight",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
