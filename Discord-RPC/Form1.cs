using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using Sentry;

namespace Discord_RPC
{
    public partial class Form1 : Form
    {
        private DiscordRpcClient rpcclient;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if DEBUG
            this.Text = this.Text + " (Debug Mode)";
#endif
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //throw new Exception("Testing Sentry Error Handler");
            if(ulong.TryParse(AppIDInput.Text,out ulong result))
            {
                rpcclient = new DiscordRpcClient(result.ToString());
                // Do Some Configuration Here
                DiscordRPCRender.Start();
            } else
            {
                MessageBox.Show(this, "Invalid Application ID Detected.", "Invalid APP ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpcclient.Dispose();
        }

        private void DiscordRPCRender_Tick(object sender, EventArgs e)
        {
            rpcclient.Invoke();
        }
        private void WriteLog(string text)
        {
            InternalLogDisplay.Text = InternalLogDisplay.Text + text + "\r\n";
        }
    }
}
