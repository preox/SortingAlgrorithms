namespace SortingAlgrorithms
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.scrambleListButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.quickSortButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 6;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 508);
            this.listBox1.TabIndex = 0;
            // 
            // scrambleListButton
            // 
            this.scrambleListButton.Location = new System.Drawing.Point(279, 12);
            this.scrambleListButton.Name = "scrambleListButton";
            this.scrambleListButton.Size = new System.Drawing.Size(102, 23);
            this.scrambleListButton.TabIndex = 1;
            this.scrambleListButton.Text = "Scramble List";
            this.scrambleListButton.UseVisualStyleBackColor = true;
            this.scrambleListButton.Click += new System.EventHandler(this.scrambleListButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(298, 497);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(102, 23);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit Program";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // quickSortButton
            // 
            this.quickSortButton.Location = new System.Drawing.Point(279, 52);
            this.quickSortButton.Name = "quickSortButton";
            this.quickSortButton.Size = new System.Drawing.Size(75, 23);
            this.quickSortButton.TabIndex = 3;
            this.quickSortButton.Text = "QuickSort";
            this.quickSortButton.UseVisualStyleBackColor = true;
            this.quickSortButton.Click += new System.EventHandler(this.quickSortButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(360, 57);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(74, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time Elapsed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 538);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.quickSortButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.scrambleListButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Sorting algorithms visualized";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button scrambleListButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button quickSortButton;
        private System.Windows.Forms.Label timeLabel;
    }
}

