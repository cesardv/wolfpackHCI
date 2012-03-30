namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.patherrorlbl = new System.Windows.Forms.Label();
            this.temper = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.picfilename = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TrainingTips = new System.Windows.Forms.TextBox();
            this.HasTrainingTips = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.healthIssue = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HasHealthIssues = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lifespanend = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lifespanstart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.origin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.breedname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtbx = new System.Windows.Forms.TextBox();
            this.breedNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jsonfile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imagefilenaneTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.heightTxtbox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.heightTxtbox);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.patherrorlbl);
            this.tabPage1.Controls.Add(this.temper);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.picfilename);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.TrainingTips);
            this.tabPage1.Controls.Add(this.HasTrainingTips);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.healthIssue);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.HasHealthIssues);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lifespanend);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lifespanstart);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.origin);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.group);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.weight);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.breedname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.idTxtbx);
            this.tabPage1.Controls.Add(this.breedNotes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.jsonfile);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // patherrorlbl
            // 
            resources.ApplyResources(this.patherrorlbl, "patherrorlbl");
            this.patherrorlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.patherrorlbl.Name = "patherrorlbl";
            // 
            // temper
            // 
            this.temper.FormattingEnabled = true;
            this.temper.Items.AddRange(new object[] {
            resources.GetString("temper.Items"),
            resources.GetString("temper.Items1"),
            resources.GetString("temper.Items2"),
            resources.GetString("temper.Items3"),
            resources.GetString("temper.Items4"),
            resources.GetString("temper.Items5"),
            resources.GetString("temper.Items6"),
            resources.GetString("temper.Items7")});
            resources.ApplyResources(this.temper, "temper");
            this.temper.Name = "temper";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            this.imagefilenaneTooltip.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            // 
            // picfilename
            // 
            resources.ApplyResources(this.picfilename, "picfilename");
            this.picfilename.Name = "picfilename";
            this.imagefilenaneTooltip.SetToolTip(this.picfilename, resources.GetString("picfilename.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // TrainingTips
            // 
            resources.ApplyResources(this.TrainingTips, "TrainingTips");
            this.TrainingTips.Name = "TrainingTips";
            // 
            // HasTrainingTips
            // 
            this.HasTrainingTips.FormattingEnabled = true;
            this.HasTrainingTips.Items.AddRange(new object[] {
            resources.GetString("HasTrainingTips.Items"),
            resources.GetString("HasTrainingTips.Items1")});
            resources.ApplyResources(this.HasTrainingTips, "HasTrainingTips");
            this.HasTrainingTips.Name = "HasTrainingTips";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // healthIssue
            // 
            resources.ApplyResources(this.healthIssue, "healthIssue");
            this.healthIssue.Name = "healthIssue";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HasHealthIssues
            // 
            this.HasHealthIssues.FormattingEnabled = true;
            this.HasHealthIssues.Items.AddRange(new object[] {
            resources.GetString("HasHealthIssues.Items"),
            resources.GetString("HasHealthIssues.Items1")});
            resources.ApplyResources(this.HasHealthIssues, "HasHealthIssues");
            this.HasHealthIssues.Name = "HasHealthIssues";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // lifespanend
            // 
            resources.ApplyResources(this.lifespanend, "lifespanend");
            this.lifespanend.Name = "lifespanend";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lifespanstart
            // 
            resources.ApplyResources(this.lifespanstart, "lifespanstart");
            this.lifespanstart.Name = "lifespanstart";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // origin
            // 
            resources.ApplyResources(this.origin, "origin");
            this.origin.Name = "origin";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // group
            // 
            resources.ApplyResources(this.group, "group");
            this.group.Name = "group";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // weight
            // 
            resources.ApplyResources(this.weight, "weight");
            this.weight.Name = "weight";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // breedname
            // 
            resources.ApplyResources(this.breedname, "breedname");
            this.breedname.Name = "breedname";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // idTxtbx
            // 
            resources.ApplyResources(this.idTxtbx, "idTxtbx");
            this.idTxtbx.Name = "idTxtbx";
            this.idTxtbx.ReadOnly = true;
            // 
            // breedNotes
            // 
            resources.ApplyResources(this.breedNotes, "breedNotes");
            this.breedNotes.Name = "breedNotes";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // jsonfile
            // 
            resources.ApplyResources(this.jsonfile, "jsonfile");
            this.jsonfile.Name = "jsonfile";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imagefilenaneTooltip
            // 
            this.imagefilenaneTooltip.Tag = "filename of file that will fo into ./images of website";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // heightTxtbox
            // 
            resources.ApplyResources(this.heightTxtbox, "heightTxtbox");
            this.heightTxtbox.Name = "heightTxtbox";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TrainingTips;
        private System.Windows.Forms.ComboBox HasTrainingTips;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox healthIssue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox HasHealthIssues;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lifespanend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lifespanstart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox origin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox breedname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtbx;
        private System.Windows.Forms.TextBox breedNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jsonfile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox picfilename;
        private System.Windows.Forms.ToolTip imagefilenaneTooltip;
        private System.Windows.Forms.ComboBox temper;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label patherrorlbl;
        private System.Windows.Forms.TextBox heightTxtbox;
        private System.Windows.Forms.Label label17;
    }
}

