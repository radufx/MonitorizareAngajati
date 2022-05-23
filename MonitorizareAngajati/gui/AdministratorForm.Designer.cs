
namespace MonitorizareAngajati
{
    partial class AdministratorForm
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
            this.loggedUsersGridView = new System.Windows.Forms.DataGridView();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.userTasksGridView = new System.Windows.Forms.DataGridView();
            this.labelParinte = new System.Windows.Forms.Label();
            this.labelFiu = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.taskIDLabel = new System.Windows.Forms.Label();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loggedUsersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loggedUsersGridView
            // 
            this.loggedUsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loggedUsersGridView.Location = new System.Drawing.Point(41, 127);
            this.loggedUsersGridView.Name = "loggedUsersGridView";
            this.loggedUsersGridView.RowHeadersWidth = 102;
            this.loggedUsersGridView.RowTemplate.Height = 40;
            this.loggedUsersGridView.Size = new System.Drawing.Size(748, 489);
            this.loggedUsersGridView.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Salmon;
            this.buttonLogout.Font = new System.Drawing.Font("Insaniburger", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buttonLogout.Location = new System.Drawing.Point(1284, 644);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(418, 77);
            this.buttonLogout.TabIndex = 15;
            this.buttonLogout.Text = "logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = System.Drawing.Color.Orange;
            this.buttonAddTask.Font = new System.Drawing.Font("Insaniburger", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTask.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buttonAddTask.Location = new System.Drawing.Point(270, 644);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(456, 77);
            this.buttonAddTask.TabIndex = 16;
            this.buttonAddTask.Text = "Adauga sarcina";
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // userTasksGridView
            // 
            this.userTasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTasksGridView.Location = new System.Drawing.Point(838, 127);
            this.userTasksGridView.Name = "userTasksGridView";
            this.userTasksGridView.RowHeadersWidth = 102;
            this.userTasksGridView.RowTemplate.Height = 40;
            this.userTasksGridView.Size = new System.Drawing.Size(1204, 489);
            this.userTasksGridView.TabIndex = 17;
            // 
            // labelParinte
            // 
            this.labelParinte.AutoSize = true;
            this.labelParinte.Font = new System.Drawing.Font("Nuvel", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParinte.ForeColor = System.Drawing.Color.Lime;
            this.labelParinte.Location = new System.Drawing.Point(164, 57);
            this.labelParinte.Name = "labelParinte";
            this.labelParinte.Size = new System.Drawing.Size(446, 54);
            this.labelParinte.TabIndex = 18;
            this.labelParinte.Text = "Angajati prezenti";
            // 
            // labelFiu
            // 
            this.labelFiu.AutoSize = true;
            this.labelFiu.Font = new System.Drawing.Font("Nuvel", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiu.ForeColor = System.Drawing.Color.Lime;
            this.labelFiu.Location = new System.Drawing.Point(1226, 57);
            this.labelFiu.Name = "labelFiu";
            this.labelFiu.Size = new System.Drawing.Size(403, 54);
            this.labelFiu.TabIndex = 19;
            this.labelFiu.Text = "Sarcini angajat";
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Location = new System.Drawing.Point(644, 57);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(168, 32);
            this.userIDLabel.TabIndex = 20;
            this.userIDLabel.Text = "userIDLabel";
            // 
            // taskIDLabel
            // 
            this.taskIDLabel.AutoSize = true;
            this.taskIDLabel.Location = new System.Drawing.Point(832, 57);
            this.taskIDLabel.Name = "taskIDLabel";
            this.taskIDLabel.Size = new System.Drawing.Size(165, 32);
            this.taskIDLabel.TabIndex = 21;
            this.taskIDLabel.Text = "taskIDLabel";
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.BackColor = System.Drawing.Color.Orange;
            this.buttonDeleteTask.Font = new System.Drawing.Font("Insaniburger", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTask.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDeleteTask.Location = new System.Drawing.Point(793, 644);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Size = new System.Drawing.Size(441, 77);
            this.buttonDeleteTask.TabIndex = 22;
            this.buttonDeleteTask.Text = "Sterge sarcina";
            this.buttonDeleteTask.UseVisualStyleBackColor = false;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2085, 758);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.taskIDLabel);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.labelFiu);
            this.Controls.Add(this.labelParinte);
            this.Controls.Add(this.userTasksGridView);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.loggedUsersGridView);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vizualizare angajati";
            ((System.ComponentModel.ISupportInitialize)(this.loggedUsersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loggedUsersGridView;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.DataGridView userTasksGridView;
        private System.Windows.Forms.Label labelParinte;
        private System.Windows.Forms.Label labelFiu;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label taskIDLabel;
        private System.Windows.Forms.Button buttonDeleteTask;
    }
}