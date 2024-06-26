using System.ComponentModel;

namespace SpWinFormsBackgroundWorkerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backWorker.WorkerReportsProgress = true;
            backWorker.WorkerSupportsCancellation = true;
        }

        private void backWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (sender is BackgroundWorker backWorker)
            {
                for (int i = 0; i <= 100; i++)
                {
                    if (backWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }

                    Thread.Sleep(100);
                    backWorker.ReportProgress(i);
                }
            }
        }

        private void backWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblResult.Text = e.ProgressPercentage.ToString();
            progressBar.PerformStep();
        }

        private void backWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblResult.Text = "Error: " + e.Error.Message;
                return;
            }

            if (e.Cancelled)
                lblResult.Text = "Progress is canceled";
            else
                lblResult.Text = "Progress is done";

            progressBar.Value = progressBar.Minimum;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!backWorker.IsBusy)
                backWorker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backWorker.WorkerSupportsCancellation)
                backWorker.CancelAsync();
        }
    }
}
