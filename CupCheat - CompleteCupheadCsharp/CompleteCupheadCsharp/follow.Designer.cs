namespace CompleteCupheadCsharp
{
    partial class follow
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
            this.dcbutton = new System.Windows.Forms.Button();
            this.twitterbutton = new System.Windows.Forms.Button();
            this.ytbutton = new System.Windows.Forms.Button();
            this.twitchbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dcbutton
            // 
            this.dcbutton.BackColor = System.Drawing.Color.Black;
            this.dcbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dcbutton.Location = new System.Drawing.Point(12, 12);
            this.dcbutton.Name = "dcbutton";
            this.dcbutton.Size = new System.Drawing.Size(97, 44);
            this.dcbutton.TabIndex = 0;
            this.dcbutton.Text = "Discord";
            this.dcbutton.UseVisualStyleBackColor = false;
            this.dcbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // twitterbutton
            // 
            this.twitterbutton.BackColor = System.Drawing.Color.Black;
            this.twitterbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.twitterbutton.Location = new System.Drawing.Point(136, 12);
            this.twitterbutton.Name = "twitterbutton";
            this.twitterbutton.Size = new System.Drawing.Size(100, 44);
            this.twitterbutton.TabIndex = 1;
            this.twitterbutton.Text = "Twitter";
            this.twitterbutton.UseVisualStyleBackColor = false;
            this.twitterbutton.Click += new System.EventHandler(this.twitterbutton_Click);
            // 
            // ytbutton
            // 
            this.ytbutton.BackColor = System.Drawing.Color.Black;
            this.ytbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ytbutton.Location = new System.Drawing.Point(12, 90);
            this.ytbutton.Name = "ytbutton";
            this.ytbutton.Size = new System.Drawing.Size(97, 40);
            this.ytbutton.TabIndex = 2;
            this.ytbutton.Text = "YouTube";
            this.ytbutton.UseVisualStyleBackColor = false;
            this.ytbutton.Click += new System.EventHandler(this.ytbutton_Click);
            // 
            // twitchbutton
            // 
            this.twitchbutton.BackColor = System.Drawing.Color.Black;
            this.twitchbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.twitchbutton.Location = new System.Drawing.Point(136, 90);
            this.twitchbutton.Name = "twitchbutton";
            this.twitchbutton.Size = new System.Drawing.Size(100, 40);
            this.twitchbutton.TabIndex = 3;
            this.twitchbutton.Text = "Twitch";
            this.twitchbutton.UseVisualStyleBackColor = false;
            this.twitchbutton.Click += new System.EventHandler(this.twitchbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(-12, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 159);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // follow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(248, 142);
            this.Controls.Add(this.twitchbutton);
            this.Controls.Add(this.ytbutton);
            this.Controls.Add(this.twitterbutton);
            this.Controls.Add(this.dcbutton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "follow";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "grialion on:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dcbutton;
        private System.Windows.Forms.Button twitterbutton;
        private System.Windows.Forms.Button ytbutton;
        private System.Windows.Forms.Button twitchbutton;
        private System.Windows.Forms.Button button1;
    }
}