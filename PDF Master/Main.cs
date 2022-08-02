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
using rotate = PDF_Rotate;

namespace PDF_Master
{
    public partial class Main : Form
    {

        split.PDF_Split_Main SplitForm;
        merge.Merge_Main MergeForm;
        convert.Main ConvertForm;
        protect.Main Protectform;
        rotate.PDF_Rotate_Main RotateForm;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
                        
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            ConvertForm = new convert.Main();
            ConvertForm.Show();
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            SplitForm = new split.PDF_Split_Main();
            SplitForm.Show();
        }

        private void BtnMerge_Click(object sender, EventArgs e)
        {
            MergeForm = new merge.Merge_Main();
            MergeForm.Show();
        }

        private void BtnProtect_Click(object sender, EventArgs e)
        {
            Protectform = new protect.Main();
            Protectform.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser frm = new browser();
            frm.Show(); 
        }

        private void BtnRotate_Click(object sender, EventArgs e)
        {
            RotateForm = new rotate.PDF_Rotate_Main();
            RotateForm.Show();
        }
    }
}
