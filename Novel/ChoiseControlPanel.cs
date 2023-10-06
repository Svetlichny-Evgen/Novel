using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novel
{
    public partial class ChoiseControlPanel : UserControl
    {
        public ChoiseControlPanel()
        {
            InitializeComponent();

            // Добавляем обработчики событий MouseEnter и MouseLeave
            Choice1.MouseEnter += Label_MouseEnter;
            Choice1.MouseLeave += Label_MouseLeave;
            Choice2.MouseEnter += Label_MouseEnter;
            Choice2.MouseLeave += Label_MouseLeave;

            Event.Font = new Font("Century Ghotic", 26, FontStyle.Regular);
            Choice1.Font = new Font("Century Ghotic", 20, FontStyle.Regular);
            Choice2.Font = new Font("Century Ghotic", 20, FontStyle.Regular);
        }

        #region label Enter/Leave Event
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
        #endregion

        public void UpdateText(string eventText, string choice1Text, string choice2Text)
        {
            Event.Text = eventText;
            Choice1.Text = choice1Text;
            Choice2.Text = choice2Text;
        }
    }
}
