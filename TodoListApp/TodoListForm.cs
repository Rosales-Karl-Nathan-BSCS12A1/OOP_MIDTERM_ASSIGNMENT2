using System;
using System.Data;
using System.Windows.Forms;

namespace TodoListApp
{
    public partial class TodoListForm : Form
    {
        DataTable activeTasks = new DataTable();
        DataTable doneTasks = new DataTable();

        public TodoListForm()
        {
            InitializeComponent();
            InitializeDataTables();
            this.Load += new EventHandler(TodoListForm_Load);
        }

        private void InitializeDataTables()
        {
            if (activeTasks.Columns.Count == 0)
            {
                activeTasks.Columns.Add("Title");
                activeTasks.Columns.Add("Description");
            }

            if (doneTasks.Columns.Count == 0)
            {
                doneTasks.Columns.Add("Title");
                doneTasks.Columns.Add("Description");
                doneTasks.Columns.Add("Timestamp");
            }
        }

        private void TodoListForm_Load(object sender, EventArgs e)
        {
            dataGridViewActive.DataSource = activeTasks;
            dataGridViewDone.DataSource = doneTasks;
            dataGridViewDone.ReadOnly = true;
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            using (TaskForm taskForm = new TaskForm())
            {
                if (taskForm.ShowDialog() == DialogResult.OK)
                {
                    activeTasks.Rows.Add(taskForm.TaskTitle, taskForm.TaskDescription);
                }
            }
        }

        private void dataGridViewActive_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < activeTasks.Rows.Count)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to mark this task as Done?", "Mark Task as Done", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string title = activeTasks.Rows[e.RowIndex]["Title"].ToString();
                    string description = activeTasks.Rows[e.RowIndex]["Description"].ToString();
                    string timestamp = DateTime.Now.ToString();

                    doneTasks.Rows.Add(title, description, timestamp);
                    activeTasks.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dataGridViewActive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
