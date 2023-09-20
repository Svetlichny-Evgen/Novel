namespace Novel
{
    public partial class NovelMain : Form
    {
        private int storyStep = 0;
        public NovelMain()
        {
            InitializeComponent();
            UpdateText("������. ��� ��� ��� ���� ��� ��������? \n���� ����� ������, � ��� ��� ����������. ���� ����� ������, � ����?", "��", "���");

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

        private void Choice1_Click(object sender, EventArgs e)
        {
            if (storyStep == 0)
            {
                UpdateText("������, ����� ����� ���� � ���� ����.\n � ������������ ����� ����� ����� ���� ����� ������ ������. \n���� �������� ����, ��� ��� ��� ����� ���������, ��� ��� ����� �������� ��� ���������� ����� ����-�������.", "������, � ��� ����� ������?", "� ��� �� ������?");
                storyStep = 1;
            }
            else if (storyStep == 1)
            {
                UpdateText("� ���� ���� ������ ������� �� ������� �����-�������, ������ ��������. \n������ ���� ��������� � ������ �� �����, � �� �� ������� ������!", "����������... �� ���, ���������!", "������??? ���, ��� ������, ����� ���� ������ ������� ���������� (�����)");
                storyStep = 2;
            }
            else if (storyStep == 2)
            {
                UpdateText("����������... �� ���, ���������!", "", "");
                storyStep = 3;
            }
        }


        private void Choice2_Click(object sender, EventArgs e)
        {
            if (storyStep == 0)
            {
                UpdateText("���... �� ���� ���, �� ��������� ������ (�����)", "", "");
            }
            //else if (storyStep==2)
            //{
            //    UpdateText()
            //}
            else if (storyStep == 3)
            {
                UpdateText("������??? ���, ��� ������, ����� ���� ������ ������� ���������� (�����)", "", "");
            }
        }
    }
}