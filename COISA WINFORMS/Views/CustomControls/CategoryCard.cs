using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COISA_WINFORMS.Views.CustomControls
{
    public partial class CategoryCard : UserControl
    {
        public Label strTitle { get; set; }
        public Label strDesc { get; set; }
        public IconButton  btnEdit { get; set; }
        public IconButton btnRemove { get; set; }

        public CategoryCard()
        {
            InitializeComponent();
            strTitle = labelTitle;
            strDesc = labelDescriotion;
            btnEdit = iconButtonEdit;
            btnRemove = iconButtonRemove;

        }

    }
}
