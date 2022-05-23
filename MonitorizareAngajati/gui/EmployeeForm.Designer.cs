
namespace MonitorizareAngajati
{
    partial class EmployeeForm
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
            this.tasksGridView = new System.Windows.Forms.DataGridView();
            this.logoutButton = new System.Windows.Forms.Button();
            this.taskIDLabel = new System.Windows.Forms.Label();
            this.buttonUpdateTask = new System.Windows.Forms.Button();
            this.statusAllButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusTodoButton = new System.Windows.Forms.RadioButton();
            this.statusProgressButton = new System.Windows.Forms.RadioButton();
            this.statusDoneButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tasksGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasksGridView
            // 
            this.tasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksGridView.Location = new System.Drawing.Point(87, 35);
            this.tasksGridView.Name = "tasksGridView";
            this.tasksGridView.RowHeadersWidth = 102;
            this.tasksGridView.RowTemplate.Height = 40;
            this.tasksGridView.Size = new System.Drawing.Size(1238, 449);
            this.tasksGridView.TabIndex = 5;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Salmon;
            this.logoutButton.Font = new System.Drawing.Font("Insaniburger", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.logoutButton.Location = new System.Drawing.Point(821, 606);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(504, 77);
            this.logoutButton.TabIndex = 15;
            this.logoutButton.Text = "logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // taskIDLabel
            // 
            this.taskIDLabel.AutoSize = true;
            this.taskIDLabel.Location = new System.Drawing.Point(-2, 654);
            this.taskIDLabel.Name = "taskIDLabel";
            this.taskIDLabel.Size = new System.Drawing.Size(93, 32);
            this.taskIDLabel.TabIndex = 18;
            this.taskIDLabel.Text = "label1";
            // 
            // buttonUpdateTask
            // 
            this.buttonUpdateTask.BackColor = System.Drawing.Color.Orange;
            this.buttonUpdateTask.Font = new System.Drawing.Font("Insaniburger", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTask.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buttonUpdateTask.Location = new System.Drawing.Point(97, 606);
            this.buttonUpdateTask.Name = "buttonUpdateTask";
            this.buttonUpdateTask.Size = new System.Drawing.Size(561, 77);
            this.buttonUpdateTask.TabIndex = 23;
            this.buttonUpdateTask.Text = "Actualizeaza sarcina";
            this.buttonUpdateTask.UseVisualStyleBackColor = false;
            this.buttonUpdateTask.Click += new System.EventHandler(this.buttonUpdateTask_Click);
            // 
            // statusAllButton
            // 
            this.statusAllButton.AutoSize = true;
            this.statusAllButton.Location = new System.Drawing.Point(25, 49);
            this.statusAllButton.Name = "statusAllButton";
            this.statusAllButton.Size = new System.Drawing.Size(125, 36);
            this.statusAllButton.TabIndex = 24;
            this.statusAllButton.TabStop = true;
            this.statusAllButton.Text = "Toate";
            this.statusAllButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusDoneButton);
            this.groupBox1.Controls.Add(this.statusProgressButton);
            this.groupBox1.Controls.Add(this.statusTodoButton);
            this.groupBox1.Controls.Add(this.statusAllButton);
            this.groupBox1.Location = new System.Drawing.Point(97, 490);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 110);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrare";
            // 
            // statusTodoButton
            // 
            this.statusTodoButton.AutoSize = true;
            this.statusTodoButton.Location = new System.Drawing.Point(308, 48);
            this.statusTodoButton.Name = "statusTodoButton";
            this.statusTodoButton.Size = new System.Drawing.Size(157, 36);
            this.statusTodoButton.TabIndex = 25;
            this.statusTodoButton.TabStop = true;
            this.statusTodoButton.Text = "De facut";
            this.statusTodoButton.UseVisualStyleBackColor = true;
            // 
            // statusProgressButton
            // 
            this.statusProgressButton.AutoSize = true;
            this.statusProgressButton.Location = new System.Drawing.Point(595, 48);
            this.statusProgressButton.Name = "statusProgressButton";
            this.statusProgressButton.Size = new System.Drawing.Size(178, 36);
            this.statusProgressButton.TabIndex = 26;
            this.statusProgressButton.TabStop = true;
            this.statusProgressButton.Text = "In progres";
            this.statusProgressButton.UseVisualStyleBackColor = true;
            // 
            // statusDoneButton
            // 
            this.statusDoneButton.AutoSize = true;
            this.statusDoneButton.Location = new System.Drawing.Point(881, 49);
            this.statusDoneButton.Name = "statusDoneButton";
            this.statusDoneButton.Size = new System.Drawing.Size(164, 36);
            this.statusDoneButton.TabIndex = 27;
            this.statusDoneButton.TabStop = true;
            this.statusDoneButton.Text = "Terminat";
            this.statusDoneButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 695);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonUpdateTask);
            this.Controls.Add(this.taskIDLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.tasksGridView);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vizualizare sarcini";
            ((System.ComponentModel.ISupportInitialize)(this.tasksGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tasksGridView;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label taskIDLabel;
        private System.Windows.Forms.Button buttonUpdateTask;
        private System.Windows.Forms.RadioButton statusAllButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton statusDoneButton;
        private System.Windows.Forms.RadioButton statusProgressButton;
        private System.Windows.Forms.RadioButton statusTodoButton;
    }
}