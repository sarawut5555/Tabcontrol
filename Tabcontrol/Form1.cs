using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabcontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string WebPage = txtAddress.Text.Trim();

            webBrowser1.Navigate(WebPage);
            tabPage2.Text = WebPage;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnBack, "Back one page");
            if(webBrowser1.CanGoBack)
            { 
                webBrowser1.GoBack(); 
            }
        }
        private void btnForward_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnForward, "Forward one page");
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn, "Go To Home");
            if (webBrowser1.IsBusy)
            {
                webBrowser1.GoHome();
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnStop, "Stop to Load Page");
            if (webBrowser1.IsBusy)
            {
                webBrowser1.Stop();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnStop, "Refresh to Page");
            webBrowser1.Refresh();
        }
    }
}
