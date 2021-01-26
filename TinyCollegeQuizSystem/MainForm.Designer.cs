
namespace TinyCollegeQuizSystem
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
            this.takeQuizButton = new System.Windows.Forms.Button();
            this.manageQuizButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // takeQuizButton
            // 
            this.takeQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeQuizButton.Location = new System.Drawing.Point(120, 140);
            this.takeQuizButton.Name = "takeQuizButton";
            this.takeQuizButton.Size = new System.Drawing.Size(300, 70);
            this.takeQuizButton.TabIndex = 0;
            this.takeQuizButton.Text = "Student Take Quiz";
            this.takeQuizButton.UseVisualStyleBackColor = true;
            // 
            // manageQuizButton
            // 
            this.manageQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageQuizButton.Location = new System.Drawing.Point(120, 232);
            this.manageQuizButton.Name = "manageQuizButton";
            this.manageQuizButton.Size = new System.Drawing.Size(300, 70);
            this.manageQuizButton.TabIndex = 1;
            this.manageQuizButton.Text = "Instructor Manage Quiz";
            this.manageQuizButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(120, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(300, 70);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiny College Quiz System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.manageQuizButton);
            this.Controls.Add(this.takeQuizButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button takeQuizButton;
        private System.Windows.Forms.Button manageQuizButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

