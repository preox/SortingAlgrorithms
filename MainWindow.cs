using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SortingAlgrorithms
{
    public partial class MainWindow : Form
    {
        private static int noOfLines = 80;
        private List<string> dataSource;
        private BindingList<string> blData;
        private int sleepTime = 2;
        private delegate void  sortingAlgorithm(BindingList<string> data);
        public delegate void listUnsorter();
        private List<sortingAlgorithm> availableAlgorithms = new List<sortingAlgorithm>();
        

        public MainWindow()
        {
            InitializeComponent();
            trackBar1.Value = sleepTime;
            trackBarLabel.Text = sleepTime + " ms";

            dataSource = new List<string>();
            blData = new BindingList<string>(dataSource);
            listBox1.DataSource = blData;

            initiateList(listBox1);

            // TODO. Wonder how this could be done better.....
            availableAlgorithms.Add(new sortingAlgorithm(quickSortStarter));
            availableAlgorithms.Add(new sortingAlgorithm(heapSort));
            availableAlgorithms.Add(new sortingAlgorithm(selectionSort));
            availableAlgorithms.Add(new sortingAlgorithm(insertionSort));
            availableAlgorithms.Add(new sortingAlgorithm(bubbleSort));
            availableAlgorithms.Add(new sortingAlgorithm(shellSort));

        }


        #region Methods

        private void initiateList(ListBox listBox)
        {
            for (int i = 1; i < noOfLines + 1; i++)
            {
                blData.Add(getLine(i));
            }
            listScrambler();
        }


        /*
         *  swaps two items. as long as given indexes does not exceed list length. 
         */
        private void swap(int indexA, int indexB, BindingList<string> data)
        {
            if (sleepTime > 0)
            {
                System.Threading.Thread.Sleep(sleepTime);
                listBox1.Refresh();
            }

            if (indexA < blData.Count && indexB < blData.Count)
            {
                string temp = blData[indexA];
                blData[indexA] = blData[indexB];
                blData[indexB] = temp;
            }
        }

        /*
         * Returns a string of '#' with given length. 
         */
        private string getLine(int length)
        {
            string retVal = "";
            for (int i = 0; i < length; i++ )
            {
                retVal += "#";
            }
            return retVal;
        }


        /*
         * doAllSorting. 
         * Sets sleeptime to 0, then performs all algorithms on a selected listunsorter. 
         * That is, on a particular type of sorted list. (random/almost/fewunique....)
         * 
         */

        private void doAllSorting(listUnsorter selectedListUnsorter)
        {
            Cursor.Current = Cursors.WaitCursor; // Set cursor to wait
            int tempSleeptime = sleepTime;
            sleepTime = 0;
            
            selectedListUnsorter.Invoke();

            foreach(sortingAlgorithm alg in availableAlgorithms)
            {
                alg.Invoke(blData);
                selectedListUnsorter.Invoke();
            }
            
            sleepTime = tempSleeptime;
            Cursor.Current = Cursors.Default; // Restore cursor
        }

        #endregion

        #region Sorting algorithms

        /*
         * Quicksort. Or at least, an attempt at one. 
         * Based upon https://en.wikipedia.org/wiki/Quicksort
         * Note that pivot isn't randomly choosen. Not optimal
         */

        private void quickSortStarter(BindingList<string> data)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            quickSort(data, 0, blData.Count - 1);
            timer.Stop();
            quickSortTimeLabel.Text = "Time elapsed: " + timer.ElapsedMilliseconds + " ms";
        }

        private void quickSort(BindingList<string> data,  int low, int high)
        {
            if (low < high)
            {
                int p = partition(data, low, high);
                quickSort(data, low, p - 1);
                quickSort(data, p + 1, high);
            }
        }
        private int partition(BindingList<string> data, int low, int high)
        {
            int pivot = data[high].Length;
            int i = low;
            for (int j = low; j < high; j++)
            {
                if (data[j].Length <= pivot)
                {
                    swap(i, j, data);
                    i++;
                }
            }
            swap(i, high, data);
            return i;
        }


        /*
         * Heapsort
         */
        private void heapSort(BindingList<string> data)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            
            heapify(data, data.Count);
            int end = data.Count - 1;
            while (end > 0)
            {
                swap(end, 0, data);
                end--;
                siftDown(data, 0, end);
            }

            timer.Stop();
            heapSortTimeLabel.Text = "Time elapsed: " + timer.ElapsedMilliseconds + " ms";

        }
        // needed for heapsort. 
        private void heapify(BindingList<string> data, int count)
        {
            int start = (int)Math.Floor( (((double)count - 2) / 2) );
            while (start >= 0)
            {
                siftDown(data, start, count - 1);
                start--;
            }
        }
        // needed for heapsort. 
        private void siftDown(BindingList<string> data, int start, int end)
        {
            int root = start;
            while ( (root*2+1)  <=  end)
            {
                int child = root * 2 + 1;
                int swapNumber = root;

                if (data[swapNumber].Length < data[child].Length)
                                swapNumber = child;
                if ((child + 1 <= end) && (data[swapNumber].Length < data[child + 1].Length))
                                 swapNumber = child + 1;
                
                if (swapNumber == root)
                {
                    return;
                }
                else
                {
                    swap(root, swapNumber, data);
                    root = swapNumber;
                }
            }
        }

        /*
         * Selection Sort
         */
        private void selectionSort(BindingList<string> data)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < data.Count; i++)
            {
                int k = i;
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (data[j].Length < data[k].Length)
                                        k = j;
                }
                if (k != i)
                    swap(i, k, data);
            }
            timer.Stop();
            selectionSortTimeLabel.Text = "Time elapsed: " + timer.ElapsedMilliseconds + " ms";

        }

        /*
         * Insertion sort
         */
        private void insertionSort(BindingList<string> data)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int length = data.Count;

            for (int x = 1; x < length; x++)
            {
                string v = data[x];
                int j = x;
                while (j > 0 && data[j - 1].Length > v.Length)
                {

                    data[j] = data[j - 1];
                    j--;
                }
                if (sleepTime > 0)
                {
                    System.Threading.Thread.Sleep(sleepTime);
                    listBox1.Refresh();
                }
                data[j] = v;
            }
            timer.Stop();
            insertionSortTimeLabel.Text = "Time elapsed: " + timer.ElapsedMilliseconds + " ms";
        }

        /*
         * Bubble sort
         */
        private void bubbleSort(BindingList<string> data)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int length = data.Count;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (data[j + 1].Length < data[j].Length)
                    {  
                        swap(j, j + 1, data);
                    }
                }
            }
            timer.Stop();
            bubbleSortTimeLabel.Text = "Time elapsed: " + timer.ElapsedMilliseconds + " ms";
        }

        /*
         * Shell Sort
         */
        private void shellSort(BindingList<string> data)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            int increment = 3, length = data.Count;
            string temp;

            while (increment > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    int j = i;
                    temp = data[i];
                    while ((j >= increment) && (data[j - increment].Length > temp.Length))
                    {
                        data[j] = data[j - increment];
                        j = j - increment;
                    }
                    if (sleepTime > 0)
                    {
                        System.Threading.Thread.Sleep(sleepTime);
                        listBox1.Refresh();
                    }
                    data[j] = temp;
                    
                }
                if (increment / 2 != 0)
                    increment = increment / 2;
                else if (increment == 1)
                    increment = 0;
                else
                    increment = 1;
            }
            timer.Stop();
            shellSortTimeLabel.Text = "Time elapsed: " + timer.ElapsedMilliseconds + " ms";

        }

        #endregion

        #region ListScramblers
        /*
         * ListScrambler
         * Clears list into a temporary list "randomly". 
         * Then re-adds to existing list. 
         */
        public void listScrambler()
        {
            Random rnd = new Random();
            List<string> tempList = new List<string>();
            int randomIndex = 0;
            while (blData.Count > 0)
            {
                randomIndex = rnd.Next(0, blData.Count);
                tempList.Add(blData[randomIndex]);
                blData.RemoveAt(randomIndex);
            }
            foreach (string st in tempList)
                blData.Add(st);
        }

        // Vague attempt of getting it...."more randomized". 
        private void randomizeList()
        {
            blData.Clear();
            for (int i = 1; i < noOfLines + 1; i++)
            {
                blData.Add(getLine(i));
            }
            listScrambler();
            listScrambler();
        }

        // Creates a sorted, albeit reversed list
        private void reverseList()
        {
            blData.Clear();
            for (int i = 1; i < noOfLines + 1; i++)
            {
                blData.Add(getLine(noOfLines - i));
            }
        }

        // Creates a list of few uinique values, and scrambles it. 
        private void fewUniqueRandomList()
        {
            blData.Clear();
            Random rnd = new Random();
            int noOfUniqueBlocks = 10;
            for (int j = 0; j < noOfUniqueBlocks; j++)
            {
                int value = rnd.Next(1, noOfLines);
                for (int i = 0; i < noOfLines / noOfUniqueBlocks; i++)
                {
                    blData.Add(getLine(value));
                }
            }
            listScrambler();
        }

        // Vague attempt of producing a somewhat "almost" sorted list. 
        private void almostSortedList()
        {
            Random rnd = new Random();
            blData.Clear();
            for (int i = 1; i < noOfLines + 1; i++)
            {
                blData.Add(getLine(i));
            }
            for (int i = 0; i < noOfLines / 10; i++)
            {
                int rnd1 = rnd.Next(1, noOfLines - 1);
                int rnd2 = rnd.Next(1, noOfLines - 1);
                if (rnd1 == rnd2)
                    continue;
                swap(rnd1, rnd2, blData);
            }
        }

        #endregion

        #region Eventhandlers

        /*
         * handler for scambleListButton
         */
        private void scrambleListButton_Click(object sender, EventArgs e)
        {
            randomizeList();
        }


        // A sorted, albeight, reversed list
        private void reversedListButton_Click(object sender, EventArgs e)
        {
            reverseList();
        }
        
        // A list of few unique's. 
        private void fewUniqueButton_Click(object sender, EventArgs e)
        {
            fewUniqueRandomList();
        }

        // A list of nearly sorted items
        private void almostSortedButton_Click(object sender, EventArgs e)
        {
            almostSortedList();
        }

        // Duuuh. 
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         // Quicksort-button. 
        private void quickSortButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; // Set cursor to wait
            quickSortStarter(blData);
            Cursor.Current = Cursors.Default; // Restore cursor
        }

        // Heapsort-button
        private void heapSortButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; // Set cursor to wait
            heapSort(blData);
            Cursor.Current = Cursors.Default; // Restore cursor
        }
        
        
        // Selection Sort-button
        private void selectionSortButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; // Set cursor to wait
            selectionSort(blData);
            Cursor.Current = Cursors.Default; // Restore cursor
        }

        // Insertion Sort button
        private void insertionSortButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; // Set cursor to wait
            insertionSort(blData);
            Cursor.Current = Cursors.Default; // Restore cursor
        }

        // Bubble sort button
        private void bubbleSortButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; // Set cursor to wait
            bubbleSort(blData);
            Cursor.Current = Cursors.Default; // Restore cursor
        }

        // shell sort button
        private void shellSortButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; // Set cursor to wait
            shellSort(blData);
            Cursor.Current = Cursors.Default; // Restore cursor

        }

        // trackbar to control sleep-time
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sleepTime = trackBar1.Value;
            trackBarLabel.Text = trackBar1.Value + " ms";
        }
        


        // Do-all-button. (does one pass for each algorithm on a choosen type of sorted list)

        private void doAllButton_Click(object sender, EventArgs e)
        {
            listUnsorter randomize;

            // TODO. This is ugly. Fixit. 
            if (radioRandom.Checked)
            {
                randomize = randomizeList;
            }
            else if (radioReversed.Checked)
            {
                randomize = reverseList;
            }
            else if (radioFewUnique.Checked)
            {
                randomize = fewUniqueRandomList;
            }
            else if (radioAlmost.Checked)
            {
                randomize = almostSortedList;
            }
            else {
                return;
            }
            doAllSorting(randomize);
        }

        #endregion


    } // end class


    /*  
     *  Wrapper for listbox. A workaround i found on the intertubes to 
     *  remove flickering of listbox as it updates. THe most common solutions of double-buffering
     *  didn't work for this program. 
     *  Source:  http://yacsharpblog.blogspot.se/2008/07/listbox-flicker.html
     */
    internal class FlickerFreeListBox : System.Windows.Forms.ListBox
    {
        public FlickerFreeListBox()
        {
            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint,
                true);
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (this.Items.Count > 0)
            {
                e.DrawBackground();
                e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, new SolidBrush(this.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));
            }
            base.OnDrawItem(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Region iRegion = new Region(e.ClipRectangle);
            e.Graphics.FillRegion(new SolidBrush(this.BackColor), iRegion);
            if (this.Items.Count > 0)
            {
                for (int i = 0; i < this.Items.Count; ++i)
                {
                    System.Drawing.Rectangle irect = this.GetItemRectangle(i);
                    if (e.ClipRectangle.IntersectsWith(irect))
                    {
                        if ((this.SelectionMode == SelectionMode.One && this.SelectedIndex == i)
                        || (this.SelectionMode == SelectionMode.MultiSimple && this.SelectedIndices.Contains(i))
                        || (this.SelectionMode == SelectionMode.MultiExtended && this.SelectedIndices.Contains(i)))
                        {
                            OnDrawItem(new DrawItemEventArgs(e.Graphics, this.Font,
                                irect, i,
                                DrawItemState.Selected, this.ForeColor,
                                this.BackColor));
                        }
                        else
                        {
                            OnDrawItem(new DrawItemEventArgs(e.Graphics, this.Font,
                                irect, i,
                                DrawItemState.Default, this.ForeColor,
                                this.BackColor));
                        }
                        iRegion.Complement(irect);
                    }
                }
            }
            base.OnPaint(e);
        }
    }


} // end namespace

