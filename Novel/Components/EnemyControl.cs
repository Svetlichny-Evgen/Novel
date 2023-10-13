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
    public partial class EnemyControl : UserControl
    {
        public EnemyControl()
        {
            InitializeComponent();
            // Добавляем обработчики событий MouseEnter и MouseLeave
            head.MouseEnter += Label_MouseEnter;
            head.MouseLeave += Label_MouseLeave;
            body.MouseEnter += Label_MouseEnter;
            body.MouseLeave += Label_MouseLeave;
            legs.MouseEnter += Label_MouseEnter;
            legs.MouseLeave += Label_MouseLeave;
        }

        #region label Enter/Leave Event
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            // Изменяем текст при наведении
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            // Восстанавливаем текст после ухода курсора
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.ForeColor = System.Drawing.Color.White;
            }
        }
        #endregion
    }
}
