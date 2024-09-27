﻿namespace TodoListApp
{
    partial class TodoListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewActive = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDone = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDone)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActive
            // 
            this.dataGridViewActive.AllowUserToAddRows = false;
            this.dataGridViewActive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActive.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActive.Location = new System.Drawing.Point(15, 90);
            this.dataGridViewActive.Name = "dataGridViewActive";
            this.dataGridViewActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActive.Size = new System.Drawing.Size(435, 150);
            this.dataGridViewActive.TabIndex = 0;
            this.dataGridViewActive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActive_CellContentClick);
            this.dataGridViewActive.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActive_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active Task";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewDone
            // 
            this.dataGridViewDone.AllowUserToAddRows = false;
            this.dataGridViewDone.AllowUserToDeleteRows = false;
            this.dataGridViewDone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDone.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDone.Location = new System.Drawing.Point(12, 276);
            this.dataGridViewDone.Name = "dataGridViewDone";
            this.dataGridViewDone.ReadOnly = true;
            this.dataGridViewDone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDone.Size = new System.Drawing.Size(438, 210);
            this.dataGridViewDone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Completed Task";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(375, 64);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTask.TabIndex = 4;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "TODOLIST";
            // 
            // TodoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewActive);
            this.Name = "TodoListForm";
            this.Text = "TODO List Application";
            this.Load += new System.EventHandler(this.TodoListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Label label3;
    }
}
