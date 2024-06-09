using System.Runtime.InteropServices;

namespace FoldersSynchronizer
{
    interface IView
    {
        string LeftFolder();
        string RightFolder();


        void TryToSynchronize(List<string> message);
        event EventHandler<EventArgs> SynchronizeLeftToRightFolder;
        event EventHandler<EventArgs> SynchronizeRightToLeftFolder;
    }

    class Model
    {
        public List<string> SynchronizeRightToLeftFolder(string leftFolder, string rightFolder)
        {
            List<string> resultofSynchronize = [""];
            try
            {
                DirectoryInfo leftFolderInfo = new DirectoryInfo(leftFolder);
                DirectoryInfo rightFolderInfo = new DirectoryInfo(rightFolder);

                resultofSynchronize = synchronizationOfTwoFolders(leftFolderInfo, rightFolderInfo);
            }
            catch (Exception exception) 
            {
                MessageBox.Show("Не выбрана левая папка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultofSynchronize;


        }

        public List<string> SynchronizeLeftToRightFolder(string leftFolder, string rightFolder)
        {
            List<string> resultofSynchronize = [""];
            try
            {
                DirectoryInfo leftFolderInfo = new DirectoryInfo(leftFolder);
                DirectoryInfo rightFolderInfo = new DirectoryInfo(rightFolder);

                resultofSynchronize = synchronizationOfTwoFolders(rightFolderInfo, leftFolderInfo);
            }
            catch (Exception exception) 
            {
                MessageBox.Show("Не выбрана правая папка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultofSynchronize;
        }

        private List<string> synchronizationOfTwoFolders(DirectoryInfo mainFolderInfo, DirectoryInfo targetFolderInfo)
        {
            List<string> historyOfSynchronization = new List<string>();

            foreach (FileInfo fileInMainFolderInfo in mainFolderInfo.GetFiles())
            {
                FileInfo fileInTargetFolderInfo = new FileInfo(Path.Combine(targetFolderInfo.FullName, fileInMainFolderInfo.Name));

                if (fileInTargetFolderInfo.Exists)
                {
                    File.Copy(fileInMainFolderInfo.FullName, fileInTargetFolderInfo.FullName, true);
                    historyOfSynchronization.Add($"Файл {fileInMainFolderInfo.Name} изменен");
                }
                if (!fileInTargetFolderInfo.Exists)
                {
                    File.Copy(fileInMainFolderInfo.FullName, fileInTargetFolderInfo.FullName, true);
                    historyOfSynchronization.Add($"Файл {fileInMainFolderInfo.Name} добавлен");
                }
            }

            foreach (FileInfo fileInTargetFolderInfo in targetFolderInfo.GetFiles())
            {
                FileInfo fileInMainFolderInfo = new FileInfo(Path.Combine(mainFolderInfo.FullName, fileInTargetFolderInfo.Name));

                if (!fileInMainFolderInfo.Exists)
                {
                    fileInTargetFolderInfo.Delete();
                    historyOfSynchronization.Add($"Файл {fileInTargetFolderInfo.Name} удален");
                }
            }

            return historyOfSynchronization;
        }
    }

    class Presenter
    {
        private IView mainView;
        private Model model;

        public Presenter(IView inputView)
        {
            mainView = inputView;
            model = new Model();

            mainView.SynchronizeLeftToRightFolder += new EventHandler<EventArgs>(SynchronizeLeftToRight);
            mainView.SynchronizeRightToLeftFolder += new EventHandler<EventArgs>(SynchronizeRightToLeft);
        }


        private void SynchronizeLeftToRight(object sender, EventArgs inputEvent)
        {
            List<string> historyOfSynchronization = model.SynchronizeLeftToRightFolder(mainView.LeftFolder(), mainView.RightFolder());

            mainView.TryToSynchronize(historyOfSynchronization);
        }

        private void SynchronizeRightToLeft(object sender, EventArgs inputEvent)
        {
            List<string> historyOfSynchronization = model.SynchronizeRightToLeftFolder(mainView.LeftFolder(), mainView.RightFolder());

            mainView.TryToSynchronize(historyOfSynchronization);
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form());
        }
    }
}