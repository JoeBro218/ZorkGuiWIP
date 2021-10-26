
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SouthDropBox = new System.Windows.Forms.ComboBox();
            this.NorthDropBox = new System.Windows.Forms.ComboBox();
            this.WestDropBox = new System.Windows.Forms.ComboBox();
            this.EastDropBox = new System.Windows.Forms.ComboBox();
            this.RoomDeleteButton = new System.Windows.Forms.Button();
            this.RoomAddButton = new System.Windows.Forms.Button();
            this.WestLabel = new System.Windows.Forms.Label();
            this.EastLabel = new System.Windows.Forms.Label();
            this.SouthLabel = new System.Windows.Forms.Label();
            this.NorthLable = new System.Windows.Forms.Label();
            this.RoomNameText = new System.Windows.Forms.TextBox();
            this.RoomDescriptionText = new System.Windows.Forms.RichTextBox();
            this.NeighborsLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.RoomsList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.StartingLocationDropDown = new System.Windows.Forms.ComboBox();
            this.WelcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.ExitMessageTextBox = new System.Windows.Forms.TextBox();
            this.ExitMessage = new System.Windows.Forms.Label();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.StartingLocationLabel = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.MenuTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // MenuTabs
            // 
            this.MenuTabs.Controls.Add(this.tabPage1);
            this.MenuTabs.Controls.Add(this.tabPage2);
            this.MenuTabs.Location = new System.Drawing.Point(0, 28);
            this.MenuTabs.Name = "MenuTabs";
            this.MenuTabs.SelectedIndex = 0;
            this.MenuTabs.Size = new System.Drawing.Size(541, 495);
            this.MenuTabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SouthDropBox);
            this.tabPage1.Controls.Add(this.NorthDropBox);
            this.tabPage1.Controls.Add(this.WestDropBox);
            this.tabPage1.Controls.Add(this.EastDropBox);
            this.tabPage1.Controls.Add(this.RoomDeleteButton);
            this.tabPage1.Controls.Add(this.RoomAddButton);
            this.tabPage1.Controls.Add(this.WestLabel);
            this.tabPage1.Controls.Add(this.EastLabel);
            this.tabPage1.Controls.Add(this.SouthLabel);
            this.tabPage1.Controls.Add(this.NorthLable);
            this.tabPage1.Controls.Add(this.RoomNameText);
            this.tabPage1.Controls.Add(this.RoomDescriptionText);
            this.tabPage1.Controls.Add(this.NeighborsLabel);
            this.tabPage1.Controls.Add(this.DescriptionLabel);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.RoomsLabel);
            this.tabPage1.Controls.Add(this.RoomsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SouthDropBox
            // 
            this.SouthDropBox.FormattingEnabled = true;
            this.SouthDropBox.Location = new System.Drawing.Point(308, 414);
            this.SouthDropBox.Name = "SouthDropBox";
            this.SouthDropBox.Size = new System.Drawing.Size(121, 21);
            this.SouthDropBox.TabIndex = 17;
            // 
            // NorthDropBox
            // 
            this.NorthDropBox.FormattingEnabled = true;
            this.NorthDropBox.Location = new System.Drawing.Point(308, 290);
            this.NorthDropBox.Name = "NorthDropBox";
            this.NorthDropBox.Size = new System.Drawing.Size(121, 21);
            this.NorthDropBox.TabIndex = 16;
            // 
            // WestDropBox
            // 
            this.WestDropBox.FormattingEnabled = true;
            this.WestDropBox.Location = new System.Drawing.Point(402, 352);
            this.WestDropBox.Name = "WestDropBox";
            this.WestDropBox.Size = new System.Drawing.Size(121, 21);
            this.WestDropBox.TabIndex = 15;
            // 
            // EastDropBox
            // 
            this.EastDropBox.FormattingEnabled = true;
            this.EastDropBox.Location = new System.Drawing.Point(211, 352);
            this.EastDropBox.Name = "EastDropBox";
            this.EastDropBox.Size = new System.Drawing.Size(121, 21);
            this.EastDropBox.TabIndex = 14;
            // 
            // RoomDeleteButton
            // 
            this.RoomDeleteButton.Location = new System.Drawing.Point(127, 432);
            this.RoomDeleteButton.Name = "RoomDeleteButton";
            this.RoomDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.RoomDeleteButton.TabIndex = 13;
            this.RoomDeleteButton.Text = "&Delete";
            this.RoomDeleteButton.UseVisualStyleBackColor = true;
            this.RoomDeleteButton.Click += new System.EventHandler(this.RoomDeleteButton_Click);
            // 
            // RoomAddButton
            // 
            this.RoomAddButton.Location = new System.Drawing.Point(4, 432);
            this.RoomAddButton.Name = "RoomAddButton";
            this.RoomAddButton.Size = new System.Drawing.Size(75, 23);
            this.RoomAddButton.TabIndex = 12;
            this.RoomAddButton.Text = "&Add";
            this.RoomAddButton.UseVisualStyleBackColor = true;
            this.RoomAddButton.Click += new System.EventHandler(this.RoomAddButton_Click);
            // 
            // WestLabel
            // 
            this.WestLabel.AutoSize = true;
            this.WestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WestLabel.Location = new System.Drawing.Point(443, 321);
            this.WestLabel.Name = "WestLabel";
            this.WestLabel.Size = new System.Drawing.Size(42, 19);
            this.WestLabel.TabIndex = 11;
            this.WestLabel.Text = "West";
            // 
            // EastLabel
            // 
            this.EastLabel.AutoSize = true;
            this.EastLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EastLabel.Location = new System.Drawing.Point(255, 321);
            this.EastLabel.Name = "EastLabel";
            this.EastLabel.Size = new System.Drawing.Size(38, 19);
            this.EastLabel.TabIndex = 10;
            this.EastLabel.Text = "East";
            // 
            // SouthLabel
            // 
            this.SouthLabel.AutoSize = true;
            this.SouthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SouthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SouthLabel.Location = new System.Drawing.Point(350, 381);
            this.SouthLabel.Name = "SouthLabel";
            this.SouthLabel.Size = new System.Drawing.Size(47, 19);
            this.SouthLabel.TabIndex = 9;
            this.SouthLabel.Text = "South";
            // 
            // NorthLable
            // 
            this.NorthLable.AutoSize = true;
            this.NorthLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NorthLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NorthLable.Location = new System.Drawing.Point(350, 259);
            this.NorthLable.Name = "NorthLable";
            this.NorthLable.Size = new System.Drawing.Size(45, 19);
            this.NorthLable.TabIndex = 8;
            this.NorthLable.Text = "North";
            // 
            // RoomNameText
            // 
            this.RoomNameText.Location = new System.Drawing.Point(211, 55);
            this.RoomNameText.Name = "RoomNameText";
            this.RoomNameText.Size = new System.Drawing.Size(201, 20);
            this.RoomNameText.TabIndex = 7;
            // 
            // RoomDescriptionText
            // 
            this.RoomDescriptionText.Location = new System.Drawing.Point(208, 98);
            this.RoomDescriptionText.Name = "RoomDescriptionText";
            this.RoomDescriptionText.Size = new System.Drawing.Size(319, 108);
            this.RoomDescriptionText.TabIndex = 6;
            this.RoomDescriptionText.Text = "";
            // 
            // NeighborsLabel
            // 
            this.NeighborsLabel.AutoSize = true;
            this.NeighborsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NeighborsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NeighborsLabel.Location = new System.Drawing.Point(335, 218);
            this.NeighborsLabel.Name = "NeighborsLabel";
            this.NeighborsLabel.Size = new System.Drawing.Size(79, 19);
            this.NeighborsLabel.TabIndex = 5;
            this.NeighborsLabel.Text = "Neighbors:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescriptionLabel.Location = new System.Drawing.Point(208, 78);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(85, 19);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameLabel.Location = new System.Drawing.Point(208, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 19);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RoomsLabel.Location = new System.Drawing.Point(7, 7);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(58, 19);
            this.RoomsLabel.TabIndex = 2;
            this.RoomsLabel.Text = "Rooms:";
            // 
            // RoomsList
            // 
            this.RoomsList.FormattingEnabled = true;
            this.RoomsList.Location = new System.Drawing.Point(4, 32);
            this.RoomsList.Name = "RoomsList";
            this.RoomsList.Size = new System.Drawing.Size(198, 394);
            this.RoomsList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.ItemScoreLable);
            this.tabPage2.Controls.Add(this.ItemDescriptionText);
            this.tabPage2.Controls.Add(this.ItemDescription);
            this.tabPage2.Controls.Add(this.ItemNameText);
            this.tabPage2.Controls.Add(this.ItemName);
            this.tabPage2.Controls.Add(this.ItemDeleteButton);
            this.tabPage2.Controls.Add(this.ItemAddButton);
            this.tabPage2.Controls.Add(this.ItemsList);
            this.tabPage2.Controls.Add(this.ItemLabel);
            this.tabPage2.Controls.Add(this.StartingLocationDropDown);
            this.tabPage2.Controls.Add(this.WelcomeMessageTextBox);
            this.tabPage2.Controls.Add(this.ExitMessageTextBox);
            this.tabPage2.Controls.Add(this.ExitMessage);
            this.tabPage2.Controls.Add(this.WelcomeMessage);
            this.tabPage2.Controls.Add(this.StartingLocationLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(272, 410);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 25;
            // 
            // ItemScoreLable
            // 
            this.ItemScoreLable.AutoSize = true;
            this.ItemScoreLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemScoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemScoreLable.Location = new System.Drawing.Point(215, 410);
            this.ItemScoreLable.Name = "ItemScoreLable";
            this.ItemScoreLable.Size = new System.Drawing.Size(51, 19);
            this.ItemScoreLable.TabIndex = 24;
            this.ItemScoreLable.Text = "Score:";
            // 
            // ItemDescriptionText
            // 
            this.ItemDescriptionText.Location = new System.Drawing.Point(215, 282);
            this.ItemDescriptionText.Name = "ItemDescriptionText";
            this.ItemDescriptionText.Size = new System.Drawing.Size(312, 108);
            this.ItemDescriptionText.TabIndex = 23;
            this.ItemDescriptionText.Text = "";
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSize = true;
            this.ItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemDescription.Location = new System.Drawing.Point(215, 262);
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Size = new System.Drawing.Size(85, 19);
            this.ItemDescription.TabIndex = 22;
            this.ItemDescription.Text = "Description:";
            // 
            // ItemNameText
            // 
            this.ItemNameText.Location = new System.Drawing.Point(215, 239);
            this.ItemNameText.Name = "ItemNameText";
            this.ItemNameText.Size = new System.Drawing.Size(204, 20);
            this.ItemNameText.TabIndex = 21;
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemName.Location = new System.Drawing.Point(215, 217);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(51, 19);
            this.ItemName.TabIndex = 20;
            this.ItemName.Text = "Name:";
            // 
            // ItemDeleteButton
            // 
            this.ItemDeleteButton.Location = new System.Drawing.Point(134, 440);
            this.ItemDeleteButton.Name = "ItemDeleteButton";
            this.ItemDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ItemDeleteButton.TabIndex = 19;
            this.ItemDeleteButton.Text = "&Delete";
            this.ItemDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ItemAddButton
            // 
            this.ItemAddButton.Location = new System.Drawing.Point(8, 440);
            this.ItemAddButton.Name = "ItemAddButton";
            this.ItemAddButton.Size = new System.Drawing.Size(75, 23);
            this.ItemAddButton.TabIndex = 18;
            this.ItemAddButton.Text = "&Add";
            this.ItemAddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsList
            // 
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(8, 217);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(201, 212);
            this.ItemsList.TabIndex = 17;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemLabel.Location = new System.Drawing.Point(8, 187);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(47, 19);
            this.ItemLabel.TabIndex = 16;
            this.ItemLabel.Text = "Items:";
            // 
            // StartingLocationDropDown
            // 
            this.StartingLocationDropDown.FormattingEnabled = true;
            this.StartingLocationDropDown.Location = new System.Drawing.Point(8, 48);
            this.StartingLocationDropDown.Name = "StartingLocationDropDown";
            this.StartingLocationDropDown.Size = new System.Drawing.Size(201, 21);
            this.StartingLocationDropDown.TabIndex = 15;
            // 
            // WelcomeMessageTextBox
            // 
            this.WelcomeMessageTextBox.Location = new System.Drawing.Point(8, 125);
            this.WelcomeMessageTextBox.Name = "WelcomeMessageTextBox";
            this.WelcomeMessageTextBox.Size = new System.Drawing.Size(201, 20);
            this.WelcomeMessageTextBox.TabIndex = 9;
            // 
            // ExitMessageTextBox
            // 
            this.ExitMessageTextBox.Location = new System.Drawing.Point(319, 124);
            this.ExitMessageTextBox.Name = "ExitMessageTextBox";
            this.ExitMessageTextBox.Size = new System.Drawing.Size(201, 20);
            this.ExitMessageTextBox.TabIndex = 8;
            // 
            // ExitMessage
            // 
            this.ExitMessage.AutoSize = true;
            this.ExitMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExitMessage.Location = new System.Drawing.Point(319, 90);
            this.ExitMessage.Name = "ExitMessage";
            this.ExitMessage.Size = new System.Drawing.Size(97, 19);
            this.ExitMessage.TabIndex = 5;
            this.ExitMessage.Text = "Exit Message:";
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WelcomeMessage.Location = new System.Drawing.Point(8, 90);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(133, 19);
            this.WelcomeMessage.TabIndex = 4;
            this.WelcomeMessage.Text = "Welcome Message:";
            // 
            // StartingLocationLabel
            // 
            this.StartingLocationLabel.AutoSize = true;
            this.StartingLocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartingLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartingLocationLabel.Location = new System.Drawing.Point(8, 15);
            this.StartingLocationLabel.Name = "StartingLocationLabel";
            this.StartingLocationLabel.Size = new System.Drawing.Size(121, 19);
            this.StartingLocationLabel.TabIndex = 3;
            this.StartingLocationLabel.Text = "Starting Location:";
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ZorkBuilder";
            this.Text = "Zork Builder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl MenuTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label NeighborsLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.ListBox RoomsList;
        private System.Windows.Forms.RichTextBox RoomDescriptionText;
        private System.Windows.Forms.TextBox RoomNameText;
        private System.Windows.Forms.Label WestLabel;
        private System.Windows.Forms.Label EastLabel;
        private System.Windows.Forms.Label SouthLabel;
        private System.Windows.Forms.Label NorthLable;
        private System.Windows.Forms.Button RoomDeleteButton;
        private System.Windows.Forms.Button RoomAddButton;
        private System.Windows.Forms.ComboBox SouthDropBox;
        private System.Windows.Forms.ComboBox NorthDropBox;
        private System.Windows.Forms.ComboBox WestDropBox;
        private System.Windows.Forms.ComboBox EastDropBox;
        private System.Windows.Forms.ComboBox StartingLocationDropDown;
        private System.Windows.Forms.TextBox WelcomeMessageTextBox;
        private System.Windows.Forms.TextBox ExitMessageTextBox;
        private System.Windows.Forms.Label ExitMessage;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Label StartingLocationLabel;
        private System.Windows.Forms.ListBox ItemsList;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Button ItemDeleteButton;
        private System.Windows.Forms.Button ItemAddButton;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.RichTextBox ItemDescriptionText;
        private System.Windows.Forms.Label ItemDescription;
        private System.Windows.Forms.TextBox ItemNameText;
        private System.Windows.Forms.Label ItemScoreLable;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

