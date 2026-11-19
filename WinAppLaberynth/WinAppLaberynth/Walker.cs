using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace WinAppLaberynth
{
    class Walker
    {
        private int[,] mMatrix;
        private int mRow, mColumn;
        private int mM, mN;
                
        private Choices mTable;       
        private Grammar mElements;

        public Choices Table { get => mTable; set => mTable = value; }
        public Grammar Elements { get => mElements; set => mElements = value; }
        
        public Walker()
        {
            mRow = 0; mColumn = 0;
            mM = 0; mN = 0;
        }

        public void CreateMatrix(int r, int c)
        {
            mMatrix = new int[r, c];
            mM = r; mN = c;
        }

        public void InitializeMatrix(int[,] a)
        {
            int i, j;

            for (i = 0; i < mM; i++)
            {
                for (j = 0; j < mN; j++)
                {
                    mMatrix[i, j] = a[i, j];
                }
            }
        }

        public void InitializeRoad()
        {
            mRow = 0; mColumn = 0;
        }

        public void LocalizeStart()
        {
            int i, j;

            for (i = 0; i < mM; i++)
            {
                for (j = 0; j < mN; j++)
                {
                    if (mMatrix[i, j] == 2)
                    {
                        mRow = i; mColumn = j;
                        return;
                    }
                }
            }
        }

        public void MoveRightSide(PictureBox picWalker)
        {
            picWalker.Left = picWalker.Left + 25;
            mColumn++;
        }

        public void MoveLeftSide(PictureBox picWalker)
        {
            picWalker.Left = picWalker.Left - 25;
            mColumn--;
        }

        public void MoveUpSide(PictureBox picWalker)
        {
            picWalker.Top = picWalker.Top - 25;
            mRow--;
        }

        public void MoveDownSide(PictureBox picWalker)
        {
            picWalker.Top = picWalker.Top + 25;
            mRow++;
        }

        public void InitializeGrammar()
        {            
            mTable = new Choices();            
            mTable.Add(new string[] { "right",
                                      "left",
                                      "up",
                                      "down" });            
            mElements = new Grammar(new GrammarBuilder(mTable));
        }

        public void ControlMovesInLaberynth(PictureBox picWalker, KeyEventArgs e)
        {
            if (mMatrix[mRow, mColumn] != 3)
            {
                if (e.KeyCode == Keys.Right)
                {
                    if (mMatrix[mRow, mColumn + 1] != 0)
                    {
                        MoveRightSide(picWalker);
                    }
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (mMatrix[mRow, mColumn - 1] != 0)
                    {
                        MoveLeftSide(picWalker);
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (mMatrix[mRow - 1, mColumn] != 0)
                    {
                        MoveUpSide(picWalker);
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (mMatrix[mRow + 1, mColumn] != 0)
                    {
                        MoveDownSide(picWalker);
                    }
                }
                if (mMatrix[mRow, mColumn] == 3)
                {
                    MessageBox.Show("Felicitaciones, buen trabajo.",
                                "Mensaje de control");
                }
            }
        }

        public void ControlSpeechMoves(PictureBox picWalker, 
                                       TextBox txtData,
                                       SpeechRecognizedEventArgs e)
        {            
            if (e.Result.Text == "right")
            {
                if (mMatrix[mRow, mColumn + 1] != 0)
                {
                    MoveRightSide(picWalker);
                }
            }
            else if (e.Result.Text == "left")
            {
                if (mMatrix[mRow, mColumn - 1] != 0)
                {
                    MoveLeftSide(picWalker);
                }
            }
            else if (e.Result.Text == "up")
            {
                if (mMatrix[mRow - 1, mColumn] != 0)
                {
                    MoveUpSide(picWalker);
                }
            }
            else if (e.Result.Text == "down")
            {
                if (mMatrix[mRow + 1, mColumn] != 0)
                {
                    MoveDownSide(picWalker);
                }
            }
            else
            {
                txtData.Text = txtData.Text + " " + e.Result.Text.ToString();
            }            
        }

    }
}
