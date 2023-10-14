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

namespace Novel
{
    public partial class EnemyControl : UserControl
    {
        public EnemyControl(PersonModel pm)
        {
            InitializeComponent();

            Head = pm.head;
            Body = pm.tail;
            Legs = pm.legs;
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
