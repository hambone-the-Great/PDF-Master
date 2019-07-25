using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDFConverter;
using PDF_Split;
using PDFmerge;
using PDFProtector;
using SchuffSharp;

namespace PDF_Master
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            PDFConverter.Form1 frm = new PDFConverter.Form1();
            frm.Show();
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            PDF_Split.Main frm = new PDF_Split.Main();
            frm.Show(); 
        }

        private void BtnMerge_Click(object sender, EventArgs e)
        {
            PDFmerge.Main frm = new PDFmerge.Main();
            frm.Show();
        }

        private void BtnProtect_Click(object sender, EventArgs e)
        {
            PDFProtector.PdfProtector frm = new PdfProtector();
            frm.Show();
        }
    }
}
