using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForumTopics
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void author_image_Click(object sender, EventArgs e)
        {

        }

        private void topic_title_Click(object sender, EventArgs e)
        {

        }

        private void topic_details_Click(object sender, EventArgs e)
        {

        }

        public string TopicAuthor
        {
            get { return author_name.Text; }
            set { author_name.Text = value; }

        }

        public string TopicTitle
        {
            get { return topic_title.Text; }
            set { topic_title.Text = value; }

        }

        public string TopicDetails
        {
            get { return topic_details.Text; }
            set { topic_details.Text = value; }

        }

        public string TopicDate
        {
            get { return topic_date.Text; }
            set { topic_date.Text = value; }

        }

        public Image AuthorImage
        {
            get { return author_image.Image; }
            set { author_image.Image = value; }

        }

        //change pictureBox picture
        public void ChangeAuthorImage (string url)
        {
            try
            {
                author_image.Load(url);
            }
            catch (Exception ex)
            {
                //显示本地默认图片
                author_image.Image = Image.FromFile(@"C:\Users\A\Desktop\OLLE\testImage.jpg");
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void view_details_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ouch!");
            TopicDetailPage Detail_page = new TopicDetailPage();

            //pass image to TopicDetailPage
            Detail_page.AuthorImage = author_image.Image;

            //pass author name to TopicDetailPage
            Detail_page.TopicAuthor = author_name.Text;

            //pass topic title to TopicDetailPage
            Detail_page.TopicTitle = topic_title.Text;

            //pass topic details to TopicDetailPage
            Detail_page.TopicDetails = topic_details.Text;

            //pass topic date to TopicDetailPage
            Detail_page.TopicDate = topic_date.Text;

            //show TopicDetailPage
            Detail_page.ShowDialog();
        }
    }
}
