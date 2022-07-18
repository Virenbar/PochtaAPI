using PochtaAPI;
using PochtaAPI.TTypes;
using PochtaAPI.STypes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PochtaAPI.Enums;
using System.ComponentModel;

namespace PochtaForm
{
    internal partial class FormMain : Form
    {
        #region Form

        private SendingClient SC;

        private TrackingClient TC;

        public FormMain()
        {
            InitializeComponent();
            ResetClients();
        }

        private void B_Unlock_Click(object sender, EventArgs e)
        {
            TLP.Enabled = true;
        }

        private void BS_Result_CurrentChanged(object sender, EventArgs e)
        {
            PG_Result.SelectedObject = BS_Result.Current;
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

        private void ResetClients()
        {
            TC = new TrackingClient(Properties.Settings.Default.Login, Properties.Settings.Default.Password);
            SC = new SendingClient(Properties.Settings.Default.Token, Properties.Settings.Default.Key);
        }

        private void SetResult(object Result)
        {
            BS_Result.DataSource = Result;
            PG_Result.SelectedObject = BS_Result.Current;
        }

        #endregion Form

        #region Tracking

        private async void B_Batch_Click(object sender, EventArgs e)
        {
            Ticket T = await TC.GetTicketAsync(new List<string> { "", "" });
            SetResult(T);
        }

        private async void B_Search_Click(object sender, EventArgs e)
        {
            MailItem MI = false ? TC.GetHistory(TB_Track.Text) : await TC.GetHistoryAsync(TB_Track.Text);

            TypeDescriptor.AddAttributes(MI.History, new Attribute[] { new ReadOnlyAttribute(true) });
            BS_Result.DataSource = MI;
            PG_Result.SelectedObject = BS_Result.Current;
        }

        #endregion Tracking

        #region Sending

        private async void B_AllBatches_Click(object sender, EventArgs e)
        {
            var A = await SC.GetAllBatches();
            SetResult(A);
        }

        private async void B_Order_Click(object sender, EventArgs e)
        {
            var LO = await SC.GetOrderByID(TB_Track.Text);
            SetResult(LO);
        }

        private async void B_SenderBatch_Click(object sender, EventArgs e)
        {
            var LO = await SC.GetOrdersInBatch("15");
            SetResult(LO);
        }

        #region ДАННЫЕ

        private async void B_Address_Click(object sender, EventArgs e)
        {
            var AL = new List<AddressRequest>
            {
                new AddressRequest("г. Москва, Варшавское шоссе, 37"),
                new AddressRequest("г. Новосибирск, ул. Жуковского, 100/4")
            };
            var ALC = await SC.CleanAddress(AL);
            SetResult(ALC);
        }

        private async void B_FIO_Click(object sender, EventArgs e)
        {
            var L = new List<FIO>
            {
                new FIO("Иванов Иван Иванович"),
                new FIO("Иванов Николай Иванович")
            };
            var R = await SC.CleanFIO(L);
            SetResult(R);
        }

        private async void B_Limit_Click(object sender, EventArgs e)
        {
            var A = await SC.GetAPILimit();
            SetResult(A);
        }

        private async void B_Phone_Click(object sender, EventArgs e)
        {
            var L = new List<Phone>
            {
                new Phone("2-08-14")
                {
                    Place ="Камышлов",
                    Region ="Свердловская область"
                },
                new Phone("8-499-257-44-56")
            };
            var R = await SC.CleanPhone(L);
            SetResult(R);
        }

        private async void B_Tariff_Click(object sender, EventArgs e)
        {
            var MI = new MailInfo
            {
                IndexFrom = "101000",
                IndexTo = "644015",
                MailCategory = MailCategory.ORDINARY,
                MailType = MailType.POSTAL_PARCEL,
                Mass = 1000,
                Dimension = new Dimension
                {
                    Height = 2,
                    Length = 5,
                    Width = 197
                },
                Fragile = true
            };
            var R = await SC.CalculateTariff(MI);
            SetResult(R);
        }

        #endregion ДАННЫЕ

        #region НАСТРОЙКИ

        private async void B_User_Click(object sender, EventArgs e)
        {
            var R = await SC.UserSettings;
            SetResult(R);
        }

        private async void B_UserPoints_Click(object sender, EventArgs e)
        {
            var R = await SC.ShippingPoints;
            SetResult(R);
        }

        #endregion НАСТРОЙКИ

        #endregion Sending
    }
}