namespace RentACarAgency
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
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Honda");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Ford");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Nissan");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Opel");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Toyota");
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToAddClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToEditClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToRemoveClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ClientsTabPage = new System.Windows.Forms.TabPage();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarsTabPage = new System.Windows.Forms.TabPage();
            this.CarsTabSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CarsMarksTreeView = new System.Windows.Forms.TreeView();
            this.CarsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.CalendarPanel = new System.Windows.Forms.Panel();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStrip.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.ClientsTabPage.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            this.CarsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsTabSplitContainer)).BeginInit();
            this.CarsTabSplitContainer.Panel1.SuspendLayout();
            this.CarsTabSplitContainer.Panel2.SuspendLayout();
            this.CarsTabSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGridView)).BeginInit();
            this.OrdersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.CalendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(1109, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HowToAddClientToolStripMenuItem,
            this.HowToEditClientToolStripMenuItem,
            this.HowToRemoveClientToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // HowToAddClientToolStripMenuItem
            // 
            this.HowToAddClientToolStripMenuItem.Name = "HowToAddClientToolStripMenuItem";
            this.HowToAddClientToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.HowToAddClientToolStripMenuItem.Text = "How to add client?";
            this.HowToAddClientToolStripMenuItem.Click += new System.EventHandler(this.HowToAddClientToolStripMenuItem_Click);
            // 
            // HowToEditClientToolStripMenuItem
            // 
            this.HowToEditClientToolStripMenuItem.Name = "HowToEditClientToolStripMenuItem";
            this.HowToEditClientToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.HowToEditClientToolStripMenuItem.Text = "How to edit client?";
            this.HowToEditClientToolStripMenuItem.Click += new System.EventHandler(this.HowToEditClientToolStripMenuItem_Click);
            // 
            // HowToRemoveClientToolStripMenuItem
            // 
            this.HowToRemoveClientToolStripMenuItem.Name = "HowToRemoveClientToolStripMenuItem";
            this.HowToRemoveClientToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.HowToRemoveClientToolStripMenuItem.Text = "How to remove client?";
            this.HowToRemoveClientToolStripMenuItem.Click += new System.EventHandler(this.HowToRemoveClientToolStripMenuItem_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ClientsTabPage);
            this.MainTabControl.Controls.Add(this.CarsTabPage);
            this.MainTabControl.Controls.Add(this.OrdersTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 28);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1109, 530);
            this.MainTabControl.TabIndex = 1;
            // 
            // ClientsTabPage
            // 
            this.ClientsTabPage.Controls.Add(this.OptionsGroupBox);
            this.ClientsTabPage.Controls.Add(this.ClientsDataGridView);
            this.ClientsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ClientsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientsTabPage.Name = "ClientsTabPage";
            this.ClientsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientsTabPage.Size = new System.Drawing.Size(1101, 501);
            this.ClientsTabPage.TabIndex = 0;
            this.ClientsTabPage.Text = "Clients";
            this.ClientsTabPage.UseVisualStyleBackColor = true;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.OptionsGroupBox.Controls.Add(this.RemoveButton);
            this.OptionsGroupBox.Controls.Add(this.EditButton);
            this.OptionsGroupBox.Controls.Add(this.AddButton);
            this.OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsGroupBox.Location = new System.Drawing.Point(3, 360);
            this.OptionsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionsGroupBox.Size = new System.Drawing.Size(1095, 139);
            this.OptionsGroupBox.TabIndex = 1;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RemoveButton.Location = new System.Drawing.Point(887, 60);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(123, 30);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove Client";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditButton.Location = new System.Drawing.Point(470, 60);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(123, 30);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit Client";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddButton.Location = new System.Drawing.Point(85, 62);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 30);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Client";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClientsDataGridView
            // 
            this.ClientsDataGridView.AllowUserToAddRows = false;
            this.ClientsDataGridView.AllowUserToDeleteRows = false;
            this.ClientsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClient,
            this.CName,
            this.Surname,
            this.PhoneNumber,
            this.Address});
            this.ClientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsDataGridView.Location = new System.Drawing.Point(3, 2);
            this.ClientsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.ReadOnly = true;
            this.ClientsDataGridView.RowTemplate.Height = 24;
            this.ClientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsDataGridView.Size = new System.Drawing.Size(1095, 497);
            this.ClientsDataGridView.TabIndex = 0;
            // 
            // IdClient
            // 
            this.IdClient.DataPropertyName = "ID_CLIENT";
            this.IdClient.HeaderText = "ID";
            this.IdClient.Name = "IdClient";
            this.IdClient.ReadOnly = true;
            this.IdClient.Visible = false;
            // 
            // CName
            // 
            this.CName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CName.DataPropertyName = "C_NAME";
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.DataPropertyName = "SURNAME";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.DataPropertyName = "PHONE_NUMBER";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "ADRESS";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // CarsTabPage
            // 
            this.CarsTabPage.Controls.Add(this.CarsTabSplitContainer);
            this.CarsTabPage.Location = new System.Drawing.Point(4, 25);
            this.CarsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarsTabPage.Name = "CarsTabPage";
            this.CarsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarsTabPage.Size = new System.Drawing.Size(1101, 501);
            this.CarsTabPage.TabIndex = 1;
            this.CarsTabPage.Text = "Cars";
            this.CarsTabPage.UseVisualStyleBackColor = true;
            // 
            // CarsTabSplitContainer
            // 
            this.CarsTabSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarsTabSplitContainer.IsSplitterFixed = true;
            this.CarsTabSplitContainer.Location = new System.Drawing.Point(3, 2);
            this.CarsTabSplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarsTabSplitContainer.Name = "CarsTabSplitContainer";
            // 
            // CarsTabSplitContainer.Panel1
            // 
            this.CarsTabSplitContainer.Panel1.Controls.Add(this.CarsMarksTreeView);
            // 
            // CarsTabSplitContainer.Panel2
            // 
            this.CarsTabSplitContainer.Panel2.Controls.Add(this.CarsDataGridView);
            this.CarsTabSplitContainer.Size = new System.Drawing.Size(1095, 497);
            this.CarsTabSplitContainer.SplitterDistance = 122;
            this.CarsTabSplitContainer.TabIndex = 0;
            // 
            // CarsMarksTreeView
            // 
            this.CarsMarksTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarsMarksTreeView.Location = new System.Drawing.Point(0, 0);
            this.CarsMarksTreeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarsMarksTreeView.Name = "CarsMarksTreeView";
            treeNode46.Name = "Honda";
            treeNode46.Text = "Honda";
            treeNode47.Name = "Ford";
            treeNode47.Text = "Ford";
            treeNode48.Name = "Nissan";
            treeNode48.Text = "Nissan";
            treeNode49.Name = "Opel";
            treeNode49.Text = "Opel";
            treeNode50.Name = "Toyota";
            treeNode50.Text = "Toyota";
            this.CarsMarksTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50});
            this.CarsMarksTreeView.Size = new System.Drawing.Size(122, 497);
            this.CarsMarksTreeView.TabIndex = 0;
            this.CarsMarksTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.CarsMarksTreeView_NodeMouseClick);
            // 
            // CarsDataGridView
            // 
            this.CarsDataGridView.AllowUserToAddRows = false;
            this.CarsDataGridView.AllowUserToDeleteRows = false;
            this.CarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCar,
            this.IdBase,
            this.Mark,
            this.Model,
            this.Registration,
            this.RentPrice,
            this.Category,
            this.ProductionYear});
            this.CarsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CarsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarsDataGridView.Name = "CarsDataGridView";
            this.CarsDataGridView.ReadOnly = true;
            this.CarsDataGridView.RowTemplate.Height = 24;
            this.CarsDataGridView.Size = new System.Drawing.Size(969, 497);
            this.CarsDataGridView.TabIndex = 0;
            // 
            // IdCar
            // 
            this.IdCar.DataPropertyName = "ID_CAR";
            this.IdCar.HeaderText = "IdCar";
            this.IdCar.Name = "IdCar";
            this.IdCar.ReadOnly = true;
            this.IdCar.Visible = false;
            // 
            // IdBase
            // 
            this.IdBase.DataPropertyName = "ID_BASE";
            this.IdBase.HeaderText = "IdBase";
            this.IdBase.Name = "IdBase";
            this.IdBase.ReadOnly = true;
            this.IdBase.Visible = false;
            // 
            // Mark
            // 
            this.Mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mark.DataPropertyName = "MARK";
            this.Mark.HeaderText = "Mark";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.DataPropertyName = "C_MODEL";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Registration
            // 
            this.Registration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Registration.DataPropertyName = "REGISTRATION_NUMBER";
            this.Registration.HeaderText = "Registration";
            this.Registration.Name = "Registration";
            this.Registration.ReadOnly = true;
            // 
            // RentPrice
            // 
            this.RentPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RentPrice.DataPropertyName = "RENT_PRICE";
            this.RentPrice.HeaderText = "Rent Price";
            this.RentPrice.Name = "RentPrice";
            this.RentPrice.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "C_CATEGORY";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // ProductionYear
            // 
            this.ProductionYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductionYear.DataPropertyName = "PRODUCTION_YEAR";
            this.ProductionYear.HeaderText = "Production Year";
            this.ProductionYear.Name = "ProductionYear";
            this.ProductionYear.ReadOnly = true;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.SplitContainer);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 25);
            this.OrdersTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersTabPage.Size = new System.Drawing.Size(1101, 501);
            this.OrdersTabPage.TabIndex = 2;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.IsSplitterFixed = true;
            this.SplitContainer.Location = new System.Drawing.Point(3, 2);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.CalendarPanel);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.OrdersDataGridView);
            this.SplitContainer.Size = new System.Drawing.Size(1095, 497);
            this.SplitContainer.SplitterDistance = 296;
            this.SplitContainer.TabIndex = 0;
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.Controls.Add(this.MonthCalendar);
            this.CalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarPanel.Location = new System.Drawing.Point(0, 0);
            this.CalendarPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(296, 497);
            this.CalendarPanel.TabIndex = 0;
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.MonthCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthCalendar.Location = new System.Drawing.Point(0, 0);
            this.MonthCalendar.MaxSelectionCount = 1;
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 0;
            this.MonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.IdOrder,
            this.Car,
            this.OrderDate,
            this.RentStartDate,
            this.RentEndDate});
            this.OrdersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.OrdersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.RowTemplate.Height = 24;
            this.OrdersDataGridView.Size = new System.Drawing.Size(795, 497);
            this.OrdersDataGridView.TabIndex = 0;
            // 
            // Client
            // 
            this.Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // IdOrder
            // 
            this.IdOrder.DataPropertyName = "ID_ORDER";
            this.IdOrder.HeaderText = "IdOrder";
            this.IdOrder.Name = "IdOrder";
            this.IdOrder.ReadOnly = true;
            this.IdOrder.Visible = false;
            // 
            // Car
            // 
            this.Car.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Car.DataPropertyName = "Mark";
            this.Car.HeaderText = "Car";
            this.Car.Name = "Car";
            this.Car.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDate.DataPropertyName = "ORDER_DATE";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // RentStartDate
            // 
            this.RentStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RentStartDate.DataPropertyName = "RENT_START_DATE";
            this.RentStartDate.HeaderText = "RentStartDate";
            this.RentStartDate.Name = "RentStartDate";
            this.RentStartDate.ReadOnly = true;
            // 
            // RentEndDate
            // 
            this.RentEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RentEndDate.DataPropertyName = "RENT_END_DATE";
            this.RentEndDate.HeaderText = "RentEndDate";
            this.RentEndDate.Name = "RentEndDate";
            this.RentEndDate.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 558);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1125, 595);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent A Car Agency";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.ClientsTabPage.ResumeLayout(false);
            this.OptionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            this.CarsTabPage.ResumeLayout(false);
            this.CarsTabSplitContainer.Panel1.ResumeLayout(false);
            this.CarsTabSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarsTabSplitContainer)).EndInit();
            this.CarsTabSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGridView)).EndInit();
            this.OrdersTabPage.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.CalendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ClientsTabPage;
        private System.Windows.Forms.TabPage CarsTabPage;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.SplitContainer CarsTabSplitContainer;
        private System.Windows.Forms.TreeView CarsMarksTreeView;
        private System.Windows.Forms.DataGridView ClientsDataGridView;
        private System.Windows.Forms.DataGridView CarsDataGridView;
        private System.Windows.Forms.Panel CalendarPanel;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HowToAddClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HowToEditClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HowToRemoveClientToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentEndDate;
    }
}

