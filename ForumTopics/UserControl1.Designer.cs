namespace ForumTopics
{
    partial class UserControl1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.author_image = new System.Windows.Forms.PictureBox();
            this.topic_details = new System.Windows.Forms.Label();
            this.topic_title = new System.Windows.Forms.Label();
            this.author_name = new System.Windows.Forms.Label();
            this.view_details = new System.Windows.Forms.Button();
            this.topic_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).BeginInit();
            this.SuspendLayout();
            // 
            // author_image
            // 
            this.author_image.Image = ((System.Drawing.Image)(resources.GetObject("author_image.Image")));
            this.author_image.Location = new System.Drawing.Point(10, 13);
            this.author_image.Name = "author_image";
            this.author_image.Size = new System.Drawing.Size(62, 59);
            this.author_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.author_image.TabIndex = 5;
            this.author_image.TabStop = false;
            this.author_image.Click += new System.EventHandler(this.author_image_Click);
            // 
            // topic_details
            // 
            this.topic_details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_details.ForeColor = System.Drawing.SystemColors.GrayText;
            this.topic_details.Location = new System.Drawing.Point(88, 47);
            this.topic_details.Name = "topic_details";
            this.topic_details.Size = new System.Drawing.Size(745, 55);
            this.topic_details.TabIndex = 4;
            this.topic_details.Text = "Topic Details";
            this.topic_details.Click += new System.EventHandler(this.topic_details_Click);
            // 
            // topic_title
            // 
            this.topic_title.AutoSize = true;
            this.topic_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_title.Location = new System.Drawing.Point(88, 11);
            this.topic_title.Name = "topic_title";
            this.topic_title.Size = new System.Drawing.Size(50, 22);
            this.topic_title.TabIndex = 3;
            this.topic_title.Text = "Title";
            this.topic_title.Click += new System.EventHandler(this.topic_title_Click);
            // 
            // author_name
            // 
            this.author_name.AutoSize = true;
            this.author_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name.Location = new System.Drawing.Point(9, 80);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(63, 22);
            this.author_name.TabIndex = 6;
            this.author_name.Text = "Name";
            // 
            // view_details
            // 
            this.view_details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_details.Location = new System.Drawing.Point(727, 136);
            this.view_details.Name = "view_details";
            this.view_details.Size = new System.Drawing.Size(75, 23);
            this.view_details.TabIndex = 7;
            this.view_details.Text = "Details";
            this.view_details.UseVisualStyleBackColor = true;
            this.view_details.Click += new System.EventHandler(this.view_details_Click);
            // 
            // topic_date
            // 
            this.topic_date.AutoSize = true;
            this.topic_date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_date.Location = new System.Drawing.Point(8, 114);
            this.topic_date.Name = "topic_date";
            this.topic_date.Size = new System.Drawing.Size(39, 16);
            this.topic_date.TabIndex = 8;
            this.topic_date.Text = "Date";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.topic_date);
            this.Controls.Add(this.view_details);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.author_image);
            this.Controls.Add(this.topic_details);
            this.Controls.Add(this.topic_title);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(856, 175);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox author_image;
        private System.Windows.Forms.Label topic_details;
        private System.Windows.Forms.Label topic_title;
        private System.Windows.Forms.Label author_name;
        private System.Windows.Forms.Button view_details;
        private System.Windows.Forms.Label topic_date;
    }
}
