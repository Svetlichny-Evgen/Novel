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
            UpdateStory(); // ����� ������ UpdateStory
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
                // � ��������� ���-�� ����� �� ���, � ��� ������ �������������� �������� ��������� ����������� ���������
                head = Properties.Resources.imgonline_com_ua_Mirror_dZKJDvksmS_removebg_preview,
                tail = Properties.Resources.imgonline_com_ua_Mirror_weAmx4nygAWp_removebg_preview,
                legs = Properties.Resources.imgonline_com_ua_Mirror_gU5vpXsSl673NnZp_removebg_preview
            };

            enemyCtrl = new EnemyControl(enemy);
            enemyCtrl.Location = new Point(565, 100);


            PersonModel player = new PersonModel()
            {
                // � ��������� ���-�� ����� �� ���, � ��� ������ �������������� �������� ��������� ����������� ���������
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
