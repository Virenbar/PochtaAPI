using PochtaAPI;
using PochtaAPI.Data;
using PochtaAPI.SData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PochtaForm
{
    internal partial class FormMain : Form
    {
        #region Form

        public FormMain()
        {
            InitializeComponent();
            ResetClients();
        }

        private TrackingClient TC;
        private SendingClient SC;

        private void ResetClients()
        {
            TC = new TrackingClient(Properties.Settings.Default.Login, Properties.Settings.Default.Password);
            SC = new SendingClient(Properties.Settings.Default.Token, Properties.Settings.Default.Key);
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

        private void SetResult(object Result)
        {
            BS_Result.DataSource = Result;
            PG_Result.SelectedObject = BS_Result.Current;
        }

        private void BS_Result_CurrentChanged(object sender, EventArgs e)
        {
            PG_Result.SelectedObject = BS_Result.Current;
        }

        #endregion Form

        #region Tracking

        private async void B_Batch_Click(object sender, EventArgs e)
        {
            Ticket T = await TC.GetTicketAsync(new List<string> { "", "" });
        }

        private async void B_Search_Click(object sender, EventArgs e)
        {
            MailItem MI = false ? TC.GetHistory(TB_Track.Text) : await TC.GetHistoryAsync(TB_Track.Text);

            BS_Result.DataSource = MI;
            PG_Result.SelectedObject = BS_Result.Current;
        }

        #endregion Tracking

        #region Sending

        private async void B_Order_Click(object sender, EventArgs e)
        {
            _ = await SC.GetOrderAsync(TB_Track.Text);
        }

        private async void B_SenderBatch_Click(object sender, EventArgs e)
        {
            _ = await SC.GetBatchOrdersAsync("15");
        }

        private async void B_Limit_Click(object sender, EventArgs e)
        {
            var A = await SC.GetAPILimit();
            SetResult(A);
        }

        private async void B_Address_Click(object sender, EventArgs e)
        {
            var AL = new List<Address>
            {
                new Address("г. Москва, Варшавское шоссе, 37"),
                new Address("г. Новосибирск, ул. Жуковского, 100/4")
            };
            AL = await SC.CleanAddress(AL);
            SetResult(AL);
        }

        #endregion Sending
    }
}