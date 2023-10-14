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
        private void Choice_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;

            // Определите, какой выбор был сделан, и обработайте его соответствующим образом
            if (currentLabel == lbChoice1)
            {
                if (NovelMain.currentStoryStep == 1)
                {
                    NovelMain.currentStoryStep = 3;
                }
                else if (NovelMain.currentStoryStep == 3)
                {
                    NovelMain.currentStoryStep = 4;
                }
                else if (NovelMain.currentStoryStep == 4)
                {
                    NovelMain.currentStoryStep = 1;
                }
                else if (NovelMain.currentStoryStep == 5)
                {
                    NovelMain.currentStoryStep = 1;
                }
                else if (NovelMain.currentStoryStep == 6)
                {
                    NovelMain.currentStoryStep = 1;
                }
            }
            else if (currentLabel == lbChoice2)
            {
                if (NovelMain.currentStoryStep == 1)
                {
                    NovelMain.currentStoryStep = 2;
                }
                else if (NovelMain.currentStoryStep == 2)
                {
                    NovelMain.currentStoryStep = 1;
                }
                else if (NovelMain.currentStoryStep == 3)
                {
                    NovelMain.currentStoryStep = 5;
                }
                else if (NovelMain.currentStoryStep == 4)
                {
                    NovelMain.currentStoryStep = 6;
                }
                else if (NovelMain.currentStoryStep == 5)
                {
                    NovelMain.currentStoryStep = 1;
                }
                else if (NovelMain.currentStoryStep == 6)
                {
                    // TODO: Начать бой
                    NovelMain.currentStoryStep = 7;
                }
            }
            NovelMain.UpdateStory();
        }
        #endregion
    }
}
