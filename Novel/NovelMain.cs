namespace Novel
{
    public partial class NovelMain : Form
    {
        private int storyStep = 0;
        public NovelMain()
        {
            InitializeComponent();
            label1.Text = "Ты просыпаешься в неизвестном месте.";
            label2.Text = "Попробовать осмотреться.";
            label3.Text = "Попробовать выйти.";
            label4.Hide();

            // Добавляем обработчики событий MouseEnter и MouseLeave
            label2.MouseEnter += Label_MouseEnter;
            label2.MouseLeave += Label_MouseLeave;
            label3.MouseEnter += Label_MouseEnter;
            label3.MouseLeave += Label_MouseLeave;
            label4.MouseEnter += Label_MouseEnter;
            label4.MouseLeave += Label_MouseLeave;
        }

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

        private void label2_Click(object sender, EventArgs e)
        {
            if (storyStep == 0)
            {
                label1.Text = "Ты находишь карту и компас.";
                label2.Text = "Идти на север.";
                label3.Text = "Идти на юг.";
                storyStep = 1;
            }
            else if (storyStep == 1)
            {
                label1.Text = "Ты нашёл сундук с сокровищами!";
                label2.Text = "Поднять сокровища.";
                label3.Text = "Оставить сокровища и продолжить исследование.";
                storyStep = 2;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (storyStep == 0)
            {
                label1.Text = "Ты выходишь из помещения и попадаешь в опасный лес.";
                label2.Text = "Попробовать вернуться назад.";
                label3.Text = "Идти глубже в лес.";
                storyStep = 3;
            }
            else if (storyStep == 1)
            {
                label1.Text = "Ты заблудился в лесу и не можешь найти дорогу обратно.";
                label2.Text = "Попробовать вернуться назад.";
                label3.Text = "Продолжать бродить по лесу.";
                storyStep = 4;
            }
            else if (storyStep == 2)
            {
                label1.Text = "Ты поднимаешь сокровища, но внезапно сработала ловушка!";
                label2.Text = "Попробовать справиться с ловушкой.";
                label3.Text = "Попытаться бежать.";
                storyStep = 5;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}