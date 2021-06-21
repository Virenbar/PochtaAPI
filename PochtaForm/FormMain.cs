using PochtaAPI;
using System;
using System.Windows.Forms;

namespace PochtaForm
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void B_Unlock_Click(object sender, EventArgs e)
		{
			TLP.Enabled = true;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			Properties.Settings.Default.Reload();
			if (TB_Login.Text.Length > 0 || TB_Password.Text.Length > 0) { TLP.Enabled = false; };
		}

		private async void B_Search_Click(object sender, EventArgs e)
		{
			var PC = new TrackingClient(Properties.Settings.Default.Login, Properties.Settings.Default.Password);
			var H = await PC.GetHistoryAsync(TB_Track.Text);

			BS_History.DataSource = H;
			PG_Result.SelectedObject = BS_History.Current;
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.Save();
		}
	}
}