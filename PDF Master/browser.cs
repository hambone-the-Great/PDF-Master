using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;


namespace PDF_Master
{
    public partial class browser : Form
    {
        public browser()
        {
            InitializeComponent();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            NavigateTo(@"content\about.htm");
        }

        private void NavigateTo(string path)
        {
            string rawUrl = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), path);
            Uri url = new Uri(rawUrl);
            browserCtrl.Url = url; 
        }

    }
}
