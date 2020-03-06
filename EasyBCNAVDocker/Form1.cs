using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//BCNAV
using System.Diagnostics;

namespace EasyBCNAVDocker
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            lblNotificationTxt.Text = "";
            if (!CheckNAVContainerHelper())
            {
                lblNotificationTxt.Text += "NavContainerHelper is not installed!    ";
                pnlNotification.Visible = true;
            }
            if (!CheckDocker())
            {
                lblNotificationTxt.Text += "Docker is not installed!";
                pnlNotification.Visible = true;
            }
        }

        private void btnCreateContainer_Click(object sender, EventArgs e)
        {
            
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private Boolean CheckNAVContainerHelper()
        {
            Process process = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.WindowStyle = ProcessWindowStyle.Hidden;
            startinfo.FileName = "powershell.exe";
            startinfo.Arguments = "/C get-installedmodule navcontainerhelper";
            process.StartInfo = startinfo;
            return (process.Start());
        }

        private Boolean CheckDocker() 
        {
            Process process = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.WindowStyle = ProcessWindowStyle.Hidden;
            startinfo.FileName = "CMD.exe";
            startinfo.Arguments = "/C docker -v";
            process.StartInfo = startinfo;
            return(process.Start());
        }

        private void txtBoxDatabase_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult result = fdlgDatabase.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = fdlgDatabase.FileName;
                txtBoxDatabase.Text = file;
            }
        }
    }
}
