namespace AthleteWithClasses
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbtnLawyer = new System.Windows.Forms.RadioButton();
            this.rbtnPA = new System.Windows.Forms.RadioButton();
            this.rbtnTrainer = new System.Windows.Forms.RadioButton();
            this.rbtnAgent = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gboxProf = new System.Windows.Forms.GroupBox();
            this.lboxProfs = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChange = new System.Windows.Forms.Button();
            this.gboxAthlete = new System.Windows.Forms.GroupBox();
            this.lblAthName = new System.Windows.Forms.Label();
            this.gboxProf.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gboxAthlete.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // rbtnLawyer
            // 
            this.rbtnLawyer.AutoSize = true;
            this.rbtnLawyer.Location = new System.Drawing.Point(38, 31);
            this.rbtnLawyer.Name = "rbtnLawyer";
            this.rbtnLawyer.Size = new System.Drawing.Size(59, 17);
            this.rbtnLawyer.TabIndex = 1;
            this.rbtnLawyer.TabStop = true;
            this.rbtnLawyer.Text = "Lawyer";
            this.rbtnLawyer.UseVisualStyleBackColor = true;
            // 
            // rbtnPA
            // 
            this.rbtnPA.AutoSize = true;
            this.rbtnPA.Location = new System.Drawing.Point(38, 67);
            this.rbtnPA.Name = "rbtnPA";
            this.rbtnPA.Size = new System.Drawing.Size(111, 17);
            this.rbtnPA.TabIndex = 2;
            this.rbtnPA.TabStop = true;
            this.rbtnPA.Text = "Personal Assistant";
            this.rbtnPA.UseVisualStyleBackColor = true;
            // 
            // rbtnTrainer
            // 
            this.rbtnTrainer.AutoSize = true;
            this.rbtnTrainer.Location = new System.Drawing.Point(38, 103);
            this.rbtnTrainer.Name = "rbtnTrainer";
            this.rbtnTrainer.Size = new System.Drawing.Size(58, 17);
            this.rbtnTrainer.TabIndex = 3;
            this.rbtnTrainer.TabStop = true;
            this.rbtnTrainer.Text = "Trainer";
            this.rbtnTrainer.UseVisualStyleBackColor = true;
            // 
            // rbtnAgent
            // 
            this.rbtnAgent.AutoSize = true;
            this.rbtnAgent.Location = new System.Drawing.Point(38, 139);
            this.rbtnAgent.Name = "rbtnAgent";
            this.rbtnAgent.Size = new System.Drawing.Size(53, 17);
            this.rbtnAgent.TabIndex = 4;
            this.rbtnAgent.TabStop = true;
            this.rbtnAgent.Text = "Agent";
            this.rbtnAgent.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(109, 351);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 43);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Add Professional";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(237, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Remove Professional";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gboxProf
            // 
            this.gboxProf.Controls.Add(this.rbtnLawyer);
            this.gboxProf.Controls.Add(this.rbtnPA);
            this.gboxProf.Controls.Add(this.rbtnTrainer);
            this.gboxProf.Controls.Add(this.rbtnAgent);
            this.gboxProf.Location = new System.Drawing.Point(71, 112);
            this.gboxProf.Name = "gboxProf";
            this.gboxProf.Size = new System.Drawing.Size(162, 183);
            this.gboxProf.TabIndex = 8;
            this.gboxProf.TabStop = false;
            this.gboxProf.Text = "Pick a profession: ";
            // 
            // lboxProfs
            // 
            this.lboxProfs.FormattingEnabled = true;
            this.lboxProfs.Location = new System.Drawing.Point(279, 122);
            this.lboxProfs.Name = "lboxProfs";
            this.lboxProfs.Size = new System.Drawing.Size(188, 173);
            this.lboxProfs.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(17, 153);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(183, 59);
            this.lblTotal.TabIndex = 9;
            // 
            // lblGross
            // 
            this.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGross.Location = new System.Drawing.Point(17, 75);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(183, 59);
            this.lblGross.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Professional\'s Name: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(363, 351);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(86, 43);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change Athlete";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // gboxAthlete
            // 
            this.gboxAthlete.Controls.Add(this.lblAthName);
            this.gboxAthlete.Controls.Add(this.lblTotal);
            this.gboxAthlete.Controls.Add(this.lblGross);
            this.gboxAthlete.Location = new System.Drawing.Point(503, 98);
            this.gboxAthlete.Name = "gboxAthlete";
            this.gboxAthlete.Size = new System.Drawing.Size(216, 226);
            this.gboxAthlete.TabIndex = 15;
            this.gboxAthlete.TabStop = false;
            this.gboxAthlete.Text = "Current Athlete: ";
            // 
            // lblAthName
            // 
            this.lblAthName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAthName.Location = new System.Drawing.Point(17, 24);
            this.lblAthName.Name = "lblAthName";
            this.lblAthName.Size = new System.Drawing.Size(183, 23);
            this.lblAthName.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 561);
            this.Controls.Add(this.gboxAthlete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxProfs);
            this.Controls.Add(this.gboxProf);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Professional Hire Form";
            this.gboxProf.ResumeLayout(false);
            this.gboxProf.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboxAthlete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbtnLawyer;
        private System.Windows.Forms.RadioButton rbtnPA;
        private System.Windows.Forms.RadioButton rbtnTrainer;
        private System.Windows.Forms.RadioButton rbtnAgent;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gboxProf;
        private System.Windows.Forms.ListBox lboxProfs;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.GroupBox gboxAthlete;
        private System.Windows.Forms.Label lblAthName;
    }
}

