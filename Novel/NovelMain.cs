namespace Novel
{
    public partial class NovelMain : Form
    {
        private int storyStep = 0;
        public NovelMain()
        {
            InitializeComponent();
            label1.Text = "�� ������������ � ����������� �����.";
            label2.Text = "����������� �����������.";
            label3.Text = "����������� �����.";
            label4.Hide();

            // ��������� ����������� ������� MouseEnter � MouseLeave
            label2.MouseEnter += Label_MouseEnter;
            label2.MouseLeave += Label_MouseLeave;
            label3.MouseEnter += Label_MouseEnter;
            label3.MouseLeave += Label_MouseLeave;
            label4.MouseEnter += Label_MouseEnter;
            label4.MouseLeave += Label_MouseLeave;
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

        private void label2_Click(object sender, EventArgs e)
        {
            if (storyStep == 0)
            {
                label1.Text = "�� �������� ����� � ������.";
                label2.Text = "���� �� �����.";
                label3.Text = "���� �� ��.";
                storyStep = 1;
            }
            else if (storyStep == 1)
            {
                label1.Text = "�� ����� ������ � �����������!";
                label2.Text = "������� ���������.";
                label3.Text = "�������� ��������� � ���������� ������������.";
                storyStep = 2;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (storyStep == 0)
            {
                label1.Text = "�� �������� �� ��������� � ��������� � ������� ���.";
                label2.Text = "����������� ��������� �����.";
                label3.Text = "���� ������ � ���.";
                storyStep = 3;
            }
            else if (storyStep == 1)
            {
                label1.Text = "�� ���������� � ���� � �� ������ ����� ������ �������.";
                label2.Text = "����������� ��������� �����.";
                label3.Text = "���������� ������� �� ����.";
                storyStep = 4;
            }
            else if (storyStep == 2)
            {
                label1.Text = "�� ���������� ���������, �� �������� ��������� �������!";
                label2.Text = "����������� ���������� � ��������.";
                label3.Text = "���������� ������.";
                storyStep = 5;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}