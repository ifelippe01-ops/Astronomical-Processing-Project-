/* Igor Cruz - Sprint 2 
10/11/2025
Version 2.0
Astronomical Processing 
Program to manage astronomical data, loading, editing, searching this data. 
Also performs mathematical calculations such and average, mode and mid extreme
*/

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        public Form1() // initialize empty
        {
            InitializeComponent();
            
        }
        static int max = 24;
        int[] myArray = new int[max];
        private void Form1_Load(object sender, EventArgs e) // loaded after click on load button
        {
        
        }
        
        private void ShowArray() //method to display array 
        {
            listBox.Items.Clear();
            foreach (int value in myArray)
            {
                listBox.Items.Add(value);
            }
        }

        private void sortButton_Click(object sender, EventArgs e) // bubble search code 
        {
            for (int outer = 0; outer < max - 1; outer++)
            {
                for (int inner = 0; inner < max - 1; inner++)
                {
                    if (myArray[inner] > myArray[inner + 1])
                    {
                        int temp = myArray[inner]; // swap method
                        myArray[inner] = myArray[inner + 1];
                        myArray[inner + 1] = temp;
                    }
                }
            }
            ShowArray();
        }

        private void searchButton_Click(object sender, EventArgs e) // binary search code 
        {
            int target;
            List<int> foundIndexes = new List<int>(); // list for multiple index fidings
            int lowBound = 0;
            int highBound = max - 1;

            if (!Int32.TryParse(searchBox.Text, out target)) // if the input is not an integer displays error message, otherwise add to target
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            while (lowBound <= highBound) // search within the array 
            {
                int mid = (lowBound + highBound) / 2; //defines mid 
                if (myArray[mid] == target)
                {
                    foundIndexes.Add(mid);

                    int down = mid - 1; //lower search
                    while (down >= lowBound && myArray[down] == target)
                    {
                        foundIndexes.Add(down);
                        down--;
                    }
                    int up = mid + 1; //higher search
                    while (up <= highBound && myArray[up] == target)
                    {
                        foundIndexes.Add(up);
                        up++;
                    }
                    break;
                }
                else if (myArray[mid] > target)
                {
                    highBound = mid - 1;
                }
                else
                {
                    lowBound = mid + 1;
                }
            }
            if (foundIndexes.Count == 0) // if the index is not on the list
            {
                MessageBox.Show("Not found, try again.");
            }
            else
            {
                string message = "Found at index(es): " + string.Join(", ", foundIndexes);
                MessageBox.Show(message);
            }
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            int slcIndex = listBox.SelectedIndex; // select index from the list 
            if (slcIndex == -1)
            {
                MessageBox.Show("Select an Item from the box to edit");
                return;
            }
            int newData; // add new data if its an int
            if (!Int32.TryParse(searchBox.Text, out newData))
            {
                MessageBox.Show("Invalid value, you must enter an integer");
                return;
            }
            myArray[slcIndex] = newData;
            ShowArray();
            MessageBox.Show("Data at index " + slcIndex + " has been replaced to " + newData);
        }                 
            

        private void loadButton_Click(object sender, EventArgs e) //load random data method
        {
            Random random = new Random();
            for (int i = 0; i < max; i++)
            {
                myArray[i] = random.Next(10, 91);
            }
            ShowArray();
        }

        private void midExButton_Click(object sender, EventArgs e) // mathematical function to calculate the mid extreme
        {           
            double midex = (myArray[0] + myArray[23]) / 2.0;
            midex = Math.Round(midex, 2);
            textMidEx.Text = midex.ToString();            
        }

        private void avarageButton_Click(object sender, EventArgs e) // mathematical function to calculate the avarage value 
        {
            double avarage = myArray.Sum() / (double) myArray.Length;
            avarage = Math.Round(avarage, 2);
            textAvarage.Text = avarage.ToString();
        }

        private void rangeButton_Click(object sender, EventArgs e) // mathematical function to calculate the range
        {
            int range = myArray[23] - myArray[0];
            textRange.Text = range.ToString();
        }

        private void modeButton_Click(object sender, EventArgs e)
        {
            IEnumerable<IGrouping<int, int>> groups = myArray.GroupBy(n => n);
            int maxCount = groups.Max(g => g.Count());

            List<int> modes = new List<int>(); // collects the numbers
            foreach (IGrouping<int, int> group in groups)
            {
                if (group.Count() == maxCount)
                {
                    modes.Add(group.Key);
                }
            }
            MessageBox.Show("Modes: " + string.Join(", ", modes) + " apears " + maxCount + " times."); // displays each number and their frequency
        }

        private void linearSearchButton_Click(object sender, EventArgs e)
        {
            int target;
            bool found = false;            
            if (!(Int32.TryParse(searchBox.Text, out target)))
            {
                MessageBox.Show("You need to enter an integer");
            }
            listBox.Items.Clear();
            for (int x = 0; x < max; x++)
            {
                listBox.Items.Add(x + myArray[x]); 
                if (myArray[x] == target)
                {
                    string message = ("Found at index: " +  x); // displays each result 
                    MessageBox.Show(message);
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("Not found, try again");
            }
        }        
    }
}


