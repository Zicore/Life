namespace Life
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.trackUpdate = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ruleEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameOfLifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wireworldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewLife = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRandom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNextCycle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonToggle = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUpdateRate = new System.Windows.Forms.Label();
            this.lifePanel = new Life.DrawPanel();
            this.lblGenerations = new System.Windows.Forms.Label();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackUpdate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.lifePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 80;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // trackUpdate
            // 
            this.trackUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackUpdate.AutoSize = false;
            this.trackUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.trackUpdate.LargeChange = 10;
            this.trackUpdate.Location = new System.Drawing.Point(0, 543);
            this.trackUpdate.Maximum = 500;
            this.trackUpdate.Minimum = 10;
            this.trackUpdate.Name = "trackUpdate";
            this.trackUpdate.Size = new System.Drawing.Size(213, 19);
            this.trackUpdate.SmallChange = 10;
            this.trackUpdate.TabIndex = 5;
            this.trackUpdate.TickFrequency = 10;
            this.trackUpdate.Value = 80;
            this.trackUpdate.Scroll += new System.EventHandler(this.trackUpdate_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator3,
            this.ruleEditorToolStripMenuItem});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Life.Properties.Resources.NewDocumentHS;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::Life.Properties.Resources.OpenFile;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.loadToolStripMenuItem.Text = "Load from clipboard";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Life.Properties.Resources.saveHS;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveToolStripMenuItem.Text = "Save to clipboard";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // ruleEditorToolStripMenuItem
            // 
            this.ruleEditorToolStripMenuItem.Name = "ruleEditorToolStripMenuItem";
            this.ruleEditorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ruleEditorToolStripMenuItem.Text = "Rule Editor";
            this.ruleEditorToolStripMenuItem.Click += new System.EventHandler(this.ruleEditorToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameOfLifeToolStripMenuItem,
            this.wireworldToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.gameToolStripMenuItem.Text = "Game Mode";
            // 
            // gameOfLifeToolStripMenuItem
            // 
            this.gameOfLifeToolStripMenuItem.Name = "gameOfLifeToolStripMenuItem";
            this.gameOfLifeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.gameOfLifeToolStripMenuItem.Text = "Game of Life";
            this.gameOfLifeToolStripMenuItem.Click += new System.EventHandler(this.gameOfLifeToolStripMenuItem_Click);
            // 
            // wireworldToolStripMenuItem
            // 
            this.wireworldToolStripMenuItem.Name = "wireworldToolStripMenuItem";
            this.wireworldToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.wireworldToolStripMenuItem.Text = "Wireworld";
            this.wireworldToolStripMenuItem.Click += new System.EventHandler(this.wireworldToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewLife,
            this.toolStripButtonRandom,
            this.toolStripSeparator2,
            this.toolStripButtonLoad,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonStop,
            this.toolStripButtonNextCycle,
            this.toolStripButtonToggle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(803, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNewLife
            // 
            this.toolStripButtonNewLife.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewLife.Image = global::Life.Properties.Resources.NewDocumentHS;
            this.toolStripButtonNewLife.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNewLife.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewLife.Name = "toolStripButtonNewLife";
            this.toolStripButtonNewLife.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewLife.Text = "New";
            this.toolStripButtonNewLife.Click += new System.EventHandler(this.toolStripButtonNewLife_Click);
            // 
            // toolStripButtonRandom
            // 
            this.toolStripButtonRandom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRandom.Image = global::Life.Properties.Resources.Random;
            this.toolStripButtonRandom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRandom.Name = "toolStripButtonRandom";
            this.toolStripButtonRandom.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRandom.Text = "Random Life";
            this.toolStripButtonRandom.Click += new System.EventHandler(this.toolStripButtonRandom_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoad.Image = global::Life.Properties.Resources.OpenFile;
            this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLoad.Text = "Load from clipboard";
            this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::Life.Properties.Resources.saveHS;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Save to clipboard";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonNextCycle
            // 
            this.toolStripButtonNextCycle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNextCycle.Image = global::Life.Properties.Resources.RightArrowHS;
            this.toolStripButtonNextCycle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNextCycle.Name = "toolStripButtonNextCycle";
            this.toolStripButtonNextCycle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNextCycle.Text = "Next Cycle";
            this.toolStripButtonNextCycle.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtonToggle
            // 
            this.toolStripButtonToggle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonToggle.Image = global::Life.Properties.Resources.PlayHS;
            this.toolStripButtonToggle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonToggle.Name = "toolStripButtonToggle";
            this.toolStripButtonToggle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonToggle.Text = "Toggle Simulation";
            this.toolStripButtonToggle.Click += new System.EventHandler(this.toolStripButtonToggle_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUpdateRate
            // 
            this.lblUpdateRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdateRate.Location = new System.Drawing.Point(219, 544);
            this.lblUpdateRate.Margin = new System.Windows.Forms.Padding(3);
            this.lblUpdateRate.Name = "lblUpdateRate";
            this.lblUpdateRate.Size = new System.Drawing.Size(137, 18);
            this.lblUpdateRate.TabIndex = 6;
            this.lblUpdateRate.Text = "80 ms";
            this.lblUpdateRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lifePanel
            // 
            this.lifePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lifePanel.BackColor = System.Drawing.SystemColors.Control;
            this.lifePanel.Controls.Add(this.lblGenerations);
            this.lifePanel.GameMode = Life.GameMode.WireWorld;
            this.lifePanel.Generation = 0;
            this.lifePanel.Location = new System.Drawing.Point(0, 49);
            this.lifePanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lifePanel.Name = "lifePanel";
            this.lifePanel.Size = new System.Drawing.Size(803, 492);
            this.lifePanel.TabIndex = 0;
            // 
            // lblGenerations
            // 
            this.lblGenerations.AutoSize = true;
            this.lblGenerations.Location = new System.Drawing.Point(12, 9);
            this.lblGenerations.Name = "lblGenerations";
            this.lblGenerations.Size = new System.Drawing.Size(76, 13);
            this.lblGenerations.TabIndex = 4;
            this.lblGenerations.Text = "Generations: 0";
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = global::Life.Properties.Resources.StopHS;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 563);
            this.Controls.Add(this.lblUpdateRate);
            this.Controls.Add(this.trackUpdate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lifePanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life";
            ((System.ComponentModel.ISupportInitialize)(this.trackUpdate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.lifePanel.ResumeLayout(false);
            this.lifePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrawPanel lifePanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblGenerations;
        private System.Windows.Forms.TrackBar trackUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonToggle;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewLife;
        private System.Windows.Forms.ToolStripButton toolStripButtonNextCycle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
        private System.Windows.Forms.ToolStripButton toolStripButtonRandom;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ruleEditorToolStripMenuItem;
        private System.Windows.Forms.Label lblUpdateRate;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameOfLifeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wireworldToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
    }
}

