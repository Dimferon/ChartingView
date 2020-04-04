using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartingView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Добавление точки данных
            chart1.Series[0].Points.AddY(20);
            chart1.Series[0].Points.AddY(20);

            //Добавление подписи к 0 точке серии
            chart1.Series[0].Points[0].Label= "20";
        }
    }
}
