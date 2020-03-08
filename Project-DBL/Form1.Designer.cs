namespace Project_DBL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.opendcbutton = new System.Windows.Forms.Button();
            this.killdcbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Pusab", 18F);
            this.button1.Location = new System.Drawing.Point(631, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Pusab", 24F);
            this.button2.Location = new System.Drawing.Point(631, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "Build";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Pusab", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(631, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 83);
            this.button3.TabIndex = 2;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // opendcbutton
            // 
            this.opendcbutton.Font = new System.Drawing.Font("Pusab", 24F);
            this.opendcbutton.Location = new System.Drawing.Point(12, 12);
            this.opendcbutton.Name = "opendcbutton";
            this.opendcbutton.Size = new System.Drawing.Size(195, 103);
            this.opendcbutton.TabIndex = 3;
            this.opendcbutton.Text = "Open Discord";
            this.opendcbutton.UseVisualStyleBackColor = true;
            this.opendcbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // killdcbutton
            // 
            this.killdcbutton.Font = new System.Drawing.Font("Pusab", 24F);
            this.killdcbutton.Location = new System.Drawing.Point(13, 122);
            this.killdcbutton.Name = "killdcbutton";
            this.killdcbutton.Size = new System.Drawing.Size(194, 99);
            this.killdcbutton.TabIndex = 4;
            this.killdcbutton.Text = "Kill Discord";
            this.killdcbutton.UseVisualStyleBackColor = true;
            this.killdcbutton.Click += new System.EventHandler(this.killdcbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = global::Project_DBL.Properties.Resources.discord;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.killdcbutton);
            this.Controls.Add(this.opendcbutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.Text = "Discord Bot Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button opendcbutton;
        private System.Windows.Forms.Button killdcbutton;
    }
}

