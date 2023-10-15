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
    public partial class ChoiseControlPanel : UserControl
    {
        public int currentStoryStep = 1;
        public ChoiseControlPanel()
        {
            InitializeComponent();

            //Добавляем обработчики событий MouseEnter и MouseLeave
            lbChoice1.MouseEnter += Label_MouseEnter;
            lbChoice1.MouseLeave += Label_MouseLeave;
            lbChoice2.MouseEnter += Label_MouseEnter;
            lbChoice2.MouseLeave += Label_MouseLeave;

            lbEvent.Font = new Font("Century Ghotic", 20, FontStyle.Regular);
            lbChoice1.Font = new Font("Century Ghotic", 16, FontStyle.Regular);
            lbChoice2.Font = new Font("Century Ghotic", 16, FontStyle.Regular);
        }

        #region label Enter/Leave Event
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
        #endregion

        #region Init
        public string Event
        {
            get
            {
                return lbEvent.Text;
            }
            set
            {
                lbEvent.Text = value;
            }
        }
        public string Choice1
        {
            get
            {
                return lbChoice1.Text;
            }
            set
            {
                lbChoice1.Text = value;
            }
        }
        public string Choice2
        {
            get
            {
                return lbChoice2.Text;
            }
            set
            {
                lbChoice2.Text = value;
            }
        }
        #endregion

        #region Update Story
        public void UpdateText(string eventText, string choice1Text, string choice2Text)
        {
            lbEvent.Text = eventText;
            lbChoice1.Text = choice1Text;
            lbChoice2.Text = choice2Text;

        }
        public void UpdateStory()
        {
            switch (currentStoryStep)
            {
                case 1:
                    UpdateText("Привет. Так это про тебя мне говорили? " +
                        "\nМеня зовут Роджер, а это моя мастерская. Тебя зовут Тимоха, я прав?",
                        "Да", "Нет");
                    lbChoice1.Visible = true;
                    lbChoice2.Visible = true;
                    NovelMain.imageLayer.Image = Properties.Resources.TalkingEngineer;
                    break;

                case 2:
                    UpdateText("Хмм... Ну если так, то выметайся отсюда",
                        "Начать заново", "Начать заново");
                    lbChoice1.Visible = false;
                    NovelMain.imageLayer.Image = Properties.Resources.AngryEngineer;
                    break;

                case 3:
                    UpdateText("Хорошо, тогда введу тебя в курс дела. Я разрабатываю новую супер пупер мега гипер мощную турель. Тебя прислали сюда, так как мне нужен ассистент, так как это может ускорить ход разработки моего чудо-прибора.",
                        "Хорошо, и что нужно делать?", "А это не опасно?");
                    NovelMain.imageLayer.Image = Properties.Resources.HappyEngineer;
                    break;

                case 4:
                    UpdateText("Я тебе буду давать задания из разряда подай-принеси, ничего сложного. Только будь осторожен и ничего не урони, а то всё взлетит в воздух!",
                        "Постараюсь... Ну что, приступим! (Начать заново)",
                        "Чтоооо??? Нет, это опасно, пусть тебе найдут другого ассистента!");
                    NovelMain.imageLayer.Image = Properties.Resources.SeriousEngineer;
                    break;

                case 5:
                    UpdateText("Безусловно, но одновременно это же весело, не так ли?",
                        "Нет, пожалуй я откажусь, до свидания! (Начать заново)",
                        "Ох. Пожалуй ты прав, ну что ж, за работу (Начать заново)");
                    NovelMain.imageLayer.Image = Properties.Resources.Engineer;
                    break;

                case 6:
                    UpdateText("Не так быстро, гадёныш. Ты узнал слишком много и поэтому я тебя просто так не отпущу!",
                        "Ладно... Помогу, ибо если я остануь, усть хотя бы небольшой шанс того, что я не пострадаю",
                        "(Начать бой)");
                    NovelMain.imageLayer.Image = Properties.Resources.AngryEngineer;
                    break;

                case 7:
                    Fight form = new Fight();
                    form.Show();
                    //Из-за моих оплошностей эту форму не получается скрыть
                    
                    break;
                default:
                    break;
            }
        }

        private void Choice_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;

            // Определите, какой выбор был сделан, и обработайте его соответствующим образом
            if (currentLabel == lbChoice1)
            {
                if (currentStoryStep == 1)
                {
                    currentStoryStep = 3;
                }
                else if (currentStoryStep == 3)
                {
                    currentStoryStep = 4;
                }
                else if (currentStoryStep == 4)
                {
                    currentStoryStep = 1;
                }
                else if (currentStoryStep == 5)
                {
                    currentStoryStep = 1;
                }
                else if (currentStoryStep == 6)
                {
                    currentStoryStep = 1;
                }
            }
            else if (currentLabel == lbChoice2)
            {
                if (currentStoryStep == 1)
                {
                    currentStoryStep = 2;
                }
                else if (currentStoryStep == 2)
                {
                    currentStoryStep = 1;
                }
                else if (currentStoryStep == 3)
                {
                    currentStoryStep = 5;
                }
                else if (currentStoryStep == 4)
                {
                    currentStoryStep = 6;
                }
                else if (currentStoryStep == 5)
                {
                    currentStoryStep = 1;
                }
                else if (currentStoryStep == 6)
                {
                    currentStoryStep = 7;
                }
            }
            UpdateStory();
        }
        #endregion
    }
}
