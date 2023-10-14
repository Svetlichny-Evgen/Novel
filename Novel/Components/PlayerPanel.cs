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
        Image _firstLayer;
        public PlayerPanel(PersonModel pm, Image firstLayer)
        {
            InitializeComponent();

            Head = pm.head;
            Body = pm.tail;
            Legs = pm.legs;
            _firstLayer = firstLayer;
        }

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
    }
}
