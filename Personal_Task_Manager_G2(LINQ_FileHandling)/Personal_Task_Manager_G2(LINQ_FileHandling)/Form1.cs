using System.Diagnostics;

namespace Personal_Task_Manager_G2_LINQ_FileHandling_
{
    public partial class Personal_Task_Manager : Form
    {
        //List that will store the tasks (List<T>)
        private List<Task> taskList = new List<Task>();
        //File Path for storing the task details (tasks.txt)
        private string filePath = "tasks.txt";

        public Personal_Task_Manager()
        {
            InitializeComponent();
        }

        //Key methods that are needed:
        //1. LoadFilesFromFile(): Loads tasks from a text file when the app starts
        private void LoadTasksFromFile()
        { //Check if the file exists;
            if (File.Exists(filePath))
            {
                //Read all the lines in the file;
                var lines = File.ReadAllLines(filePath);
                //Parse each line to create task obj
                foreach (var line in lines)
                {
                    //Split the line into 2 parts (description & status)
                    var parts = line.Split('|');

                    //Ensure line formatted correctly (2 parts)
                    if (parts.Length == 2)
                    {
                        //Create a new task object & add it to the task list
                        taskList.Add(new Task
                        {
                            Description = parts[0],
                            IsCompleted = bool.Parse(parts[1])
                        });
                    }
                }
            }
        }
        //2. WriteTaskToFile(): Appends a new task to the file
        private void WriteTaskToFile(Task task)
        {
            //Open the file in append mode to add in a new task
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                //write the task description & completion status to the text file
                writer.WriteLine($"{task.Description}|{task.IsCompleted}");
            }

        }
        //3. UpdateTasksFile(): Rewrites the entire file when a task status changes
        private void UpdateTasksFile()
        {
            File.WriteAllLines(filePath, taskList.Select(t => $"{t.Description}|{t.IsCompleted}"));
        }

        //4. DisplayTasks(): Show tasks in the ListBox, including their status
        private void DisplayTasks(List<Task> tasks)
        {
            //Clear the current listbox content
            listBoxTasks.Items.Clear();
            //Add each task to the listBox with it status
            foreach (var task in tasks)
            {//Determine the status (Completed / Pending)
                string status = task.IsCompleted ? "[Completed] " : "[Pending] ";
                //Add the task with its status
                listBoxTasks.Items.Add(status + task.Description);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            //get the task description from the input textbox
            string taskDescription = txtTaskInput.Text.Trim();
            //ensure the task description is not empty
            if (!string.IsNullOrEmpty(taskDescription))
            {//check to see is task with duplicated description already exists
                if (taskList.Any(t => t.Description.Equals(taskDescription, StringComparison.OrdinalIgnoreCase)))
                {   //show msg to user if the task description exists
                    MessageBox.Show("A task with that description already exists. Please enter a different description");
                }
                else
                {
                    //create a new task object & mark as pending
                    Task newTask = new Task { Description = taskDescription, IsCompleted = false };
                    //add task to listBox
                    taskList.Add(newTask);
                    //write the task to the text file
                    WriteTaskToFile(newTask);
                    //clear the input text box for new entries
                    txtTaskInput.Clear();
                    //update the ListBox display with the latest list of tasks
                    DisplayTasks(taskList);
                }
            }


        }

        private void btnShowAllTasks_Click(object sender, EventArgs e)
        {
            //Display all the tasks in the ListBox
            DisplayTasks(taskList);
        }

        private void btnShowPending_Click(object sender, EventArgs e)
        {
            //Filter the tasks based on status - Pending 
            var pendingTasks = taskList.Where(t => !t.IsCompleted).ToList();

            DisplayTasks(pendingTasks);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //filter the results based on the keyword in the search text box
            //makes sure the keyword is set to be case-insensitive
            string search = txtSearch.Text.Trim().ToLower();

            //filter the tasks based on description
            var filteredTasks = taskList.Where(t => t.Description.ToLower().Contains(search)).ToList();
            //Display the filtered results in the listBox
            DisplayTasks(filteredTasks);
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            //check if the task is selected in the list box 
            if (listBoxTasks.SelectedIndex != -1) 
            { 
                //get index of the selected task
                int index = listBoxTasks.SelectedIndex;
                //mark the task as completed
                taskList[index].IsCompleted = true;
                //Update the task files to reflect the change in status
                UpdateTasksFile();
                //Refresh the display on the listbox
                DisplayTasks(taskList);
            }
        }
    }
}
