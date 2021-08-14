using System.Windows.Forms;
using System.IO;

namespace people_search
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void InformationForm_Load(object sender, System.EventArgs e)
        {
            var info = new FileInfo("..\\..\\..\\people_search\\database.json");
            if (info.Exists)
            {
                label_version.Text += info.LastWriteTime;
            }
            else label_version.Text = "Database wasn't uploaded!";
        }

    }
}
