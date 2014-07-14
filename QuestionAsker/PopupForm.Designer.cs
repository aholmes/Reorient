namespace QuestionAsker
{
    partial class PopupForm
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
            this.responseText = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.responseSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // responseText
            // 
            this.responseText.Location = new System.Drawing.Point(12, 60);
            this.responseText.Multiline = true;
            this.responseText.Name = "responseText";
            this.responseText.Size = new System.Drawing.Size(806, 433);
            this.responseText.TabIndex = 0;
            this.responseText.TextChanged += new System.EventHandler(this.responseText_TextChanged);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(12, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 40);
            this.questionLabel.TabIndex = 1;
            // 
            // responseSaveButton
            // 
            this.responseSaveButton.Location = new System.Drawing.Point(12, 499);
            this.responseSaveButton.Name = "responseSaveButton";
            this.responseSaveButton.Size = new System.Drawing.Size(405, 38);
            this.responseSaveButton.TabIndex = 2;
            this.responseSaveButton.Text = "Save response and close";
            this.responseSaveButton.UseVisualStyleBackColor = true;
            this.responseSaveButton.Click += new System.EventHandler(this.responseSaveButton_Click);
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 544);
            this.Controls.Add(this.responseSaveButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.responseText);
            this.Name = "PopupForm";
            this.Text = "Please answer the question.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox responseText;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button responseSaveButton;
    }
}