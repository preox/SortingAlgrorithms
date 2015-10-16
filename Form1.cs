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


        public Form1()
        {
            // Initializing stuff. Listbox and dataconnections as well. 
            InitializeComponent();
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

        #endregion


        /*
         * All eventhandlers for button and suchs
         */
        #region Eventhandlers

        /*
         * handler for scambleListButton
         * Scrambles list. Sort of....
         */
        private void scrambleListButton_Click(object sender, EventArgs e)
        {
            listScrambler();
            timeLabel.Text = "Time Elapsed: ";
        }

        // Duuuh. 
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void quickSortButton_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            quickSort(blData, 0, blData.Count - 1);
            timer.Stop();
            timeLabel.Text = "Time elapsed: " + timer.ElapsedMilliseconds + " ms";
        }


        #endregion


    }
}
