namespace HyggeWindowsForms
{
    partial class PoemWindow
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
            this.cmbPoems = new System.Windows.Forms.ComboBox();
            this.lblChooseAPoem = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbPoems
            // 
            this.cmbPoems.FormattingEnabled = true;
            this.cmbPoems.Items.AddRange(new object[] {
            "sea.txt",
            "sky.txt",
            "forest.txt"});
            this.cmbPoems.Location = new System.Drawing.Point(129, 114);
            this.cmbPoems.Name = "cmbPoems";
            this.cmbPoems.Size = new System.Drawing.Size(159, 21);
            this.cmbPoems.TabIndex = 0;
            // 
            // lblChooseAPoem
            // 
            this.lblChooseAPoem.AutoSize = true;
            this.lblChooseAPoem.Location = new System.Drawing.Point(126, 98);
            this.lblChooseAPoem.Name = "lblChooseAPoem";
            this.lblChooseAPoem.Size = new System.Drawing.Size(90, 13);
            this.lblChooseAPoem.TabIndex = 1;
            this.lblChooseAPoem.Text = "Choose a poem...";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(129, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(394, 114);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(223, 137);
            this.txtBox.TabIndex = 3;
            // 
            // PoemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblChooseAPoem);
            this.Controls.Add(this.cmbPoems);
            this.Name = "PoemWindow";
            this.Text = "PoemWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPoems;
        private System.Windows.Forms.Label lblChooseAPoem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBox;
    }
}

