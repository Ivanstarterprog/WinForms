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
            List<string> resultOfSynchronization = new List<string>();

            foreach (FileInfo folderFile in mainFolderInfo.GetFiles())
            {
                FileInfo targetFileInTargetFolder = new FileInfo(Path.Combine(targetFolderInfo.FullName, folderFile.Name));

                if (targetFileInTargetFolder.Exists)
                {
                    File.Copy(folderFile.FullName, targetFileInTargetFolder.FullName, true);
                    resultOfSynchronization.Add($"Файл {folderFile.Name} изменен");
                }
                if (!targetFileInTargetFolder.Exists)
                {
                    File.Copy(folderFile.FullName, targetFileInTargetFolder.FullName, true);
                    resultOfSynchronization.Add($"Файл {folderFile.Name} добавлен");
                }
            }

            foreach (FileInfo folderFile in targetFolderInfo.GetFiles())
            {
                FileInfo fileInMainDirectory = new FileInfo(Path.Combine(mainFolderInfo.FullName, folderFile.Name));

                if (!fileInMainDirectory.Exists)
                {
                    folderFile.Delete();
                    resultOfSynchronization.Add($"Файл {folderFile.Name} удален");
                }
            }

            return resultOfSynchronization;
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
            List<string> resultOfSynchronization = model.SynchronizeLeftToRightFolder(mainView.LeftFolder(), mainView.RightFolder());

            mainView.TryToSynchronize(resultOfSynchronization);
        }

        private void SynchronizeRightToLeft(object sender, EventArgs inputEvent)
        {
            List<string> resultOfSynchronization = model.SynchronizeRightToLeftFolder(mainView.LeftFolder(), mainView.RightFolder());

            mainView.TryToSynchronize(resultOfSynchronization);
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