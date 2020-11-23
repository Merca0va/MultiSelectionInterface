using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0va_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "You have selected";

            for (int i = 0; i < LeftListBox.Items.Count; i++)
            {
                if(RightListBox.Items.Contains(LeftListBox.Items[i]))
                 {
                    text = text + " " + LeftListBox.Items[i];
                 }
            }

                MessageBox.Show(text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeftListBox.Items.Clear();
            RightListBox.Items.Clear();
            LeftListBox.SelectionMode = SelectionMode.MultiExtended;
            RightListBox.SelectionMode = SelectionMode.MultiExtended;

            for (int i = 0; i <= 9; i++)
            {
                LeftListBox.Items.Insert(i, "Data" + i);
            }

            LeftListBox.Sorted = true;
            RightListBox.Sorted = true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LeftListBox.Items.Clear();
            RightListBox.Items.Clear();
            LeftListBox.SelectionMode = SelectionMode.MultiExtended;
            RightListBox.SelectionMode = SelectionMode.MultiExtended;

            for (int i = 0; i < 9; i++)
            {
                LeftListBox.Items.Insert(i, "Object" + i);
            }

            LeftListBox.Sorted = true;
            RightListBox.Sorted = true;
        }

        private void AllLeftButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LeftListBox.Items.Count; i++)
            {
                LeftListBox.SetSelected(i, true);
            }
        }

        private void AllRightButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < RightListBox.Items.Count; i++)
            {
                RightListBox.SetSelected(i, true);
            }
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            // If right side object is selected add it to left side.
            for (int i = 0; i < RightListBox.Items.Count; i++)
            {
                if (RightListBox.GetSelected(i) == true)
                {
                    LeftListBox.Items.Add(RightListBox.Items[i]);
                }               
            }

            //Invert the scan for the remove
            for (int i = RightListBox.Items.Count - 1; i >= 0; i--)
            {
                if (RightListBox.GetSelected(i) == true)
                {
                    RightListBox.Items.RemoveAt(i);
                }
            }
        }

        private void MoveRightButton_Click(object sender, EventArgs e)
        {
            // If right side object is selected add it to left side.
            for (int i = 0; i < LeftListBox.Items.Count; i++)
            {
                if (LeftListBox.GetSelected(i) == true)
                {
                    RightListBox.Items.Add(LeftListBox.Items[i]);
                }
            }

            for (int i = LeftListBox.Items.Count - 1; i <= 0; i--)
            {
                if (LeftListBox.GetSelected(i) == true)
                {
                    LeftListBox.Items.RemoveAt(i);
                }
            }
        }
    }
}
