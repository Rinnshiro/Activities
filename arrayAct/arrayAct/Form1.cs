using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayAct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            string[] classmates = { "Cris", "Patrick", "Jhirro", "Rhobbie", "Justine", "Mark" };
            classmateNameList.Items.Clear();
            foreach (string name in classmates)
            {
                classmateNameList.Items.Add(name);
            }

            char[,] initial = new char[2, 3]
            {
        { 'C', 'P', 'J' },
        { 'R', 'J', 'M' }
            };


            string gridOutput = "";
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    gridOutput += initial[row, col] + " ";
                }
                gridOutput += Environment.NewLine;
            }
            rowandcolumnsTexBox.Text = gridOutput;


            string message = "Hello everyone, welcome to class!";
            bool containsHello = message.ToLower().Contains("hello");

            MessageBox.Show($"{message}" +
                $"\nDoes the message contain 'hello'? \n" +
                $"{containsHello}");
        }
    }
}
