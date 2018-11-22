namespace scriptEditorForYGOPRO2
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
            this.sButton = new System.Windows.Forms.Button();
            this.idButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteLocalButton = new System.Windows.Forms.Button();
            this.doEverythingButton = new System.Windows.Forms.Button();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorkerDoEverything = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // sButton
            // 
            this.sButton.Location = new System.Drawing.Point(1049, 12);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(94, 23);
            this.sButton.TabIndex = 0;
            this.sButton.Text = "replace s.";
            this.sButton.UseVisualStyleBackColor = true;
            this.sButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // idButton
            // 
            this.idButton.Location = new System.Drawing.Point(1049, 41);
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(94, 23);
            this.idButton.TabIndex = 1;
            this.idButton.Text = "replace id";
            this.idButton.UseVisualStyleBackColor = true;
            this.idButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 576);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(226, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(764, 574);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1049, 426);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteLocalButton
            // 
            this.deleteLocalButton.Location = new System.Drawing.Point(1049, 71);
            this.deleteLocalButton.Name = "deleteLocalButton";
            this.deleteLocalButton.Size = new System.Drawing.Size(94, 23);
            this.deleteLocalButton.TabIndex = 5;
            this.deleteLocalButton.Text = "delete local s,id";
            this.deleteLocalButton.UseVisualStyleBackColor = true;
            this.deleteLocalButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // doEverythingButton
            // 
            this.doEverythingButton.Location = new System.Drawing.Point(1049, 138);
            this.doEverythingButton.Name = "doEverythingButton";
            this.doEverythingButton.Size = new System.Drawing.Size(94, 23);
            this.doEverythingButton.TabIndex = 6;
            this.doEverythingButton.Text = "Do everything for everything";
            this.doEverythingButton.UseVisualStyleBackColor = true;
            this.doEverythingButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(1049, 182);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(94, 23);
            this.selectFolderButton.TabIndex = 7;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "D:\\ygopro_vs_links_beta";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // backgroundWorkerDoEverything
            // 
            this.backgroundWorkerDoEverything.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDoEverything_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1155, 757);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.doEverythingButton);
            this.Controls.Add(this.deleteLocalButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.idButton);
            this.Controls.Add(this.sButton);
            this.Name = "Form1";
            this.Text = "SomeCatchyNameTemplete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sButton;
        private System.Windows.Forms.Button idButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteLocalButton;
        private System.Windows.Forms.Button doEverythingButton;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDoEverything;
    }
}

