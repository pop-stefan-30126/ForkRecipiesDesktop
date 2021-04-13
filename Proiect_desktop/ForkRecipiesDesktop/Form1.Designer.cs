
namespace ForkRecipiesDesktop
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
            this.ViewRecipies = new System.Windows.Forms.Button();
            this.CreateRecipies = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewRecipies
            // 
            this.ViewRecipies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ViewRecipies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewRecipies.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRecipies.ForeColor = System.Drawing.Color.Black;
            this.ViewRecipies.Location = new System.Drawing.Point(108, 210);
            this.ViewRecipies.Name = "ViewRecipies";
            this.ViewRecipies.Size = new System.Drawing.Size(127, 55);
            this.ViewRecipies.TabIndex = 0;
            this.ViewRecipies.Text = "View Recipies";
            this.ViewRecipies.UseVisualStyleBackColor = false;
            this.ViewRecipies.Click += new System.EventHandler(this.ViewRecipies_Click);
            // 
            // CreateRecipies
            // 
            this.CreateRecipies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CreateRecipies.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CreateRecipies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateRecipies.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRecipies.ForeColor = System.Drawing.Color.Black;
            this.CreateRecipies.Location = new System.Drawing.Point(670, 210);
            this.CreateRecipies.Name = "CreateRecipies";
            this.CreateRecipies.Size = new System.Drawing.Size(143, 55);
            this.CreateRecipies.TabIndex = 1;
            this.CreateRecipies.Text = "Create Recipies";
            this.CreateRecipies.UseVisualStyleBackColor = false;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.BackColor = System.Drawing.Color.Transparent;
            this.Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Message.Font = new System.Drawing.Font("Gill Sans MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Message.Location = new System.Drawing.Point(347, 26);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(237, 67);
            this.Message.TabIndex = 2;
            this.Message.Text = "Welcome!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(63, 27);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 619);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.CreateRecipies);
            this.Controls.Add(this.ViewRecipies);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewRecipies;
        private System.Windows.Forms.Button CreateRecipies;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

