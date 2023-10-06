namespace Novel
{
    public partial class NovelMain : Form
    {

        private ChoiseControlPanel choiseControlPanel;
        public NovelMain()
        {
            InitializeComponent();
            choiseControlPanel = new ChoiseControlPanel(); // Инициализация экземпляра
            UpdateStory(); // Вызов метода UpdateStory
        }

        private void Choice_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;

            // Определите, какой выбор был сделан, и обработайте его соответствующим образом
            if (currentLabel == choiseControlPanel.Choice1)
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
            else if (currentLabel == choiseControlPanel.Choice2)
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
