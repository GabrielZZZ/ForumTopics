﻿namespace ForumTopics
{
    partial class TopicDetailPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicDetailPage));
            this.author_name = new System.Windows.Forms.Label();
            this.author_image = new System.Windows.Forms.PictureBox();
            this.topic_title = new System.Windows.Forms.Label();
            this.topic_details1 = new System.Windows.Forms.RichTextBox();
            this.topic_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).BeginInit();
            this.SuspendLayout();
            // 
            // author_name
            // 
            this.author_name.AutoSize = true;
            this.author_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name.Location = new System.Drawing.Point(11, 79);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(63, 22);
            this.author_name.TabIndex = 10;
            this.author_name.Text = "Name";
            // 
            // author_image
            // 
            this.author_image.Image = ((System.Drawing.Image)(resources.GetObject("author_image.Image")));
            this.author_image.Location = new System.Drawing.Point(12, 12);
            this.author_image.Name = "author_image";
            this.author_image.Size = new System.Drawing.Size(62, 59);
            this.author_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.author_image.TabIndex = 9;
            this.author_image.TabStop = false;
            // 
            // topic_title
            // 
            this.topic_title.AutoSize = true;
            this.topic_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_title.Location = new System.Drawing.Point(90, 10);
            this.topic_title.Name = "topic_title";
            this.topic_title.Size = new System.Drawing.Size(50, 22);
            this.topic_title.TabIndex = 7;
            this.topic_title.Text = "Title";
            // 
            // topic_details1
            // 
            this.topic_details1.AutoWordSelection = true;
            this.topic_details1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topic_details1.Cursor = System.Windows.Forms.Cursors.Default;
            this.topic_details1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_details1.Location = new System.Drawing.Point(89, 50);
            this.topic_details1.Name = "topic_details1";
            this.topic_details1.ReadOnly = true;
            this.topic_details1.Size = new System.Drawing.Size(694, 388);
            this.topic_details1.TabIndex = 11;
            this.topic_details1.Text = "Topic Details";
            // 
            // topic_date
            // 
            this.topic_date.AutoSize = true;
            this.topic_date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_date.Location = new System.Drawing.Point(8, 113);
            this.topic_date.Name = "topic_date";
            this.topic_date.Size = new System.Drawing.Size(34, 14);
            this.topic_date.TabIndex = 12;
            this.topic_date.Text = "Date";
            // 
            // TopicDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topic_date);
            this.Controls.Add(this.topic_details1);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.author_image);
            this.Controls.Add(this.topic_title);
            this.Name = "TopicDetailPage";
            this.Text = "TopicDetailPage";
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label author_name;
        private System.Windows.Forms.PictureBox author_image;
        private System.Windows.Forms.Label topic_title;
        private System.Windows.Forms.RichTextBox topic_details1;
        private System.Windows.Forms.Label topic_date;
    }
}