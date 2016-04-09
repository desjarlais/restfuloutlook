using RESTfulOutlook.Utils;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class ContentBytesForm : Form
    {
        public ContentBytesForm(byte[] byteArray)
        {
            InitializeComponent();
            tbContent.Text = AttachmentHelper.GetHexStringFromByteArray(byteArray);
        }
    }
}
