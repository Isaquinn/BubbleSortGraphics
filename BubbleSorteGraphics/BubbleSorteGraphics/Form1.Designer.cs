namespace BubbleSorteGraphics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GerarGraficoQuantVsTempo = new System.Windows.Forms.Button();
            this.GerarNumeros = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // GerarGraficoQuantVsTempo
            // 
            this.GerarGraficoQuantVsTempo.Location = new System.Drawing.Point(452, 43);
            this.GerarGraficoQuantVsTempo.Name = "GerarGraficoQuantVsTempo";
            this.GerarGraficoQuantVsTempo.Size = new System.Drawing.Size(300, 23);
            this.GerarGraficoQuantVsTempo.TabIndex = 0;
            this.GerarGraficoQuantVsTempo.Text = "Gerar Gráfico - Quantidade X Tempo";
            this.GerarGraficoQuantVsTempo.UseVisualStyleBackColor = true;
            this.GerarGraficoQuantVsTempo.Click += new System.EventHandler(this.GerarGraficoQuantVsTempo_Click);
            // 
            // GerarNumeros
            // 
            this.GerarNumeros.Location = new System.Drawing.Point(28, 43);
            this.GerarNumeros.Name = "GerarNumeros";
            this.GerarNumeros.Size = new System.Drawing.Size(300, 23);
            this.GerarNumeros.TabIndex = 1;
            this.GerarNumeros.Text = "DemosntraçãoBubbleSort";
            this.GerarNumeros.UseVisualStyleBackColor = true;
            this.GerarNumeros.Click += new System.EventHandler(this.GerarNumeros_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(452, 85);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "QuantidadeXTempo";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(28, 85);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "DemostracaoBubbleSort";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 397);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.GerarNumeros);
            this.Controls.Add(this.GerarGraficoQuantVsTempo);
            this.Name = "Form1";
            this.Text = "BubbleSort";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GerarGraficoQuantVsTempo;
        private System.Windows.Forms.Button GerarNumeros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

