using System.Collections.Generic;
using Microsoft.Graph;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class ItemBodyForm : Form
    {
        public ItemBodyForm(string id, List<ItemBody> body)
        {
            InitializeComponent();

            if (body[0].ContentType == BodyType.Text)
            {
                toolstripcontenttype.Text = "Text";
            }
            else
            {
                toolstripcontenttype.Text = "HTML";
            }

            txtBody.Text = body[0].Content;
        }
    }
}
