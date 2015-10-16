using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace SortingAlgrorithms
{
    public partial class Form1 : Form
    {
        private static int noOfLines = 80;
        private Random rnd = new Random();
        private List<string> dataSource;// = new List<string>();
        private BindingList<string> blData;// = new BindingList<string>(dataSource);
        private int sleepTime = 10;


        public Form1()
        {
            // Initializing stuff. Listbox and dataconnections as well. 
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;
            trackBar1.Value = sleepTime;
            trackBarLabel.Text = sleepTime + " ms";

            dataSource = new List<string>();
            blData = new BindingList<string>(dataSource);
            listBox1.DataSource = blData;

            for (int i = 1; i < noOfLines+1; i++ )
            {
                blData.Add(getLine(i));
            }
            listScrambler();


        }


        #region Functions

        /*
         * ListScrambler
         * Clears list into a temporary list "randomly". 
         * Then re-adds to existing list. 
         */
        public void listScrambler()
        {
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


        /*
         * Simply swaps two items. as long as given indexes does not exceed list length. 
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
         * Quicksort. Or at least, an attempt at one. 
         * Based upon https://en.wikipedia.org/wiki/Quicksort
         * Note that pivot isn't randomly choosen. Not optimal
         */
        private void quickSort(BindingList<string> data,  int low, int high)
        {
            if (low < high)
            {
                int p = partition(data, low, high);
                quickSort(data, low, p - 1);
                quickSort(data, p + 1, high);
            }
        }
        // Needed for quicksort. 
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
         * Heapsort. Or a brave attempt, atleast. 
         * 
         */
        private void heapSort(BindingList<string> data, int count)
        {
            heapify(data, count);
            int end = count - 1;
            while (end > 0)
            {
                swap(end, 0, data);
                end--;
                siftDown(data, 0, end);
            }
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


        #endregion


        /*
         * All eventhandlers for button and suchs 
         */
        #region Eventhandlers

        /*
         * handler for scambleListButton
         * Scrambles list......sort of....
         */
        private void scrambleListButton_Click(object sender, EventArgs e)
        {
            listScrambler();
        }

        // Duuuh. 
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         // Quicksort-button. 
        private void quickSortButton_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            quickSort(blData, 0, blData.Count - 1);
            
            timer.Stop();
            quickSortTimeLabel.Text = "Time elapsed: " + timer.ElapsedMilliseconds + " ms";
        }

        // Heapsort-button
        private void heapSortButton_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            heapSort(blData, blData.Count);
            timer.Stop();
            heapSortTimeLabel.Text = "Time elapsed: " + timer.ElapsedMilliseconds + " ms";
        }


        // trackbar to control sleep-time
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sleepTime = trackBar1.Value;
            trackBarLabel.Text = trackBar1.Value + " ms";
        }

        #endregion





    }
}
