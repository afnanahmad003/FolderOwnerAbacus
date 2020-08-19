using FolderOwnerAbacus.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderOwnerAbacus
{
    public partial class Main : Form
    {
        private delegate void DAddLog(string Log);
        private int topACL = 0;
        private int topActivity = 0;

        public Main()
        {


            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dgvACLScore.RowTemplate.Height = 70;
			dgvActivity.RowTemplate.Height = 70;
            dgvSuggestedOwner.RowTemplate.Height = 70;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //if (tbUNCPath .Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input UNC Path.");
                //    tbUNCPath.Focus();
                //    return;
                //}
                //if (tbDomainName.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input domain name.");
                //    tbDomainName.Focus();
                //    return;
                //}
                //if (tbUsername.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input username.");
                //    tbUsername.Focus();
                //    return;
                //}
                //if (tbPassword.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input password.");
                //    tbPassword.Focus();
                //    return;
                //}
                //if (txtACLTopRecords.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input ACL top records.");
                //    txtACLTopRecords.Focus();
                //    return;
                //}
                //if (txtActivityTopRecords.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Activity top records.");
                //    txtActivityTopRecords.Focus();
                //    return;
                //}
                //if (tbReadData.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Read Data.");
                //    tbReadData.Focus();
                //    return;
                //}
                //if (tbWriteData.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Write Data.");
                //    tbWriteData.Focus();
                //    return;
                //}
                //if (tbCreateFiles.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Create Files.");
                //    tbCreateFiles.Focus();
                //    return;
                //}
                //if (tbModify.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Modify.");
                //    tbModify.Focus();
                //    return;
                //}
                //if (tbFullControl.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Full Control.");
                //    tbFullControl.Focus();
                //    return;
                //}
                //if (tbCreateDirectories.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Create Directories.");
                //    tbCreateDirectories.Focus();
                //    return;
                //}
                //if (tbExecuteFile.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Execute Files.");
                //    tbExecuteFile.Focus();
                //    return;
                //}
                //if (tbRead.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Read.");
                //    tbRead.Focus();
                //    return;
                //}
                //if (tbChangePermissions.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Change Permission.");
                //    tbChangePermissions.Focus();
                //    return;
                //}
                //if (tbTakeOwnership.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Take Ownership.");
                //    tbTakeOwnership.Focus();
                //    return;
                //}
                //if (tbDeleteSubdirectories.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Delete Subdirectories.");
                //    tbDeleteSubdirectories.Focus();
                //    return;
                //}
                //if (tbWrite.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Write.");
                //    tbWrite.Focus();
                //    return;
                //}
                //if (tbDelete.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Delete.");
                //    tbDelete.Focus();
                //    return;
                //}
                //if (tbReadAndExecute.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please input Read And Execute.");
                //    tbReadAndExecute.Focus();
                //    return;
                //}

                topACL = Convert.ToInt32(txtACLTopRecords.Text.Trim());
                topActivity = Convert.ToInt32(txtActivityTopRecords.Text.Trim());
                this.Cursor = Cursors.WaitCursor;
                StartACLProcessing();
            }
            catch (Exception ex)
            {

            }
            this.Cursor = Cursors.Default;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(tx.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tx.Text = tx.Text.Remove(tx.Text.Length - 1);
                tx.Focus();
            }
        }

        private void StartACLProcessing()
        {
            Dictionary<string, int> diActivity = new Dictionary<string, int>();
            int TotalFileProcessed = 0;
            DataTable dTACLScoring = new DataTable();
            try
            {
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Start - Folder Owner Abacus" });
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "-------------------------------------------------------------------" });

                string UNCPath = tbUNCPath.Text;
                DirectoryInfo DirInfo = new DirectoryInfo(UNCPath);

                var files = from f in DirInfo.EnumerateFiles()
                            select f;

                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Fetched all the files from [" + tbUNCPath.Text + "]" });
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Tota number of files found [" + files.Count() + "]" });
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Now going to connect with your domain if you want to know Universal principle name of an owner." });

                UserPrincipal DirectoryUser = null;
                PrincipalContext PrincipalContext = null;
                string OwnerofDirectory = string.Empty;
                try
                {
                    PrincipalContext = new PrincipalContext(ContextType.Domain, tbDomainName.Text, tbUsername.Text, tbPassword.Text);

                    base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Application is connected with your provided domain." });
                    base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Owner of your selected folder is [" + "" + "]" });
                    base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Now application will be processing your file(s) inside your selected folder." });

                    DirectoryUser = UserPrincipal.FindByIdentity(PrincipalContext, IdentityType.SamAccountName, OwnerofDirectory);
                }
                catch (Exception exp)
                {
                    base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Faile to get the Universal Principle Name of an Owner using provided Domain." });
                    base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { exp.Message });
                }

                var DCL = DirInfo.GetAccessControl();
                OwnerofDirectory = DCL.GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();

                lblDirOwnerName.Text = OwnerofDirectory;
				lblDirOwnerPic.Image = GetImage(OwnerofDirectory);



				if (DirectoryUser == null & tbDomainName.Text.Trim() != string.Empty)
                    base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Could not get the Universal Principle Name of an Owner using provided Domain." });

                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "However, the NT Account name of an expected Owner is [" + OwnerofDirectory + "]" });
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Now, application will start executing all files inside selected folder." });

                List<ACL> liACL = new List<ACL>();

                foreach (var f in files)
                {
                    ACL objACL = new ACL();

                    objACL.FileName = f.Name;

                    base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "====================================================================================" });
                    base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Executing file [" + f.Name + "]" });

                    var ACLControl = f.GetAccessControl();

                    string OwnerofFile = f.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();

                    if (!diActivity.ContainsKey(OwnerofFile))
                    {
                        if (diActivity.Count <= topActivity)
                            diActivity.Add(OwnerofFile, 1);
                    }
                    else
                    {
                        int noffiles = 0;
                        diActivity.TryGetValue(OwnerofFile, out noffiles);
                        diActivity[OwnerofFile] = noffiles + 1;
                    }

                    TotalFileProcessed += 1;

                    List<ACLScore> liACLScore = new List<ACLScore>();

                    base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Now, its going to process all the users with thier ACL for file [" + f.Name + "]" });

                    foreach (FileSystemAccessRule rule in ACLControl.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount)))
                    {
                        base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Calculating ACL now." });
                        try
                        {
                            ACLScore objACLScore = new ACLScore();
                            CalculateACL(rule, PrincipalContext, ref objACLScore);
                            liACLScore.Add(objACLScore);
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message + System.Environment.NewLine + "Please contact administrator", "Error", MessageBoxButtons.OK);
                            base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { exp.Message + exp.StackTrace });
                        }
                    }

                    objACL.ACLScore = liACLScore;
                    liACL.Add(objACL);
                }

                dTACLScoring = CalculateACLPercentage(liACL);
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Application has proccessed all the files inside your selected folder." });
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + System.Environment.NewLine + "Please contact administrator", "Error", MessageBoxButtons.OK);
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { exp.Message + exp.StackTrace });
            }

            DataTable dTActivity = new DataTable();
            try
            {
                dTActivity.Columns.Add("Avtar", typeof(Image));
                dTActivity.Columns.Add("Username");
                dTActivity.Columns.Add("FilesCount");

                var sortedDict = from entry in diActivity orderby entry.Value descending select entry;

                foreach (var item in sortedDict)
                {
                    dTActivity.Rows.Add(GetImage(item.Key), item.Key, (Convert.ToDecimal(item.Value) / TotalFileProcessed) * 100 + "%");
                }
                dgvActivity.DataSource = dTActivity;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + System.Environment.NewLine + "Please contact administrator", "Error", MessageBoxButtons.OK);
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { exp.Message + exp.StackTrace });
            }

            try
            {
                CalculateSuggestedOwner(dTACLScoring, dTActivity);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + System.Environment.NewLine + "Please contact administrator", "Error", MessageBoxButtons.OK);
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { exp.Message + exp.StackTrace });
            }
        }

        private DataTable SortTable(DataTable dtInput)
        {
            try
            {
                DataView dv = dtInput.DefaultView;
                dv.Sort = "Score desc";
                return dv.ToTable();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + System.Environment.NewLine + "Please contact administrator", "Error", MessageBoxButtons.OK);
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { exp.Message + exp.StackTrace });
            }
            return null;
        }

        private DataTable CalculateACLPercentage(List<ACL> liACL)
        {
            DataTable dTACLScoring = new DataTable();
            try
            {
                dTACLScoring.Columns.Add("Avtar", typeof(Image));
                dTACLScoring.Columns.Add("Username");
                dTACLScoring.Columns.Add("Score");

                var UniqueUsers = liACL.Select(a => a.ACLScore).Select(y => y.Select(a => a.User).Distinct());

                foreach (var u in UniqueUsers)
                {
                    foreach (var i in u)
                    {
                        string Username = string.Empty;
                        int ObtainedScore = 0;
                        int FilesCounter = 0;
                        var Scores = liACL.Select(a => a.ACLScore).Select(y => y.Where(g => g.User == i.ToString()));

                        foreach (var item in Scores)
                        {
                            foreach (var it in item)
                            {
                                Username = it.User;
                                ObtainedScore += it.ObtainedScore;
                                FilesCounter += 1;
                            }
                        }

                        decimal finalscore = (ObtainedScore / Convert.ToDecimal(100 * FilesCounter)) * 100;
                        if (dTACLScoring.Rows.Count <= topActivity)
                        {
                            dTACLScoring.Rows.Add(GetImage(Username), Username, finalscore + "%");
                        }
                    }
                    break;
                }
            }
            catch (Exception ex)
            {

            }
            dgvACLScore.DataSource = dTACLScoring;

			return dTACLScoring;
        }

        private Image GetImage(string Name)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject(Name.Substring(0, 1).ToLower());
            if (rm == null)
                rm = Properties.Resources.ResourceManager.GetObject("user");
            Bitmap myImage = (Bitmap)rm;
            return myImage;
        }

        private void CalculateACL(FileSystemAccessRule rule, PrincipalContext Context, ref ACLScore objACLScore)
        {
            try
            {
                int ObtainedScore = 0;

                //Read Data
                if ((rule.FileSystemRights & FileSystemRights.ReadData) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbReadData.Text);

                //Read Data
                if ((rule.FileSystemRights & FileSystemRights.WriteData) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbWriteData.Text);

                //Create File
                if ((rule.FileSystemRights & FileSystemRights.CreateFiles) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbCreateFiles.Text);

                //Modify
                if ((rule.FileSystemRights & FileSystemRights.Modify) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbModify.Text);

                //Full Control
                if ((rule.FileSystemRights & FileSystemRights.FullControl) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbFullControl.Text);

                //Create Directories
                if ((rule.FileSystemRights & FileSystemRights.CreateDirectories) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbCreateDirectories.Text);

                //Execute File
                if ((rule.FileSystemRights & FileSystemRights.ExecuteFile) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbExecuteFile.Text);

                //Read
                if ((rule.FileSystemRights & FileSystemRights.Read) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbRead.Text);

                //Change Permissions
                if ((rule.FileSystemRights & FileSystemRights.ChangePermissions) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbChangePermissions.Text);

                //Take Ownership
                if ((rule.FileSystemRights & FileSystemRights.TakeOwnership) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbTakeOwnership.Text);

                //Delete subdirectories and files
                if ((rule.FileSystemRights & FileSystemRights.DeleteSubdirectoriesAndFiles) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbDeleteSubdirectories.Text);

                //Write
                if ((rule.FileSystemRights & FileSystemRights.Write) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbWrite.Text);

                //Delete
                if ((rule.FileSystemRights & FileSystemRights.Delete) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbDelete.Text);

                //Read and Excute
                if ((rule.FileSystemRights & FileSystemRights.ReadAndExecute) > 0 && rule.AccessControlType != AccessControlType.Deny)
                    ObtainedScore += Convert.ToInt32(tbReadAndExecute.Text);

                UserPrincipal User = null;
                try { User = UserPrincipal.FindByIdentity(Context, IdentityType.SamAccountName, rule.IdentityReference.Value); } catch (Exception) { }

                string UPN = string.Empty;
                if (User != null)
                    UPN = User.UserPrincipalName;
                else
                    UPN = rule.IdentityReference.Value;

                objACLScore.User = UPN;
                objACLScore.ObtainedScore = ObtainedScore;

                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { "Obtained score of User [" + objACLScore.User + "] is [" + objACLScore.ObtainedScore + "]" });
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + System.Environment.NewLine + "Please contact administrator", "Error", MessageBoxButtons.OK);
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { exp.Message + exp.StackTrace });
            }
        }

        private void AddLogs(string Log)
        {
            try
            {
                lstLogs.Items.Add(Log);
                lstLogs.SelectedIndex = lstLogs.Items.Count - 1;
            }
            catch (Exception E)
            {
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TabControl.SelectedIndex == 0)
                {
                    lblControlPanelSelect.Visible = lblConfigUnselect.Visible = lblStatsUnselect.Visible = true;
                    lblControlPanelUnselect.Visible = lblConfigSelect.Visible = lblStatsSelect.Visible = false;
                }
                else if (TabControl.SelectedIndex == 1)
                {
                    lblControlPanelUnselect.Visible = lblConfigSelect.Visible = lblStatsUnselect.Visible = true;
                    lblControlPanelSelect.Visible = lblConfigUnselect.Visible = lblStatsSelect.Visible = false;
                }
                else if (TabControl.SelectedIndex == 2)
                {
                    lblControlPanelUnselect.Visible = lblConfigUnselect.Visible = lblStatsSelect.Visible = true;
                    lblControlPanelSelect.Visible = lblConfigSelect.Visible = lblStatsUnselect.Visible = false;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + System.Environment.NewLine + "Please contact administrator", "Error", MessageBoxButtons.OK);
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { exp.Message + exp.StackTrace });
            }
        }

        private void lblOverviewUnselect_Click(object sender, EventArgs e)
        {
            try
            {
                TabControl.SelectedIndex = 0;
            }
            catch (Exception E)
            {

            }
        }

        private void lblConfigurationUnselect_Click(object sender, EventArgs e)
        {
            try
            {
                TabControl.SelectedIndex = 1;
            }
            catch (Exception E)
            {

            }
        }

        private void lblLogsUnselect_Click(object sender, EventArgs e)
        {
            try
            {
                TabControl.SelectedIndex = 2;
            }
            catch (Exception E)
            {

            }
        }

        private void CalculateSuggestedOwner(DataTable dTACL, DataTable dTActivity)
        {
            try
            {
                DataTable dTSuggestedOwner = new DataTable();
                dTSuggestedOwner.Columns.Add("Avtar", typeof(Image));
                dTSuggestedOwner.Columns.Add("Username");
                dTSuggestedOwner.Columns.Add("Score");

                DataTable dTMain = null;

                if (dTACL.Rows.Count > dTActivity.Rows.Count)
                    dTMain = dTACL;
                else
                    dTMain = dTActivity;

                for (int i = 0; i < dTMain.Rows.Count - 1; i++)
                {
                    string Username = dTMain.Rows[i]["Username"].ToString().Trim();
                    DataRow[] drACL = dTACL.Select("Username='" + Username + "'");
                    DataRow[] drActivity = dTActivity.Select("Username='" + Username + "'");

                    if (drACL == null || drACL.Length <= 0 || drActivity == null || drActivity.Length <= 0)
                        continue;

                    decimal TotalScore = (Convert.ToDecimal(drACL[0]["Score"].ToString().Trim().Replace("%", "")) + Convert.ToDecimal(drActivity[0]["FilesCount"].ToString().Trim().Replace("%", ""))) / 2;

                    if (dTSuggestedOwner.Rows.Count == 3)
                        break;

                    dTSuggestedOwner.Rows.Add(GetImage(Username), Username, TotalScore + "%");
                }
                dgvSuggestedOwner.DataSource = dTSuggestedOwner;
			}
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + System.Environment.NewLine + "Please contact administrator", "Error", MessageBoxButtons.OK);
                base.BeginInvoke(new DAddLog(this.AddLogs), new object[] { exp.Message + exp.StackTrace });
            }
        }

        private void tpOverview_Click(object sender, EventArgs e)
        {

        }
    }
    public class ACL
    {
        public string FileName { get; set; }
        public List<ACLScore> ACLScore { get; set; }
    }

    public class ACLScore
    {
        public string User { get; set; }
        public int ObtainedScore { get; set; }
    }

    public class FileScore
    {
        public string FileName { get; set; }
        public int Score { get; set; }
    }

    public class User
    {
        List<FileScore> objUserFileScores = new List<FileScore>();
    }
}