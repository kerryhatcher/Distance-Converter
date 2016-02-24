using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string from;
        private string to;
        private double input;
        private bool inputok = false;
        private bool selection1ok = false;
        private bool selection2ok = false;

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void listBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            input_tester();

            from = listBoxFrom.SelectedItem.ToString();
            //to = listBoxTo.SelectedItem.ToString();
            //input = textBoxInput.Text;
            if (to == from)
            {
                selection1ok = false;
                labelSelectionStatus.Text = "Please slect different to and from";
            }
            else
            {
                selection1ok = true;
                labelSelectionStatus.Text = "";
            }

            input_tester();
        }

        private void listBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            to = listBoxTo.SelectedItem.ToString();
            if (to == from)
            {
                selection2ok = false;
                labelSelectionStatus.Text = "Please slect different to and from";
            }
            else
            {
                selection2ok = true;
                labelSelectionStatus.Text = "";
            }
            //labelSelectionStatus.Text = to;
            input_tester();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (from == "Feet" && to == "Inches")
            {
                textBoxConverted.Text = feet2inch(input).ToString();
            }
            else if (from == "Feet" && to == "Yards")
            {
                textBoxConverted.Text = feet2yard(input).ToString();
            }
            else if (from == "Yards" && to == "Feet")
            {
                textBoxConverted.Text = yard2feet(input).ToString();
            }
            else if (from == "Yards" && to == "Inches")
            {
                textBoxConverted.Text = yard2inch(input).ToString();
            }
            else if (from == "Inches" && to == "Feet")
            {
                textBoxConverted.Text = inch2feet(input).ToString();
            }
            else if (from == "Inches" && to == "Yards")
            {
                textBoxConverted.Text = inch2yard(input).ToString();
            }
            else
            {
                textBoxConverted.Text = "ERROR";
            }
        }

        public double feet2inch(double datain)
        {
            return datain * 12;
        }

        public double feet2yard(double datain)
        {
            return datain / 3;
        }

        public double yard2inch(double datain)
        {
            return datain * 3 * 12;
        }

        public double yard2feet(double datain)
        {
            return datain * 3;
        }

        public double inch2yard(double datain)
        {
            return datain / 12 / 3;
        }

        public double inch2feet(double datain)
        {
            return datain / 12;
        }

        private void textBoxInput_KeyPress(object sender, EventArgs e)
        {

            if (double.TryParse(textBoxInput.Text, out input))
            {
                //parsing successful 
                //buttonConvert.Enabled = true;
                inputok = true;
                labelInputStatus.Text = "";
                input_tester();
            }
            else
            {
                //parsing failed. 
                //textBoxInput.Clear();
                labelInputStatus.Text = "Only nubers please";
                //buttonConvert.Enabled = false;
                inputok = false;
                input_tester();
            }

            input_tester();

        }

        private void input_tester()
        {


            if (inputok & selection1ok & selection2ok)
            {
                buttonConvert.Enabled = true;
                labelSelectionStatus.Text = "";
                textBoxConverted.Clear();
            }
            else
            {
                buttonConvert.Enabled = false;
            }
        }


    }
}
