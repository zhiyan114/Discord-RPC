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
            WriteLog("Debug Mode Enabled. If you're seeing this, please use release mode instead unless your developing.");
#endif
        }

        private void Rpcclient_OnPresenceUpdate(object sender, DiscordRPC.Message.PresenceMessage args)
        {
            WriteLog("Your Presence has been updated.");
        }

        private void Rpcclient_OnReady(object sender, DiscordRPC.Message.ReadyMessage args)
        {
            WriteLog("Client Connected. Detected User: "+args.User.Username+"#"+args.User.Discriminator+" (ID: "+args.User.ID+")");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //throw new Exception("Testing Sentry Error Handler");
            if(ulong.TryParse(AppIDInput.Text,out ulong result))
            {
                rpcclient = new DiscordRpcClient(result.ToString());
                rpcclient.OnReady += Rpcclient_OnReady;
                rpcclient.OnPresenceUpdate += Rpcclient_OnPresenceUpdate;
                if (!rpcclient.Initialize())
                {
                    // Cant init the client
                    MessageBox.Show(this, "Unable to initialize the client, maybe invalid client ID?","Initialize Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    rpcclient.Dispose();
                    return;
                }
                AppIDInput.ReadOnly = true;
                button1.Enabled = false;
                button2.Enabled = true;
                MessageBox.Show("The client was successful initialized", "Initialized Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Do Some Configuration Here
                DiscordRPCRender.Start();
            } else
            {
                MessageBox.Show(this, "Invalid Application ID Detected.", "Invalid APP ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //rpcclient.Dispose();
        }

        private void DiscordRPCRender_Tick(object sender, EventArgs e)
        {
            rpcclient.Invoke();
        }
        private void WriteLog(string text)
        {
            InternalLogDisplay.Text = InternalLogDisplay.Text + DateTime.Now.ToString("h:mm:ss tt")+": "+text + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RichPresence presence = new RichPresence();
            Assets RPCAsset = new Assets();
            RPCAsset.
            presence.WithAssets(RPCAsset);
            presence.WithState(StateInput.Text);
            presence.WithDetails(DetailInput.Text);
            presence.Buttons = { };
            rpcclient.SetPresence(presence);
        }
    }
}
