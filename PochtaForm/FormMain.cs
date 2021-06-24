using PochtaAPI;
using PochtaAPI.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PochtaForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private async void B_Batch_Click(object sender, EventArgs e)
        {
            TrackingClient TC = new TrackingClient(Properties.Settings.Default.Login, Properties.Settings.Default.Password);
            Ticket T = await TC.GetTicketAsync(new List<string> { "", "" });
        }

        private async void B_Search_Click(object sender, EventArgs e)
        {
            TrackingClient TC = new TrackingClient(Properties.Settings.Default.Login, Properties.Settings.Default.Password);
            MailItem MI = false ? TC.GetHistory(TB_Track.Text) : await TC.GetHistoryAsync(TB_Track.Text);

            BS_History.DataSource = MI;
            PG_Result.SelectedObject = BS_History.Current;
        }

        private void B_Unlock_Click(object sender, EventArgs e)
        {
            TLP.Enabled = true;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            if (TB_Login.Text.Length + TB_Password.Text.Length > 0) { TLP.Enabled = false; }
        }

        private async void B_Order_Click(object sender, EventArgs e)
        {
            var SC = new SendingClient(Properties.Settings.Default.Token, Properties.Settings.Default.Key);
            _ = await SC.GetOrderAsync(TB_Track.Text);
        }

        private async void B_SenderBatch_Click(object sender, EventArgs e)
        {
            var SC = new SendingClient(Properties.Settings.Default.Token, Properties.Settings.Default.Key);
            _ = await SC.GetBatchOrdersAsync("15");
        }
    }
}