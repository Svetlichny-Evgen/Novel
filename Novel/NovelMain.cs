namespace Novel
{
    public partial class NovelMain : Form
    {
        public NovelMain()
        {
            InitializeComponent();
            label1.Text = "Start";
            label3.Text = "Exit";

        }

        private void NovelMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}