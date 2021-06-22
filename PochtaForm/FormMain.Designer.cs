namespace PochtaForm
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.TB_Track = new System.Windows.Forms.TextBox();
			this.PG_Result = new System.Windows.Forms.PropertyGrid();
			this.B_Search = new System.Windows.Forms.Button();
			this.B_Unlock = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.TLP = new System.Windows.Forms.TableLayoutPanel();
			this.TB_Password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TB_Login = new System.Windows.Forms.TextBox();
			this.BS_History = new System.Windows.Forms.BindingSource(this.components);
			this.B_Batch = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1.SuspendLayout();
			this.TLP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BS_History)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TB_Track
			// 
			this.TB_Track.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_Track.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PochtaForm.Properties.Settings.Default, "LastTrack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TB_Track.Location = new System.Drawing.Point(510, 3);
			this.TB_Track.Name = "TB_Track";
			this.TB_Track.Size = new System.Drawing.Size(233, 20);
			this.TB_Track.TabIndex = 0;
			this.TB_Track.Text = global::PochtaForm.Properties.Settings.Default.LastTrack;
			// 
			// PG_Result
			// 
			this.PG_Result.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PG_Result.Location = new System.Drawing.Point(0, 79);
			this.PG_Result.Name = "PG_Result";
			this.PG_Result.Size = new System.Drawing.Size(827, 393);
			this.PG_Result.TabIndex = 1;
			// 
			// B_Search
			// 
			this.B_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Search.Location = new System.Drawing.Point(749, 3);
			this.B_Search.Name = "B_Search";
			this.B_Search.Size = new System.Drawing.Size(75, 23);
			this.B_Search.TabIndex = 2;
			this.B_Search.Text = "Search";
			this.B_Search.UseVisualStyleBackColor = true;
			this.B_Search.Click += new System.EventHandler(this.B_Search_Click);
			// 
			// B_Unlock
			// 
			this.B_Unlock.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Unlock.AutoSize = true;
			this.B_Unlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_Unlock.Location = new System.Drawing.Point(224, 17);
			this.B_Unlock.Name = "B_Unlock";
			this.B_Unlock.Size = new System.Drawing.Size(51, 23);
			this.B_Unlock.TabIndex = 5;
			this.B_Unlock.Text = "Unlock";
			this.B_Unlock.UseVisualStyleBackColor = true;
			this.B_Unlock.Click += new System.EventHandler(this.B_Unlock_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Login";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.TLP);
			this.flowLayoutPanel1.Controls.Add(this.B_Unlock);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 58);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// TLP
			// 
			this.TLP.AutoSize = true;
			this.TLP.ColumnCount = 2;
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TLP.Controls.Add(this.TB_Password, 1, 1);
			this.TLP.Controls.Add(this.label2, 0, 1);
			this.TLP.Controls.Add(this.label1, 0, 0);
			this.TLP.Controls.Add(this.TB_Login, 1, 0);
			this.TLP.Location = new System.Drawing.Point(3, 3);
			this.TLP.Name = "TLP";
			this.TLP.RowCount = 2;
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.Size = new System.Drawing.Size(215, 52);
			this.TLP.TabIndex = 8;
			// 
			// TB_Password
			// 
			this.TB_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TB_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PochtaForm.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TB_Password.Location = new System.Drawing.Point(62, 29);
			this.TB_Password.Name = "TB_Password";
			this.TB_Password.Size = new System.Drawing.Size(150, 20);
			this.TB_Password.TabIndex = 4;
			this.TB_Password.Text = global::PochtaForm.Properties.Settings.Default.Password;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Password";
			// 
			// TB_Login
			// 
			this.TB_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TB_Login.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PochtaForm.Properties.Settings.Default, "Login", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TB_Login.Location = new System.Drawing.Point(62, 3);
			this.TB_Login.Name = "TB_Login";
			this.TB_Login.Size = new System.Drawing.Size(150, 20);
			this.TB_Login.TabIndex = 3;
			this.TB_Login.Text = global::PochtaForm.Properties.Settings.Default.Login;
			// 
			// B_Batch
			// 
			this.B_Batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Batch.Location = new System.Drawing.Point(749, 32);
			this.B_Batch.Name = "B_Batch";
			this.B_Batch.Size = new System.Drawing.Size(75, 23);
			this.B_Batch.TabIndex = 8;
			this.B_Batch.Text = "Batch";
			this.B_Batch.UseVisualStyleBackColor = true;
			this.B_Batch.Click += new System.EventHandler(this.B_Batch_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.B_Search);
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Controls.Add(this.B_Batch);
			this.panel1.Controls.Add(this.TB_Track);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(827, 79);
			this.panel1.TabIndex = 9;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 472);
			this.Controls.Add(this.PG_Result);
			this.Controls.Add(this.panel1);
			this.Name = "FormMain";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.TLP.ResumeLayout(false);
			this.TLP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BS_History)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox TB_Track;
		private System.Windows.Forms.PropertyGrid PG_Result;
		private System.Windows.Forms.Button B_Search;
		private System.Windows.Forms.TextBox TB_Login;
		private System.Windows.Forms.TextBox TB_Password;
		private System.Windows.Forms.Button B_Unlock;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel TLP;
		private System.Windows.Forms.BindingSource BS_History;
		private System.Windows.Forms.Button B_Batch;
		private System.Windows.Forms.Panel panel1;
	}
}

