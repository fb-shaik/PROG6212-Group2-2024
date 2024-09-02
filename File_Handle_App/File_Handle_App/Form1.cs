namespace File_Handle_App
{
    public partial class Form1 : Form
    {
        private string directoryPath = "NewDirectory";
        public Form1()
        {
            InitializeComponent();
        }
        // Helper method to display the result in the text box
        private void DisplayResult(string message)
        {
            txtOutput.Text = message;
        }

        private void btn_CreateDirectory_Click(object sender, EventArgs e)
        {
            string directoryPath = "NewDirectory";

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                DisplayResult($"Directory '{directoryPath}' created successfully.");
            }
            else
            {
                DisplayResult($"Directory '{directoryPath}' already exists.");
            }
        }
        private void btn_CreateAndWriteToFile_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(directoryPath, "log.txt");
            string content = $"File created on: {DateTime.Now}";

            File.WriteAllText(filePath, content);
            DisplayResult($"Exercise 1: Created and wrote to '{filePath}'");
        }

        private void btn_ReadFromFile_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(directoryPath, "log.txt");
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                DisplayResult($"Exercise 2: Content of '{filePath}':\n{content}");
            }
            else
            {
                DisplayResult($"Exercise 2: '{filePath}' does not exist.");
            }
        }

        private void btn_AppendToFile_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(directoryPath, "log.txt");
            string content = $"\nFile updated on: {DateTime.Now}";

            File.AppendAllText(filePath, content);
            DisplayResult($"Exercise 3: Appended to '{filePath}'");
        }

        private void btn_CountLinesInFile_Click(object sender, EventArgs e)
        {
            string path = "log.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                DisplayResult($"Exercise 4: Number of lines in log.txt: {lines.Length}");
            }
            else
            {
                DisplayResult("Exercise 4: log.txt does not exist.");
            }
        }

        private void btn_DeleteFile_Click(object sender, EventArgs e)
        {
            string path = "log.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                DisplayResult("Exercise 5: log.txt has been deleted.");
            }
            else
            {
                DisplayResult("Exercise 5: log.txt does not exist.");
            }
        }

        private void btn_HandleFileExceptions_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "nonexistent.txt";
                string content = File.ReadAllText(path);
                DisplayResult(content);
            }
            catch (FileNotFoundException ex)
            {
                DisplayResult($"Exercise 6: Exception caught: {ex.Message}");
            }
        }

        private void btn_StreamWriterAndStreamReader_Click(object sender, EventArgs e)
        {
            string path = "shopping_list.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Apples");
                writer.WriteLine("Bread");
                writer.WriteLine("Milk");
                writer.WriteLine("Eggs");
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string result = "Exercise 7: Reading shopping list:\n";
                while ((line = reader.ReadLine()) != null)
                {
                    result += line + "\n";
                }
                DisplayResult(result);
            }
        }

        private void btn_CopyFile_Click(object sender, EventArgs e)
        {
            string sourcePath = "shopping_list.txt";
            string destPath = "shopping_list_backup.txt";

            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destPath, overwrite: true);
                DisplayResult("Exercise 8: Copied shopping_list.txt to shopping_list_backup.txt");
            }
            else
            {
                DisplayResult("Exercise 8: shopping_list.txt does not exist.");
            }
        }

        private void btn_FileInfoExample_Click(object sender, EventArgs e)
        {
            string path = "shopping_list_backup.txt";
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                DisplayResult($"Exercise 9: File size of shopping_list_backup.txt: {fileInfo.Length} bytes");
            }
            else
            {
                DisplayResult("Exercise 9: shopping_list_backup.txt does not exist.");
            }
        }

        private void btn_CheckIfFileExists_Click(object sender, EventArgs e)
        {
            string path = "shopping_list.txt";
            if (File.Exists(path))
            {
                DisplayResult("Exercise 10: File exists.");
            }
            else
            {
                DisplayResult("Exercise 10: File does not exist.");
            }
        }

        // Method for opening the file dialog with file type restrictions
        private void btn_OpenFileDialog_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the filter to limit file types to docx, pdf, and txt files
                openFileDialog.Filter = "Word Documents (*.docx)|*.docx|PDF files (*.pdf)|*.pdf|Text files (*.txt)|*.txt";
                openFileDialog.Title = "Select a File";

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string selectedFilePath = openFileDialog.FileName;

                    // Check if the file is of the correct type
                    string extension = Path.GetExtension(selectedFilePath).ToLower();
                    if (extension == ".docx" || extension == ".pdf" || extension == ".txt")
                    {
                        // Provide feedback in the text box
                        DisplayResult($"File uploaded successfully: {selectedFilePath}");
                    }
                    else
                    {
                        DisplayResult("Error: Invalid file type selected.");
                    }
                }
                else
                {
                    // If the user cancels the file selection
                    DisplayResult("File selection was canceled.");
                }
            }


        }
    }
}