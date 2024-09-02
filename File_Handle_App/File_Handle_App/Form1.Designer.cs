namespace File_Handle_App
{
    partial class Form1
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
            txtOutput = new TextBox();
            btn_CreateAndWriteToFile = new Button();
            btn_ReadFromFile = new Button();
            btn_AppendToFile = new Button();
            btn_CountLinesInFile = new Button();
            btn_DeleteFile = new Button();
            btn_HandleFileExceptions = new Button();
            btn_StreamWriterAndStreamReader = new Button();
            btn_CopyFile = new Button();
            btn_FileInfoExample = new Button();
            btn_CheckIfFileExists = new Button();
            btn_OpenFileDialog = new Button();
            btn_CreateDirectory = new Button();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 12);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(834, 138);
            txtOutput.TabIndex = 0;
            // 
            // btn_CreateAndWriteToFile
            // 
            btn_CreateAndWriteToFile.Location = new Point(34, 237);
            btn_CreateAndWriteToFile.Name = "btn_CreateAndWriteToFile";
            btn_CreateAndWriteToFile.Size = new Size(218, 34);
            btn_CreateAndWriteToFile.TabIndex = 1;
            btn_CreateAndWriteToFile.Text = "Create And Write To File";
            btn_CreateAndWriteToFile.UseVisualStyleBackColor = true;
            btn_CreateAndWriteToFile.Click += btn_CreateAndWriteToFile_Click;
            // 
            // btn_ReadFromFile
            // 
            btn_ReadFromFile.Location = new Point(34, 302);
            btn_ReadFromFile.Name = "btn_ReadFromFile";
            btn_ReadFromFile.Size = new Size(218, 34);
            btn_ReadFromFile.TabIndex = 2;
            btn_ReadFromFile.Text = "Read From File";
            btn_ReadFromFile.UseVisualStyleBackColor = true;
            btn_ReadFromFile.Click += btn_ReadFromFile_Click;
            // 
            // btn_AppendToFile
            // 
            btn_AppendToFile.Location = new Point(34, 371);
            btn_AppendToFile.Name = "btn_AppendToFile";
            btn_AppendToFile.Size = new Size(218, 34);
            btn_AppendToFile.TabIndex = 3;
            btn_AppendToFile.Text = "Append To File";
            btn_AppendToFile.UseVisualStyleBackColor = true;
            btn_AppendToFile.Click += btn_AppendToFile_Click;
            // 
            // btn_CountLinesInFile
            // 
            btn_CountLinesInFile.Location = new Point(34, 448);
            btn_CountLinesInFile.Name = "btn_CountLinesInFile";
            btn_CountLinesInFile.Size = new Size(218, 34);
            btn_CountLinesInFile.TabIndex = 4;
            btn_CountLinesInFile.Text = "Count Lines In File";
            btn_CountLinesInFile.UseVisualStyleBackColor = true;
            btn_CountLinesInFile.Click += btn_CountLinesInFile_Click;
            // 
            // btn_DeleteFile
            // 
            btn_DeleteFile.Location = new Point(311, 173);
            btn_DeleteFile.Name = "btn_DeleteFile";
            btn_DeleteFile.Size = new Size(218, 34);
            btn_DeleteFile.TabIndex = 5;
            btn_DeleteFile.Text = "Delete File";
            btn_DeleteFile.UseVisualStyleBackColor = true;
            btn_DeleteFile.Click += btn_DeleteFile_Click;
            // 
            // btn_HandleFileExceptions
            // 
            btn_HandleFileExceptions.Location = new Point(311, 260);
            btn_HandleFileExceptions.Name = "btn_HandleFileExceptions";
            btn_HandleFileExceptions.Size = new Size(218, 34);
            btn_HandleFileExceptions.TabIndex = 6;
            btn_HandleFileExceptions.Text = "Handle File Exceptions";
            btn_HandleFileExceptions.UseVisualStyleBackColor = true;
            btn_HandleFileExceptions.Click += btn_HandleFileExceptions_Click;
            // 
            // btn_StreamWriterAndStreamReader
            // 
            btn_StreamWriterAndStreamReader.Location = new Point(311, 334);
            btn_StreamWriterAndStreamReader.Name = "btn_StreamWriterAndStreamReader";
            btn_StreamWriterAndStreamReader.Size = new Size(218, 71);
            btn_StreamWriterAndStreamReader.TabIndex = 7;
            btn_StreamWriterAndStreamReader.Text = "StreamWriter And StreamReader";
            btn_StreamWriterAndStreamReader.UseVisualStyleBackColor = true;
            btn_StreamWriterAndStreamReader.Click += btn_StreamWriterAndStreamReader_Click;
            // 
            // btn_CopyFile
            // 
            btn_CopyFile.Location = new Point(297, 448);
            btn_CopyFile.Name = "btn_CopyFile";
            btn_CopyFile.Size = new Size(218, 34);
            btn_CopyFile.TabIndex = 8;
            btn_CopyFile.Text = "Copy File";
            btn_CopyFile.UseVisualStyleBackColor = true;
            btn_CopyFile.Click += btn_CopyFile_Click;
            // 
            // btn_FileInfoExample
            // 
            btn_FileInfoExample.Location = new Point(581, 256);
            btn_FileInfoExample.Name = "btn_FileInfoExample";
            btn_FileInfoExample.Size = new Size(218, 38);
            btn_FileInfoExample.TabIndex = 9;
            btn_FileInfoExample.Text = "FileInfo Example";
            btn_FileInfoExample.UseVisualStyleBackColor = true;
            btn_FileInfoExample.Click += btn_FileInfoExample_Click;
            // 
            // btn_CheckIfFileExists
            // 
            btn_CheckIfFileExists.Location = new Point(581, 173);
            btn_CheckIfFileExists.Name = "btn_CheckIfFileExists";
            btn_CheckIfFileExists.Size = new Size(218, 34);
            btn_CheckIfFileExists.TabIndex = 10;
            btn_CheckIfFileExists.Text = "Check If File Exists";
            btn_CheckIfFileExists.UseVisualStyleBackColor = true;
            btn_CheckIfFileExists.Click += btn_CheckIfFileExists_Click;
            // 
            // btn_OpenFileDialog
            // 
            btn_OpenFileDialog.Location = new Point(581, 352);
            btn_OpenFileDialog.Name = "btn_OpenFileDialog";
            btn_OpenFileDialog.Size = new Size(218, 34);
            btn_OpenFileDialog.TabIndex = 11;
            btn_OpenFileDialog.Text = "Open File Dialog";
            btn_OpenFileDialog.UseVisualStyleBackColor = true;
            btn_OpenFileDialog.Click += btn_OpenFileDialog_Click;
            // 
            // btn_CreateDirectory
            // 
            btn_CreateDirectory.Location = new Point(34, 173);
            btn_CreateDirectory.Name = "btn_CreateDirectory";
            btn_CreateDirectory.Size = new Size(218, 34);
            btn_CreateDirectory.TabIndex = 12;
            btn_CreateDirectory.Text = "Create Directory";
            btn_CreateDirectory.UseVisualStyleBackColor = true;
            btn_CreateDirectory.Click += btn_CreateDirectory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 551);
            Controls.Add(btn_CreateDirectory);
            Controls.Add(btn_OpenFileDialog);
            Controls.Add(btn_CheckIfFileExists);
            Controls.Add(btn_FileInfoExample);
            Controls.Add(btn_CopyFile);
            Controls.Add(btn_StreamWriterAndStreamReader);
            Controls.Add(btn_HandleFileExceptions);
            Controls.Add(btn_DeleteFile);
            Controls.Add(btn_CountLinesInFile);
            Controls.Add(btn_AppendToFile);
            Controls.Add(btn_ReadFromFile);
            Controls.Add(btn_CreateAndWriteToFile);
            Controls.Add(txtOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput;
        private Button btn_CreateAndWriteToFile;
        private Button btn_ReadFromFile;
        private Button btn_AppendToFile;
        private Button btn_CountLinesInFile;
        private Button btn_DeleteFile;
        private Button btn_HandleFileExceptions;
        private Button btn_StreamWriterAndStreamReader;
        private Button btn_CopyFile;
        private Button btn_FileInfoExample;
        private Button btn_CheckIfFileExists;
        private Button btn_OpenFileDialog;
        private Button btn_CreateDirectory;
    }
}
