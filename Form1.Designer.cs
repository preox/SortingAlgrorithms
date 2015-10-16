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
            this.quickSortTimeLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBarLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heapSortTimeLabel = new System.Windows.Forms.Label();
            this.heapSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.scrambleListButton.Location = new System.Drawing.Point(279, 80);
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
            this.quickSortButton.Location = new System.Drawing.Point(279, 152);
            this.quickSortButton.Name = "quickSortButton";
            this.quickSortButton.Size = new System.Drawing.Size(75, 23);
            this.quickSortButton.TabIndex = 3;
            this.quickSortButton.Text = "QuickSort";
            this.quickSortButton.UseVisualStyleBackColor = true;
            this.quickSortButton.Click += new System.EventHandler(this.quickSortButton_Click);
            // 
            // quickSortTimeLabel
            // 
            this.quickSortTimeLabel.AutoSize = true;
            this.quickSortTimeLabel.Location = new System.Drawing.Point(360, 157);
            this.quickSortTimeLabel.Name = "quickSortTimeLabel";
            this.quickSortTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.quickSortTimeLabel.TabIndex = 4;
            this.quickSortTimeLabel.Text = "Time Elapsed:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(279, 29);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarLabel
            // 
            this.trackBarLabel.AutoSize = true;
            this.trackBarLabel.Location = new System.Drawing.Point(346, 13);
            this.trackBarLabel.Name = "trackBarLabel";
            this.trackBarLabel.Size = new System.Drawing.Size(35, 13);
            this.trackBarLabel.TabIndex = 6;
            this.trackBarLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Delay time: ";
            // 
            // heapSortTimeLabel
            // 
            this.heapSortTimeLabel.AutoSize = true;
            this.heapSortTimeLabel.Location = new System.Drawing.Point(360, 186);
            this.heapSortTimeLabel.Name = "heapSortTimeLabel";
            this.heapSortTimeLabel.Size = new System.Drawing.Size(77, 13);
            this.heapSortTimeLabel.TabIndex = 12;
            this.heapSortTimeLabel.Text = "Time Elapsed: ";
            // 
            // heapSortButton
            // 
            this.heapSortButton.Location = new System.Drawing.Point(279, 181);
            this.heapSortButton.Name = "heapSortButton";
            this.heapSortButton.Size = new System.Drawing.Size(75, 23);
            this.heapSortButton.TabIndex = 13;
            this.heapSortButton.Text = "Heap Sort";
            this.heapSortButton.UseVisualStyleBackColor = true;
            this.heapSortButton.Click += new System.EventHandler(this.heapSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 538);
            this.Controls.Add(this.heapSortButton);
            this.Controls.Add(this.heapSortTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.quickSortTimeLabel);
            this.Controls.Add(this.quickSortButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.scrambleListButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Sorting algorithms visualized";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button scrambleListButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button quickSortButton;
        private System.Windows.Forms.Label quickSortTimeLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label trackBarLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label heapSortTimeLabel;
        private System.Windows.Forms.Button heapSortButton;
    }
}

