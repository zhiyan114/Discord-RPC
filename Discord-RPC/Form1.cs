using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            WriteLog("Thank you for using discord RPC Service by zhiyan114. With big thanks to DiscordRPC C# lib that allows this to happen.");
#if DEBUG
            this.Text = this.Text + " (Debug Mode)";
            WriteLog("Debug Mode Enabled. If you're seeing this, please use release mode instead unless your developing.");
#endif
        }

        private void Rpcclient_OnPresenceUpdate(object sender, DiscordRPC.Message.PresenceMessage args)
        {
            WriteLog("Your Presence has been updated.");
            button2.Enabled = true;
        }

        private void Rpcclient_OnReady(object sender, DiscordRPC.Message.ReadyMessage args)
        {
            WriteLog("Client Connected. Detected User: "+args.User.Username+"#"+args.User.Discriminator+" (ID: "+args.User.ID+")");
            button2.Enabled = true;
            MessageBox.Show("The client was successful initialized", "Initialized Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DiscordRPCRender.Start();
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
                WriteLog("Loading Client... (If you do not see any futher logs in a while, then it means that the client ID you supplied could be invalid. Restart the software and try again)");
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
        private bool CheckLength(TextBox textbox)
        {
            if(textbox.Text.Length > 32)
            {
                MessageBox.Show("The textbox "+textbox.Name+" has exceeded the maximum input of 32 characters. Please reduce the character count and try again","Max Character Length",MessageBoxButtons.OK,MessageBoxIcon.Error);
                WriteLog(textbox.Name +" are only allowed a maximum of 32 characters, received "+textbox.Text.Length+" characters");
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RichPresence presence = new RichPresence();
            if(!string.IsNullOrWhiteSpace(LargeImageIDInput.Text) || !string.IsNullOrWhiteSpace(SmallImageIDInput.Text))
            {
                Assets RPCAsset = new Assets();
                if(!string.IsNullOrWhiteSpace(LargeImageIDInput.Text))
                {
                    if (CheckLength(LargeImageTextInput))
                        return;
                    RPCAsset.LargeImageKey = LargeImageIDInput.Text;
                    RPCAsset.LargeImageText = LargeImageTextInput.Text;
                }
                if(!string.IsNullOrWhiteSpace(SmallImageIDInput.Text)) {
                    if (CheckLength(SmallImageTextInput))
                        return;
                    RPCAsset.SmallImageKey = SmallImageIDInput.Text;
                    RPCAsset.SmallImageText = SmallImageTextInput.Text;
                }
                presence.WithAssets(RPCAsset);
            }
            if(!string.IsNullOrWhiteSpace(FirstButtonNameInput.Text) && !string.IsNullOrWhiteSpace(FirstButtonLinkInput.Text))
            {
                DiscordRPC.Button[] ButtonList = new DiscordRPC.Button[1];
                DiscordRPC.Button FirstBtn = new DiscordRPC.Button();
                if (CheckLength(FirstButtonNameInput))
                    return;
                FirstBtn.Label = FirstButtonNameInput.Text;
                FirstBtn.Url = FirstButtonLinkInput.Text;
                if (!string.IsNullOrWhiteSpace(SecondButtonNameInput.Text) && !string.IsNullOrWhiteSpace(SecondButtonLinkInput.Text))
                {
                    ButtonList = new DiscordRPC.Button[2];
                    DiscordRPC.Button SecondBtn = new DiscordRPC.Button();
                    if (CheckLength(SecondButtonNameInput))
                        return;
                    SecondBtn.Label = SecondButtonNameInput.Text;
                    SecondBtn.Url = SecondButtonLinkInput.Text;
                    ButtonList.SetValue(SecondBtn, 1);
                }
                ButtonList.SetValue(FirstBtn, 0);
                presence.Buttons = ButtonList;
            }
            if (CheckLength(StateInput) || CheckLength(DetailInput))
                return;
            presence.WithState(StateInput.Text);
            presence.WithDetails(DetailInput.Text);
            rpcclient.SetPresence(presence);
            WriteLog("presence update has been added to the queue...");
            button2.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.com/developers/applications");
        }
    }
}
