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
            SynchronizeLeftToRightFolderButton = new Button();
            SynchronizeRightToLeftFolderButton = new Button();
            ChooseLeftFolderButton = new Button();
            ChooseRightFolderButton = new Button();
            ClearHistoryButton = new Button();
            historyListBox = new ListBox();
            LeftFolderFilesListBox = new ListBox();
            RightFolderFilesListBox = new ListBox();
            SuspendLayout();
            // 
            // SynchronizeLeftToRightFolderButton
            // 
            SynchronizeLeftToRightFolderButton.Location = new Point(299, 12);
            SynchronizeLeftToRightFolderButton.Name = "SynchronizeLeftToRightFolderButton";
            SynchronizeLeftToRightFolderButton.Size = new Size(100, 33);
            SynchronizeLeftToRightFolderButton.TabIndex = 2;
            SynchronizeLeftToRightFolderButton.Text = "<--";
            SynchronizeLeftToRightFolderButton.UseVisualStyleBackColor = true;
            SynchronizeLeftToRightFolderButton.Click += SynchronizeLeftToRightFolderButton_Click;
            // 
            // SynchronizeRightToLeftFolderButton
            // 
            SynchronizeRightToLeftFolderButton.Location = new Point(401, 12);
            SynchronizeRightToLeftFolderButton.Name = "SynchronizeRightToLeftFolderButton";
            SynchronizeRightToLeftFolderButton.Size = new Size(100, 33);
            SynchronizeRightToLeftFolderButton.TabIndex = 3;
            SynchronizeRightToLeftFolderButton.Text = "-->";
            SynchronizeRightToLeftFolderButton.UseVisualStyleBackColor = true;
            SynchronizeRightToLeftFolderButton.Click += SynchronizeRightToLeftFolderButton_Click;
            // 
            // ChooseLeftFolderButton
            // 
            ChooseLeftFolderButton.Location = new Point(12, 251);
            ChooseLeftFolderButton.Name = "ChooseLeftFolderButton";
            ChooseLeftFolderButton.Size = new Size(281, 40);
            ChooseLeftFolderButton.TabIndex = 5;
            ChooseLeftFolderButton.Text = "Выбрать левую папку";
            ChooseLeftFolderButton.UseVisualStyleBackColor = true;
            ChooseLeftFolderButton.Click += ChooseLeftFolderButton_Click;
            // 
            // ChooseRightFolderButton
            // 
            ChooseRightFolderButton.Location = new Point(507, 251);
            ChooseRightFolderButton.Name = "ChooseRightFolderButton";
            ChooseRightFolderButton.Size = new Size(281, 40);
            ChooseRightFolderButton.TabIndex = 6;
            ChooseRightFolderButton.Text = "Выбрать правую папку";
            ChooseRightFolderButton.UseVisualStyleBackColor = true;
            ChooseRightFolderButton.Click += ChooseRightFolderButton_Click;
            // 
            // ClearHistoryButton
            // 
            ClearHistoryButton.Location = new Point(299, 251);
            ClearHistoryButton.Name = "ClearHistoryButton";
            ClearHistoryButton.Size = new Size(202, 40);
            ClearHistoryButton.TabIndex = 7;
            ClearHistoryButton.Text = "Очистить историю";
            ClearHistoryButton.UseVisualStyleBackColor = true;
            ClearHistoryButton.Click += ClearHistoryButton_Click;
            // 
            // historyListBox
            // 
            historyListBox.FormattingEnabled = true;
            historyListBox.ImeMode = ImeMode.Off;
            historyListBox.ItemHeight = 15;
            historyListBox.Location = new Point(299, 51);
            historyListBox.Name = "historyListBox";
            historyListBox.Size = new Size(202, 199);
            historyListBox.TabIndex = 8;
            // 
            // LeftFolderFilesListBox
            // 
            LeftFolderFilesListBox.FormattingEnabled = true;
            LeftFolderFilesListBox.ItemHeight = 15;
            LeftFolderFilesListBox.Location = new Point(12, 15);
            LeftFolderFilesListBox.Name = "LeftFolderFilesListBox";
            LeftFolderFilesListBox.Size = new Size(281, 229);
            LeftFolderFilesListBox.TabIndex = 9;
            // 
            // RightFolderFilesListBox
            // 
            RightFolderFilesListBox.FormattingEnabled = true;
            RightFolderFilesListBox.ItemHeight = 15;
            RightFolderFilesListBox.Location = new Point(507, 12);
            RightFolderFilesListBox.Name = "RightFolderFilesListBox";
            RightFolderFilesListBox.Size = new Size(281, 229);
            RightFolderFilesListBox.TabIndex = 10;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 318);
            Controls.Add(RightFolderFilesListBox);
            Controls.Add(LeftFolderFilesListBox);
            Controls.Add(historyListBox);
            Controls.Add(ClearHistoryButton);
            Controls.Add(ChooseRightFolderButton);
            Controls.Add(ChooseLeftFolderButton);
            Controls.Add(SynchronizeRightToLeftFolderButton);
            Controls.Add(SynchronizeLeftToRightFolderButton);
            Name = "Form";
            Text = "Синхронизатор Папок";
            ResumeLayout(false);
        }

        #endregion
        private Button SynchronizeLeftToRightFolderButton;
        private Button SynchronizeRightToLeftFolderButton;
        private Button ChooseLeftFolderButton;
        private Button ChooseRightFolderButton;
        private Button ClearHistoryButton;
        private ListBox historyListBox;
        private ListBox LeftFolderFilesListBox;
        private ListBox RightFolderFilesListBox;
    }
}
