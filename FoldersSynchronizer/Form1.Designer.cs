namespace FoldersSynchronizer
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LeftFolderFilesTreeView = new TreeView();
            RightFolderFilesTreeView = new TreeView();
            SynchronizeLeftToRightFolderButton = new Button();
            SynchronizeRightToLeftFolderButton = new Button();
            HistoryTreeView = new TreeView();
            ChooseLeftFolderButton = new Button();
            ChooseRightFolderButton = new Button();
            ClearHistoryButton = new Button();
            SuspendLayout();
            // 
            // LeftFolderFilesTreeView
            // 
            LeftFolderFilesTreeView.Location = new Point(12, 12);
            LeftFolderFilesTreeView.Name = "LeftFolderFilesTreeView";
            LeftFolderFilesTreeView.Size = new Size(281, 233);
            LeftFolderFilesTreeView.TabIndex = 0;
            // 
            // RightFolderFilesTreeView
            // 
            RightFolderFilesTreeView.Location = new Point(507, 12);
            RightFolderFilesTreeView.Name = "RightFolderFilesTreeView";
            RightFolderFilesTreeView.Size = new Size(281, 233);
            RightFolderFilesTreeView.TabIndex = 1;
            // 
            // SynchronizeLeftToRightFolderButton
            // 
            SynchronizeLeftToRightFolderButton.Location = new Point(299, 12);
            SynchronizeLeftToRightFolderButton.Name = "SynchronizeLeftToRightFolderButton";
            SynchronizeLeftToRightFolderButton.Size = new Size(100, 33);
            SynchronizeLeftToRightFolderButton.TabIndex = 2;
            SynchronizeLeftToRightFolderButton.Text = "<--";
            SynchronizeLeftToRightFolderButton.UseVisualStyleBackColor = true;
            // 
            // SynchronizeRightToLeftFolderButton
            // 
            SynchronizeRightToLeftFolderButton.Location = new Point(401, 12);
            SynchronizeRightToLeftFolderButton.Name = "SynchronizeRightToLeftFolderButton";
            SynchronizeRightToLeftFolderButton.Size = new Size(100, 33);
            SynchronizeRightToLeftFolderButton.TabIndex = 3;
            SynchronizeRightToLeftFolderButton.Text = "-->";
            SynchronizeRightToLeftFolderButton.UseVisualStyleBackColor = true;
            // 
            // HistoryTreeView
            // 
            HistoryTreeView.Location = new Point(299, 56);
            HistoryTreeView.Name = "HistoryTreeView";
            HistoryTreeView.Size = new Size(202, 189);
            HistoryTreeView.TabIndex = 4;
            // 
            // ChooseLeftFolderButton
            // 
            ChooseLeftFolderButton.Location = new Point(12, 251);
            ChooseLeftFolderButton.Name = "ChooseLeftFolderButton";
            ChooseLeftFolderButton.Size = new Size(281, 40);
            ChooseLeftFolderButton.TabIndex = 5;
            ChooseLeftFolderButton.Text = "Выбрать левую папку";
            ChooseLeftFolderButton.UseVisualStyleBackColor = true;
            // 
            // ChooseRightFolderButton
            // 
            ChooseRightFolderButton.Location = new Point(507, 251);
            ChooseRightFolderButton.Name = "ChooseRightFolderButton";
            ChooseRightFolderButton.Size = new Size(281, 40);
            ChooseRightFolderButton.TabIndex = 6;
            ChooseRightFolderButton.Text = "Выбрать правую папку";
            ChooseRightFolderButton.UseVisualStyleBackColor = true;
            // 
            // ClearHistoryButton
            // 
            ClearHistoryButton.Location = new Point(299, 251);
            ClearHistoryButton.Name = "ClearHistoryButton";
            ClearHistoryButton.Size = new Size(202, 40);
            ClearHistoryButton.TabIndex = 7;
            ClearHistoryButton.Text = "Очистить историю";
            ClearHistoryButton.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 318);
            Controls.Add(ClearHistoryButton);
            Controls.Add(ChooseRightFolderButton);
            Controls.Add(ChooseLeftFolderButton);
            Controls.Add(HistoryTreeView);
            Controls.Add(SynchronizeRightToLeftFolderButton);
            Controls.Add(SynchronizeLeftToRightFolderButton);
            Controls.Add(RightFolderFilesTreeView);
            Controls.Add(LeftFolderFilesTreeView);
            Name = "Form";
            Text = "Синхронизатор Папок";
            ResumeLayout(false);
        }

        #endregion

        private TreeView LeftFolderFilesTreeView;
        private TreeView RightFolderFilesTreeView;
        private Button SynchronizeLeftToRightFolderButton;
        private Button SynchronizeRightToLeftFolderButton;
        private TreeView HistoryTreeView;
        private Button ChooseLeftFolderButton;
        private Button ChooseRightFolderButton;
        private Button ClearHistoryButton;
    }
}
