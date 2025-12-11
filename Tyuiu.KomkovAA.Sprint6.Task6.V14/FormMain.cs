using Tyuiu.KomkovAA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.KomkovAA.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBoxIn.Text = File.ReadAllText(openFilePath);
            buttonRes.Enabled = true;
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            textBoxRes.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
