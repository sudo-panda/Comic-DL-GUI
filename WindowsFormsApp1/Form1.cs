using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string FolName;

        public Form1()
        {
            InitializeComponent();
            comic_dl();
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            picBox.Visible = true;
            Pass.PasswordChar = '*';
            MakeVis(true);
            EnableI(false);
            EnableI(true);
        }

        private void HideP()
        {
            Thread.Sleep(5000);
            label11.Visible = false;
            label12.Visible = false;
            picBox.Visible = false;
        }

        private void MakeVis(bool v)
        {
            label1.Visible = v;
            label2.Visible = v;
            label3.Visible = v;
            label4.Visible = v;
            label5.Visible = v;
            label6.Visible = v;
            label7.Visible = v;
            label8.Visible = v;
            label9.Visible = v;
            label10.Visible = v;
            Link.Visible = v;
            From.Visible = v;
            To.Visible = v;
            DD.Visible = v;
            UName.Visible = v;
            Pass.Visible = v;
            None.Visible = v;
            PDF.Visible = v;
            Delete.Visible = v;
            Start.Visible = v;
            Browse.Visible = v;
        }

        private void comic_dl()
        {
            if(!File.Exists("comic_dl.exe"))
            {
                MessageBox.Show("comic-dl.exe must be present in the the same folder as the GUI" + Environment.NewLine + "Program will now exit", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult dr = foldD.ShowDialog();

            if (dr == DialogResult.OK || dr == DialogResult.Yes)
            {
                FolName = foldD.SelectedPath;

                if(!FolName.EndsWith("\\"))
                {
                    FolName = FolName + "\\";
                }

                DD.Text = FolName;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Pass.Text);
            if(Link.Text != null && Link.Text != "http://")
            {
                RunComic();
            }
            else
            {
                MessageBox.Show("Required fields not filled in","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                label1.ForeColor = Color.Red ;
            }
        }

        public static string getHomePath()
        {
            // Not in .NET 2.0
            // System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (System.Environment.OSVersion.Platform == System.PlatformID.Unix)
                return System.Environment.GetEnvironmentVariable("HOME");

            return System.Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
        }

        public static string getDownloadFolderPath()
        {
            if (System.Environment.OSVersion.Platform == System.PlatformID.Unix)
            {
                string pathDownload = System.IO.Path.Combine(getHomePath(), "Downloads");
                return pathDownload;
            }

            return System.Convert.ToString(
                Microsoft.Win32.Registry.GetValue(
                     @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders"
                    , "{374DE290-123F-4565-9164-39C4925E467B}"
                    , String.Empty
                )
            );
        }

        private void RunComic()
        {

            string a = "-i \"" + Link.Text + "\"";
            if(From.Text != "" || To.Text != "")
            {
                a = "-rn " + From.Text + "-" + To.Text + " " + a;
            }
            if(DD.Text != "")
            {
                a = "-dd \"" + DD.Text + "\" " + a;
            }
            else
            {
                FolName = getDownloadFolderPath();
                a = "-dd \"" + FolName + "\" " + a;
            }
            if(UName.Text != "" || Pass.Text != "")
            {
                a = "-u " + UName.Text + " -p " + Pass.Text + " " + a;
            }
            if(!None.Checked)
            {
                if(Delete.Checked)
                {
                    a = "--keep False" + a;
                }
                if(PDF.Checked)
                {
                    a = "--convert pdf" + a;
                }
            }
            

            if(File.Exists("comic_dl.exe"))
            {
                Console.WriteLine(a);
                ExecuteCommandSync("comic_dl.exe " + a);
            }
            else
            {
                comic_dl();
            }
        }
        
        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comic-DL" + Environment.NewLine + "by Xonshiz" + Environment.NewLine + Environment.NewLine + "Visit the github page: " + Environment.NewLine + "https://github.com/Xonshiz/comic-dl " + Environment.NewLine + Environment.NewLine + "GUI made by Baidyanath", "Comic - DL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ExecuteCommandSync(object command)
        {
            try
            {
                Boolean success = false;

                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                
                procStartInfo.CreateNoWindow = true;
                
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                EnableI(false);
                
                if(File.Exists("log.txt"))
                {
                    File.Delete("log.txt");
                }

                StreamWriter sw = File.CreateText("log.txt");

                string standard_output;
                while ((standard_output = proc.StandardOutput.ReadLine()) != null)
                {
                    if(standard_output.Contains("/") && standard_output.Contains("-"))
                    {
                        int Num = Convert.ToInt32(standard_output.Substring(standard_output.IndexOf("]") + 1, standard_output.IndexOf("/") - standard_output.IndexOf(":") - 1));
                        int Den = Convert.ToInt32(standard_output.Substring(standard_output.IndexOf("/") + 1, standard_output.IndexOf("-") - standard_output.IndexOf(":") - 1));
                        Console.WriteLine(Num + " " + Den);
                    }
                    if(standard_output.Contains("Manga Name"))
                    {
                        MName.Text = (standard_output.Substring(standard_output.IndexOf(":") + 1, standard_output.Length - standard_output.IndexOf(":") - 1)).Trim();
                    }
                    if(standard_output.Contains("Chapter"))
                    {
                        INo.Text = (standard_output.Substring(standard_output.IndexOf("-") + 1, standard_output.Length - standard_output.IndexOf("-") - 1)).Trim();
                    }
                    if(standard_output.Contains("Downloading") && standard_output.IndexOf(":") != -1)
                    {
                        PNo.Text = (standard_output.Substring(standard_output.IndexOf(":") + 1, standard_output.Length - standard_output.IndexOf(":") - 1)).Trim();
                    }
                    if(standard_output.Contains("Finished"))
                    {
                        success = true;
                    }
                    Console.WriteLine(standard_output);
                    sw.WriteLine(standard_output);
                }
                if(success)
                {
                    MessageBox.Show("Finished Downloading" + Environment.NewLine + MName.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Some Error occured!!" + Environment.NewLine + "Please Try Again." + Environment.NewLine + "Check Log file for errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                EnableI(true);
            }
            catch (Exception objException)
            {
                Console.WriteLine(objException);
            }
        }

        private void EnableI(bool v)
        {
            Link.Enabled = v;
            DD.Enabled = v;
            From.Enabled = v;
            To.Enabled = v;
            Browse.Enabled = v;
            None.Enabled = v;
            PDF.Enabled = v;
            UName.Enabled = v;
            Pass.Enabled = v;
            Start.Enabled = v;
            label1.ForeColor = Color.White;
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            picBox.Visible = false;
        }
    }
}
