using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ImageProxy.Pattern;

namespace ImageProxy
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog browseFolder;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browseFolder = new FolderBrowserDialog();

            if (browseFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(browseFolder.SelectedPath);

                foreach (FileInfo file in dir.GetFiles())
                {
                    PictureList.listPictures.Add(new PictureProxy(file.FullName));
                }

                initPictures();
            }
        }

        private void initPictures()
        {
            imageList1.Images.Clear();
            listView1.Items.Clear();

            foreach (var pics in PictureList.listPictures)
            {
                this.imageList1.Images.Add(pics.PictureToShow);
                imageList1.ImageSize = new Size(52, 62);
            }

            this.listView1.View = View.LargeIcon;
            this.listView1.LargeImageList = this.imageList1;

            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listView1.Items.Add(item);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                if (PictureList.listPictures[e.ItemIndex] is Picture)
                {
                    Image picture = PictureList.listPictures[e.ItemIndex].PictureToShow;
                    pictureBox1.Image = new Bitmap(picture, pictureBox1.Width, pictureBox1.Height) as Image;
                }
                else
                {
                    (PictureList.listPictures[e.ItemIndex] as PictureProxy).Draw();
                    (PictureList.listPictures[e.ItemIndex] as PictureProxy).Load();
                    Image picture = PictureList.listPictures[e.ItemIndex].PictureToShow;
                    pictureBox1.Image = new Bitmap(picture, pictureBox1.Width, pictureBox1.Height) as Image;
                    this.imageList1.Images[e.ItemIndex] = new Bitmap(pictureBox1.Image, 52, 62) as Image;
                }
            }
        }
    }
}
