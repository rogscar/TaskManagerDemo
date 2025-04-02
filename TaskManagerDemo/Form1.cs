using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManagerDemo
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        public Form1()
        {
            InitializeComponent();
            SetupGridColumns();
        }

        private void SetupGridColumns()
        {
            dataGridViewTasks.Columns.Add("Name", "Task Name");
            dataGridViewTasks.Columns.Add("Description", "Description");
            dataGridViewTasks.Columns.Add("DueDate", "Due Date");
            dataGridViewTasks.Columns.Add("Priority", "Priority");
            dataGridViewTasks.Columns.Add("Completed", "Completed");
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter a task name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TaskItem newTask = new TaskItem
            {
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
                DueDate = dateTimePickerDue.Value,
                Priority = comboBoxPriority.SelectedItem?.ToString() ?? "Medium",
                IsCompleted = false
            };
            tasks.Add(newTask);
            RefreshGrid();
            ClearInputs();
        }
        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                int index = dataGridViewTasks.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show($"Delete task '{tasks[index].Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tasks.RemoveAt(index);
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RefreshGrid()
        {
            dataGridViewTasks.Rows.Clear();
            foreach (var task in tasks)
            {
                dataGridViewTasks.Rows.Add(task.Name, task.Description, task.DueDate.ToShortDateString(), task.Priority, task.IsCompleted);
            }
        }

        private void ClearInputs()
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
            dateTimePickerDue.Value = DateTime.Now;
            comboBoxPriority.SelectedIndex = -1;
        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                int index = dataGridViewTasks.SelectedRows[0].Index;
                TaskItem task = tasks[index];
                textBoxName.Text = task.Name;
                textBoxDescription.Text = task.Description;
                dateTimePickerDue.Value = task.DueDate;
                comboBoxPriority.SelectedItem = task.Priority;
                tasks.RemoveAt(index); // Remove old version, re-add via Add Task
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class TaskItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public bool IsCompleted { get; set; }
    }
}