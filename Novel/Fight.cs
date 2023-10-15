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
using static System.Windows.Forms.DataFormats;

namespace Novel
{
    public partial class Fight : Form
    {
        private PlayerPanel playerPnl;
        private EnemyControl enemyCtrl;
        private Random random = new Random();
        public Fight()
        {
            InitializeComponent();
        }


        private void Fight_Load(object sender, EventArgs e)
        {
            PersonModel enemy = new PersonModel()
            {
                // К сожалению что-то пошло не так, и при попітке переименования ресурсов возникает критическая остановка
                head = Properties.Resources.imgonline_com_ua_Mirror_dZKJDvksmS_removebg_preview,
                tail = Properties.Resources.imgonline_com_ua_Mirror_weAmx4nygAWp_removebg_preview,
                legs = Properties.Resources.imgonline_com_ua_Mirror_gU5vpXsSl673NnZp_removebg_preview
            };

            enemyCtrl = new EnemyControl(enemy);
            enemyCtrl.ClickOnPerson += Enemy_ClickOnPerson;
            enemyCtrl.Location = new Point(565, 100);
            Controls.Add(enemyCtrl);


            PersonModel player = new PersonModel()
            {
                // К сожалению что-то пошло не так, и при попітке переименования ресурсов возникает критическая остановка
                head = Properties.Resources.image_part_001,
                tail = Properties.Resources.image_part_002,
                legs = Properties.Resources.image_part_003,
                hand = Properties.Resources.Sheald

            };
            playerPnl = new PlayerPanel(player);
            playerPnl.Location = new Point(0, 100);
            Controls.Add(playerPnl);

            SetElementsPosition();
        }
        private void SetElementsPosition() 
        {
            int centerX = Width / 2 - dice.Width / 2;
            int topPosition = (int)(Height * 0.8 - dice.Height);

            dice.Location = new Point(centerX, topPosition);
        }
        bool isAnimate = false;
        private async void Enemy_ClickOnPerson(object? sender, EventArgs e)
        {
            if (isAnimate)
                return;
            isAnimate = true;
            int diceEnemy = await dice.rollDice();
            helthEnemy.Value -= diceEnemy * 3;
            
            enemyCtrl.Animation();
            await Task.Delay(500);

            int diceHero = await dice.rollDice();
            helthPlayer.Value -= diceHero * 3;

            int part = random.Next(0, 3);
            playerPnl.getDamage(part);
            //Из-за того, что я не удалил задний фон у игрока - не видно куда попали
            playerPnl.Animation();
            isAnimate = false;
        }
    }
}
