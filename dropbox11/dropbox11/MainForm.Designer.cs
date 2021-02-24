
namespace dropbox11
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
            this.label1 = new System.Windows.Forms.Label();
            this.advisorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adviseeListBox = new System.Windows.Forms.ListBox();
            this.addAdviseeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.removeAdviseeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an Advisor";
            // 
            // advisorComboBox
            // 
            this.advisorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisorComboBox.FormattingEnabled = true;
            this.advisorComboBox.Location = new System.Drawing.Point(176, 77);
            this.advisorComboBox.Name = "advisorComboBox";
            this.advisorComboBox.Size = new System.Drawing.Size(125, 24);
            this.advisorComboBox.TabIndex = 1;
            this.advisorComboBox.SelectedIndexChanged += new System.EventHandler(this.advisorComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Advisee Names";
            // 
            // adviseeListBox
            // 
            this.adviseeListBox.FormattingEnabled = true;
            this.adviseeListBox.Location = new System.Drawing.Point(13, 273);
            this.adviseeListBox.Name = "adviseeListBox";
            this.adviseeListBox.Size = new System.Drawing.Size(459, 173);
            this.adviseeListBox.TabIndex = 3;
            // 
            // addAdviseeButton
            // 
            this.addAdviseeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdviseeButton.Location = new System.Drawing.Point(12, 491);
            this.addAdviseeButton.Name = "addAdviseeButton";
            this.addAdviseeButton.Size = new System.Drawing.Size(125, 30);
            this.addAdviseeButton.TabIndex = 4;
            this.addAdviseeButton.Text = "&Add Advisee";
            this.addAdviseeButton.UseVisualStyleBackColor = true;
            this.addAdviseeButton.Click += new System.EventHandler(this.addAdviseeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(347, 491);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // removeAdviseeButton
            // 
            this.removeAdviseeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAdviseeButton.Location = new System.Drawing.Point(176, 491);
            this.removeAdviseeButton.Name = "removeAdviseeButton";
            this.removeAdviseeButton.Size = new System.Drawing.Size(125, 30);
            this.removeAdviseeButton.TabIndex = 6;
            this.removeAdviseeButton.Text = "&Delete Advisee";
            this.removeAdviseeButton.UseVisualStyleBackColor = true;
            this.removeAdviseeButton.Click += new System.EventHandler(this.removeAdviseeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.removeAdviseeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addAdviseeButton);
            this.Controls.Add(this.adviseeListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.advisorComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox advisorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox adviseeListBox;
        private System.Windows.Forms.Button addAdviseeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button removeAdviseeButton;
    }
}

