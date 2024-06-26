namespace SpWinFormsBackgroundWorkerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backWorker = new System.ComponentModel.BackgroundWorker();
            btnStart = new Button();
            btnCancel = new Button();
            lblResult = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // backWorker
            // 
            backWorker.DoWork += backWorker_DoWork;
            backWorker.ProgressChanged += backWorker_ProgressChanged;
            backWorker.RunWorkerCompleted += backWorker_RunWorkerCompleted;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(99, 293);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(193, 62);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(432, 293);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(193, 62);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(325, 44);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 30);
            lblResult.TabIndex = 1;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(56, 159);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(594, 52);
            progressBar.Step = 1;
            progressBar.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 384);
            Controls.Add(progressBar);
            Controls.Add(lblResult);
            Controls.Add(btnCancel);
            Controls.Add(btnStart);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backWorker;
        private Button btnStart;
        private Button btnCancel;
        private Label lblResult;
        private ProgressBar progressBar;
    }
}
