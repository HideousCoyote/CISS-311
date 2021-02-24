
namespace dropbox13
{
    partial class MainForm
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
            this.updateAdviseeButton = new System.Windows.Forms.Button();
            this.changeAdvisorButton = new System.Windows.Forms.Button();
            this.updateAdvisorButton = new System.Windows.Forms.Button();
            this.deleteAdviseeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateAdviseeButton
            // 
            this.updateAdviseeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAdviseeButton.Location = new System.Drawing.Point(12, 13);
            this.updateAdviseeButton.Name = "updateAdviseeButton";
            this.updateAdviseeButton.Size = new System.Drawing.Size(286, 52);
            this.updateAdviseeButton.TabIndex = 0;
            this.updateAdviseeButton.Text = "Update Advisee Name";
            this.updateAdviseeButton.UseVisualStyleBackColor = true;
            this.updateAdviseeButton.Click += new System.EventHandler(this.updateAdviseeButton_Click);
            // 
            // changeAdvisorButton
            // 
            this.changeAdvisorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAdvisorButton.Location = new System.Drawing.Point(12, 71);
            this.changeAdvisorButton.Name = "changeAdvisorButton";
            this.changeAdvisorButton.Size = new System.Drawing.Size(286, 52);
            this.changeAdvisorButton.TabIndex = 1;
            this.changeAdvisorButton.Text = "Change Advisor";
            this.changeAdvisorButton.UseVisualStyleBackColor = true;
            this.changeAdvisorButton.Click += new System.EventHandler(this.changeAdvisorButton_Click);
            // 
            // updateAdvisorButton
            // 
            this.updateAdvisorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAdvisorButton.Location = new System.Drawing.Point(12, 129);
            this.updateAdvisorButton.Name = "updateAdvisorButton";
            this.updateAdvisorButton.Size = new System.Drawing.Size(286, 52);
            this.updateAdvisorButton.TabIndex = 2;
            this.updateAdvisorButton.Text = "Update Advisor";
            this.updateAdvisorButton.UseVisualStyleBackColor = true;
            this.updateAdvisorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteAdviseeButton
            // 
            this.deleteAdviseeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdviseeButton.Location = new System.Drawing.Point(12, 187);
            this.deleteAdviseeButton.Name = "deleteAdviseeButton";
            this.deleteAdviseeButton.Size = new System.Drawing.Size(286, 52);
            this.deleteAdviseeButton.TabIndex = 3;
            this.deleteAdviseeButton.Text = "Delete Student";
            this.deleteAdviseeButton.UseVisualStyleBackColor = true;
            this.deleteAdviseeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 245);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(286, 52);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 311);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteAdviseeButton);
            this.Controls.Add(this.updateAdvisorButton);
            this.Controls.Add(this.changeAdvisorButton);
            this.Controls.Add(this.updateAdviseeButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateAdviseeButton;
        private System.Windows.Forms.Button changeAdvisorButton;
        private System.Windows.Forms.Button updateAdvisorButton;
        private System.Windows.Forms.Button deleteAdviseeButton;
        private System.Windows.Forms.Button exitButton;
    }
}

