using Novel.Models;
using System.Runtime.CompilerServices;

namespace Novel
{
    public partial class NovelMain : Form
    {

        private ChoiseControlPanel choiseControlPanel = new ChoiseControlPanel();

        public NovelMain()
        {
            InitializeComponent();
            choiseControlPanel.UpdateStory(); // ����� ������ UpdateStory
            this.Hide();
        }
    }
}
