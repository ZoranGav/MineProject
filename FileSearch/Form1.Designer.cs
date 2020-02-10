namespace FileSearch
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
            this.directoryLocationBox = new System.Windows.Forms.TextBox();
            this.directoryLocationBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.itmesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directoryLocationBox
            // 
            this.directoryLocationBox.Location = new System.Drawing.Point(70, 306);
            this.directoryLocationBox.Name = "directoryLocationBox";
            this.directoryLocationBox.Size = new System.Drawing.Size(529, 20);
            this.directoryLocationBox.TabIndex = 0;
            // 
            // directoryLocationBtn
            // 
            this.directoryLocationBtn.Location = new System.Drawing.Point(605, 306);
            this.directoryLocationBtn.Name = "directoryLocationBtn";
            this.directoryLocationBtn.Size = new System.Drawing.Size(46, 20);
            this.directoryLocationBtn.TabIndex = 1;
            this.directoryLocationBtn.Text = "...";
            this.directoryLocationBtn.UseVisualStyleBackColor = true;
            this.directoryLocationBtn.Click += new System.EventHandler(this.directoryLocationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(15, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(549, 20);
            this.searchTextBox.TabIndex = 3;
            
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(576, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // itmesListBox
            // 
            this.itmesListBox.FormattingEnabled = true;
            this.itmesListBox.Location = new System.Drawing.Point(15, 42);
            this.itmesListBox.Name = "itmesListBox";
            this.itmesListBox.Size = new System.Drawing.Size(636, 238);
            this.itmesListBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itmesListBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryLocationBtn);
            this.Controls.Add(this.directoryLocationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "String Searcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directoryLocationBox;
        private System.Windows.Forms.Button directoryLocationBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox itmesListBox;
        private System.Windows.Forms.Label label2;
    }
}

