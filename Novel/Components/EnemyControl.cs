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

        #region Init
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

        event EventHandler clickOnPerson;
        public event EventHandler ClickOnPerson
        {
            add { clickOnPerson += value; }
            remove { clickOnPerson -= value; }
        }


        private void body_Click(object sender, EventArgs e)
        {
            clickOnPerson.Invoke(sender, e);
        }
    }
}
