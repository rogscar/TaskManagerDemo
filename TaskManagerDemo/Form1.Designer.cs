namespace TaskManagerDemo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            dateTimePickerDue = new DateTimePicker();
            comboBoxPriority = new ComboBox();
            buttonAddTask = new Button();
            dataGridViewTasks = new DataGridView();
            buttonEditTask = new Button();
            buttonDeleteTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 53);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 83);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Due Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 113);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Priority";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(120, 20);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(120, 50);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 23);
            textBoxDescription.TabIndex = 5;
            // 
            // dateTimePickerDue
            // 
            dateTimePickerDue.Location = new Point(120, 80);
            dateTimePickerDue.Name = "dateTimePickerDue";
            dateTimePickerDue.Size = new Size(200, 23);
            dateTimePickerDue.TabIndex = 6;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            comboBoxPriority.Location = new Point(120, 110);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(200, 23);
            comboBoxPriority.TabIndex = 7;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(120, 140);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(100, 30);
            buttonAddTask.TabIndex = 8;
            buttonAddTask.Text = "Add Task";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(20, 180);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.Size = new Size(500, 200);
            dataGridViewTasks.TabIndex = 9;
            // 
            // buttonEditTask
            // 
            buttonEditTask.Location = new Point(226, 140);
            buttonEditTask.Name = "buttonEditTask";
            buttonEditTask.Size = new Size(100, 30);
            buttonEditTask.TabIndex = 10;
            buttonEditTask.Text = "Edit Task";
            buttonEditTask.UseVisualStyleBackColor = true;
            buttonEditTask.Click += buttonEditTask_Click;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Location = new Point(340, 140);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(100, 30);
            buttonDeleteTask.TabIndex = 11;
            buttonDeleteTask.Text = "Delete Task";
            buttonDeleteTask.UseVisualStyleBackColor = true;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 411);
            Controls.Add(buttonDeleteTask);
            Controls.Add(buttonEditTask);
            Controls.Add(dataGridViewTasks);
            Controls.Add(buttonAddTask);
            Controls.Add(comboBoxPriority);
            Controls.Add(dateTimePickerDue);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Task Manager Demo";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private DateTimePicker dateTimePickerDue;
        private ComboBox comboBoxPriority;
        private Button buttonAddTask;
        private DataGridView dataGridViewTasks;
        private Button buttonEditTask;
        private Button buttonDeleteTask;
    }
}
