
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
                        int temp = myArray[inner];
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
            if (!Int32.TryParse(editBox.Text, out newData))
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
    }
}


