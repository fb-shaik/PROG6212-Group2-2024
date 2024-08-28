namespace Personal_Task_Manager_G2_LINQ_FileHandling_
{
    partial class Personal_Task_Manager
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
            txtTaskInput = new TextBox();
            txtSearch = new TextBox();
            btnAddTask = new Button();
            btnShowAllTasks = new Button();
            btnShowPending = new Button();
            btnSearch = new Button();
            listBoxTasks = new ListBox();
            btnMarkCompleted = new Button();
            SuspendLayout();
            // 
            // txtTaskInput
            // 
            txtTaskInput.Location = new Point(28, 32);
            txtTaskInput.Name = "txtTaskInput";
            txtTaskInput.Size = new Size(369, 31);
            txtTaskInput.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(427, 91);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(427, 32);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(181, 34);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnShowAllTasks
            // 
            btnShowAllTasks.Location = new Point(28, 91);
            btnShowAllTasks.Name = "btnShowAllTasks";
            btnShowAllTasks.Size = new Size(182, 34);
            btnShowAllTasks.TabIndex = 3;
            btnShowAllTasks.Text = "Show All Tasks";
            btnShowAllTasks.UseVisualStyleBackColor = true;
            btnShowAllTasks.Click += btnShowAllTasks_Click;
            // 
            // btnShowPending
            // 
            btnShowPending.Location = new Point(238, 91);
            btnShowPending.Name = "btnShowPending";
            btnShowPending.Size = new Size(159, 34);
            btnShowPending.TabIndex = 4;
            btnShowPending.Text = "Show Pending";
            btnShowPending.UseVisualStyleBackColor = true;
            btnShowPending.Click += btnShowPending_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(704, 88);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(135, 34);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 25;
            listBoxTasks.Location = new Point(43, 176);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(871, 204);
            listBoxTasks.TabIndex = 6;
            // 
            // btnMarkCompleted
            // 
            btnMarkCompleted.FlatAppearance.BorderSize = 6;
            btnMarkCompleted.Location = new Point(28, 404);
            btnMarkCompleted.Name = "btnMarkCompleted";
            btnMarkCompleted.Size = new Size(290, 34);
            btnMarkCompleted.TabIndex = 7;
            btnMarkCompleted.Text = "Mark Task As Completed";
            btnMarkCompleted.UseVisualStyleBackColor = true;
            btnMarkCompleted.Click += btnMarkCompleted_Click;
            // 
            // Personal_Task_Manager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 450);
            Controls.Add(btnMarkCompleted);
            Controls.Add(listBoxTasks);
            Controls.Add(btnSearch);
            Controls.Add(btnShowPending);
            Controls.Add(btnShowAllTasks);
            Controls.Add(btnAddTask);
            Controls.Add(txtSearch);
            Controls.Add(txtTaskInput);
            Name = "Personal_Task_Manager";
            Text = "Personal Task Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTaskInput;
        private TextBox txtSearch;
        private Button btnAddTask;
        private Button btnShowAllTasks;
        private Button btnShowPending;
        private Button btnSearch;
        private ListBox listBoxTasks;
        private Button btnMarkCompleted;
    }
}
