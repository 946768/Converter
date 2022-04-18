using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Конвектер: Form
    {
        public Конвектер()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxFrom.Text == "")
            {
                MessageBox.Show("Введите валюту!");
            }
            else
            {


                double kzt = 0.0, eur = 0.0, rub = 0.0, usd = 0.0, from;
                from = Double.Parse(textBoxFrom.Text);

                string operatorFrom = comboBoxFrom.Text;
                string operatorTo = comboBoxTo.Text;

                switch (operatorFrom)
                {
                    case "USD":
                        kzt = 449.64;
                        eur = 0.91979;
                        rub = 79.63;
                        usd = 1.0;
                        break;
                    case "EUR":
                        kzt = 490.06;
                        eur = 1.0;
                        rub = 86.79;
                        usd = 1.09;
                        break;
                    case "RUB":
                        kzt = 5.65;
                        eur = 0.011522;
                        rub = 1.0;
                        usd = 0.012558;
                        break;
                    case "KZT":
                        kzt = 1.0;
                        eur = 0.002039;
                        rub = 0.1771;
                        usd = 0.002224;
                        break;
                }
                switch (operatorTo)
                {
                    case "USD":
                        textBoxTo.Text = Convert.ToString(from * usd);
                        break;
                    case "EUR":
                        textBoxTo.Text = Convert.ToString(from * eur);
                        break;
                    case "RUB":
                        textBoxTo.Text = Convert.ToString(from * rub);
                        break;
                    case "KZT":
                        textBoxTo.Text = Convert.ToString(from * kzt);
                        break;
                }
            }

        }

        

    }
}
