
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
            this.label1 = new System.Windows.Forms.Label();
            this.noLoggedUsersLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loggedUsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loggedUsersGridView
            // 
            this.loggedUsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loggedUsersGridView.Location = new System.Drawing.Point(36, 48);
            this.loggedUsersGridView.Name = "loggedUsersGridView";
            this.loggedUsersGridView.RowHeadersWidth = 102;
            this.loggedUsersGridView.RowTemplate.Height = 40;
            this.loggedUsersGridView.Size = new System.Drawing.Size(761, 449);
            this.loggedUsersGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angajati prezenti: ";
            // 
            // noLoggedUsersLabel
            // 
            this.noLoggedUsersLabel.AutoSize = true;
            this.noLoggedUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLoggedUsersLabel.Location = new System.Drawing.Point(404, 536);
            this.noLoggedUsersLabel.Name = "noLoggedUsersLabel";
            this.noLoggedUsersLabel.Size = new System.Drawing.Size(42, 46);
            this.noLoggedUsersLabel.TabIndex = 2;
            this.noLoggedUsersLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(863, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(437, 102);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adauga sarcina";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Orange;
            this.buttonLogout.Font = new System.Drawing.Font("Insaniburger", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buttonLogout.Location = new System.Drawing.Point(863, 349);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(437, 97);
            this.buttonLogout.TabIndex = 15;
            this.buttonLogout.Text = "logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 658);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noLoggedUsersLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loggedUsersGridView);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vizualizare angajati";
            ((System.ComponentModel.ISupportInitialize)(this.loggedUsersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loggedUsersGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label noLoggedUsersLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogout;
    }
}