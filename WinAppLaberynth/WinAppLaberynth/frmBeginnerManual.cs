using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace WinAppLaberynth
{
    public partial class frmBeginnerManual : Form
    {
        private Walker ObjectWalker = new Walker();        

        private SpeechSynthesizer mSynthesizer = new SpeechSynthesizer();
        private PromptBuilder mPrompt = new PromptBuilder();
        private SpeechRecognitionEngine mRecognition = new SpeechRecognitionEngine();

        private int[,] mMatrix = new int[,] {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
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
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        };

        public frmBeginnerManual()
        {
            InitializeComponent();
        }

        private void StartSpeech()
        {
            ObjectWalker.InitializeGrammar();
            
            try
            {
                mRecognition.RequestRecognizerUpdate();
                mRecognition.LoadGrammar(ObjectWalker.Elements);
                mRecognition.SpeechRecognized += MRecognition_SpeechRecognized;
                mRecognition.SetInputToDefaultAudioDevice();
                mRecognition.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }
        }

        private void MRecognition_SpeechRecognized(object sender,
                                                   SpeechRecognizedEventArgs e)
        {
            ObjectWalker.ControlSpeechMoves(picWalker, txtData, e);            
        }

        private void frmLaberynth_Load(object sender, EventArgs e)
        {
            ObjectWalker.CreateMatrix(19, 19);
            ObjectWalker.InitializeMatrix(mMatrix);
            ObjectWalker.InitializeRoad();
            ObjectWalker.LocalizeStart();

            StartSpeech();            
        }

        private void frmLaberynth_KeyDown(object sender, KeyEventArgs e)
        {
            ObjectWalker.ControlMovesInLaberynth(picWalker, e);
        }

        private void picWalker_Click(object sender, EventArgs e)
        {

        }
    }
}
