using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novel
{
    public partial class NovelMain
    {

        private int currentStoryStep = 1;

        public void UpdateText(string eventText, string choice1Text, string choice2Text)
        {
            Event.Text = eventText;
            Choice1.Text = choice1Text;
            Choice2.Text = choice2Text;
        }

        public void UpdateStory()
        {
            switch (currentStoryStep)
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
    }
}
