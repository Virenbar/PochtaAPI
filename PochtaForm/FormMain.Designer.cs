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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.PG_Result = new System.Windows.Forms.PropertyGrid();
			this.B_Search = new System.Windows.Forms.Button();
			this.B_Unlock = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.TLP = new System.Windows.Forms.TableLayoutPanel();
			this.TB_Key = new System.Windows.Forms.TextBox();
			this.TB_Password = new System.Windows.Forms.TextBox();
			this.TB_Token = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TB_Login = new System.Windows.Forms.TextBox();
			this.BS_Result = new System.Windows.Forms.BindingSource(this.components);
			this.B_Batch = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.TB_Track = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.B_Limit = new System.Windows.Forms.Button();
			this.B_AllBatches = new System.Windows.Forms.Button();
			this.B_Order = new System.Windows.Forms.Button();
			this.B_SenderBatch = new System.Windows.Forms.Button();
			this.B_Address = new System.Windows.Forms.Button();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.B_FIO = new System.Windows.Forms.Button();
			this.B_Phone = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.TLP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BS_Result)).BeginInit();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PG_Result
			// 
			this.PG_Result.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PG_Result.Location = new System.Drawing.Point(0, 172);
			this.PG_Result.Name = "PG_Result";
			this.PG_Result.Size = new System.Drawing.Size(827, 448);
			this.PG_Result.TabIndex = 1;
			// 
			// B_Search
			// 
			this.B_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Search.Location = new System.Drawing.Point(3, 32);
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
			this.B_Unlock.Location = new System.Drawing.Point(3, 113);
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
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(221, 147);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// TLP
			// 
			this.TLP.AutoSize = true;
			this.TLP.ColumnCount = 2;
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TLP.Controls.Add(this.TB_Key, 1, 3);
			this.TLP.Controls.Add(this.TB_Password, 1, 1);
			this.TLP.Controls.Add(this.TB_Token, 1, 2);
			this.TLP.Controls.Add(this.label3, 0, 3);
			this.TLP.Controls.Add(this.label2, 0, 1);
			this.TLP.Controls.Add(this.label4, 0, 2);
			this.TLP.Controls.Add(this.label1, 0, 0);
			this.TLP.Controls.Add(this.TB_Login, 1, 0);
			this.TLP.Location = new System.Drawing.Point(3, 3);
			this.TLP.Name = "TLP";
			this.TLP.RowCount = 4;
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.Size = new System.Drawing.Size(215, 104);
			this.TLP.TabIndex = 8;
			// 
			// TB_Key
			// 
			this.TB_Key.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TB_Key.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PochtaForm.Properties.Settings.Default, "Key", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TB_Key.Location = new System.Drawing.Point(62, 81);
			this.TB_Key.Name = "TB_Key";
			this.TB_Key.Size = new System.Drawing.Size(150, 20);
			this.TB_Key.TabIndex = 4;
			this.TB_Key.Text = global::PochtaForm.Properties.Settings.Default.Key;
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
			// TB_Token
			// 
			this.TB_Token.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TB_Token.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PochtaForm.Properties.Settings.Default, "Token", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TB_Token.Location = new System.Drawing.Point(62, 55);
			this.TB_Token.Name = "TB_Token";
			this.TB_Token.Size = new System.Drawing.Size(150, 20);
			this.TB_Token.TabIndex = 3;
			this.TB_Token.Text = global::PochtaForm.Properties.Settings.Default.Token;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Key";
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
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Token";
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
			// BS_Result
			// 
			this.BS_Result.AllowNew = false;
			this.BS_Result.CurrentChanged += new System.EventHandler(this.BS_Result_CurrentChanged);
			// 
			// B_Batch
			// 
			this.B_Batch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Batch.Location = new System.Drawing.Point(84, 32);
			this.B_Batch.Name = "B_Batch";
			this.B_Batch.Size = new System.Drawing.Size(75, 23);
			this.B_Batch.TabIndex = 8;
			this.B_Batch.Text = "Batch";
			this.B_Batch.UseVisualStyleBackColor = true;
			this.B_Batch.Click += new System.EventHandler(this.B_Batch_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.flowLayoutPanel3);
			this.panel1.Controls.Add(this.flowLayoutPanel2);
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(827, 147);
			this.panel1.TabIndex = 9;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.AutoSize = true;
			this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel3.Controls.Add(this.TB_Track);
			this.flowLayoutPanel3.Controls.Add(this.B_Search);
			this.flowLayoutPanel3.Controls.Add(this.B_Batch);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(227, 3);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(279, 58);
			this.flowLayoutPanel3.TabIndex = 12;
			// 
			// TB_Track
			// 
			this.TB_Track.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TB_Track.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PochtaForm.Properties.Settings.Default, "LastTrack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.flowLayoutPanel3.SetFlowBreak(this.TB_Track, true);
			this.TB_Track.Location = new System.Drawing.Point(3, 4);
			this.TB_Track.Name = "TB_Track";
			this.TB_Track.Size = new System.Drawing.Size(192, 20);
			this.TB_Track.TabIndex = 0;
			this.TB_Track.Text = global::PochtaForm.Properties.Settings.Default.LastTrack;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.B_Limit);
			this.flowLayoutPanel2.Controls.Add(this.B_AllBatches);
			this.flowLayoutPanel2.Controls.Add(this.B_Order);
			this.flowLayoutPanel2.Controls.Add(this.B_SenderBatch);
			this.flowLayoutPanel2.Controls.Add(this.B_Address);
			this.flowLayoutPanel2.Controls.Add(this.B_FIO);
			this.flowLayoutPanel2.Controls.Add(this.B_Phone);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(659, 0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(168, 147);
			this.flowLayoutPanel2.TabIndex = 11;
			// 
			// B_Limit
			// 
			this.B_Limit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Limit.Location = new System.Drawing.Point(3, 3);
			this.B_Limit.Name = "B_Limit";
			this.B_Limit.Size = new System.Drawing.Size(75, 23);
			this.B_Limit.TabIndex = 11;
			this.B_Limit.Text = "Limit";
			this.B_Limit.UseVisualStyleBackColor = true;
			this.B_Limit.Click += new System.EventHandler(this.B_Limit_Click);
			// 
			// B_AllBatches
			// 
			this.B_AllBatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.B_AllBatches.Location = new System.Drawing.Point(84, 3);
			this.B_AllBatches.Name = "B_AllBatches";
			this.B_AllBatches.Size = new System.Drawing.Size(75, 23);
			this.B_AllBatches.TabIndex = 12;
			this.B_AllBatches.Text = "AllBatches";
			this.B_AllBatches.UseVisualStyleBackColor = true;
			this.B_AllBatches.Click += new System.EventHandler(this.B_AllBatches_Click);
			// 
			// B_Order
			// 
			this.B_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Order.Location = new System.Drawing.Point(3, 32);
			this.B_Order.Name = "B_Order";
			this.B_Order.Size = new System.Drawing.Size(75, 23);
			this.B_Order.TabIndex = 9;
			this.B_Order.Text = "OrderByID";
			this.B_Order.UseVisualStyleBackColor = true;
			this.B_Order.Click += new System.EventHandler(this.B_Order_Click);
			// 
			// B_SenderBatch
			// 
			this.B_SenderBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.B_SenderBatch.Location = new System.Drawing.Point(84, 32);
			this.B_SenderBatch.Name = "B_SenderBatch";
			this.B_SenderBatch.Size = new System.Drawing.Size(75, 23);
			this.B_SenderBatch.TabIndex = 10;
			this.B_SenderBatch.Text = "OrdersInBatch";
			this.B_SenderBatch.UseVisualStyleBackColor = true;
			this.B_SenderBatch.Click += new System.EventHandler(this.B_SenderBatch_Click);
			// 
			// B_Address
			// 
			this.B_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Address.Location = new System.Drawing.Point(3, 61);
			this.B_Address.Name = "B_Address";
			this.B_Address.Size = new System.Drawing.Size(75, 23);
			this.B_Address.TabIndex = 11;
			this.B_Address.Text = "Address";
			this.B_Address.UseVisualStyleBackColor = true;
			this.B_Address.Click += new System.EventHandler(this.B_Address_Click);
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.BindingSource = this.BS_Result;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 147);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(827, 25);
			this.bindingNavigator1.TabIndex = 10;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			this.bindingNavigatorAddNewItem.Visible = false;
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			this.bindingNavigatorDeleteItem.Visible = false;
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			this.bindingNavigatorSeparator2.Visible = false;
			// 
			// B_FIO
			// 
			this.B_FIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.B_FIO.Location = new System.Drawing.Point(84, 61);
			this.B_FIO.Name = "B_FIO";
			this.B_FIO.Size = new System.Drawing.Size(75, 23);
			this.B_FIO.TabIndex = 13;
			this.B_FIO.Text = "FIO";
			this.B_FIO.UseVisualStyleBackColor = true;
			this.B_FIO.Click += new System.EventHandler(this.B_FIO_Click);
			// 
			// B_Phone
			// 
			this.B_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Phone.Location = new System.Drawing.Point(3, 90);
			this.B_Phone.Name = "B_Phone";
			this.B_Phone.Size = new System.Drawing.Size(75, 23);
			this.B_Phone.TabIndex = 14;
			this.B_Phone.Text = "Phone";
			this.B_Phone.UseVisualStyleBackColor = true;
			this.B_Phone.Click += new System.EventHandler(this.B_Phone_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 620);
			this.Controls.Add(this.PG_Result);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.panel1);
			this.Name = "FormMain";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.TLP.ResumeLayout(false);
			this.TLP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BS_Result)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.BindingSource BS_Result;
		private System.Windows.Forms.Button B_Batch;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox TB_Key;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TB_Token;
		private System.Windows.Forms.Button B_Order;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button B_SenderBatch;
        private System.Windows.Forms.Button B_Limit;
        private System.Windows.Forms.Button B_Address;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button B_AllBatches;
        private System.Windows.Forms.Button B_FIO;
        private System.Windows.Forms.Button B_Phone;
    }
}

