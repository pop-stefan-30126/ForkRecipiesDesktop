
namespace ForkRecipiesDesktop
{
    partial class Form2
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
            this.imageRecipies = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Ingredients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureRecipie = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRecipie)).BeginInit();
            this.SuspendLayout();
            // 
            // imageRecipies
            // 
            this.imageRecipies.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageRecipies.ImageSize = new System.Drawing.Size(16, 16);
            this.imageRecipies.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "...";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(33, 117);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(82, 33);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Ingredients
            // 
            this.Ingredients.BackColor = System.Drawing.Color.DarkGray;
            this.Ingredients.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredients.FormattingEnabled = true;
            this.Ingredients.ItemHeight = 23;
            this.Ingredients.Location = new System.Drawing.Point(231, 50);
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.Size = new System.Drawing.Size(223, 372);
            this.Ingredients.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search for ingredients";
            // 
            // pictureRecipie
            // 
            this.pictureRecipie.BackgroundImage = global::ForkRecipiesDesktop.Properties.Resources.lupa;
            this.pictureRecipie.Image = global::ForkRecipiesDesktop.Properties.Resources.lupa;
            this.pictureRecipie.Location = new System.Drawing.Point(33, 50);
            this.pictureRecipie.Name = "pictureRecipie";
            this.pictureRecipie.Size = new System.Drawing.Size(23, 23);
            this.pictureRecipie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRecipie.TabIndex = 1;
            this.pictureRecipie.TabStop = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(894, 524);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(111, 33);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(33, 525);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(111, 32);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(1054, 525);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(111, 32);
            this.Next.TabIndex = 8;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1235, 585);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ingredients);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureRecipie);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureRecipie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageRecipies;
        private System.Windows.Forms.PictureBox pictureRecipie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox Ingredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Next;
    }
}