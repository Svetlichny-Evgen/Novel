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
    }
}
