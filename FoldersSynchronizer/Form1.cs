namespace FoldersSynchronizer
{
    public partial class Form : System.Windows.Forms.Form, IView
    {
        public Form()
        {
            InitializeComponent();
            Presenter programPresenter = new Presenter(this);
        }

        string leftFolderPath = "";
        string rightFolderPath = "";
        public event EventHandler<EventArgs> SynchronizeLeftToRightFolder;
        public event EventHandler<EventArgs> SynchronizeRightToLeftFolder;

        string IView.LeftFolder()
        {
            return leftFolderPath;
        }

        string IView.RightFolder()
        {
            return rightFolderPath;
        }

        void IView.TryToSynchronize(List<string> historyOfSynchronization)
        {
            historyListBox.Items.Clear();

            foreach (string historyStamp in historyOfSynchronization)
            {
                historyListBox.Items.Add(historyStamp);
            }

            ShowFoldersFiles();
        }

        private void SynchronizeLeftToRightFolderButton_Click(object sender, EventArgs inputEvent)
        {
            SynchronizeLeftToRightFolder(sender, inputEvent);
        }


        private string SelectFolderFromDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }

            return null;
        }

        private void ShowFoldersFiles()
        {
            LeftFolderFilesListBox.Items.Clear();
            RightFolderFilesListBox.Items.Clear();

            if (leftFolderPath != "")
            {
                DirectoryInfo leftFolderInfo = new DirectoryInfo(leftFolderPath);
                foreach (FileInfo folderFile in leftFolderInfo.GetFiles())
                {
                    LeftFolderFilesListBox.Items.Add(folderFile.Name);
                }
            }

            if (rightFolderPath != "")
            {
                DirectoryInfo rightFolderInfo = new DirectoryInfo(rightFolderPath);
                foreach (FileInfo folderFile in rightFolderInfo.GetFiles())
                {
                    RightFolderFilesListBox.Items.Add(folderFile.Name);
                }
            }
        }

        private void ChooseLeftFolderButton_Click(object sender, EventArgs inputEvent)
        {
            string folderPath = SelectFolderFromDialog();

            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Выбор папки прерван", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            leftFolderPath = folderPath;
            ShowFoldersFiles();
        }

        private void SynchronizeRightToLeftFolderButton_Click(object sender, EventArgs inputEvent)
        {
            SynchronizeRightToLeftFolder(sender, inputEvent);
        }

        private void ChooseRightFolderButton_Click(object sender, EventArgs inputEvent)
        {
            string folderPath = SelectFolderFromDialog();

            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Выбор папки прерван", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rightFolderPath = folderPath;
            ShowFoldersFiles();
        }

        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();
        }
    }
}
