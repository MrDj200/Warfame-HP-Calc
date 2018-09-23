using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HP_Rechner_Shit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int life = int.Parse(numericUpDown1.Value.ToString());
            int armor = int.Parse(numericUpDown2.Value.ToString());
            int shield = int.Parse(numericUpDown3.Value.ToString());

            int chromaArmorBuff = int.Parse(numericUpDown4.Value.ToString());


            textBox1.Text = String.Format("{0:P2}", MathFuck.DmgReduction(armor));
            textBox2.Text = MathFuck.FakeLife(life, armor, shield).ToString("N0");

            double armorWithBuff = MathFuck.ArmorWithBuff(chromaArmorBuff, armor);

            textBox3.Text = armorWithBuff.ToString("N0");
            textBox4.Text = MathFuck.FakeLife(life, int.Parse(armorWithBuff.ToString()), shield).ToString("N0");
            textBox5.Text = String.Format("{0:P2}", MathFuck.DmgReduction(int.Parse(armorWithBuff.ToString())));


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Form1.ActiveForm.Opacity = trackBar1.Value / 100d;
            outputLabel6.Text = $"Opacity: {trackBar1.Value}%";
        }
    }
}
