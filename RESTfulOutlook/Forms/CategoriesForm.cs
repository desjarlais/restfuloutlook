using System.Collections.Generic;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm(List<string> list)
        {
            InitializeComponent();
            foreach (var item in list)
            {
                lstCategories.Items.Add(item);
            }
        }
    }
}
