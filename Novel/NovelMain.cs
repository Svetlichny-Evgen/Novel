namespace Novel
{
    public partial class NovelMain : Form
    {
        public NovelMain()
        {
            InitializeComponent();
            UpdateStory();

            // ƒобавл€ем обработчики событий MouseEnter и MouseLeave
            Choice1.MouseEnter += Label_MouseEnter;
            Choice1.MouseLeave += Label_MouseLeave;
            Choice2.MouseEnter += Label_MouseEnter;
            Choice2.MouseLeave += Label_MouseLeave;

            //
            Event.Font = new Font("Century Ghotic", 26, FontStyle.Regular);
            Choice1.Font = new Font("Century Ghotic", 26, FontStyle.Regular);
            Choice2.Font = new Font("Century Ghotic", 26, FontStyle.Regular);
        }

        #region label Enter/Leave Event
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            // »змен€ем текст при наведении
            Label label = sender as Label;
            if (label != null)
            {
                label.Font = new System.Drawing.Font(label.Font, System.Drawing.FontStyle.Bold);
                label.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            // ¬осстанавливаем текст после ухода курсора
            Label label = sender as Label;
            if (label != null)
            {
                label.Font = new System.Drawing.Font(label.Font, System.Drawing.FontStyle.Regular);
                label.ForeColor = System.Drawing.Color.Black;
            }
        }
        #endregion

        private void Choice_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;

            // ќпределите, какой выбор был сделан, и обработайте его соответствующим образом
            if (currentLabel == Choice1)
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
            }
            else if (currentLabel == Choice2)
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
                    currentStoryStep = 1;
                }
                else if (currentStoryStep == 5)
                {
                    currentStoryStep = 1;
                }
            }
            UpdateStory();
        }
    }
}
