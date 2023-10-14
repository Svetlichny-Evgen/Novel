using Novel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Novel
{
    public partial class PlayerPanel : UserControl
    {
        PersonModel _pm;
        Color damage = Color.FromArgb(145,45,45);
        Color success = Color.FromArgb(0, 125, 125);
        public PlayerPanel(PersonModel pm)
        {
            InitializeComponent();

            _pm = pm;

            Head = pm.head;
            Body = pm.tail;
            Legs = pm.legs;

            BodyImage = pm.hand;
        }

        #region Head/Body/Legs
        public Image Head
        {
            get
            {
                return head.BackgroundImage;
            }
            set
            {
                head.BackgroundImage = value;
            }
        }
        public Image Body
        {
            get
            {
                return body.BackgroundImage;
            }
            set
            {
                body.BackgroundImage = value;
            }
        }
        public Image Legs
        {
            get
            {
                return legs.BackgroundImage;
            }
            set
            {
                legs.BackgroundImage = value;
            }
        }
        #endregion

        #region Images
        public Image HeadImage
        {
            get
            {
                return head.Image;
            }
            set
            {
                head.Image = value;
            }
        }
        public Image BodyImage
        {
            get
            {
                return body.Image;
            }
            set
            {
                body.Image = value;
            }
        }
        public Image LegsImage
        {
            get
            {
                return legs.Image;
            }
            set
            {
                legs.Image = value;
            }
        }

        #endregion

        public async void Animation()
        {
            Point current = Location;
            int power = 3;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Location = new Point(current.X + power, current.Y - power);
                }
                else
                {
                    Location = new Point(current.X - power, current.Y + power);
                }
                await Task.Delay(30);
            }
            Location = current;
        }

        private void SaveZone(object sender, EventArgs e)
        {
            ClearHand();
            PictureBox current = (PictureBox)sender;
            current.Image = _pm.hand;
        }
        public void ClearHand() 
        {
            HeadImage = BodyImage = LegsImage = null;
        }

        public async void getDamage(int part)
        {
            PictureBox? current = null;

            if (part == 0)
            {
                current = head;
            }
            else if (part == 1)
            {
                current = body;
            }
            else if(part == 2)
            {
                current = legs;
            }

            Color color;
            if (current.Image != null)
            {
                color = success;
            }
            else { 
                color = damage; 
            }
            current.BackColor = color;
            await Task.Delay(500);
            current.BackColor = Color.Transparent;
        }
    }
}
