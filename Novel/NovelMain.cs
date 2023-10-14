using Novel.Models;

namespace Novel
{
    public partial class NovelMain : Form
    {
        public static int currentStoryStep = 1;
        private static ChoiseControlPanel? choiseControlPanel;
        PlayerPanel playerPnl;
        EnemyControl enemyCtrl;
        public NovelMain()
        {
            InitializeComponent();
            UpdateStory(); // Вызов метода UpdateStory
            Fight();
        }


        #region Story update text
        public static void UpdateText(string eventText, string choice1Text, string choice2Text)
        {
            ChoiseControlPanel.lbEvent.Text = eventText;
            ChoiseControlPanel.lbChoice1.Text = choice1Text;
            ChoiseControlPanel.lbChoice2.Text = choice2Text;
        }

        public static void UpdateStory()
        {
            switch (currentStoryStep)
            {
                case 1:
                    UpdateText("Привет. Так это про тебя мне говорили? " +
                        "\nМеня зовут Роджер, а это моя мастерская. Тебя зовут Тимоха, я прав?",
                        "Да", "Нет");

                    ChoiseControlPanel.lbChoice1.Visible = true;
                    ChoiseControlPanel.lbChoice2.Visible = true;
                    imageLayer.Image = Properties.Resources.TalkingEngineer;
                    break;

                case 2:
                    UpdateText("Хмм... Ну если так, то выметайся отсюда",
                        "Начать заново", "Начать заново");
                    ChoiseControlPanel.lbChoice1.Visible = false;
                    imageLayer.Image = Properties.Resources.AngryEngineer;
                    break;

                case 3:
                    UpdateText("Хорошо, тогда введу тебя в курс дела. Я разрабатываю новую супер пупер мега гипер мощную турель. Тебя прислали сюда, так как мне нужен ассистент, так как это может ускорить ход разработки моего чудо-прибора.",
                        "Хорошо, и что нужно делать?", "А это не опасно?");
                    imageLayer.Image = Properties.Resources.HappyEngineer;
                    break;

                case 4:
                    UpdateText("Я тебе буду давать задания из разряда подай-принеси, ничего сложного. Только будь осторожен и ничего не урони, а то всё взлетит в воздух!",
                        "Постараюсь... Ну что, приступим! (Начать заново)",
                        "Чтоооо??? Нет, это опасно, пусть тебе найдут другого ассистента!");
                    imageLayer.Image = Properties.Resources.SeriousEngineer;
                    break;

                case 5:
                    UpdateText("Безусловно, но одновременно это же весело, не так ли?",
                        "Нет, пожалуй я откажусь, до свидания! (Начать заново)",
                        "Ох. Пожалуй ты прав, ну что ж, за работу (Начать заново)");
                    imageLayer.Image = Properties.Resources.Engineer;
                    break;

                case 6:
                    UpdateText("Не так быстро, гадёныш. Ты узнал слишком много и поэтому я тебя просто так не отпущу!",
                        "Ладно... Помогу, ибо если я остануь, усть хотя бы небольшой шанс того, что я не пострадаю",
                        "(Начать бой)");
                    imageLayer.Image = Properties.Resources.AngryEngineer;
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Fight
        public void Fight()
        {
            PersonModel enemy = new PersonModel()
            {
                // К сожалению что-то пошло не так, и при попітке переименования ресурсов возникает критическая остановка
                head = Properties.Resources.imgonline_com_ua_Mirror_dZKJDvksmS_removebg_preview,
                tail = Properties.Resources.imgonline_com_ua_Mirror_weAmx4nygAWp_removebg_preview,
                legs = Properties.Resources.imgonline_com_ua_Mirror_gU5vpXsSl673NnZp_removebg_preview
            };

            enemyCtrl = new EnemyControl(enemy);
            enemyCtrl.Location = new Point(565, 100);


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
            imageLayer.Hide();
            choiseControlPanel1.Hide();
            Controls.Add(playerPnl);
            Controls.Add(enemyCtrl);
        }
        #endregion
    }
}
