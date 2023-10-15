using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novel.Components
{
    public partial class DiceComponent : UserControl
    {
        Random Random = new Random();
        public DiceComponent()
        {
            InitializeComponent();
        }

        private async void Animation() 
        {
            int top = 0;
            int power = 3;
            for (int i = 0; i < 10; i++)
            {
                Location = new Point(Location.X, Location.Y - top);
                top += power;
                await Task.Delay(30);
            }
            await Task.Delay(200);
            top= 0;
            for (int i = 0; i < 10; i++)
            {
                Location = new Point(Location.X, Location.Y + top);
                top += power;
                await Task.Delay(30);
            }
        }

        public async Task<int> rollDice()
        {
            Animation();    
            diceArea.Image = Properties.Resources.dice;
            await Task.Delay(1000);
            int side = Random.Next(0, 6) + 1;

            if (side == 1)
            {
                diceArea.Image = Properties.Resources.D6_1;
            }
            else if (side == 2)
            {
                diceArea.Image = Properties.Resources.D6_2;
            }
            else if (side == 3)
            {
                diceArea.Image = Properties.Resources.D6_3;
            }
            else if (side == 4)
            {
                diceArea.Image = Properties.Resources.D6_4;
            }
            else if (side == 5)
            {
                diceArea.Image = Properties.Resources.D6_5;
            }
            else if (side == 6)
            {
                diceArea.Image = Properties.Resources.D6_6;
            }
            await Task.Delay(700);
            diceArea.Image = null;
            return side;
        }
    }
}
