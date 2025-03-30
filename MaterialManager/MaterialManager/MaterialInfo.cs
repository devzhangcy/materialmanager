using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialManager
{
    public partial class MaterialInfo : Form
    {
        public MaterialInfo()
        {
            InitializeComponent();
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            labelContent.Text = time;
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            labelContent.Text = time;
        }
    }
}
