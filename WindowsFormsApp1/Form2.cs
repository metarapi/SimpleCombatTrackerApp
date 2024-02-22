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
    public partial class Form2 : Form
    {

        double[] DamageTypeVectorLocal = new double[10];
        double[] ResultsVector = new double[10];
        double[] FinalOutputVector = new double[10];
        double FinalDmgMulti = 0;
        double DamageD = 0;
        int Damage = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a slashing resistance and updates the resistance table

            if (typSlashing.Checked)
            {
                DamageTypeVectorLocal[0] = 1.0;
            }
            else
            {
                DamageTypeVectorLocal[0] = 0.0;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Energy resistance and updates the resistance table

            if (typEnergy.Checked)
            {
                DamageTypeVectorLocal[8] = 1.0;
            }
            else
            {
                DamageTypeVectorLocal[8] = 0.0;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (typFire.Checked)
            {
                DamageTypeVectorLocal[4] = 1.0;
            }
            else
            {
                DamageTypeVectorLocal[4] = 0.0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (typCold.Checked)
            {
                DamageTypeVectorLocal[5] = 1.0;
            }
            else
            {
                DamageTypeVectorLocal[5] = 0.0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = ($"{GlobalVariablesClass.DamageTypeVector[1]}");
        }

        private void typBludgeoning_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Bludgeoning resistance and updates the resistance table

            if (typBludgeoning.Checked)
            {
                DamageTypeVectorLocal[1] = 1.0;
            }
            else
            {
                DamageTypeVectorLocal[1] = 0.0;
            }
        }

        private void typPiercing_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Piercing resistance and updates the resistance table

            if (typPiercing.Checked)
            {
                DamageTypeVectorLocal[2] = 1.0;
            }
            else
            {
                DamageTypeVectorLocal[2] = 0.0;
            }
        }

        private void typThunder_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the NPC has a Thunder resistance and updates the resistance table

            if (typThunder.Checked)
            {
                DamageTypeVectorLocal[3] = 1.0;
            }
            else
            {
                DamageTypeVectorLocal[3] = 0.0;
            }
        }

        private void typAcid_CheckedChanged(object sender, EventArgs e)
        {
            if (typAcid.Checked)
            {
                DamageTypeVectorLocal[6] = 1.0;
            }
            else
            {
                DamageTypeVectorLocal[6] = 0.0;
            }
        }

        private void typLightning_CheckedChanged(object sender, EventArgs e)
        {
            if (typLightning.Checked)
            {
                DamageTypeVectorLocal[7] = 1.0;
            }
            else
            {
                DamageTypeVectorLocal[7] = 0.0;
            }
        }

        private void typRadiant_CheckedChanged(object sender, EventArgs e)
        {
            if (typRadiant.Checked)
            {
                DamageTypeVectorLocal[9] = 1.0;
            }
            else
            {
                DamageTypeVectorLocal[9] = 0.0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GlobalVariablesClass.DamageTypeVector = DamageTypeVectorLocal;

            for (int i = 0; i < 10; i++)
            {
                ResultsVector[i] = GlobalVariablesClass.ResistanceVector[i] / DamageTypeVectorLocal[i];
            }

            for (int i = 0; i < 10; i++)
            {
                if (ResultsVector[i] == 1.0)
                {
                    FinalOutputVector[i] = 0.5;
                }
                else if (ResultsVector[i] == 0.0)
                {
                    FinalOutputVector[i] = 1.0;
                }
            }

            FinalDmgMulti = FinalOutputVector.Max();

            double.TryParse(textBox1.Text , out DamageD);

            DamageD = DamageD * FinalDmgMulti;

            Damage = Convert.ToInt32(DamageD);

            GlobalVariablesClass.HealthCur = GlobalVariablesClass.HealthCur - Damage;

            this.Close();

            //Console.WriteLine(Damage);


        }
    }
    
}
