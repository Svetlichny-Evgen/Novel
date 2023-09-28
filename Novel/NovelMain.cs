namespace Novel
{
    public partial class NovelMain : Form
    {
        private int storyStep = 1;

        public NovelMain()
        {
            InitializeComponent();
            UpdateStory();

            // ��������� ����������� ������� MouseEnter � MouseLeave
            Choice1.MouseEnter += Label_MouseEnter;
            Choice1.MouseLeave += Label_MouseLeave;
            Choice2.MouseEnter += Label_MouseEnter;
            Choice2.MouseLeave += Label_MouseLeave;
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            // �������� ����� ��� ���������
            Label label = sender as Label;
            if (label != null)
            {
                label.Font = new System.Drawing.Font(label.Font, System.Drawing.FontStyle.Bold);
                label.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            // ��������������� ����� ����� ����� �������
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
                    UpdateText("������. ��� ��� ��� ���� ��� ��������? " +
                        "\n���� ����� ������, � ��� ��� ����������. ���� ����� ������, � ����?",
                        "��", "���");
                    Choice1.Visible = true;
                    Choice2.Visible = true;
                    imageLayer.Image = Properties.Resources.TalkingEngineer;
                    break;
                case 2:
                    UpdateText("���... �� ���� ���, �� ��������� ������",
                        "������ ������", "������ ������");
                    Choice1.Visible = false;
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
                        "������??? ���, ��� ������, ����� ���� ������ ������� ����������! (������ ������)");
                    imageLayer.Image = Properties.Resources.SeriousEngineer;
                    break;
                case 5:
                    UpdateText("����������, �� ������������ ��� �� ������, �� ��� ��?",
                        "���, ������� � ��������, �� ��������! (������ ������)",
                        "��. ������� �� ����, �� ��� �, �� ������ (������ ������)");
                    imageLayer.Image = Properties.Resources.Engineer;
                    break;
                default:
                    break;
            }
        }

        //private void Choice1_Click(object sender, EventArgs e)
        //{
        //    // ��������� ������ 1
        //    if (storyStep == 1)
        //    {
        //        storyStep = 3; // ������� � ������� 3
        //        UpdateStory();
        //    }
        //    else if (storyStep == 3)
        //    {
        //        // ��������� ������ "������, � ��� ����� ������?"
        //        storyStep = 4; // ������� � ������� 4
        //        UpdateStory();
        //    }
        //    else if (storyStep == 4)
        //    {
        //        // ��������� ������ "����������... �� ���, ���������! (������ ������)"
        //        storyStep = 1; // ������ �������
        //        UpdateStory();
        //    }
        //    else if (storyStep == 5)
        //    {
        //        // ��������� ������ "���, ������� � ��������, �� ��������! (������ ������)"
        //        storyStep = 1; // ������ �������
        //        UpdateStory();
        //    }
        //}

        //private void Choice2_Click(object sender, EventArgs e)
        //{
        //    // ��������� ������ 2
        //    if (storyStep == 1)
        //    {
        //        storyStep = 2; // ������� � ������� 2
        //        UpdateStory();
        //    }
        //    else if (storyStep == 2)
        //    {
        //        storyStep = 1; // ������ �������
        //        UpdateStory();
        //    }
        //    else if (storyStep == 3)
        //    {
        //        // ��������� ������ "� ��� �� ������?"
        //        storyStep = 5; // ������� � ������� 5
        //        UpdateStory();
        //    }
        //    else if (storyStep == 4)
        //    {
        //        // ��������� ������ "����������... �� ���, ���������! (������ ������)"
        //        storyStep = 1; // ������ �������
        //        UpdateStory();
        //    }
        //    else if (storyStep == 5)
        //    {
        //        // ��������� ������ "��. ������� �� ����, �� ��� �, �� ������ (������ ������)"
        //        storyStep = 1; // ������ �������
        //        UpdateStory();
        //    }
        //}

        private void Choice_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;

            // ����������, ����� ����� ��� ������, � ����������� ��� ��������������� �������
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
