using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace BubbleSorteGraphics
{
    public partial class Form1 : Form
    {
        Thread thread;
        static List<int> numeros = new List<int>();
        static List<int> numbers = new List<int>();
        public static int valor;
        Stopwatch stopwatch = new Stopwatch();
        System.Windows.Forms.Timer time;
        Random random = new Random();
        Series series;
        int selectNumber = 0, numberChecked = 1;
        bool finished;

        public Form1()
        {
            InitializeComponent();
            time = new System.Windows.Forms.Timer();
        }
        void BubbleSort(List<int> numeros)
        {
            for (int i = 0; i < numeros.Count; i++)
            {
                for (int k = i + 1; k < numeros.Count; k++)
                {
                    if (numeros[i] > numeros[k])
                    {
                        int temp = numeros[i];
                        numeros[i] = numeros[k];
                        numeros[k] = temp;
                    }
                }
            }

        }
        void BubbleSortWrite()
        {
            if (selectNumber < numbers.Count - numberChecked)
            {

                if (numbers[selectNumber] > numbers[selectNumber + 1])
                {
                    int saveNumber = numbers[selectNumber];
                    int saveLocal = selectNumber;
                    numbers[selectNumber] = numbers[selectNumber + 1];
                    numbers[selectNumber + 1] = saveNumber;

                    selectNumber++;
                }
                else
                {
                     selectNumber++;
                }
            }

            else
            {

                if (finished)
                    time.Stop();

                selectNumber = 0;

                numberChecked++;

                if (numberChecked >= numbers.Count)
                {
                    numberChecked = 1;
                    finished = true;
                }
            }
        }
        public void InitTimer()
        {
            time = new System.Windows.Forms.Timer();

            time.Tick += new EventHandler(timer1_Tick_1);
            time.Interval = 1;


            time.Start();
        }


        static bool NoRepeat(int item)
        {

            if (!numeros.Contains(item))
            {

                numeros.Add(item);
                return false;
            }
            else
            {
                return true;
            }


        }
        static bool NoRepeatWrite(int item)
        {

            if (!numbers.Contains(item))
            {

                numbers.Add(item);
                return false;
            }
            else
            {
                return true;
            }


        }
        void GerarGrafico()
        {
            this.Invoke(new MethodInvoker(() =>
            {

                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[0].Points.Clear();
            }));
            for (int i = 10; i < 2000; i += 5)
            {
                numeros.Clear();
                for (int j = 0; j < i; j++)
                {
                    NoRepeat(random.Next(0, 3000));
                }
                stopwatch.Restart();
                BubbleSort(numeros);
                stopwatch.Stop();
                this.Invoke(new MethodInvoker(() =>
                {
                    chart1.Series[0].Points.AddXY(i, stopwatch.Elapsed.TotalMilliseconds);
                }));


            }
        }
        private void GerarGraficoQuantVsTempo_Click(object sender, EventArgs e)
        {
            thread = new Thread(GerarGrafico);
            thread.IsBackground = true;
            thread.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            BubbleSortWrite();
            Write();
        }

        private void GerarNumeros_Click(object sender, EventArgs e)
        {
            finished = false; numberChecked = 1; selectNumber = 1;
            chart2.Series.Clear();
            numbers.Clear();
            for (int i = 10; i < 2000; i += 5)
            {
                chart2.Series.Clear();
                valor = random.Next(0, 3000);
                NoRepeat(valor);
                NoRepeatWrite(valor);
            }
            if (time.Enabled)
                time.Stop();
                chart2.Series.Clear();

            for (int i = 0; i < numbers.Count; i++)
            {
                series = this.chart2.Series.Add(i.ToString());
                series.Points.Add(numbers[i]);
                series.IsVisibleInLegend = false;
            }
            InitTimer();
        }

        private void Desenho_Click(object sender, EventArgs e)
        {

                finished = false; numberChecked = 1; selectNumber = 1;

                if (time.Enabled)
                time.Stop();
                 chart2.Series.Clear();
             for (int i = 0; i < numbers.Count; i++)
            {
                series = this.chart2.Series.Add(i.ToString());
                series.Points.Add(numbers[i]);
                series.IsVisibleInLegend = false;
            }
            InitTimer();
        }

        void Write()
        {
            chart2.Series.Clear();

            for (int i = 0; i < numbers.Count; i++)
            {
                series = this.chart2.Series.Add(i.ToString());
                series.Points.Add(numbers[i]);
                series.IsVisibleInLegend = false;
                if (finished && i < selectNumber)
                    series.Color = Color.Lime;

                if (i.Equals(selectNumber))
                {
                    series.Color = Color.Red;
                }
            }

        }
    }
}
