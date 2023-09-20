namespace Novel
{
    public partial class NovelMain : Form
    {
        private int storyStep = 0;
        public NovelMain()
        {
            InitializeComponent();
            UpdateText("Привет. Так это про тебя мне говорили? \nМеня зовут Роджер, а это моя мастерская. Тебя зовут Вернон, я прав?", "Да", "Нет");

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

        private void Choice1_Click(object sender, EventArgs e)
        {
            if (storyStep == 0)
            {
                UpdateText("Хорошо, тогда введу тебя в курс дела.\n Я разрабатываю новую супер пупер мега гипер мощную турель. \nТебя прислали сюда, так как мне нужен ассистент, ибо это может ускорить ход разработки моего чудо-прибора.", "Хорошо, и что нужно делать?", "А это не опасно?");
                storyStep = 1;
            }
            else if (storyStep == 1)
            {
                UpdateText("Я тебе буду давать задания из разряда подай-принеси, ничего сложного. \nТолько будь осторожен и ничего не урони, а то всё взлетит наверх!", "Постараюсь... Ну что, приступим!", "Чтоооо??? Нет, это опасно, пусть тебе найдут другого ассистента (КОНЕЦ)");
                storyStep = 2;
            }
            else if (storyStep == 2)
            {
                UpdateText("Постараюсь... Ну что, приступим!", "", "");
                storyStep = 3;
            }
        }


        private void Choice2_Click(object sender, EventArgs e)
        {
            if (storyStep == 0)
            {
                UpdateText("Хмм... Ну если так, то выметайся отсюда (КОНЕЦ)", "", "");
            }
            //else if (storyStep==2)
            //{
            //    UpdateText()
            //}
            else if (storyStep == 3)
            {
                UpdateText("Чтоооо??? Нет, это опасно, пусть тебе найдут другого ассистента (КОНЕЦ)", "", "");
            }
        }
    }
}