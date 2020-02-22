using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverOS.UI
{
    [DefaultEvent("Click")]
    [ProvideProperty("SilverUI", typeof(Control))]
    public partial class SilverImageButton : PictureBox
    {
        private int zoom = 10;
        private Image image;
        private Image imageActive;

        public int Zoom
        {
            get
            {
                return zoom;
            }
            set
            {
                zoom = value;
            }
        }

        public Image ImageActive
        {
            get
            {
                return imageActive;
            }
            set
            {
                imageActive = value;
            }
        }

        public SilverImageButton()
        {
            InitializeComponent();
            SizeMode = PictureBoxSizeMode.Zoom;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            image = Image;
            if (imageActive != null)
                Image = imageActive;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Image = image;
            base.OnMouseEnter(e);
        }
    }
}
