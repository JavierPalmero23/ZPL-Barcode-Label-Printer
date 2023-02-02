using Microsoft.Win32.SafeHandles;
using System.Drawing.Printing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Print();
        }
        private void Print()
        {
            try
            {
                string clase = Clase.Text;
                string lote = Lote.Text;
                string fecha = Fecha.Text;
                string huerta = Huerta.Text;
                var sb = new StringBuilder();
                PrintDialog pd = new PrintDialog();
                pd.PrinterSettings= new System.Drawing.Printing.PrinterSettings();
                sb.AppendLine();
                sb.AppendLine("^XA");
                sb.AppendLine("^CFA,20");
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "^FO50,10^FDClase: "+clase+"^FS"));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "^FO50,30^FDFolio: "+lote+"^FS"));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "^FO50,50^FDFecha: " + fecha + "^FS"));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "^FO50,70^FDHuerto: " + huerta + "^FS"));
                sb.AppendLine("^BY2,2,70");
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "^FO50,90^BC^FD"+lote+"^FS"));
                sb.AppendLine("^XZ");
                sb.AppendLine();
                if (DialogResult.OK == pd.ShowDialog(this))
                {
                    RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, sb.ToString());

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Print Error"+ex.Message);
            }


        }

        private void imprimir2_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += PrintPicture;
            pd.Document = pDoc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                pDoc.Print();
            }
        }

        private void PrintPicture(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(ValorBC.Text, 50);
        }
    }
}