using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sentry;

namespace Discord_RPC
{
    public partial class Form1 : Form
    {
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
            throw new Exception("OMG PANIC");
            if(ulong.TryParse(AppIDInput.Text,out ulong result))
            {

            } else
            {
                MessageBox.Show(this, "Invalid Application ID Detected.", "Invalid APP ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
