using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace KalkulatorRat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime Data { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Task.Factory.StartNew(() =>
            {
                var result = client.GetAsync(@"http://wibor3m.pl");
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                result.Wait();
                var str = result.Result.Content.ReadAsStringAsync();
                str.Wait();
                doc.LoadHtml(str.Result);
                var item = doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[2]/div[1]/div[2]/div[2]");
                //var item = doc.DocumentNode.SelectNodes("//*[@class=\"value\"]");
                var value = item.InnerText.Trim('\r', '\n', ' ', '%');

                Invoke((MethodInvoker) delegate { ActualWibor.Text = value.ToString(); });
            });

            Data = DateTime.Today;
            DateBox.Text = Data.ToShortDateString();
            DateFirstBox.Value = new DateTime(2016, 10, 10);
        }

        private void ActualWibor_TextChanged(object sender, EventArgs e)
        {
            double wibor = 0;
            double procent = 0;

            if(double.TryParse(ActualWibor.Text, out wibor) && double.TryParse(ProcentBox.Text, out procent))
            {
                SumProcentBox.Text = (wibor + procent).ToString();
            }else
            {
                SumProcentBox.Text = "";
            }
        }

        private void ProcentBox_TextChanged(object sender, EventArgs e)
        {
            ActualWibor_TextChanged(sender, e);
        }

        Dictionary<int, double> listaRat = new Dictionary<int, double>();

        private void ObliczBtn_Click(object sender, EventArgs e)
        {
            double kwota = double.Parse(KwotaBox.Text);
            int ileRat = int.Parse(IleRatBox.Text);
            double procent = double.Parse(SumProcentBox.Text) / 100;

            double rataBezProc = kwota / ileRat;

            int numerRaty = ((Data.Year - DateFirstBox.Value.Year) * 12 + (Data.Month - DateFirstBox.Value.Month)) + 1;

            double kwotaTmp = kwota;
            double rata = 0;

            for( int i = 0; i < numerRaty; i++)
            {
                rata = ((kwotaTmp * procent) / 12) + rataBezProc;
                kwotaTmp -= rataBezProc;
            }

            WynikBox.Text = rata.ToString();
            numerRatyBox.Text = numerRaty.ToString();

            kwotaTmp = kwota;
            rata = 0;
            listaRat.Clear();
            for(int i = 0; i < ileRat; i++)
            {
                rata = ((kwotaTmp * procent) / 12) + rataBezProc;
                kwotaTmp -= rataBezProc;
                listaRat.Add(i + 1, rata);
            }

            PokazRaty.Enabled = true;
        }

        private void PokazRaty_Click(object sender, EventArgs e)
        {
            ListaRat lista = new ListaRat(listaRat);
            lista.ShowDialog();
        }
    }
}
