using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novel.Components
{
    public partial class HelthBar : UserControl
    {
        public HelthBar()
        {
            InitializeComponent();
        }
        #region Properties
        Color firstColor;
        Color lastColor;
        public Color FirstColor
        {
            get
            {
                return firstColor;
            }
            set
            {
                firstColor = value;
                SetColors();
            }
        }
        public Color LastColor
        {
            get
            {
                return lastColor;
            }
            set
            {
                lastColor = value;
                SetColors();
            }
        }
        
        bool reverse = false;
        public bool Revers
        {
            get
            {
                return reverse;
            }
            set
            {
                reverse = value;
                SetColors();
            }
        }

        public float Value
        {
            get
            {
                int index = reverse ? 1 : 0;
                var columns = healthArea.ColumnStyles;
                return columns[index].Width;
            }
            set
            {
                healthArea.ColumnStyles[0].Width = reverse ? 100 - value : value;
                healthArea.ColumnStyles[1].Width = reverse ? value: 100 - value;
            }
        }
        #endregion

        private void SetColors()
        {
            firstLine.BackColor = reverse ? lastColor : firstColor;
            lastLine.BackColor = reverse ? firstColor : lastColor;
        }


    }
}
