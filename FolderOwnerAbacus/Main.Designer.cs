using System.Windows.Forms;

namespace FolderOwnerAbacus
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblFullControl = new System.Windows.Forms.Label();
            this.tbFullControl = new System.Windows.Forms.TextBox();
            this.tbTakeOwnership = new System.Windows.Forms.TextBox();
            this.lblTakeOwnership = new System.Windows.Forms.Label();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbChangePermissions = new System.Windows.Forms.TextBox();
            this.lblModify = new System.Windows.Forms.Label();
            this.tbModify = new System.Windows.Forms.TextBox();
            this.tbReadAndExecute = new System.Windows.Forms.TextBox();
            this.lblReadAndExecute = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbRead = new System.Windows.Forms.TextBox();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.tbWrite = new System.Windows.Forms.TextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblWrite = new System.Windows.Forms.Label();
            this.lblDeleteSubDirectoriesAndFiles = new System.Windows.Forms.Label();
            this.tbDeleteSubdirectories = new System.Windows.Forms.TextBox();
            this.tbReadData = new System.Windows.Forms.TextBox();
            this.tbExecuteFile = new System.Windows.Forms.TextBox();
            this.lblExecuteFile = new System.Windows.Forms.Label();
            this.lblCreateDirectories = new System.Windows.Forms.Label();
            this.lblCreateFiles = new System.Windows.Forms.Label();
            this.tbCreateFiles = new System.Windows.Forms.TextBox();
            this.lblWriteData = new System.Windows.Forms.Label();
            this.tbWriteData = new System.Windows.Forms.TextBox();
            this.lblReadData = new System.Windows.Forms.Label();
            this.tbCreateDirectories = new System.Windows.Forms.TextBox();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tpOverview = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblUNCPath = new System.Windows.Forms.Label();
            this.tbUNCPath = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.Avtar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDirOwnerName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDirOwnerPic = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvSuggestedOwner = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvACLScore = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbDomainName = new System.Windows.Forms.TextBox();
            this.lblDomainName = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtACLTopRecords = new System.Windows.Forms.TextBox();
            this.txtActivityTopRecords = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblControlPanelUnselect = new System.Windows.Forms.Label();
            this.lblConfigUnselect = new System.Windows.Forms.Label();
            this.lblStatsUnselect = new System.Windows.Forms.Label();
            this.lblControlPanelSelect = new System.Windows.Forms.Label();
            this.lblConfigSelect = new System.Windows.Forms.Label();
            this.lblStatsSelect = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tpOverview.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuggestedOwner)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvACLScore)).BeginInit();
            this.tpSettings.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullControl
            // 
            this.lblFullControl.AutoSize = true;
            this.lblFullControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullControl.Location = new System.Drawing.Point(85, 244);
            this.lblFullControl.Name = "lblFullControl";
            this.lblFullControl.Size = new System.Drawing.Size(79, 17);
            this.lblFullControl.TabIndex = 218;
            this.lblFullControl.Text = "Full Control";
            // 
            // tbFullControl
            // 
            this.tbFullControl.Location = new System.Drawing.Point(172, 241);
            this.tbFullControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFullControl.MaxLength = 100;
            this.tbFullControl.Name = "tbFullControl";
            this.tbFullControl.Size = new System.Drawing.Size(48, 23);
            this.tbFullControl.TabIndex = 216;
            this.tbFullControl.Text = "10";
            this.tbFullControl.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbTakeOwnership
            // 
            this.tbTakeOwnership.Location = new System.Drawing.Point(590, 142);
            this.tbTakeOwnership.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTakeOwnership.MaxLength = 100;
            this.tbTakeOwnership.Name = "tbTakeOwnership";
            this.tbTakeOwnership.Size = new System.Drawing.Size(48, 23);
            this.tbTakeOwnership.TabIndex = 212;
            this.tbTakeOwnership.Text = "6";
            this.tbTakeOwnership.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblTakeOwnership
            // 
            this.lblTakeOwnership.AutoSize = true;
            this.lblTakeOwnership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTakeOwnership.Location = new System.Drawing.Point(467, 145);
            this.lblTakeOwnership.Name = "lblTakeOwnership";
            this.lblTakeOwnership.Size = new System.Drawing.Size(111, 17);
            this.lblTakeOwnership.TabIndex = 211;
            this.lblTakeOwnership.Text = "Take Ownership";
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.Location = new System.Drawing.Point(441, 94);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(137, 17);
            this.lblChangePassword.TabIndex = 210;
            this.lblChangePassword.Text = "Change Permissions";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 238);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 17);
            this.label23.TabIndex = 209;
            // 
            // tbChangePermissions
            // 
            this.tbChangePermissions.Location = new System.Drawing.Point(590, 91);
            this.tbChangePermissions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbChangePermissions.MaxLength = 100;
            this.tbChangePermissions.Name = "tbChangePermissions";
            this.tbChangePermissions.Size = new System.Drawing.Size(48, 23);
            this.tbChangePermissions.TabIndex = 208;
            this.tbChangePermissions.Text = "6";
            this.tbChangePermissions.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblModify
            // 
            this.lblModify.AutoSize = true;
            this.lblModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModify.Location = new System.Drawing.Point(115, 193);
            this.lblModify.Name = "lblModify";
            this.lblModify.Size = new System.Drawing.Size(49, 17);
            this.lblModify.TabIndex = 207;
            this.lblModify.Text = "Modify";
            // 
            // tbModify
            // 
            this.tbModify.Location = new System.Drawing.Point(172, 190);
            this.tbModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbModify.MaxLength = 100;
            this.tbModify.Name = "tbModify";
            this.tbModify.Size = new System.Drawing.Size(48, 23);
            this.tbModify.TabIndex = 205;
            this.tbModify.Text = "10";
            this.tbModify.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbReadAndExecute
            // 
            this.tbReadAndExecute.Location = new System.Drawing.Point(590, 337);
            this.tbReadAndExecute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReadAndExecute.MaxLength = 100;
            this.tbReadAndExecute.Name = "tbReadAndExecute";
            this.tbReadAndExecute.Size = new System.Drawing.Size(48, 23);
            this.tbReadAndExecute.TabIndex = 204;
            this.tbReadAndExecute.Text = "5";
            this.tbReadAndExecute.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblReadAndExecute
            // 
            this.lblReadAndExecute.AutoSize = true;
            this.lblReadAndExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadAndExecute.Location = new System.Drawing.Point(453, 340);
            this.lblReadAndExecute.Name = "lblReadAndExecute";
            this.lblReadAndExecute.Size = new System.Drawing.Size(125, 17);
            this.lblReadAndExecute.TabIndex = 203;
            this.lblReadAndExecute.Text = "Read And Execute";
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRead.Location = new System.Drawing.Point(522, 47);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(42, 17);
            this.lblRead.TabIndex = 202;
            this.lblRead.Text = "Read";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 17);
            this.label19.TabIndex = 201;
            // 
            // tbRead
            // 
            this.tbRead.Location = new System.Drawing.Point(590, 44);
            this.tbRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbRead.MaxLength = 100;
            this.tbRead.Name = "tbRead";
            this.tbRead.Size = new System.Drawing.Size(48, 23);
            this.tbRead.TabIndex = 200;
            this.tbRead.Text = "6";
            this.tbRead.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(590, 289);
            this.tbDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDelete.MaxLength = 100;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(48, 23);
            this.tbDelete.TabIndex = 196;
            this.tbDelete.Text = "5";
            this.tbDelete.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbWrite
            // 
            this.tbWrite.Location = new System.Drawing.Point(590, 241);
            this.tbWrite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWrite.MaxLength = 100;
            this.tbWrite.Name = "tbWrite";
            this.tbWrite.Size = new System.Drawing.Size(48, 23);
            this.tbWrite.TabIndex = 195;
            this.tbWrite.Text = "5";
            this.tbWrite.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(529, 292);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(49, 17);
            this.lblDelete.TabIndex = 192;
            this.lblDelete.Text = "Delete";
            // 
            // lblWrite
            // 
            this.lblWrite.AutoSize = true;
            this.lblWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrite.Location = new System.Drawing.Point(537, 244);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(41, 17);
            this.lblWrite.TabIndex = 190;
            this.lblWrite.Text = "Write";
            // 
            // lblDeleteSubDirectoriesAndFiles
            // 
            this.lblDeleteSubDirectoriesAndFiles.AutoSize = true;
            this.lblDeleteSubDirectoriesAndFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteSubDirectoriesAndFiles.Location = new System.Drawing.Point(372, 193);
            this.lblDeleteSubDirectoriesAndFiles.Name = "lblDeleteSubDirectoriesAndFiles";
            this.lblDeleteSubDirectoriesAndFiles.Size = new System.Drawing.Size(206, 17);
            this.lblDeleteSubDirectoriesAndFiles.TabIndex = 187;
            this.lblDeleteSubDirectoriesAndFiles.Text = "Delete Subdirectories And Files";
            // 
            // tbDeleteSubdirectories
            // 
            this.tbDeleteSubdirectories.Location = new System.Drawing.Point(590, 190);
            this.tbDeleteSubdirectories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDeleteSubdirectories.MaxLength = 100;
            this.tbDeleteSubdirectories.Name = "tbDeleteSubdirectories";
            this.tbDeleteSubdirectories.Size = new System.Drawing.Size(48, 23);
            this.tbDeleteSubdirectories.TabIndex = 186;
            this.tbDeleteSubdirectories.Text = "5";
            this.tbDeleteSubdirectories.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbReadData
            // 
            this.tbReadData.Location = new System.Drawing.Point(172, 44);
            this.tbReadData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReadData.MaxLength = 100;
            this.tbReadData.Name = "tbReadData";
            this.tbReadData.Size = new System.Drawing.Size(48, 23);
            this.tbReadData.TabIndex = 185;
            this.tbReadData.Text = "10";
            this.tbReadData.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbExecuteFile
            // 
            this.tbExecuteFile.Location = new System.Drawing.Point(172, 337);
            this.tbExecuteFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbExecuteFile.MaxLength = 100;
            this.tbExecuteFile.Name = "tbExecuteFile";
            this.tbExecuteFile.Size = new System.Drawing.Size(48, 23);
            this.tbExecuteFile.TabIndex = 183;
            this.tbExecuteFile.Text = "6";
            this.tbExecuteFile.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblExecuteFile
            // 
            this.lblExecuteFile.AutoSize = true;
            this.lblExecuteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecuteFile.Location = new System.Drawing.Point(80, 340);
            this.lblExecuteFile.Name = "lblExecuteFile";
            this.lblExecuteFile.Size = new System.Drawing.Size(84, 17);
            this.lblExecuteFile.TabIndex = 177;
            this.lblExecuteFile.Text = "Execute File";
            // 
            // lblCreateDirectories
            // 
            this.lblCreateDirectories.AutoSize = true;
            this.lblCreateDirectories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDirectories.Location = new System.Drawing.Point(42, 292);
            this.lblCreateDirectories.Name = "lblCreateDirectories";
            this.lblCreateDirectories.Size = new System.Drawing.Size(122, 17);
            this.lblCreateDirectories.TabIndex = 171;
            this.lblCreateDirectories.Text = "Create Directories";
            // 
            // lblCreateFiles
            // 
            this.lblCreateFiles.AutoSize = true;
            this.lblCreateFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateFiles.Location = new System.Drawing.Point(77, 145);
            this.lblCreateFiles.Name = "lblCreateFiles";
            this.lblCreateFiles.Size = new System.Drawing.Size(87, 17);
            this.lblCreateFiles.TabIndex = 166;
            this.lblCreateFiles.Text = "Create Files ";
            // 
            // tbCreateFiles
            // 
            this.tbCreateFiles.Location = new System.Drawing.Point(172, 142);
            this.tbCreateFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCreateFiles.MaxLength = 100;
            this.tbCreateFiles.Name = "tbCreateFiles";
            this.tbCreateFiles.Size = new System.Drawing.Size(48, 23);
            this.tbCreateFiles.TabIndex = 165;
            this.tbCreateFiles.Text = "10";
            this.tbCreateFiles.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblWriteData
            // 
            this.lblWriteData.AutoSize = true;
            this.lblWriteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteData.Location = new System.Drawing.Point(89, 94);
            this.lblWriteData.Name = "lblWriteData";
            this.lblWriteData.Size = new System.Drawing.Size(75, 17);
            this.lblWriteData.TabIndex = 164;
            this.lblWriteData.Text = "Write Data";
            // 
            // tbWriteData
            // 
            this.tbWriteData.Location = new System.Drawing.Point(172, 91);
            this.tbWriteData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWriteData.MaxLength = 100;
            this.tbWriteData.Name = "tbWriteData";
            this.tbWriteData.Size = new System.Drawing.Size(48, 23);
            this.tbWriteData.TabIndex = 163;
            this.tbWriteData.Text = "10";
            this.tbWriteData.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblReadData
            // 
            this.lblReadData.AutoSize = true;
            this.lblReadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadData.Location = new System.Drawing.Point(88, 47);
            this.lblReadData.Name = "lblReadData";
            this.lblReadData.Size = new System.Drawing.Size(76, 17);
            this.lblReadData.TabIndex = 131;
            this.lblReadData.Text = "Read Data";
            // 
            // tbCreateDirectories
            // 
            this.tbCreateDirectories.Location = new System.Drawing.Point(172, 289);
            this.tbCreateDirectories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCreateDirectories.MaxLength = 100;
            this.tbCreateDirectories.Name = "tbCreateDirectories";
            this.tbCreateDirectories.Size = new System.Drawing.Size(48, 23);
            this.tbCreateDirectories.TabIndex = 1;
            this.tbCreateDirectories.Text = "6";
            this.tbCreateDirectories.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lstLogs
            // 
            this.lstLogs.ForeColor = System.Drawing.Color.Green;
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.Location = new System.Drawing.Point(4, 39);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(1210, 563);
            this.lstLogs.TabIndex = 179;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(194)))));
            this.btnStart.Location = new System.Drawing.Point(862, 29);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 29);
            this.btnStart.TabIndex = 180;
            this.btnStart.Text = "Start Processing";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.tpOverview);
            this.TabControl.Controls.Add(this.tpSettings);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(202, 24);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1259, 697);
            this.TabControl.TabIndex = 181;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpOverview
            // 
            this.tpOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.tpOverview.Controls.Add(this.panel9);
            this.tpOverview.Controls.Add(this.panel8);
            this.tpOverview.Controls.Add(this.panel7);
            this.tpOverview.Controls.Add(this.panel6);
            this.tpOverview.Controls.Add(this.panel5);
            this.tpOverview.Location = new System.Drawing.Point(4, 25);
            this.tpOverview.Name = "tpOverview";
            this.tpOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverview.Size = new System.Drawing.Size(1251, 668);
            this.tpOverview.TabIndex = 0;
            this.tpOverview.Text = "Overview";
            this.tpOverview.Click += new System.EventHandler(this.tpOverview_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.lblUNCPath);
            this.panel9.Controls.Add(this.tbUNCPath);
            this.panel9.Controls.Add(this.btnStart);
            this.panel9.Location = new System.Drawing.Point(16, 13);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1206, 82);
            this.panel9.TabIndex = 181;
            // 
            // lblUNCPath
            // 
            this.lblUNCPath.AutoSize = true;
            this.lblUNCPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUNCPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.lblUNCPath.Location = new System.Drawing.Point(89, 33);
            this.lblUNCPath.Name = "lblUNCPath";
            this.lblUNCPath.Size = new System.Drawing.Size(100, 20);
            this.lblUNCPath.TabIndex = 180;
            this.lblUNCPath.Text = "UNC Path *";
            // 
            // tbUNCPath
            // 
            this.tbUNCPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUNCPath.Location = new System.Drawing.Point(207, 30);
            this.tbUNCPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUNCPath.MaxLength = 100;
            this.tbUNCPath.Name = "tbUNCPath";
            this.tbUNCPath.Size = new System.Drawing.Size(638, 26);
            this.tbUNCPath.TabIndex = 179;
            this.tbUNCPath.Text = "C:\\temp\\test";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.dgvActivity);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Location = new System.Drawing.Point(852, 112);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(375, 522);
            this.panel8.TabIndex = 186;
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.AllowUserToResizeColumns = false;
            this.dgvActivity.AllowUserToResizeRows = false;
            this.dgvActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivity.BackgroundColor = System.Drawing.Color.White;
            this.dgvActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActivity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.ColumnHeadersVisible = false;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Avtar,
            this.Username,
            this.FilesCount});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivity.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvActivity.Location = new System.Drawing.Point(4, 44);
            this.dgvActivity.MultiSelect = false;
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivity.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvActivity.RowHeadersVisible = false;
            this.dgvActivity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivity.Size = new System.Drawing.Size(366, 471);
            this.dgvActivity.TabIndex = 1;
            // 
            // Avtar
            // 
            this.Avtar.DataPropertyName = "Avtar";
            this.Avtar.FillWeight = 68.13827F;
            this.Avtar.HeaderText = "Avtar";
            this.Avtar.Image = global::FolderOwnerAbacus.Properties.Resources.user;
            this.Avtar.Name = "Avtar";
            this.Avtar.ReadOnly = true;
            this.Avtar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Avtar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.FillWeight = 184.6536F;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // FilesCount
            // 
            this.FilesCount.DataPropertyName = "FilesCount";
            this.FilesCount.FillWeight = 47.20812F;
            this.FilesCount.HeaderText = "FilesCount";
            this.FilesCount.Name = "FilesCount";
            this.FilesCount.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label15.Location = new System.Drawing.Point(319, -12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 43);
            this.label15.TabIndex = 4;
            this.label15.Text = "...";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label16.Location = new System.Drawing.Point(11, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Activity";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label17.Location = new System.Drawing.Point(4, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(421, 1);
            this.label17.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lblDirOwnerName);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.lblDirOwnerPic);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(16, 112);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(430, 148);
            this.panel7.TabIndex = 183;
            // 
            // lblDirOwnerName
            // 
            this.lblDirOwnerName.AutoSize = true;
            this.lblDirOwnerName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirOwnerName.Location = new System.Drawing.Point(83, 79);
            this.lblDirOwnerName.Name = "lblDirOwnerName";
            this.lblDirOwnerName.Size = new System.Drawing.Size(102, 16);
            this.lblDirOwnerName.TabIndex = 4;
            this.lblDirOwnerName.Text = "Directory Owner";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label12.Location = new System.Drawing.Point(374, -12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 43);
            this.label12.TabIndex = 4;
            this.label12.Text = "...";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirOwnerPic
            // 
            this.lblDirOwnerPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirOwnerPic.Image = global::FolderOwnerAbacus.Properties.Resources.alphabet_01;
            this.lblDirOwnerPic.Location = new System.Drawing.Point(13, 63);
            this.lblDirOwnerPic.Name = "lblDirOwnerPic";
            this.lblDirOwnerPic.Size = new System.Drawing.Size(56, 50);
            this.lblDirOwnerPic.TabIndex = 3;
            this.lblDirOwnerPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label13.Location = new System.Drawing.Point(11, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Directory Owner";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label14.Location = new System.Drawing.Point(4, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(421, 1);
            this.label14.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dgvSuggestedOwner);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(16, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 348);
            this.panel6.TabIndex = 182;
            // 
            // dgvSuggestedOwner
            // 
            this.dgvSuggestedOwner.AllowUserToAddRows = false;
            this.dgvSuggestedOwner.AllowUserToDeleteRows = false;
            this.dgvSuggestedOwner.AllowUserToResizeColumns = false;
            this.dgvSuggestedOwner.AllowUserToResizeRows = false;
            this.dgvSuggestedOwner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuggestedOwner.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuggestedOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuggestedOwner.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuggestedOwner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvSuggestedOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuggestedOwner.ColumnHeadersVisible = false;
            this.dgvSuggestedOwner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuggestedOwner.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvSuggestedOwner.Location = new System.Drawing.Point(6, 43);
            this.dgvSuggestedOwner.MultiSelect = false;
            this.dgvSuggestedOwner.Name = "dgvSuggestedOwner";
            this.dgvSuggestedOwner.ReadOnly = true;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuggestedOwner.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvSuggestedOwner.RowHeadersVisible = false;
            this.dgvSuggestedOwner.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSuggestedOwner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuggestedOwner.Size = new System.Drawing.Size(418, 297);
            this.dgvSuggestedOwner.TabIndex = 6;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.DataPropertyName = "Avtar";
            this.dataGridViewImageColumn3.FillWeight = 60.9137F;
            this.dataGridViewImageColumn3.HeaderText = "Avtar";
            this.dataGridViewImageColumn3.Image = global::FolderOwnerAbacus.Properties.Resources.user;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.FillWeight = 192.2438F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn3.FillWeight = 46.84246F;
            this.dataGridViewTextBoxColumn3.HeaderText = "FilesCount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label8.Location = new System.Drawing.Point(374, -12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 43);
            this.label8.TabIndex = 4;
            this.label8.Text = "...";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label9.Location = new System.Drawing.Point(11, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Suggested Owner";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label10.Location = new System.Drawing.Point(4, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(421, 1);
            this.label10.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.dgvACLScore);
            this.panel5.Location = new System.Drawing.Point(466, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 522);
            this.panel5.TabIndex = 181;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label7.Location = new System.Drawing.Point(319, -12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 43);
            this.label7.TabIndex = 4;
            this.label7.Text = "...";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(11, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "ACL Scoring";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label4.Location = new System.Drawing.Point(1, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 1);
            this.label4.TabIndex = 2;
            // 
            // dgvACLScore
            // 
            this.dgvACLScore.AllowUserToAddRows = false;
            this.dgvACLScore.AllowUserToDeleteRows = false;
            this.dgvACLScore.AllowUserToResizeColumns = false;
            this.dgvACLScore.AllowUserToResizeRows = false;
            this.dgvACLScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvACLScore.BackgroundColor = System.Drawing.Color.White;
            this.dgvACLScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvACLScore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvACLScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvACLScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvACLScore.ColumnHeadersVisible = false;
            this.dgvACLScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.Score});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvACLScore.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvACLScore.Location = new System.Drawing.Point(6, 44);
            this.dgvACLScore.MultiSelect = false;
            this.dgvACLScore.Name = "dgvACLScore";
            this.dgvACLScore.ReadOnly = true;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvACLScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvACLScore.RowHeadersVisible = false;
            this.dgvACLScore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvACLScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvACLScore.Size = new System.Drawing.Size(363, 471);
            this.dgvACLScore.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Avtar";
            this.dataGridViewImageColumn1.FillWeight = 45.68528F;
            this.dataGridViewImageColumn1.HeaderText = "Avtar";
            this.dataGridViewImageColumn1.Image = global::FolderOwnerAbacus.Properties.Resources.user;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn1.FillWeight = 202.2584F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.FillWeight = 52.0564F;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.tpSettings.Controls.Add(this.panel4);
            this.tpSettings.Controls.Add(this.panel3);
            this.tpSettings.Controls.Add(this.panel2);
            this.tpSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpSettings.Location = new System.Drawing.Point(4, 25);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(1251, 668);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.lblUsername);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.label31);
            this.panel4.Controls.Add(this.tbPassword);
            this.panel4.Controls.Add(this.tbUsername);
            this.panel4.Controls.Add(this.tbDomainName);
            this.panel4.Controls.Add(this.lblDomainName);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Location = new System.Drawing.Point(16, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 186);
            this.panel4.TabIndex = 221;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label29.Location = new System.Drawing.Point(463, -12);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 43);
            this.label29.TabIndex = 231;
            this.label29.Text = "...";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(27, 94);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 17);
            this.lblUsername.TabIndex = 162;
            this.lblUsername.Text = "Username *";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label30.Location = new System.Drawing.Point(11, 6);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(192, 20);
            this.label30.TabIndex = 230;
            this.label30.Text = "Domain Configurations";
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label31.Location = new System.Drawing.Point(1, 31);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(519, 1);
            this.label31.TabIndex = 229;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(134, 125);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(348, 23);
            this.tbPassword.TabIndex = 3;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(134, 91);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUsername.MaxLength = 100;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(348, 23);
            this.tbUsername.TabIndex = 2;
            // 
            // tbDomainName
            // 
            this.tbDomainName.Location = new System.Drawing.Point(134, 59);
            this.tbDomainName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDomainName.MaxLength = 100;
            this.tbDomainName.Name = "tbDomainName";
            this.tbDomainName.Size = new System.Drawing.Size(348, 23);
            this.tbDomainName.TabIndex = 1;
            // 
            // lblDomainName
            // 
            this.lblDomainName.AutoSize = true;
            this.lblDomainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomainName.Location = new System.Drawing.Point(55, 62);
            this.lblDomainName.Name = "lblDomainName";
            this.lblDomainName.Size = new System.Drawing.Size(54, 17);
            this.lblDomainName.TabIndex = 131;
            this.lblDomainName.Text = "Name *";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(31, 128);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 17);
            this.label28.TabIndex = 132;
            this.label28.Text = "Password *";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.label35);
            this.panel3.Controls.Add(this.txtACLTopRecords);
            this.panel3.Controls.Add(this.txtActivityTopRecords);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(16, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 274);
            this.panel3.TabIndex = 220;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label32.Location = new System.Drawing.Point(239, 43);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(2, 73);
            this.label32.TabIndex = 229;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label33.Location = new System.Drawing.Point(463, -13);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 43);
            this.label33.TabIndex = 234;
            this.label33.Text = "...";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 162;
            this.label2.Text = "Activity *";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label34.Location = new System.Drawing.Point(11, 5);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(111, 20);
            this.label34.TabIndex = 233;
            this.label34.Text = "Top Records";
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label35.Location = new System.Drawing.Point(1, 30);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(519, 1);
            this.label35.TabIndex = 232;
            // 
            // txtACLTopRecords
            // 
            this.txtACLTopRecords.Location = new System.Drawing.Point(134, 62);
            this.txtACLTopRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtACLTopRecords.MaxLength = 100;
            this.txtACLTopRecords.Name = "txtACLTopRecords";
            this.txtACLTopRecords.Size = new System.Drawing.Size(72, 23);
            this.txtACLTopRecords.TabIndex = 1;
            this.txtACLTopRecords.Text = "10";
            this.txtACLTopRecords.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // txtActivityTopRecords
            // 
            this.txtActivityTopRecords.Location = new System.Drawing.Point(362, 62);
            this.txtActivityTopRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtActivityTopRecords.MaxLength = 100;
            this.txtActivityTopRecords.Name = "txtActivityTopRecords";
            this.txtActivityTopRecords.Size = new System.Drawing.Size(72, 23);
            this.txtActivityTopRecords.TabIndex = 2;
            this.txtActivityTopRecords.Text = "10";
            this.txtActivityTopRecords.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 131;
            this.label6.Text = "ACL *";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lblFullControl);
            this.panel2.Controls.Add(this.lblReadData);
            this.panel2.Controls.Add(this.tbTakeOwnership);
            this.panel2.Controls.Add(this.tbReadAndExecute);
            this.panel2.Controls.Add(this.tbWriteData);
            this.panel2.Controls.Add(this.lblReadAndExecute);
            this.panel2.Controls.Add(this.lblTakeOwnership);
            this.panel2.Controls.Add(this.tbFullControl);
            this.panel2.Controls.Add(this.tbDelete);
            this.panel2.Controls.Add(this.lblChangePassword);
            this.panel2.Controls.Add(this.tbWrite);
            this.panel2.Controls.Add(this.lblWriteData);
            this.panel2.Controls.Add(this.lblDelete);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.tbCreateFiles);
            this.panel2.Controls.Add(this.lblWrite);
            this.panel2.Controls.Add(this.tbChangePermissions);
            this.panel2.Controls.Add(this.lblDeleteSubDirectoriesAndFiles);
            this.panel2.Controls.Add(this.lblCreateFiles);
            this.panel2.Controls.Add(this.tbDeleteSubdirectories);
            this.panel2.Controls.Add(this.tbReadData);
            this.panel2.Controls.Add(this.tbModify);
            this.panel2.Controls.Add(this.lblModify);
            this.panel2.Controls.Add(this.lblRead);
            this.panel2.Controls.Add(this.tbCreateDirectories);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.lblCreateDirectories);
            this.panel2.Controls.Add(this.tbRead);
            this.panel2.Controls.Add(this.lblExecuteFile);
            this.panel2.Controls.Add(this.tbExecuteFile);
            this.panel2.Location = new System.Drawing.Point(549, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 481);
            this.panel2.TabIndex = 219;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label27.Location = new System.Drawing.Point(323, 57);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(2, 284);
            this.label27.TabIndex = 228;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label26.Location = new System.Drawing.Point(3, 322);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(682, 1);
            this.label26.TabIndex = 227;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label25.Location = new System.Drawing.Point(3, 274);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(682, 1);
            this.label25.TabIndex = 226;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label24.Location = new System.Drawing.Point(3, 223);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(682, 1);
            this.label24.TabIndex = 225;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label22.Location = new System.Drawing.Point(3, 175);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(682, 1);
            this.label22.TabIndex = 224;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(3, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 1);
            this.label1.TabIndex = 223;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label21.Location = new System.Drawing.Point(3, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(682, 1);
            this.label21.TabIndex = 222;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label11.Location = new System.Drawing.Point(628, -14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 43);
            this.label11.TabIndex = 221;
            this.label11.Text = "...";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label18.Location = new System.Drawing.Point(13, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(199, 20);
            this.label18.TabIndex = 220;
            this.label18.Text = "Scoring of Folder\'s ACL";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label20.Location = new System.Drawing.Point(3, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(682, 1);
            this.label20.TabIndex = 219;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.tabPage3.Controls.Add(this.panel10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1251, 668);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.lstLogs);
            this.panel10.Controls.Add(this.label37);
            this.panel10.Controls.Add(this.label38);
            this.panel10.Location = new System.Drawing.Point(16, 13);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1219, 618);
            this.panel10.TabIndex = 222;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label3.Location = new System.Drawing.Point(1160, -12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 43);
            this.label3.TabIndex = 231;
            this.label3.Text = "...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label37.Location = new System.Drawing.Point(11, 6);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(157, 20);
            this.label37.TabIndex = 230;
            this.label37.Text = "Application Traces";
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label38.Location = new System.Drawing.Point(1, 31);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(1213, 1);
            this.label38.TabIndex = 229;
            // 
            // lblControlPanelUnselect
            // 
            this.lblControlPanelUnselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.lblControlPanelUnselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblControlPanelUnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlPanelUnselect.Image = global::FolderOwnerAbacus.Properties.Resources.overview_s;
            this.lblControlPanelUnselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblControlPanelUnselect.Location = new System.Drawing.Point(0, 4);
            this.lblControlPanelUnselect.Name = "lblControlPanelUnselect";
            this.lblControlPanelUnselect.Padding = new System.Windows.Forms.Padding(20, 0, 60, 0);
            this.lblControlPanelUnselect.Size = new System.Drawing.Size(207, 47);
            this.lblControlPanelUnselect.TabIndex = 6;
            this.lblControlPanelUnselect.Text = "Overview";
            this.lblControlPanelUnselect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblControlPanelUnselect.Visible = false;
            this.lblControlPanelUnselect.Click += new System.EventHandler(this.lblOverviewUnselect_Click);
            // 
            // lblConfigUnselect
            // 
            this.lblConfigUnselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.lblConfigUnselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfigUnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigUnselect.Image = global::FolderOwnerAbacus.Properties.Resources.Configurations_s;
            this.lblConfigUnselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConfigUnselect.Location = new System.Drawing.Point(0, 51);
            this.lblConfigUnselect.Name = "lblConfigUnselect";
            this.lblConfigUnselect.Padding = new System.Windows.Forms.Padding(20, 0, 18, 0);
            this.lblConfigUnselect.Size = new System.Drawing.Size(207, 46);
            this.lblConfigUnselect.TabIndex = 7;
            this.lblConfigUnselect.Text = "Configurations";
            this.lblConfigUnselect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConfigUnselect.Click += new System.EventHandler(this.lblConfigurationUnselect_Click);
            // 
            // lblStatsUnselect
            // 
            this.lblStatsUnselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.lblStatsUnselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStatsUnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsUnselect.Image = global::FolderOwnerAbacus.Properties.Resources.Logs_s;
            this.lblStatsUnselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatsUnselect.Location = new System.Drawing.Point(0, 97);
            this.lblStatsUnselect.Name = "lblStatsUnselect";
            this.lblStatsUnselect.Padding = new System.Windows.Forms.Padding(20, 0, 78, 0);
            this.lblStatsUnselect.Size = new System.Drawing.Size(207, 46);
            this.lblStatsUnselect.TabIndex = 8;
            this.lblStatsUnselect.Text = "Traces";
            this.lblStatsUnselect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatsUnselect.Click += new System.EventHandler(this.lblLogsUnselect_Click);
            // 
            // lblControlPanelSelect
            // 
            this.lblControlPanelSelect.BackColor = System.Drawing.Color.White;
            this.lblControlPanelSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblControlPanelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlPanelSelect.Image = global::FolderOwnerAbacus.Properties.Resources.overview_s;
            this.lblControlPanelSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblControlPanelSelect.Location = new System.Drawing.Point(0, 4);
            this.lblControlPanelSelect.Name = "lblControlPanelSelect";
            this.lblControlPanelSelect.Padding = new System.Windows.Forms.Padding(20, 0, 60, 0);
            this.lblControlPanelSelect.Size = new System.Drawing.Size(207, 47);
            this.lblControlPanelSelect.TabIndex = 5;
            this.lblControlPanelSelect.Text = "Overview";
            this.lblControlPanelSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConfigSelect
            // 
            this.lblConfigSelect.BackColor = System.Drawing.Color.White;
            this.lblConfigSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfigSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigSelect.Image = global::FolderOwnerAbacus.Properties.Resources.Configurations_s;
            this.lblConfigSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConfigSelect.Location = new System.Drawing.Point(0, 51);
            this.lblConfigSelect.Name = "lblConfigSelect";
            this.lblConfigSelect.Padding = new System.Windows.Forms.Padding(20, 0, 18, 0);
            this.lblConfigSelect.Size = new System.Drawing.Size(207, 46);
            this.lblConfigSelect.TabIndex = 4;
            this.lblConfigSelect.Text = "Configurations";
            this.lblConfigSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConfigSelect.Visible = false;
            // 
            // lblStatsSelect
            // 
            this.lblStatsSelect.BackColor = System.Drawing.Color.White;
            this.lblStatsSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStatsSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsSelect.Image = global::FolderOwnerAbacus.Properties.Resources.Logs_s;
            this.lblStatsSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatsSelect.Location = new System.Drawing.Point(0, 97);
            this.lblStatsSelect.Name = "lblStatsSelect";
            this.lblStatsSelect.Padding = new System.Windows.Forms.Padding(20, 0, 78, 0);
            this.lblStatsSelect.Size = new System.Drawing.Size(207, 46);
            this.lblStatsSelect.TabIndex = 3;
            this.lblStatsSelect.Text = "Traces";
            this.lblStatsSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatsSelect.Visible = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Avtar";
            this.dataGridViewImageColumn2.FillWeight = 73.18613F;
            this.dataGridViewImageColumn2.HeaderText = "Avtar";
            this.dataGridViewImageColumn2.Image = global::FolderOwnerAbacus.Properties.Resources.user;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 112;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.lblConfigUnselect);
            this.panel1.Controls.Add(this.lblControlPanelUnselect);
            this.panel1.Controls.Add(this.lblStatsSelect);
            this.panel1.Controls.Add(this.lblStatsUnselect);
            this.panel1.Controls.Add(this.lblConfigSelect);
            this.panel1.Controls.Add(this.lblControlPanelSelect);
            this.panel1.Location = new System.Drawing.Point(1, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 669);
            this.panel1.TabIndex = 181;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1477, 48);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.label36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Image = ((System.Drawing.Image)(resources.GetObject("label36.Image")));
            this.label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label36.Location = new System.Drawing.Point(7, 5);
            this.label36.Name = "label36";
            this.label36.Padding = new System.Windows.Forms.Padding(20, 0, 38, 0);
            this.label36.Size = new System.Drawing.Size(230, 37);
            this.label36.TabIndex = 182;
            this.label36.Text = "EnterprizID";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1456, 695);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Owner Abacus v(1.0)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TabControl.ResumeLayout(false);
            this.tpOverview.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuggestedOwner)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvACLScore)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblReadData;
		private System.Windows.Forms.TextBox tbCreateDirectories;
		private System.Windows.Forms.Label lblWriteData;
		private System.Windows.Forms.TextBox tbWriteData;
		private System.Windows.Forms.Label lblCreateFiles;
		private System.Windows.Forms.TextBox tbCreateFiles;
		private System.Windows.Forms.Label lblExecuteFile;
		private System.Windows.Forms.Label lblCreateDirectories;
		private System.Windows.Forms.TextBox tbReadData;
		private System.Windows.Forms.TextBox tbExecuteFile;
		private System.Windows.Forms.TextBox tbDelete;
		private System.Windows.Forms.TextBox tbWrite;
		private System.Windows.Forms.Label lblDelete;
		private System.Windows.Forms.Label lblWrite;
		private System.Windows.Forms.Label lblDeleteSubDirectoriesAndFiles;
		private System.Windows.Forms.TextBox tbDeleteSubdirectories;
		private System.Windows.Forms.Label lblRead;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox tbRead;
		private System.Windows.Forms.TextBox tbReadAndExecute;
		private System.Windows.Forms.Label lblReadAndExecute;
		private System.Windows.Forms.TextBox tbTakeOwnership;
		private System.Windows.Forms.Label lblTakeOwnership;
		private System.Windows.Forms.Label lblChangePassword;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox tbChangePermissions;
		private System.Windows.Forms.Label lblModify;
		private System.Windows.Forms.TextBox tbModify;
		private System.Windows.Forms.Label lblFullControl;
		private System.Windows.Forms.TextBox tbFullControl;
		private System.Windows.Forms.ListBox lstLogs;
		private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tpOverview;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.Label lblUNCPath;
        private System.Windows.Forms.TextBox tbUNCPath;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblDomainName;
        private System.Windows.Forms.TextBox tbDomainName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblControlPanelUnselect;
        private System.Windows.Forms.Label lblConfigUnselect;
        private System.Windows.Forms.Label lblStatsUnselect;
        private System.Windows.Forms.Label lblControlPanelSelect;
        private System.Windows.Forms.Label lblConfigSelect;
        private System.Windows.Forms.Label lblStatsSelect;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.DataGridView dgvACLScore;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActivityTopRecords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtACLTopRecords;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridView dgvSuggestedOwner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
		private PictureBox pictureBox1;
		private Label lblDirOwnerPic;
		private Label lblDirOwnerName;
		private DataGridViewImageColumn dataGridViewImageColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewImageColumn Avtar;
		private DataGridViewTextBoxColumn Username;
		private DataGridViewTextBoxColumn FilesCount;
        private Panel panel5;
        private Label label4;
        private Label label5;
        private Label label7;
        private Panel panel6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel7;
        private Label label12;
        private Label label13;
        private Label label14;
        private Panel panel8;
        private Label label15;
        private Label label16;
        private Label label17;
        private Panel panel9;
        private Label label21;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label22;
        private Label label1;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label11;
        private Label label18;
        private Label label20;
        private Label label27;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Panel panel10;
        private Label label3;
        private Label label37;
        private Label label38;
        private Label label36;
    }
}

