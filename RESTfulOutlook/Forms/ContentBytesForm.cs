using RESTfulOutlook.Utils;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class ContentBytesForm : Form
    {
        public ContentBytesForm(byte[] byteArray)
        {
            InitializeComponent();
            Cursor = Cursors.WaitCursor;
            tbContent.Text = AttachmentHelper.GetHexStringFromByteArray(byteArray);
            Cursor = Cursors.Default;
        }
    }
}
