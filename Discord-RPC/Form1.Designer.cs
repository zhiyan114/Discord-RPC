namespace Discord_RPC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.AppIDInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DiscordRPCRender = new System.Windows.Forms.Timer(this.components);
            this.InternalLogDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StateInput = new System.Windows.Forms.TextBox();
            this.DetailInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LargeImageIDInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LargeImageTextInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SmallImageTextInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SmallImageIDInput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.FirstButtonNameInput = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.FirstButtonLinkInput = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SecondButtonNameInput = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SecondButtonLinkInput = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discord RPC";
            // 
            // AppIDInput
            // 
            this.AppIDInput.Location = new System.Drawing.Point(94, 88);
            this.AppIDInput.Name = "AppIDInput";
            this.AppIDInput.Size = new System.Drawing.Size(537, 20);
            this.AppIDInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Application ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Authenticate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiscordRPCRender
            // 
            this.DiscordRPCRender.Tick += new System.EventHandler(this.DiscordRPCRender_Tick);
            // 
            // InternalLogDisplay
            // 
            this.InternalLogDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InternalLogDisplay.Location = new System.Drawing.Point(12, 487);
            this.InternalLogDisplay.Multiline = true;
            this.InternalLogDisplay.Name = "InternalLogDisplay";
            this.InternalLogDisplay.ReadOnly = true;
            this.InternalLogDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InternalLogDisplay.Size = new System.Drawing.Size(700, 215);
            this.InternalLogDisplay.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Internal Logs:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(700, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update Presence";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Generals:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Assets:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(597, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Buttons:";
            // 
            // StateInput
            // 
            this.StateInput.Location = new System.Drawing.Point(12, 230);
            this.StateInput.Name = "StateInput";
            this.StateInput.Size = new System.Drawing.Size(150, 20);
            this.StateInput.TabIndex = 10;
            // 
            // DetailInput
            // 
            this.DetailInput.Location = new System.Drawing.Point(12, 284);
            this.DetailInput.Multiline = true;
            this.DetailInput.Name = "DetailInput";
            this.DetailInput.Size = new System.Drawing.Size(150, 120);
            this.DetailInput.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Details:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(287, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Large Image";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Image Key:";
            // 
            // LargeImageIDInput
            // 
            this.LargeImageIDInput.Location = new System.Drawing.Point(290, 245);
            this.LargeImageIDInput.Name = "LargeImageIDInput";
            this.LargeImageIDInput.Size = new System.Drawing.Size(150, 20);
            this.LargeImageIDInput.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Image Text:";
            // 
            // LargeImageTextInput
            // 
            this.LargeImageTextInput.Location = new System.Drawing.Point(290, 284);
            this.LargeImageTextInput.Name = "LargeImageTextInput";
            this.LargeImageTextInput.Size = new System.Drawing.Size(150, 20);
            this.LargeImageTextInput.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(287, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Small Image";
            // 
            // SmallImageTextInput
            // 
            this.SmallImageTextInput.Location = new System.Drawing.Point(290, 384);
            this.SmallImageTextInput.Name = "SmallImageTextInput";
            this.SmallImageTextInput.Size = new System.Drawing.Size(150, 20);
            this.SmallImageTextInput.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 368);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Image Text:";
            // 
            // SmallImageIDInput
            // 
            this.SmallImageIDInput.Location = new System.Drawing.Point(290, 345);
            this.SmallImageIDInput.Name = "SmallImageIDInput";
            this.SmallImageIDInput.Size = new System.Drawing.Size(150, 20);
            this.SmallImageIDInput.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(287, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Image Key:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(559, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 18);
            this.label15.TabIndex = 24;
            this.label15.Text = "First Button";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(559, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Button Name:";
            // 
            // FirstButtonNameInput
            // 
            this.FirstButtonNameInput.Location = new System.Drawing.Point(562, 245);
            this.FirstButtonNameInput.Name = "FirstButtonNameInput";
            this.FirstButtonNameInput.Size = new System.Drawing.Size(150, 20);
            this.FirstButtonNameInput.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(559, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Button Link:";
            // 
            // FirstButtonLinkInput
            // 
            this.FirstButtonLinkInput.Location = new System.Drawing.Point(562, 284);
            this.FirstButtonLinkInput.Name = "FirstButtonLinkInput";
            this.FirstButtonLinkInput.Size = new System.Drawing.Size(150, 20);
            this.FirstButtonLinkInput.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(559, 307);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 18);
            this.label18.TabIndex = 29;
            this.label18.Text = "Second Button";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(559, 329);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Button Name:";
            // 
            // SecondButtonNameInput
            // 
            this.SecondButtonNameInput.Location = new System.Drawing.Point(562, 345);
            this.SecondButtonNameInput.Name = "SecondButtonNameInput";
            this.SecondButtonNameInput.Size = new System.Drawing.Size(150, 20);
            this.SecondButtonNameInput.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(559, 368);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Button Link:";
            // 
            // SecondButtonLinkInput
            // 
            this.SecondButtonLinkInput.Location = new System.Drawing.Point(562, 384);
            this.SecondButtonLinkInput.Name = "SecondButtonLinkInput";
            this.SecondButtonLinkInput.Size = new System.Drawing.Size(150, 20);
            this.SecondButtonLinkInput.TabIndex = 33;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 121);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get Application ID";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 714);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SecondButtonLinkInput);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.SecondButtonNameInput);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.FirstButtonLinkInput);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.FirstButtonNameInput);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SmallImageTextInput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SmallImageIDInput);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LargeImageTextInput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LargeImageIDInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DetailInput);
            this.Controls.Add(this.StateInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InternalLogDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AppIDInput);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Discord RPC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AppIDInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer DiscordRPCRender;
        private System.Windows.Forms.TextBox InternalLogDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StateInput;
        private System.Windows.Forms.TextBox DetailInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LargeImageIDInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LargeImageTextInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SmallImageTextInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SmallImageIDInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox FirstButtonNameInput;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox FirstButtonLinkInput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox SecondButtonNameInput;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox SecondButtonLinkInput;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

