using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sentry;

namespace Discord_RPC {

    public partial class UserReport : Form
    {
        public SentryId MainEventId;
        public UserReport() // SentryEvent sevent
        {
            InitializeComponent();
            TopMost = true;
        }

        private void UserReport_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SentrySdk.CaptureUserFeedback(new UserFeedback(MainEventId, null, null, FeedbackInput.Text));
            MessageBox.Show(this,"Your feedback has been recorded, thank you for taking your time to report it.","Report Sent", MessageBoxButtons.OK,MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure that you don't want to report any further errors for this session? If you don't want to report some issues, feel free to use the cancel button instead.", "Stop Error Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DialogResult = DialogResult.No;
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
