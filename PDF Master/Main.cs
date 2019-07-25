using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using split = PDF_Split;
using merge = PDFmerge;
using convert = PDFConverter;
using protect = PDFProtector;
using SchuffSharp;

namespace PDF_Master
{
    public partial class Main : Form
    {

        split.Main SplitForm = new split.Main();
        merge.Main MergeForm = new merge.Main();
        convert.Main ConvertForm = new convert.Main();
        protect.Main Protectform = new protect.Main();        

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            ConvertForm.Show();
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            SplitForm.Show();
        }

        private void BtnMerge_Click(object sender, EventArgs e)
        {
            MergeForm.Show();
        }

        private void BtnProtect_Click(object sender, EventArgs e)
        {
            Protectform.Show();
        }


    }
}
