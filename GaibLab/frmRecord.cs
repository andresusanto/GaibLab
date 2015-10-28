using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaibLab
{
    public partial class frmRecord : Form
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private bool isRecording = false;

        public frmRecord()
        {
            InitializeComponent();
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
                mciSendString("record recsound", "", 0, 0);
                isRecording = true;
                button1.Text = "Stop";
                label1.Text = "Recording audio ...";
            }
            else
            {
                MessageBox.Show("Recording saved!");
                mciSendString("save recsound \"" + Application.ExecutablePath + "result.wav\"", "", 0, 0);
                mciSendString("close recsound ", "", 0, 0);
                isRecording = false;
                button1.Text = "Record";
                label1.Text = "Press 'Record' to begin recording ...";
            }
                        
        }
    }
}
