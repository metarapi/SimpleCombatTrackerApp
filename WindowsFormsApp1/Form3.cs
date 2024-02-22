using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        int ADDER = 0;
        public static Dictionary<int, Form1> form1Array = new Dictionary<int, Form1>();

        public Form3()
        {
            InitializeComponent();                       
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

    
        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GlobalVariablesClass.formNumber = GlobalVariablesClass.formNumber + 1;

            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();

            form1Array.Add(GlobalVariablesClass.formNumber, f1);

            ADDER = ADDER + 69;

            form1Array[GlobalVariablesClass.formNumber].Test = form1Array[GlobalVariablesClass.formNumber].Test + ADDER;

            Console.WriteLine($"{GlobalVariablesClass.formNumber}");
            Console.WriteLine($"{form1Array[GlobalVariablesClass.formNumber].Test}");
            
        }

    }
}

