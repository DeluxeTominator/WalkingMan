namespace WalkingMan
{
    partial class frmWalkingMan
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
            this.lbl = new System.Windows.Forms.Label();
            this.btnWalk = new System.Windows.Forms.Button();
            this.picMan = new System.Windows.Forms.PictureBox();
            this.mnuWalkingMan = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).BeginInit();
            this.mnuWalkingMan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(-5, 201);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(1177, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "__________________________________";
            // 
            // btnWalk
            // 
            this.btnWalk.Location = new System.Drawing.Point(338, 12);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(145, 23);
            this.btnWalk.TabIndex = 1;
            this.btnWalk.Text = "Gotta go fast!";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // picMan
            // 
            this.picMan.Location = new System.Drawing.Point(704, 34);
            this.picMan.Name = "picMan";
            this.picMan.Size = new System.Drawing.Size(100, 104);
            this.picMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMan.TabIndex = 2;
            this.picMan.TabStop = false;
            // 
            // mnuWalkingMan
            // 
            this.mnuWalkingMan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuWalkingMan.Location = new System.Drawing.Point(0, 0);
            this.mnuWalkingMan.Name = "mnuWalkingMan";
            this.mnuWalkingMan.Size = new System.Drawing.Size(897, 24);
            this.mnuWalkingMan.TabIndex = 3;
            this.mnuWalkingMan.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 261);
            this.Controls.Add(this.picMan);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.mnuWalkingMan);
            this.MainMenuStrip = this.mnuWalkingMan;
            this.Name = "frmWalkingMan";
            this.Text = "Walking man";
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).EndInit();
            this.mnuWalkingMan.ResumeLayout(false);
            this.mnuWalkingMan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.PictureBox picMan;
        private System.Windows.Forms.MenuStrip mnuWalkingMan;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

