using System;
using System.Windows.Forms;

namespace Calculus
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();

            // Запретить изменение размеров окна Формы.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.Show();
        }
    }
}
