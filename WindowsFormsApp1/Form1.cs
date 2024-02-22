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
    public partial class Form1 : Form
    {
        public int Test = 69;

        int identifier = GlobalVariablesClass.formNumber;

        //Damage Type Vector = [Piercing Slashing Bludgeoning Thunder Fire Cold Acid Lightning Energy Radiant]

        //double[] DamageTypeVector = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

        double[] ResistanceVectorLocal = new double[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int TMPHealth;

            bool success = int.TryParse(textBox1.Text, out TMPHealth);

            if (success)
            {
                GlobalVariablesClass.HealthMax = TMPHealth;

                GlobalVariablesClass.ResistanceVector = ResistanceVectorLocal;
                int.TryParse(textBox10.Text, out GlobalVariablesClass.HealthCur);
                //GlobalVariablesClass.HealthCur = textBox10.Text;
                int.TryParse(textBox1.Text, out GlobalVariablesClass.HealthMax);
                Form2 f2 = new Form2();
                    f2.ShowDialog();

                textBox10.Text = ($"{ GlobalVariablesClass.HealthCur}");

            }
            else
            {
                return;
            }

            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a slashing resistance and updates the resistance table

            if (resSlashing.Checked)
                {
                ResistanceVectorLocal[0] = 1.0;
                }
            else
                {
                ResistanceVectorLocal[0] = 0.0;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void resBludgeoning_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Bludgeoning resistance and updates the resistance table

            if (resBludgeoning.Checked)
            {
                ResistanceVectorLocal[1] = 1.0;
            }
            else
            {
                ResistanceVectorLocal[1] = 0.0;
            }
        }

        private void resPiercing_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Piercing resistance and updates the resistance table

            if (resPiercing.Checked)
            {
                ResistanceVectorLocal[2] = 1.0;
            }
            else
            {
                ResistanceVectorLocal[2] = 0.0;
            }
        }

        private void resThunder_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Thunder resistance and updates the resistance table

            if (resThunder.Checked)
            {
                ResistanceVectorLocal[3] = 1.0;
            }
            else
            {
                ResistanceVectorLocal[3] = 0.0;
            }
        }

        private void resFire_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Fire resistance and updates the resistance table

            if (resFire.Checked)
            {
                ResistanceVectorLocal[4] = 1.0;
            }
            else
            {
                ResistanceVectorLocal[4] = 0.0;
            }
        }

        private void resCold_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Cold resistance and updates the resistance table

            if (resCold.Checked)
            {
                ResistanceVectorLocal[5] = 1.0;
            }
            else
            {
                ResistanceVectorLocal[5] = 0.0;
            }
        }

        private void resAcid_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Acid resistance and updates the resistance table

            if (resAcid.Checked)
            {
                ResistanceVectorLocal[6] = 1.0;
            }
            else
            {
                ResistanceVectorLocal[6] = 0.0;
            }
        }

        private void resLightning_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Lightning resistance and updates the resistance table

            if (resLightning.Checked)
            {
                ResistanceVectorLocal[7] = 1.0;
            }
            else
            {
                ResistanceVectorLocal[7] = 0.0;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int TMPHealth;

            bool success = int.TryParse(textBox1.Text, out TMPHealth);

            if (success)
            {
                GlobalVariablesClass.HealthMax = TMPHealth;

                GlobalVariablesClass.ResistanceVector = ResistanceVectorLocal;
                int.TryParse(textBox1.Text, out GlobalVariablesClass.HealthMax);
                GlobalVariablesClass.HealthCur = GlobalVariablesClass.HealthMax;
                textBox10.Text = ($"{GlobalVariablesClass.HealthCur}");

            }
            else
            {
                return;
            }
        }

        public void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {

            Form3.form1Array.Remove(identifier); 
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
