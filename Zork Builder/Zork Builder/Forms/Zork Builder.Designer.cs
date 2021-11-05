
namespace Zork_Builder
{
    partial class ZorkBuilder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
            System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.TabPage roomsTab;
            System.Windows.Forms.Label RoomsLabel;
            System.Windows.Forms.TabPage extrasTab;
            this.closeWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSeparatorStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomsListGroupBox = new System.Windows.Forms.GroupBox();
            this.RoomDeleteButton = new System.Windows.Forms.Button();
            this.RoomAddButton = new System.Windows.Forms.Button();
            this.RoomsList = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SouthControl = new Zork_Builder.UserControls.NeighborControl();
            this.WestControl = new Zork_Builder.UserControls.NeighborControl();
            this.EastControl = new Zork_Builder.UserControls.NeighborControl();
            this.NorthControl = new Zork_Builder.UserControls.NeighborControl();
            this.RoomNameText = new System.Windows.Forms.TextBox();
            this.RoomDescriptionText = new System.Windows.Forms.RichTextBox();
            this.roomNeighborsLabel = new System.Windows.Forms.Label();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.ExtraInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.StartingLocationDropDown = new System.Windows.Forms.ComboBox();
            this.WelcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.ExitMessageTextBox = new System.Windows.Forms.TextBox();
            this.ExitMessage = new System.Windows.Forms.Label();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.StartingLocationLabel = new System.Windows.Forms.Label();
            this.ItemInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ItemScoreLable = new System.Windows.Forms.Label();
            this.ItemDescriptionText = new System.Windows.Forms.RichTextBox();
            this.ItemDescription = new System.Windows.Forms.Label();
            this.ItemNameText = new System.Windows.Forms.TextBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemDeleteButton = new System.Windows.Forms.Button();
            this.ItemAddButton = new System.Windows.Forms.Button();
            this.ItemsList = new System.Windows.Forms.ListBox();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.MenuTabs = new System.Windows.Forms.TabControl();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsTab = new System.Windows.Forms.TabPage();
            RoomsLabel = new System.Windows.Forms.Label();
            extrasTab = new System.Windows.Forms.TabPage();
            mainMenuStrip.SuspendLayout();
            roomsTab.SuspendLayout();
            this.RoomsListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.RoomInfoGroupBox.SuspendLayout();
            extrasTab.SuspendLayout();
            this.ExtraInfoGroupBox.SuspendLayout();
            this.ItemInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.MenuTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new System.Drawing.Size(541, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            this.closeWorldToolStripMenuItem,
            toolStripMenuItem2,
            this.saveToolStripMenuItem,
            saveAsToolStripMenuItem,
            this.fileSeparatorStripMenuItem,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            newToolStripMenuItem.Text = "&New...";
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            openToolStripMenuItem.Text = "&Open...";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeWorldToolStripMenuItem
            // 
            this.closeWorldToolStripMenuItem.Enabled = false;
            this.closeWorldToolStripMenuItem.Name = "closeWorldToolStripMenuItem";
            this.closeWorldToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeWorldToolStripMenuItem.Text = "Close World";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // fileSeparatorStripMenuItem
            // 
            this.fileSeparatorStripMenuItem.Name = "fileSeparatorStripMenuItem";
            this.fileSeparatorStripMenuItem.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "&Run";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // roomsTab
            // 
            roomsTab.Controls.Add(this.RoomsListGroupBox);
            roomsTab.Controls.Add(this.RoomInfoGroupBox);
            roomsTab.Location = new System.Drawing.Point(4, 22);
            roomsTab.Name = "roomsTab";
            roomsTab.Padding = new System.Windows.Forms.Padding(3);
            roomsTab.Size = new System.Drawing.Size(533, 475);
            roomsTab.TabIndex = 0;
            roomsTab.Text = "Rooms";
            roomsTab.UseVisualStyleBackColor = true;
            // 
            // RoomsListGroupBox
            // 
            this.RoomsListGroupBox.Controls.Add(this.RoomDeleteButton);
            this.RoomsListGroupBox.Controls.Add(this.RoomAddButton);
            this.RoomsListGroupBox.Controls.Add(RoomsLabel);
            this.RoomsListGroupBox.Controls.Add(this.RoomsList);
            this.RoomsListGroupBox.Location = new System.Drawing.Point(3, 6);
            this.RoomsListGroupBox.Name = "RoomsListGroupBox";
            this.RoomsListGroupBox.Size = new System.Drawing.Size(200, 461);
            this.RoomsListGroupBox.TabIndex = 14;
            this.RoomsListGroupBox.TabStop = false;
            // 
            // RoomDeleteButton
            // 
            this.RoomDeleteButton.Location = new System.Drawing.Point(124, 431);
            this.RoomDeleteButton.Name = "RoomDeleteButton";
            this.RoomDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.RoomDeleteButton.TabIndex = 17;
            this.RoomDeleteButton.Text = "&Delete";
            this.RoomDeleteButton.UseVisualStyleBackColor = true;
            // 
            // RoomAddButton
            // 
            this.RoomAddButton.Enabled = false;
            this.RoomAddButton.Location = new System.Drawing.Point(1, 431);
            this.RoomAddButton.Name = "RoomAddButton";
            this.RoomAddButton.Size = new System.Drawing.Size(75, 23);
            this.RoomAddButton.TabIndex = 16;
            this.RoomAddButton.Text = "&Add";
            this.RoomAddButton.UseVisualStyleBackColor = true;
            // 
            // RoomsLabel
            // 
            RoomsLabel.AutoSize = true;
            RoomsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RoomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            RoomsLabel.Location = new System.Drawing.Point(4, 6);
            RoomsLabel.Name = "RoomsLabel";
            RoomsLabel.Size = new System.Drawing.Size(58, 19);
            RoomsLabel.TabIndex = 15;
            RoomsLabel.Text = "Rooms:";
            // 
            // RoomsList
            // 
            this.RoomsList.DataSource = this.roomsBindingSource;
            this.RoomsList.DisplayMember = "Name";
            this.RoomsList.FormattingEnabled = true;
            this.RoomsList.Location = new System.Drawing.Point(1, 31);
            this.RoomsList.Name = "RoomsList";
            this.RoomsList.Size = new System.Drawing.Size(198, 394);
            this.RoomsList.TabIndex = 14;
            this.RoomsList.ValueMember = "Description";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork_Builder.WorldViewModel);
            // 
            // RoomInfoGroupBox
            // 
            this.RoomInfoGroupBox.Controls.Add(this.SouthControl);
            this.RoomInfoGroupBox.Controls.Add(this.WestControl);
            this.RoomInfoGroupBox.Controls.Add(this.EastControl);
            this.RoomInfoGroupBox.Controls.Add(this.NorthControl);
            this.RoomInfoGroupBox.Controls.Add(this.RoomNameText);
            this.RoomInfoGroupBox.Controls.Add(this.RoomDescriptionText);
            this.RoomInfoGroupBox.Controls.Add(this.roomNeighborsLabel);
            this.RoomInfoGroupBox.Controls.Add(this.roomDescriptionLabel);
            this.RoomInfoGroupBox.Controls.Add(this.roomNameLabel);
            this.RoomInfoGroupBox.Location = new System.Drawing.Point(208, 23);
            this.RoomInfoGroupBox.Name = "RoomInfoGroupBox";
            this.RoomInfoGroupBox.Size = new System.Drawing.Size(319, 432);
            this.RoomInfoGroupBox.TabIndex = 2;
            this.RoomInfoGroupBox.TabStop = false;
            this.RoomInfoGroupBox.Text = "Room Info";
            // 
            // SouthControl
            // 
            this.SouthControl.Location = new System.Drawing.Point(87, 352);
            this.SouthControl.Name = "SouthControl";
            this.SouthControl.Size = new System.Drawing.Size(154, 53);
            this.SouthControl.TabIndex = 26;
            // 
            // WestControl
            // 
            this.WestControl.Location = new System.Drawing.Point(159, 293);
            this.WestControl.Name = "WestControl";
            this.WestControl.Size = new System.Drawing.Size(154, 53);
            this.WestControl.TabIndex = 25;
            // 
            // EastControl
            // 
            this.EastControl.Location = new System.Drawing.Point(6, 293);
            this.EastControl.Name = "EastControl";
            this.EastControl.Size = new System.Drawing.Size(154, 53);
            this.EastControl.TabIndex = 24;
            // 
            // NorthControl
            // 
            this.NorthControl.Location = new System.Drawing.Point(87, 234);
            this.NorthControl.Name = "NorthControl";
            this.NorthControl.Size = new System.Drawing.Size(154, 53);
            this.NorthControl.TabIndex = 23;
            this.NorthControl.Load += new System.EventHandler(this.neighborControl1_Load);
            // 
            // RoomNameText
            // 
            this.RoomNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoomNameText.Location = new System.Drawing.Point(6, 38);
            this.RoomNameText.Name = "RoomNameText";
            this.RoomNameText.Size = new System.Drawing.Size(201, 20);
            this.RoomNameText.TabIndex = 22;
            // 
            // RoomDescriptionText
            // 
            this.RoomDescriptionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.RoomDescriptionText.Location = new System.Drawing.Point(0, 83);
            this.RoomDescriptionText.Name = "RoomDescriptionText";
            this.RoomDescriptionText.Size = new System.Drawing.Size(319, 108);
            this.RoomDescriptionText.TabIndex = 21;
            this.RoomDescriptionText.Text = "";
            // 
            // roomNeighborsLabel
            // 
            this.roomNeighborsLabel.AutoSize = true;
            this.roomNeighborsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNeighborsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roomNeighborsLabel.Location = new System.Drawing.Point(127, 201);
            this.roomNeighborsLabel.Name = "roomNeighborsLabel";
            this.roomNeighborsLabel.Size = new System.Drawing.Size(79, 19);
            this.roomNeighborsLabel.TabIndex = 20;
            this.roomNeighborsLabel.Text = "Neighbors:";
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roomDescriptionLabel.Location = new System.Drawing.Point(6, 61);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(85, 19);
            this.roomDescriptionLabel.TabIndex = 19;
            this.roomDescriptionLabel.Text = "Description:";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roomNameLabel.Location = new System.Drawing.Point(6, 16);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(51, 19);
            this.roomNameLabel.TabIndex = 18;
            this.roomNameLabel.Text = "Name:";
            // 
            // extrasTab
            // 
            extrasTab.Controls.Add(this.ExtraInfoGroupBox);
            extrasTab.Controls.Add(this.ItemInfoGroupBox);
            extrasTab.Location = new System.Drawing.Point(4, 22);
            extrasTab.Name = "extrasTab";
            extrasTab.Padding = new System.Windows.Forms.Padding(3);
            extrasTab.Size = new System.Drawing.Size(533, 475);
            extrasTab.TabIndex = 1;
            extrasTab.Text = "Extras";
            extrasTab.UseVisualStyleBackColor = true;
            // 
            // ExtraInfoGroupBox
            // 
            this.ExtraInfoGroupBox.Controls.Add(this.StartingLocationDropDown);
            this.ExtraInfoGroupBox.Controls.Add(this.WelcomeMessageTextBox);
            this.ExtraInfoGroupBox.Controls.Add(this.ExitMessageTextBox);
            this.ExtraInfoGroupBox.Controls.Add(this.ExitMessage);
            this.ExtraInfoGroupBox.Controls.Add(this.WelcomeMessage);
            this.ExtraInfoGroupBox.Controls.Add(this.StartingLocationLabel);
            this.ExtraInfoGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ExtraInfoGroupBox.Name = "ExtraInfoGroupBox";
            this.ExtraInfoGroupBox.Size = new System.Drawing.Size(533, 157);
            this.ExtraInfoGroupBox.TabIndex = 27;
            this.ExtraInfoGroupBox.TabStop = false;
            this.ExtraInfoGroupBox.Text = "Extra Info";
            // 
            // StartingLocationDropDown
            // 
            this.StartingLocationDropDown.FormattingEnabled = true;
            this.StartingLocationDropDown.Location = new System.Drawing.Point(8, 53);
            this.StartingLocationDropDown.Name = "StartingLocationDropDown";
            this.StartingLocationDropDown.Size = new System.Drawing.Size(201, 21);
            this.StartingLocationDropDown.TabIndex = 21;
            // 
            // WelcomeMessageTextBox
            // 
            this.WelcomeMessageTextBox.Location = new System.Drawing.Point(8, 130);
            this.WelcomeMessageTextBox.Name = "WelcomeMessageTextBox";
            this.WelcomeMessageTextBox.Size = new System.Drawing.Size(201, 20);
            this.WelcomeMessageTextBox.TabIndex = 20;
            // 
            // ExitMessageTextBox
            // 
            this.ExitMessageTextBox.Location = new System.Drawing.Point(319, 129);
            this.ExitMessageTextBox.Name = "ExitMessageTextBox";
            this.ExitMessageTextBox.Size = new System.Drawing.Size(201, 20);
            this.ExitMessageTextBox.TabIndex = 19;
            // 
            // ExitMessage
            // 
            this.ExitMessage.AutoSize = true;
            this.ExitMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExitMessage.Location = new System.Drawing.Point(319, 95);
            this.ExitMessage.Name = "ExitMessage";
            this.ExitMessage.Size = new System.Drawing.Size(97, 19);
            this.ExitMessage.TabIndex = 18;
            this.ExitMessage.Text = "Exit Message:";
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WelcomeMessage.Location = new System.Drawing.Point(8, 95);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(133, 19);
            this.WelcomeMessage.TabIndex = 17;
            this.WelcomeMessage.Text = "Welcome Message:";
            // 
            // StartingLocationLabel
            // 
            this.StartingLocationLabel.AutoSize = true;
            this.StartingLocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartingLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartingLocationLabel.Location = new System.Drawing.Point(8, 20);
            this.StartingLocationLabel.Name = "StartingLocationLabel";
            this.StartingLocationLabel.Size = new System.Drawing.Size(121, 19);
            this.StartingLocationLabel.TabIndex = 16;
            this.StartingLocationLabel.Text = "Starting Location:";
            // 
            // ItemInfoGroupBox
            // 
            this.ItemInfoGroupBox.Controls.Add(this.numericUpDown1);
            this.ItemInfoGroupBox.Controls.Add(this.ItemScoreLable);
            this.ItemInfoGroupBox.Controls.Add(this.ItemDescriptionText);
            this.ItemInfoGroupBox.Controls.Add(this.ItemDescription);
            this.ItemInfoGroupBox.Controls.Add(this.ItemNameText);
            this.ItemInfoGroupBox.Controls.Add(this.ItemName);
            this.ItemInfoGroupBox.Controls.Add(this.ItemDeleteButton);
            this.ItemInfoGroupBox.Controls.Add(this.ItemAddButton);
            this.ItemInfoGroupBox.Controls.Add(this.ItemsList);
            this.ItemInfoGroupBox.Controls.Add(this.ItemLabel);
            this.ItemInfoGroupBox.Location = new System.Drawing.Point(0, 163);
            this.ItemInfoGroupBox.Name = "ItemInfoGroupBox";
            this.ItemInfoGroupBox.Size = new System.Drawing.Size(533, 306);
            this.ItemInfoGroupBox.TabIndex = 26;
            this.ItemInfoGroupBox.TabStop = false;
            this.ItemInfoGroupBox.Text = "Item Info";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(271, 234);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 35;
            // 
            // ItemScoreLable
            // 
            this.ItemScoreLable.AutoSize = true;
            this.ItemScoreLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemScoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemScoreLable.Location = new System.Drawing.Point(214, 234);
            this.ItemScoreLable.Name = "ItemScoreLable";
            this.ItemScoreLable.Size = new System.Drawing.Size(51, 19);
            this.ItemScoreLable.TabIndex = 34;
            this.ItemScoreLable.Text = "Score:";
            // 
            // ItemDescriptionText
            // 
            this.ItemDescriptionText.Location = new System.Drawing.Point(214, 106);
            this.ItemDescriptionText.Name = "ItemDescriptionText";
            this.ItemDescriptionText.Size = new System.Drawing.Size(312, 108);
            this.ItemDescriptionText.TabIndex = 33;
            this.ItemDescriptionText.Text = "";
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSize = true;
            this.ItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemDescription.Location = new System.Drawing.Point(214, 86);
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Size = new System.Drawing.Size(85, 19);
            this.ItemDescription.TabIndex = 32;
            this.ItemDescription.Text = "Description:";
            // 
            // ItemNameText
            // 
            this.ItemNameText.Location = new System.Drawing.Point(214, 63);
            this.ItemNameText.Name = "ItemNameText";
            this.ItemNameText.Size = new System.Drawing.Size(204, 20);
            this.ItemNameText.TabIndex = 31;
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemName.Location = new System.Drawing.Point(214, 41);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(51, 19);
            this.ItemName.TabIndex = 30;
            this.ItemName.Text = "Name:";
            // 
            // ItemDeleteButton
            // 
            this.ItemDeleteButton.Location = new System.Drawing.Point(133, 264);
            this.ItemDeleteButton.Name = "ItemDeleteButton";
            this.ItemDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ItemDeleteButton.TabIndex = 29;
            this.ItemDeleteButton.Text = "&Delete";
            this.ItemDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ItemAddButton
            // 
            this.ItemAddButton.Location = new System.Drawing.Point(7, 264);
            this.ItemAddButton.Name = "ItemAddButton";
            this.ItemAddButton.Size = new System.Drawing.Size(75, 23);
            this.ItemAddButton.TabIndex = 28;
            this.ItemAddButton.Text = "&Add";
            this.ItemAddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsList
            // 
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(7, 41);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(201, 212);
            this.ItemsList.TabIndex = 27;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemLabel.Location = new System.Drawing.Point(7, 19);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(47, 19);
            this.ItemLabel.TabIndex = 26;
            this.ItemLabel.Text = "Items:";
            // 
            // MenuTabs
            // 
            this.MenuTabs.Controls.Add(roomsTab);
            this.MenuTabs.Controls.Add(extrasTab);
            this.MenuTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTabs.Location = new System.Drawing.Point(0, 24);
            this.MenuTabs.Name = "MenuTabs";
            this.MenuTabs.SelectedIndex = 0;
            this.MenuTabs.Size = new System.Drawing.Size(541, 501);
            this.MenuTabs.TabIndex = 1;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "JSON Files|*.json";
            // 
            // ZorkBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 525);
            this.Controls.Add(this.MenuTabs);
            this.Controls.Add(mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "ZorkBuilder";
            this.Text = "Zork Builder";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            roomsTab.ResumeLayout(false);
            this.RoomsListGroupBox.ResumeLayout(false);
            this.RoomsListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.RoomInfoGroupBox.ResumeLayout(false);
            this.RoomInfoGroupBox.PerformLayout();
            extrasTab.ResumeLayout(false);
            this.ExtraInfoGroupBox.ResumeLayout(false);
            this.ExtraInfoGroupBox.PerformLayout();
            this.ItemInfoGroupBox.ResumeLayout(false);
            this.ItemInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.MenuTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileSeparatorStripMenuItem;
        private System.Windows.Forms.TabControl MenuTabs;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem closeWorldToolStripMenuItem;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.GroupBox RoomsListGroupBox;
        private System.Windows.Forms.Button RoomDeleteButton;
        private System.Windows.Forms.Button RoomAddButton;
        private System.Windows.Forms.ListBox RoomsList;
        private System.Windows.Forms.GroupBox RoomInfoGroupBox;
        private System.Windows.Forms.TextBox RoomNameText;
        private System.Windows.Forms.RichTextBox RoomDescriptionText;
        private System.Windows.Forms.Label roomNeighborsLabel;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.GroupBox ExtraInfoGroupBox;
        private System.Windows.Forms.ComboBox StartingLocationDropDown;
        private System.Windows.Forms.TextBox WelcomeMessageTextBox;
        private System.Windows.Forms.TextBox ExitMessageTextBox;
        private System.Windows.Forms.Label ExitMessage;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Label StartingLocationLabel;
        private System.Windows.Forms.GroupBox ItemInfoGroupBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label ItemScoreLable;
        private System.Windows.Forms.RichTextBox ItemDescriptionText;
        private System.Windows.Forms.Label ItemDescription;
        private System.Windows.Forms.TextBox ItemNameText;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Button ItemDeleteButton;
        private System.Windows.Forms.Button ItemAddButton;
        private System.Windows.Forms.ListBox ItemsList;
        private System.Windows.Forms.Label ItemLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControls.NeighborControl SouthControl;
        private UserControls.NeighborControl WestControl;
        private UserControls.NeighborControl EastControl;
        private UserControls.NeighborControl NorthControl;
    }
}

