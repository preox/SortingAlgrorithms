﻿namespace SortingAlgrorithms
{
    partial class MainWindow
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
            this.scrambleListButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.quickSortButton = new System.Windows.Forms.Button();
            this.quickSortTimeLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBarLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heapSortTimeLabel = new System.Windows.Forms.Label();
            this.heapSortButton = new System.Windows.Forms.Button();
            this.selectionSortTimeLabel = new System.Windows.Forms.Label();
            this.selectionSortButton = new System.Windows.Forms.Button();
            this.insertionSortButton = new System.Windows.Forms.Button();
            this.insertionSortTimeLabel = new System.Windows.Forms.Label();
            this.bubbleSortTimeLabel = new System.Windows.Forms.Label();
            this.bubbleSortButton = new System.Windows.Forms.Button();
            this.reversedListButton = new System.Windows.Forms.Button();
            this.fewUniqueButton = new System.Windows.Forms.Button();
            this.almostSortedButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shellSortTimeLabel = new System.Windows.Forms.Label();
            this.shellSortButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.doAllButton = new System.Windows.Forms.Button();
            this.radioAlmost = new System.Windows.Forms.RadioButton();
            this.radioFewUnique = new System.Windows.Forms.RadioButton();
            this.radioReversed = new System.Windows.Forms.RadioButton();
            this.radioRandom = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new SortingAlgrorithms.FlickerFreeListBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrambleListButton
            // 
            this.scrambleListButton.Location = new System.Drawing.Point(6, 109);
            this.scrambleListButton.Name = "scrambleListButton";
            this.scrambleListButton.Size = new System.Drawing.Size(73, 23);
            this.scrambleListButton.TabIndex = 1;
            this.scrambleListButton.Text = "Random list";
            this.scrambleListButton.UseVisualStyleBackColor = true;
            this.scrambleListButton.Click += new System.EventHandler(this.scrambleListButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(12, 508);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(102, 23);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit Program";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // quickSortButton
            // 
            this.quickSortButton.Location = new System.Drawing.Point(6, 21);
            this.quickSortButton.Name = "quickSortButton";
            this.quickSortButton.Size = new System.Drawing.Size(89, 23);
            this.quickSortButton.TabIndex = 3;
            this.quickSortButton.Text = "QuickSort";
            this.quickSortButton.UseVisualStyleBackColor = true;
            this.quickSortButton.Click += new System.EventHandler(this.quickSortButton_Click);
            // 
            // quickSortTimeLabel
            // 
            this.quickSortTimeLabel.AutoSize = true;
            this.quickSortTimeLabel.Location = new System.Drawing.Point(101, 26);
            this.quickSortTimeLabel.Name = "quickSortTimeLabel";
            this.quickSortTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.quickSortTimeLabel.TabIndex = 4;
            this.quickSortTimeLabel.Text = "Time Elapsed:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 34);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(89, 45);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarLabel
            // 
            this.trackBarLabel.AutoSize = true;
            this.trackBarLabel.Location = new System.Drawing.Point(60, 18);
            this.trackBarLabel.Name = "trackBarLabel";
            this.trackBarLabel.Size = new System.Drawing.Size(35, 13);
            this.trackBarLabel.TabIndex = 6;
            this.trackBarLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Delay time: ";
            // 
            // heapSortTimeLabel
            // 
            this.heapSortTimeLabel.AutoSize = true;
            this.heapSortTimeLabel.Location = new System.Drawing.Point(101, 55);
            this.heapSortTimeLabel.Name = "heapSortTimeLabel";
            this.heapSortTimeLabel.Size = new System.Drawing.Size(77, 13);
            this.heapSortTimeLabel.TabIndex = 12;
            this.heapSortTimeLabel.Text = "Time Elapsed: ";
            // 
            // heapSortButton
            // 
            this.heapSortButton.Location = new System.Drawing.Point(6, 50);
            this.heapSortButton.Name = "heapSortButton";
            this.heapSortButton.Size = new System.Drawing.Size(89, 23);
            this.heapSortButton.TabIndex = 13;
            this.heapSortButton.Text = "Heap Sort";
            this.heapSortButton.UseVisualStyleBackColor = true;
            this.heapSortButton.Click += new System.EventHandler(this.heapSortButton_Click);
            // 
            // selectionSortTimeLabel
            // 
            this.selectionSortTimeLabel.AutoSize = true;
            this.selectionSortTimeLabel.Location = new System.Drawing.Point(101, 85);
            this.selectionSortTimeLabel.Name = "selectionSortTimeLabel";
            this.selectionSortTimeLabel.Size = new System.Drawing.Size(77, 13);
            this.selectionSortTimeLabel.TabIndex = 14;
            this.selectionSortTimeLabel.Text = "Time Elapsed: ";
            // 
            // selectionSortButton
            // 
            this.selectionSortButton.Location = new System.Drawing.Point(6, 80);
            this.selectionSortButton.Name = "selectionSortButton";
            this.selectionSortButton.Size = new System.Drawing.Size(89, 23);
            this.selectionSortButton.TabIndex = 15;
            this.selectionSortButton.Text = "Selection Sort";
            this.selectionSortButton.UseVisualStyleBackColor = true;
            this.selectionSortButton.Click += new System.EventHandler(this.selectionSortButton_Click);
            // 
            // insertionSortButton
            // 
            this.insertionSortButton.Location = new System.Drawing.Point(6, 109);
            this.insertionSortButton.Name = "insertionSortButton";
            this.insertionSortButton.Size = new System.Drawing.Size(89, 23);
            this.insertionSortButton.TabIndex = 16;
            this.insertionSortButton.Text = "Insertion Sort";
            this.insertionSortButton.UseVisualStyleBackColor = true;
            this.insertionSortButton.Click += new System.EventHandler(this.insertionSortButton_Click);
            // 
            // insertionSortTimeLabel
            // 
            this.insertionSortTimeLabel.AutoSize = true;
            this.insertionSortTimeLabel.Location = new System.Drawing.Point(101, 114);
            this.insertionSortTimeLabel.Name = "insertionSortTimeLabel";
            this.insertionSortTimeLabel.Size = new System.Drawing.Size(77, 13);
            this.insertionSortTimeLabel.TabIndex = 17;
            this.insertionSortTimeLabel.Text = "Time Elapsed: ";
            // 
            // bubbleSortTimeLabel
            // 
            this.bubbleSortTimeLabel.AutoSize = true;
            this.bubbleSortTimeLabel.Location = new System.Drawing.Point(101, 144);
            this.bubbleSortTimeLabel.Name = "bubbleSortTimeLabel";
            this.bubbleSortTimeLabel.Size = new System.Drawing.Size(77, 13);
            this.bubbleSortTimeLabel.TabIndex = 18;
            this.bubbleSortTimeLabel.Text = "Time Elapsed: ";
            // 
            // bubbleSortButton
            // 
            this.bubbleSortButton.Location = new System.Drawing.Point(6, 139);
            this.bubbleSortButton.Name = "bubbleSortButton";
            this.bubbleSortButton.Size = new System.Drawing.Size(89, 23);
            this.bubbleSortButton.TabIndex = 19;
            this.bubbleSortButton.Text = "Bubble Sort";
            this.bubbleSortButton.UseVisualStyleBackColor = true;
            this.bubbleSortButton.Click += new System.EventHandler(this.bubbleSortButton_Click);
            // 
            // reversedListButton
            // 
            this.reversedListButton.Location = new System.Drawing.Point(85, 109);
            this.reversedListButton.Name = "reversedListButton";
            this.reversedListButton.Size = new System.Drawing.Size(73, 23);
            this.reversedListButton.TabIndex = 20;
            this.reversedListButton.Text = "Reversed list";
            this.reversedListButton.UseVisualStyleBackColor = true;
            this.reversedListButton.Click += new System.EventHandler(this.reversedListButton_Click);
            // 
            // fewUniqueButton
            // 
            this.fewUniqueButton.Location = new System.Drawing.Point(6, 138);
            this.fewUniqueButton.Name = "fewUniqueButton";
            this.fewUniqueButton.Size = new System.Drawing.Size(73, 23);
            this.fewUniqueButton.TabIndex = 21;
            this.fewUniqueButton.Text = "Few unique";
            this.fewUniqueButton.UseVisualStyleBackColor = true;
            this.fewUniqueButton.Click += new System.EventHandler(this.fewUniqueButton_Click);
            // 
            // almostSortedButton
            // 
            this.almostSortedButton.Location = new System.Drawing.Point(85, 138);
            this.almostSortedButton.Name = "almostSortedButton";
            this.almostSortedButton.Size = new System.Drawing.Size(73, 23);
            this.almostSortedButton.TabIndex = 22;
            this.almostSortedButton.Text = "Almost Sorted";
            this.almostSortedButton.UseVisualStyleBackColor = true;
            this.almostSortedButton.Click += new System.EventHandler(this.almostSortedButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shellSortTimeLabel);
            this.groupBox1.Controls.Add(this.shellSortButton);
            this.groupBox1.Controls.Add(this.quickSortButton);
            this.groupBox1.Controls.Add(this.quickSortTimeLabel);
            this.groupBox1.Controls.Add(this.heapSortTimeLabel);
            this.groupBox1.Controls.Add(this.heapSortButton);
            this.groupBox1.Controls.Add(this.selectionSortTimeLabel);
            this.groupBox1.Controls.Add(this.bubbleSortButton);
            this.groupBox1.Controls.Add(this.selectionSortButton);
            this.groupBox1.Controls.Add(this.bubbleSortTimeLabel);
            this.groupBox1.Controls.Add(this.insertionSortButton);
            this.groupBox1.Controls.Add(this.insertionSortTimeLabel);
            this.groupBox1.Location = new System.Drawing.Point(279, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 204);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available algorithms";
            // 
            // shellSortTimeLabel
            // 
            this.shellSortTimeLabel.AutoSize = true;
            this.shellSortTimeLabel.Location = new System.Drawing.Point(101, 174);
            this.shellSortTimeLabel.Name = "shellSortTimeLabel";
            this.shellSortTimeLabel.Size = new System.Drawing.Size(77, 13);
            this.shellSortTimeLabel.TabIndex = 21;
            this.shellSortTimeLabel.Text = "Time Elapsed: ";
            // 
            // shellSortButton
            // 
            this.shellSortButton.Location = new System.Drawing.Point(6, 169);
            this.shellSortButton.Name = "shellSortButton";
            this.shellSortButton.Size = new System.Drawing.Size(89, 23);
            this.shellSortButton.TabIndex = 20;
            this.shellSortButton.Text = "Shell Sort";
            this.shellSortButton.UseVisualStyleBackColor = true;
            this.shellSortButton.Click += new System.EventHandler(this.shellSortButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doAllButton);
            this.groupBox2.Controls.Add(this.radioAlmost);
            this.groupBox2.Controls.Add(this.radioFewUnique);
            this.groupBox2.Controls.Add(this.radioReversed);
            this.groupBox2.Controls.Add(this.radioRandom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.fewUniqueButton);
            this.groupBox2.Controls.Add(this.scrambleListButton);
            this.groupBox2.Controls.Add(this.trackBarLabel);
            this.groupBox2.Controls.Add(this.almostSortedButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.reversedListButton);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 297);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Control";
            // 
            // doAllButton
            // 
            this.doAllButton.Location = new System.Drawing.Point(156, 245);
            this.doAllButton.Name = "doAllButton";
            this.doAllButton.Size = new System.Drawing.Size(80, 41);
            this.doAllButton.TabIndex = 29;
            this.doAllButton.Text = "Run on all algorithms!";
            this.doAllButton.UseVisualStyleBackColor = true;
            this.doAllButton.Click += new System.EventHandler(this.doAllButton_Click);
            // 
            // radioAlmost
            // 
            this.radioAlmost.AutoSize = true;
            this.radioAlmost.Location = new System.Drawing.Point(6, 269);
            this.radioAlmost.Name = "radioAlmost";
            this.radioAlmost.Size = new System.Drawing.Size(103, 17);
            this.radioAlmost.TabIndex = 28;
            this.radioAlmost.TabStop = true;
            this.radioAlmost.Text = "Almost sorted list";
            this.radioAlmost.UseVisualStyleBackColor = true;
            // 
            // radioFewUnique
            // 
            this.radioFewUnique.AutoSize = true;
            this.radioFewUnique.Location = new System.Drawing.Point(6, 245);
            this.radioFewUnique.Name = "radioFewUnique";
            this.radioFewUnique.Size = new System.Drawing.Size(135, 17);
            this.radioFewUnique.TabIndex = 27;
            this.radioFewUnique.TabStop = true;
            this.radioFewUnique.Text = "Few Unique items in list";
            this.radioFewUnique.UseVisualStyleBackColor = true;
            // 
            // radioReversed
            // 
            this.radioReversed.AutoSize = true;
            this.radioReversed.Location = new System.Drawing.Point(6, 221);
            this.radioReversed.Name = "radioReversed";
            this.radioReversed.Size = new System.Drawing.Size(86, 17);
            this.radioReversed.TabIndex = 26;
            this.radioReversed.TabStop = true;
            this.radioReversed.Text = "Reversed list";
            this.radioReversed.UseVisualStyleBackColor = true;
            // 
            // radioRandom
            // 
            this.radioRandom.AutoSize = true;
            this.radioRandom.Location = new System.Drawing.Point(6, 197);
            this.radioRandom.Name = "radioRandom";
            this.radioRandom.Size = new System.Drawing.Size(99, 17);
            this.radioRandom.TabIndex = 25;
            this.radioRandom.TabStop = true;
            this.radioRandom.Text = "Randomized list";
            this.radioRandom.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Run algormiths on:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Randomize list: ";
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 6;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 490);
            this.listBox1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Sorting algorithms visualized";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.ListBox listBox1;
        private FlickerFreeListBox listBox1;
        
        private System.Windows.Forms.Button scrambleListButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button quickSortButton;
        private System.Windows.Forms.Label quickSortTimeLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label trackBarLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label heapSortTimeLabel;
        private System.Windows.Forms.Button heapSortButton;
        private System.Windows.Forms.Label selectionSortTimeLabel;
        private System.Windows.Forms.Button selectionSortButton;
        private System.Windows.Forms.Button insertionSortButton;
        private System.Windows.Forms.Label insertionSortTimeLabel;
        private System.Windows.Forms.Label bubbleSortTimeLabel;
        private System.Windows.Forms.Button bubbleSortButton;
        private System.Windows.Forms.Button reversedListButton;
        private System.Windows.Forms.Button fewUniqueButton;
        private System.Windows.Forms.Button almostSortedButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioAlmost;
        private System.Windows.Forms.RadioButton radioFewUnique;
        private System.Windows.Forms.RadioButton radioReversed;
        private System.Windows.Forms.RadioButton radioRandom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button doAllButton;
        private System.Windows.Forms.Label shellSortTimeLabel;
        private System.Windows.Forms.Button shellSortButton;
    }
}

