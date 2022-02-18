namespace Assignment2Client2
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
            this.btnFileOne = new System.Windows.Forms.Button();
            this.btnFileTwo = new System.Windows.Forms.Button();
            this.txtBoxTwo = new System.Windows.Forms.TextBox();
            this.txtBoxOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFileOne
            // 
            this.btnFileOne.Location = new System.Drawing.Point(132, 112);
            this.btnFileOne.Name = "btnFileOne";
            this.btnFileOne.Size = new System.Drawing.Size(163, 93);
            this.btnFileOne.TabIndex = 0;
            this.btnFileOne.Text = "File One";
            this.btnFileOne.UseVisualStyleBackColor = true;
            this.btnFileOne.Click += new System.EventHandler(this.btnFileOne_Click);
            // 
            // btnFileTwo
            // 
            this.btnFileTwo.Location = new System.Drawing.Point(341, 112);
            this.btnFileTwo.Name = "btnFileTwo";
            this.btnFileTwo.Size = new System.Drawing.Size(158, 93);
            this.btnFileTwo.TabIndex = 1;
            this.btnFileTwo.Text = "File Two";
            this.btnFileTwo.UseVisualStyleBackColor = true;
            // 
            // txtBoxTwo
            // 
            this.txtBoxTwo.Location = new System.Drawing.Point(341, 211);
            this.txtBoxTwo.Name = "txtBoxTwo";
            this.txtBoxTwo.Size = new System.Drawing.Size(158, 20);
            this.txtBoxTwo.TabIndex = 2;
            // 
            // txtBoxOne
            // 
            this.txtBoxOne.Location = new System.Drawing.Point(132, 211);
            this.txtBoxOne.Name = "txtBoxOne";
            this.txtBoxOne.Size = new System.Drawing.Size(163, 20);
            this.txtBoxOne.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path :";
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(127, 292);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(372, 20);
            this.txtBoxPath.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxOne);
            this.Controls.Add(this.txtBoxTwo);
            this.Controls.Add(this.btnFileTwo);
            this.Controls.Add(this.btnFileOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileOne;
        private System.Windows.Forms.Button btnFileTwo;
        private System.Windows.Forms.TextBox txtBoxTwo;
        private System.Windows.Forms.TextBox txtBoxOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPath;
    }
}

