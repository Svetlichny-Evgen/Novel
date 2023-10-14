using Novel.Models;

namespace Novel
{
    public partial class NovelMain : Form
    {
        public static int currentStoryStep = 1;
        private static ChoiseControlPanel? choiseControlPanel = null;

        public NovelMain()
        {
            InitializeComponent();
            UpdateStory(); // ����� ������ UpdateStory
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
                    UpdateText("������. ��� ��� ��� ���� ��� ��������? " +
                        "\n���� ����� ������, � ��� ��� ����������. ���� ����� ������, � ����?",
                        "��", "���");

                    ChoiseControlPanel.lbChoice1.Visible = true;
                    ChoiseControlPanel.lbChoice2.Visible = true;
                    imageLayer.Image = Properties.Resources.TalkingEngineer;
                    break;

                case 2:
                    UpdateText("���... �� ���� ���, �� ��������� ������",
                        "������ ������", "������ ������");
                    ChoiseControlPanel.lbChoice1.Visible = false;
                    imageLayer.Image = Properties.Resources.AngryEngineer;
                    break;

                case 3:
                    UpdateText("������, ����� ����� ���� � ���� ����. � ������������ ����� ����� ����� ���� ����� ������ ������. ���� �������� ����, ��� ��� ��� ����� ���������, ��� ��� ��� ����� �������� ��� ���������� ����� ����-�������.",
                        "������, � ��� ����� ������?", "� ��� �� ������?");
                    imageLayer.Image = Properties.Resources.HappyEngineer;
                    break;

                case 4:
                    UpdateText("� ���� ���� ������ ������� �� ������� �����-�������, ������ ��������. ������ ���� ��������� � ������ �� �����, � �� �� ������� � ������!",
                        "����������... �� ���, ���������! (������ ������)",
                        "������??? ���, ��� ������, ����� ���� ������ ������� ����������!");
                    imageLayer.Image = Properties.Resources.SeriousEngineer;
                    break;

                case 5:
                    UpdateText("����������, �� ������������ ��� �� ������, �� ��� ��?",
                        "���, ������� � ��������, �� ��������! (������ ������)",
                        "��. ������� �� ����, �� ��� �, �� ������ (������ ������)");
                    imageLayer.Image = Properties.Resources.Engineer;
                    break;

                case 6:
                    UpdateText("�� ��� ������, ������. �� ����� ������� ����� � ������� � ���� ������ ��� �� ������!",
                        "�����... ������, ��� ���� � �������, ���� ���� �� ��������� ���� ����, ��� � �� ���������",
                        "(������ ���)");
                    imageLayer.Image = Properties.Resources.AngryEngineer;
                    break;
                
                case 7:
                    Fight form = new Fight();
                    form.Show();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
