namespace Life
{
    partial class ControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.listRules = new System.Windows.Forms.ListBox();
            this.comboRule = new System.Windows.Forms.ComboBox();
            this.btLoadRule = new System.Windows.Forms.Button();
            this.comboRuleSet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listRules
            // 
            this.listRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRules.FormattingEnabled = true;
            this.listRules.Location = new System.Drawing.Point(12, 38);
            this.listRules.Name = "listRules";
            this.listRules.Size = new System.Drawing.Size(780, 186);
            this.listRules.TabIndex = 12;
            this.listRules.SelectedIndexChanged += new System.EventHandler(this.listRules_SelectedIndexChanged);
            // 
            // comboRule
            // 
            this.comboRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRule.FormattingEnabled = true;
            this.comboRule.Location = new System.Drawing.Point(523, 11);
            this.comboRule.Name = "comboRule";
            this.comboRule.Size = new System.Drawing.Size(269, 21);
            this.comboRule.TabIndex = 14;
            this.comboRule.SelectedIndexChanged += new System.EventHandler(this.comboRule_SelectedIndexChanged);
            // 
            // btLoadRule
            // 
            this.btLoadRule.Location = new System.Drawing.Point(12, 9);
            this.btLoadRule.Name = "btLoadRule";
            this.btLoadRule.Size = new System.Drawing.Size(92, 23);
            this.btLoadRule.TabIndex = 17;
            this.btLoadRule.Text = "Load Ruleset";
            this.btLoadRule.UseVisualStyleBackColor = true;
            this.btLoadRule.Click += new System.EventHandler(this.btLoadRule_Click);
            // 
            // comboRuleSet
            // 
            this.comboRuleSet.FormattingEnabled = true;
            this.comboRuleSet.Items.AddRange(new object[] {
            "3/3",
            "13/3",
            "23/3",
            "34/3",
            "35/3",
            "236/3",
            "135/35",
            "12345/3",
            "1357/1357",
            "24/35",
            "0123/01234",
            "01234678/0123478",
            "01234678/0123678",
            "02468/02468"});
            this.comboRuleSet.Location = new System.Drawing.Point(110, 9);
            this.comboRuleSet.Name = "comboRuleSet";
            this.comboRuleSet.Size = new System.Drawing.Size(190, 21);
            this.comboRuleSet.TabIndex = 18;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 231);
            this.Controls.Add(this.comboRuleSet);
            this.Controls.Add(this.btLoadRule);
            this.Controls.Add(this.comboRule);
            this.Controls.Add(this.listRules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rule Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlForm_FormClosing);
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRules;
        private System.Windows.Forms.ComboBox comboRule;
        private System.Windows.Forms.Button btLoadRule;
        private System.Windows.Forms.ComboBox comboRuleSet;
    }
}