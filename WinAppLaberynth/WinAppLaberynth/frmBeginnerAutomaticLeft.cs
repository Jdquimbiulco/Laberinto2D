using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppLaberynth
{
    public partial class frmBeginnerAutomaticLeft : Form
    {
        private NonPlayerCharacter ObjectNPC = new NonPlayerCharacter();
        private int[,] mMatrix = new int[,] {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, // fil=0; col=0;
            {0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, // fil = 1; col = 2;
            {0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0},
            {0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,0,0},
            {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0},
            {0,0,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,0,0},
            {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0},
            {0,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0},
            {0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0},
            {0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
            {0,0,1,0,1,1,1,1,1,1,0,1,1,1,1,1,1,0,0},
            {0,0,1,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0},
            {0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0},
            {0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0,1,0,0},
            {0,0,1,0,1,1,1,1,1,1,0,1,1,1,1,1,1,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0},//fil = 17; col = 16;
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        };

        public frmBeginnerAutomaticLeft()
        {
            InitializeComponent();
        }

        private void frmBeginnerAutomaticLeft_Load(object sender, EventArgs e)
        {
            ObjectNPC.CreateMatrix(19, 19);
            ObjectNPC.InitializeMatrix(mMatrix);
            ObjectNPC.InitializeRoad();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            ObjectNPC.LocalizeStart();
            ObjectNPC.InitializeRapidMovement(picWalker);
            tmrBeginner.Enabled = true;

            //ObjectNPC.LocalizeStart();

            //ObjectNPC.InitializeRapidMovement(picWalker);
            //do
            //{
            //    ObjectNPC.RapidMovementWithAILeft(picWalker);
            //} while (!ObjectNPC.DetermineFinishDirection(picWalker));

            //ObjectNPC.InitializePausedMovement(txtDirection, picWalker);
            //do
            //{
            //    ObjectNPC.PausedMovementWithAILeft(txtDirection, picWalker);
            //} while (!ObjectNPC.DetermineFinishDirection(picWalker));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDirection_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrBeginner_Tick(object sender, EventArgs e)
        {
            ObjectNPC.RapidMovementWithAILeft(picWalker);
            if (ObjectNPC.DetermineFinishDirection(picWalker))
            {
                tmrBeginner.Enabled = false;
                MessageBox.Show("Haz llegado al final");
            }
        }
    }
}
