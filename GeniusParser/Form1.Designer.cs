namespace GeniusParser
{
    partial class Form
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
            this.start_button = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.artist_label = new System.Windows.Forms.Label();
            this.somg_label = new System.Windows.Forms.Label();
            this.artist_textBox = new System.Windows.Forms.TextBox();
            this.song_textBox = new System.Windows.Forms.TextBox();
            this.abort_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(721, 151);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(13, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(663, 420);
            this.listBox.TabIndex = 1;
            // 
            // artist_label
            // 
            this.artist_label.AutoSize = true;
            this.artist_label.Location = new System.Drawing.Point(682, 8);
            this.artist_label.Name = "artist_label";
            this.artist_label.Size = new System.Drawing.Size(154, 13);
            this.artist_label.TabIndex = 2;
            this.artist_label.Text = "What artist are you looking for?";
            // 
            // somg_label
            // 
            this.somg_label.AutoSize = true;
            this.somg_label.Location = new System.Drawing.Point(682, 76);
            this.somg_label.Name = "somg_label";
            this.somg_label.Size = new System.Drawing.Size(155, 13);
            this.somg_label.TabIndex = 3;
            this.somg_label.Text = "What song are you looking for?";
            // 
            // artist_textBox
            // 
            this.artist_textBox.Location = new System.Drawing.Point(685, 36);
            this.artist_textBox.Name = "artist_textBox";
            this.artist_textBox.Size = new System.Drawing.Size(151, 20);
            this.artist_textBox.TabIndex = 4;
            // 
            // song_textBox
            // 
            this.song_textBox.Location = new System.Drawing.Point(688, 107);
            this.song_textBox.Name = "song_textBox";
            this.song_textBox.Size = new System.Drawing.Size(148, 20);
            this.song_textBox.TabIndex = 5;
            // 
            // abort_button
            // 
            this.abort_button.Location = new System.Drawing.Point(721, 193);
            this.abort_button.Name = "abort_button";
            this.abort_button.Size = new System.Drawing.Size(75, 23);
            this.abort_button.TabIndex = 6;
            this.abort_button.Text = "Abort";
            this.abort_button.UseVisualStyleBackColor = true;
            this.abort_button.Click += new System.EventHandler(this.abort_button_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.abort_button);
            this.Controls.Add(this.song_textBox);
            this.Controls.Add(this.artist_textBox);
            this.Controls.Add(this.somg_label);
            this.Controls.Add(this.artist_label);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.start_button);
            this.Name = "Form";
            this.Text = "Genius parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label artist_label;
        private System.Windows.Forms.Label somg_label;
        private System.Windows.Forms.TextBox artist_textBox;
        private System.Windows.Forms.TextBox song_textBox;
        private System.Windows.Forms.Button abort_button;
    }
}

