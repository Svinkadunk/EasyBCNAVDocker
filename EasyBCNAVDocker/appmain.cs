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
using System.Management.Automation;
using System.Text.RegularExpressions;

namespace EasyBCNAVDocker
{
    public partial class main : Form
    {
        Point advancedConst = new Point(50, 0);

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
            CreateContainer();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private Boolean CheckNAVContainerHelper()
        {
            return RunProcess("powershell.exe", "/C get-installedmodule navcontainerhelper", true);
        }

        private Boolean CheckDocker() 
        {
            return RunProcess("CMD.exe", "/C docker -v", true);
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

        private void CreateContainer()
        {
            //dummy username and password
            System.Security.SecureString password = new System.Security.SecureString();
            string dummypw = "password";
            Array.ForEach(dummypw.ToArray(), password.AppendChar);
            PSCredential credential = new PSCredential("admin",password);

            PowerShell ps = PowerShell.Create();
            ps.AddCommand("New-BCContainer");
            ps.AddParameter("-accept_eula");
            ps.AddParameter("-containerName",containerName());
            ps.AddParameter("-imageName", dockerImage());
            ps.AddParameter("-auth", "NavUserPassword");
            ps.AddParameter("-Credential", credential);
            Regex rx = new Regex("^.*(.bak)$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (rx.IsMatch(txtBoxDatabase.Text))
            {
                ps.AddParameter("-bakFile", txtBoxDatabase.Text);
            }
            try
            {
                ps.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            string containerName()
            {
                //regex på containername
                //if regex check = valid then
                return txtBoxContainerName.Text;
            }

            string dockerImage()
            {
                string dockerImageString = "No image chosen";
                Boolean chooseApp = false;
                switch (cbImageSelector.Text)
                {
                    case "":
                        lblNotificationTxt.Text = "You must choose a base app.";
                        pnlNotification.Visible = true;
                        chooseApp = true;
                        break;
                    case "Business Central On-premises":
                        dockerImageString = "\"mcr.microsoft.com/businesscentral/onprem\"";
                        break;
                    case "Business Central Cloud":
                        dockerImageString = "\"mcr.microsoft.com/businesscentral/sandbox\"";
                        break;
                    case "NAV":
                        dockerImageString = "\"microsoft/dynamics-nav\"";
                        break;
                    default:
                        dockerImageString = "\"mcr.microsoft.com/businesscentral/sandbox\"";
                        break;
                }
                //create version tag (combination of localization and version)
                if (!chooseApp)
                {
                    pnlNotification.Visible = false;
                    pullImage(dockerImageString);
                }
                return dockerImageString;

                void pullImage(string imageString)
                {
                    RunProcess("CMD.exe", "/C docker pull " + imageString, false);
                }
            }
        }

        private Boolean RunProcess(string FileNameParam, string ArgumentsParam, bool Hidden)
        {
            Process process = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo
            {
                FileName = FileNameParam,
                Arguments = ArgumentsParam
            };
            if (Hidden)
            {
                startinfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            process.StartInfo = startinfo;
            return (process.Start());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            var advancedForm = new Advanced();
            advancedForm.StartPosition = FormStartPosition.Manual;
            advancedForm.Location = new Point(this.Location.X + this.Size.Width + advancedConst.X, this.Location.Y + advancedConst.Y);
            advancedForm.Show();
        }
    }
}

//Functionality to build:
//Remove containers (pop-up where you can choose which container to remove)
//Advanced setup (container parameters)
//Import extensions to container
//Backup database from container
//Add test toolkit
//Clean up unused images
//Overview of containers