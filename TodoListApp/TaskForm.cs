using System;
using System.Windows.Forms;

namespace TodoListApp
{
    public partial class TaskForm : Form
    {
        public string TaskTitle { get; private set; }
        public string TaskDescription { get; private set; }

        public TaskForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(TaskForm_Load);
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TaskTitle = textBoxTitle.Text;
            TaskDescription = textBoxDescription.Text;

            if (!string.IsNullOrWhiteSpace(TaskTitle))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Task title cannot be empty.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
