namespace Novel
{
    public partial class NovelMain : Form
    {
        private int storyStep = 1;

        public NovelMain()
        {
            InitializeComponent();
            UpdateStory();

            // Добавляем обработчики событий MouseEnter и MouseLeave
            Choice1.MouseEnter += Label_MouseEnter;
            Choice1.MouseLeave += Label_MouseLeave;
            Choice2.MouseEnter += Label_MouseEnter;
            Choice2.MouseLeave += Label_MouseLeave;
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            // Изменяем текст при наведении
            Label label = sender as Label;
            if (label != null)
            {
                label.Font = new System.Drawing.Font(label.Font, System.Drawing.FontStyle.Bold);
                label.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            // Восстанавливаем текст после ухода курсора
            Label label = sender as Label;
            if (label != null)
            {
                label.Font = new System.Drawing.Font(label.Font, System.Drawing.FontStyle.Regular);
                label.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void UpdateText(string eventText, string choice1Text, string choice2Text)
        {
            Event.Text = eventText;
            Choice1.Text = choice1Text;
            Choice2.Text = choice2Text;
        }

        private void UpdateStory()
        {
            switch (storyStep)
            {
                case 1:
                    UpdateText("Привет. Так это про тебя мне говорили? " +
                        "\nМеня зовут Роджер, а это моя мастерская. Тебя зовут Тимоха, я прав?",
                        "Да", "Нет");
                    Choice1.Visible = true;
                    Choice2.Visible = true;
                    imageLayer.Image = Properties.Resources.TalkingEngineer;
                    break;
                case 2:
                    UpdateText("Хмм... Ну если так, то выметайся отсюда",
                        "Начать заново", "Начать заново");
                    Choice1.Visible = false;
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
                        "Чтоооо??? Нет, это опасно, пусть тебе найдут другого ассистента! (Начать заново)");
                    imageLayer.Image = Properties.Resources.SeriousEngineer;
                    break;
                case 5:
                    UpdateText("Безусловно, но одновременно это же весело, не так ли?",
                        "Нет, пожалуй я откажусь, до свидания! (Начать заново)",
                        "Ох. Пожалуй ты прав, ну что ж, за работу (Начать заново)");
                    imageLayer.Image = Properties.Resources.Engineer;
                    break;
                default:
                    break;
            }
        }

        //private void Choice1_Click(object sender, EventArgs e)
        //{
        //    // Обработка выбора 1
        //    if (storyStep == 1)
        //    {
        //        storyStep = 3; // Переход к событию 3
        //        UpdateStory();
        //    }
        //    else if (storyStep == 3)
        //    {
        //        // Обработка выбора "Хорошо, и что нужно делать?"
        //        storyStep = 4; // Переход к событию 4
        //        UpdateStory();
        //    }
        //    else if (storyStep == 4)
        //    {
        //        // Обработка выбора "Постараюсь... Ну что, приступим! (Начать заново)"
        //        storyStep = 1; // Начало истории
        //        UpdateStory();
        //    }
        //    else if (storyStep == 5)
        //    {
        //        // Обработка выбора "Нет, пожалуй я откажусь, до свидания! (Начать заново)"
        //        storyStep = 1; // Начало истории
        //        UpdateStory();
        //    }
        //}

        //private void Choice2_Click(object sender, EventArgs e)
        //{
        //    // Обработка выбора 2
        //    if (storyStep == 1)
        //    {
        //        storyStep = 2; // Переход к событию 2
        //        UpdateStory();
        //    }
        //    else if (storyStep == 2)
        //    {
        //        storyStep = 1; // Начало истории
        //        UpdateStory();
        //    }
        //    else if (storyStep == 3)
        //    {
        //        // Обработка выбора "А это не опасно?"
        //        storyStep = 5; // Переход к событию 5
        //        UpdateStory();
        //    }
        //    else if (storyStep == 4)
        //    {
        //        // Обработка выбора "Постараюсь... Ну что, приступим! (Начать заново)"
        //        storyStep = 1; // Начало истории
        //        UpdateStory();
        //    }
        //    else if (storyStep == 5)
        //    {
        //        // Обработка выбора "Ох. Пожалуй ты прав, ну что ж, за работу (Начать заново)"
        //        storyStep = 1; // Начало истории
        //        UpdateStory();
        //    }
        //}

        private void Choice_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;

            // Определите, какой выбор был сделан, и обработайте его соответствующим образом
            if (currentLabel == Choice1)
            {
                if (storyStep == 1)
                {
                    storyStep = 3;
                }
                else if (storyStep == 3)
                {
                    storyStep = 4;
                }
                else if (storyStep == 4)
                {
                    storyStep = 1;
                }
                else if (storyStep == 5)
                {
                    storyStep = 1;
                }
            }
            else if (currentLabel == Choice2)
            {
                if (storyStep == 1)
                {
                    storyStep = 2;
                }
                else if (storyStep == 2)
                {
                    storyStep = 1;
                }
                else if (storyStep == 3)
                {
                    storyStep = 5;
                }
                else if (storyStep == 4)
                {
                    storyStep = 1;
                }
                else if (storyStep == 5)
                {
                    storyStep = 1;
                }
            }

            UpdateStory();
        }
    }
}
