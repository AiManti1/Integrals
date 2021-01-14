using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Calculus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Запретить изменение размеров окна Формы.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.StartPosition = FormStartPosition.CenterScreen;

            // Установить значок интеграла (Unicode 0x222B).
            label1.Text = Convert.ToString(Convert.ToChar(0x222B));

            // Установить значок радикала (Unicode 0x23B7).
            radioButton2.Text = Convert.ToString("(" + (Convert.ToChar(0x23B7)) + "kx + p" + ") dx");
            radioButton2.Font = new Font("Tahoma", 8, FontStyle.Regular);

            // Вызвать инициализацию модуля ZedGraph.
            InitZedGraph();
        }

        // Инициализировать модуль ZedGraph.
        private void InitZedGraph()
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            pane.YAxis.Title.Text = "Ось Y";
            pane.XAxis.Title.Text = "Ось X";
            pane.Title.Text = "График функции";
            pane.XAxis.Cross = 0.0;
            pane.YAxis.Cross = 0.0;
            pane.XAxis.Scale.IsSkipFirstLabel = true;
            pane.XAxis.Scale.IsSkipLastLabel = true;
            pane.XAxis.Scale.IsSkipCrossLabel = true;
            pane.YAxis.Scale.IsSkipFirstLabel = true;
            pane.YAxis.Scale.IsSkipLastLabel = true;
            pane.YAxis.Scale.IsSkipCrossLabel = true;
            pane.IsFontsScaled = false;
            pane.IsBoundedRanges = true;
            zedGraph.AxisChange();
        }

        // Защита от ввода некорректных данных в элементы TextBox.
        private void limA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back != (e.KeyChar == ',') != (e.KeyChar == '-'))
                {
                    e.Handled = true;
                }
            }
        }
        private void limB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back != (e.KeyChar == ',') != (e.KeyChar == '-'))
                {
                    e.Handled = true;
                }
            }
        }
        private void step_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back != (e.KeyChar == ',') != (e.KeyChar == '-'))
                {
                    e.Handled = true;
                }
            }
        }
        private void graphA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back != (e.KeyChar == ',') != (e.KeyChar == '-'))
                {
                    e.Handled = true;
                }
            }
        }
        private void graphB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back != (e.KeyChar == ',') != (e.KeyChar == '-'))
                {
                    e.Handled = true;
                }
            }
        }

        // Настройка placeholder для элементов TextBox.
        private void limA_Enter(object sender, EventArgs e)
        {
            if (limA.Text == "a")
            {
                limA.Text = "";
            }
        }
        private void limA_Leave(object sender, EventArgs e)
        {
            if (limA.Text == "")
            {
                limA.Text = "a";
                limA.ForeColor = Color.Gray;
            }
        }
        private void limB_Enter(object sender, EventArgs e)
        {
            if (limB.Text == "b")
            {
                limB.Text = "";
            }
        }
        private void limB_Leave(object sender, EventArgs e)
        {
            if (limB.Text == "")
            {
                limB.Text = "b";
                limB.ForeColor = Color.Gray;
            }
        }
        private void step_Enter(object sender, EventArgs e)
        {
            if (stepN.Text == "n")
            {
                stepN.Text = "";
            }
        }
        private void step_Leave(object sender, EventArgs e)
        {
            if (stepN.Text == "")
            {
                stepN.Text = "n";
                stepN.ForeColor = Color.Gray;
            }
        }
        private void k_Enter(object sender, EventArgs e)
        {
            if (k.Text == "k")
            {
                k.Text = "";
            }
        }
        private void k_Leave(object sender, EventArgs e)
        {
            if (k.Text == "")
            {
                k.Text = "k";
                k.ForeColor = Color.Gray;
            }
        }
        private void p_Enter(object sender, EventArgs e)
        {
            if (p.Text == "p")
            {
                p.Text = "";
            }
        }
        private void p_Leave(object sender, EventArgs e)
        {
            if (p.Text == "")
            {
                p.Text = "p";
                p.ForeColor = Color.Gray;
            }
        }

        // Подынтегральные функции.
        double f1(double x)
        {
            return 1 / Math.Log(x);
        }
        double f2(double x)
        {
            double k1 = Convert.ToDouble(k.Text);
            double p1 = Convert.ToDouble(p.Text);
            if (x > 0)
            {
                return Math.Sqrt(k1 * x) + p1;
            }
            else
            {
                return 0;
            }
        }
        double f3(double x)
        {
            double k1 = Convert.ToDouble(k.Text);
            double p1 = Convert.ToDouble(p.Text);

            return (k1 * x) + (p1 * x);
        }
        double f4(double x)
        {
            double k1 = Convert.ToDouble(k.Text);
            double p1 = Convert.ToDouble(p.Text);
            if (p1 != 0)
            {
                return Math.Sin(Math.Pow(x, k1)) / p1;
            }
            else
            {
                return 0;
            }
        }

        // Внешняя переменная для грфика, равная количесву шагов n из функции вычисления интеграла.
        double s; 

        // Вычислить определенный интеграл методом прямоугольников.
        private void btCalculate_Click(object sender, EventArgs e)
        {
            try
            {                       
                double  a, b,          // Пределы интегрирования.                      
                        n,             // Количество отрезков разбиения.                        
                        h,             // Шаг.              
                        x,             // Середина шага (орезка деления).                          
                        sum = 0;       // Интегральная сумма (используется для построения графика, как набор точек по оси X).

                a = Convert.ToDouble(limA.Text);        
                b = Convert.ToDouble(limB.Text);        
                n = Convert.ToDouble(stepN.Text);
                s = n;

                if (b > a && n > 0)
                { 
                    h = (b - a) / n;                  
                    x = a + h * 0.5; 
                    if (radioButton1.Checked)
                    {
                        if (a > 0)
                        {
                            while (x <= b)
                            {
                                sum += f1(x) * h;
                                x += h;
                            }
                        }
                        else MessageBox.Show("Неверный нижний предел интегрирования (ln(x), x > 0)", "Ошибка.");
                    }
                    if (radioButton2.Checked)
                    {
                         if (f2(x) > 0)
                         {
                           while (x <= b)
                           {
                                sum += f2(x) * h;
                                x += h;
                           }
                         }
                            else MessageBox.Show("Невозможно извлечь корень из отрицательного числа.", "Ошибка");
                    }
                    if (radioButton3.Checked)
                    {
                        while (x <= b)
                        {
                            sum += f3(x) * h;
                            x += h;
                        }
                    }
                    if (radioButton4.Checked)
                    {
                            while (x <= b)
                            {
                            sum += f4(x) * h;
                            x += h;
                            }
                    }
                    result.Text = "Ответ: " + sum.ToString();                  
                }
                else MessageBox.Show("Проверьте правильность ввода данных.", "Ошибка.");
            }
            catch
            {
                MessageBox.Show("Введие данные.", "Ошибка.");
            }
        }

        // Построить график.
        private void btGraph_Click(object sender, EventArgs e)
        {
            try
            {
                if (s != 0)
                {
                    // Получить панель для рисования.
                    GraphPane pane = zedGraph.GraphPane;
                    // Очистить список кривых, если до этого сигналы уже были нарисованы.
                    pane.CurveList.Clear();
                    // Создать список точек.
                    PointPairList list = new PointPairList();
                    // Создать кривую с названием "Curv" красного цвета (Color.Red),
                    // опорные точки - круги (SymbolType.Circle).
                    LineItem myCurve = pane.AddCurve("Curv", list, Color.Red, SymbolType.Circle);
                    myCurve.Line.Fill = new Fill(Color.Aquamarine);
                    double a = Convert.ToDouble(limA.Text);
                    double b = Convert.ToDouble(limB.Text);
                    double h = (b - a) / s;
                    // Добавить точки в список.
                    for (double x = a; x <= b; x += h)
                    {
                        if (radioButton1.Checked)
                        {
                            list.Add(x, f1(x));
                        }
                        if (radioButton2.Checked)
                        {
                            list.Add(x, f2(x));
                        }
                        if (radioButton3.Checked)
                        {
                            list.Add(x, f3(x));
                        }
                        if (radioButton4.Checked)
                        {
                            list.Add(x, f4(x));
                        }
                    }
                    // Вызвать метод AxisChange, чтобы обновить данные об осях. 
                    // В противном случае, на рисунке будет показана только часть графика, 
                    // которая умещается в интервалы по осям, установленные по умолчанию.
                    zedGraph.AxisChange();
                    // Обновить график.
                    zedGraph.Invalidate();
                }
                else MessageBox.Show("Необходимо решить интеграл.", "Ошибка.");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных.", "Ошибка.");
            }
        }

        // Открыть форму "О программе".
        private void btAbout_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        // Выйти из приложения.
        private void btExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
