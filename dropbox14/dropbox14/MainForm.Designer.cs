
namespace dropbox14
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
            this.updateCourseTitleButton = new System.Windows.Forms.Button();
            this.changeCourseInstructorButton = new System.Windows.Forms.Button();
            this.updateInstructorInfoButton = new System.Windows.Forms.Button();
            this.deleteCourseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addUpdateCourseFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateCourseTitleButton
            // 
            this.updateCourseTitleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCourseTitleButton.Location = new System.Drawing.Point(55, 12);
            this.updateCourseTitleButton.Name = "updateCourseTitleButton";
            this.updateCourseTitleButton.Size = new System.Drawing.Size(275, 65);
            this.updateCourseTitleButton.TabIndex = 0;
            this.updateCourseTitleButton.Text = "Update Course Title";
            this.updateCourseTitleButton.UseVisualStyleBackColor = true;
            this.updateCourseTitleButton.Click += new System.EventHandler(this.updateCourseTitleButton_Click);
            // 
            // changeCourseInstructorButton
            // 
            this.changeCourseInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCourseInstructorButton.Location = new System.Drawing.Point(55, 83);
            this.changeCourseInstructorButton.Name = "changeCourseInstructorButton";
            this.changeCourseInstructorButton.Size = new System.Drawing.Size(275, 65);
            this.changeCourseInstructorButton.TabIndex = 1;
            this.changeCourseInstructorButton.Text = "Change Course Instructor";
            this.changeCourseInstructorButton.UseVisualStyleBackColor = true;
            this.changeCourseInstructorButton.Click += new System.EventHandler(this.changeCourseInstructorButton_Click);
            // 
            // updateInstructorInfoButton
            // 
            this.updateInstructorInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateInstructorInfoButton.Location = new System.Drawing.Point(55, 154);
            this.updateInstructorInfoButton.Name = "updateInstructorInfoButton";
            this.updateInstructorInfoButton.Size = new System.Drawing.Size(275, 65);
            this.updateInstructorInfoButton.TabIndex = 2;
            this.updateInstructorInfoButton.Text = "Update Instructor Info";
            this.updateInstructorInfoButton.UseVisualStyleBackColor = true;
            this.updateInstructorInfoButton.Click += new System.EventHandler(this.updateInstructorInfoButton_Click);
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourseButton.Location = new System.Drawing.Point(55, 225);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(275, 65);
            this.deleteCourseButton.TabIndex = 3;
            this.deleteCourseButton.Text = "Delete Course";
            this.deleteCourseButton.UseVisualStyleBackColor = true;
            this.deleteCourseButton.Click += new System.EventHandler(this.deleteCourseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(55, 367);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(275, 65);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addUpdateCourseFormButton
            // 
            this.addUpdateCourseFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUpdateCourseFormButton.Location = new System.Drawing.Point(55, 296);
            this.addUpdateCourseFormButton.Name = "addUpdateCourseFormButton";
            this.addUpdateCourseFormButton.Size = new System.Drawing.Size(275, 65);
            this.addUpdateCourseFormButton.TabIndex = 5;
            this.addUpdateCourseFormButton.Text = "Add/Update Course";
            this.addUpdateCourseFormButton.UseVisualStyleBackColor = true;
            this.addUpdateCourseFormButton.Click += new System.EventHandler(this.addUpdateCourseFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.addUpdateCourseFormButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteCourseButton);
            this.Controls.Add(this.updateInstructorInfoButton);
            this.Controls.Add(this.changeCourseInstructorButton);
            this.Controls.Add(this.updateCourseTitleButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateCourseTitleButton;
        private System.Windows.Forms.Button changeCourseInstructorButton;
        private System.Windows.Forms.Button updateInstructorInfoButton;
        private System.Windows.Forms.Button deleteCourseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addUpdateCourseFormButton;
    }
}