using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Life
{
    public partial class ControlForm : Form
    {
        private readonly DrawPanel lifePanel;
        private readonly LifeSaver lifeSaver = new LifeSaver();

        public ControlForm(DrawPanel drawPanel)
        {
            InitializeComponent();
            this.lifePanel = drawPanel;
            bindingRules = new BindingSource(drawPanel.Rules, null);
            listRules.DataSource = bindingRules;
            comboRule.DataSource = new BindingSource(Enum.GetValues(typeof(CellState)), null);
            comboRuleSet.SelectedIndex = 2;
        }

        private void RefreshBindings()
        {
            bindingRules.ResetBindings(false);
        }

        public event EventHandler InvalidateRequired;
        public event EventHandler ToggleTimer;
        private BindingSource bindingRules;

        private bool _loaded = false;


        private CellRule _selectedRule = null;

        private void listRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedRule = listRules.SelectedItem as CellRule;
            if (_selectedRule != null)
            {
                //numAmount.Value = _selectedRule.Index;
                comboRule.SelectedItem = _selectedRule.State;
            }
        }

        private void comboRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loaded)
            {
                if (_selectedRule != null)
                {
                    if (comboRule.SelectedItem != null)
                    {
                        //_selectedRule.Index = (int)numAmount.Value;
                        _selectedRule.State = (CellState)comboRule.SelectedItem;
                        RefreshBindings();
                    }
                }
            }
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            _loaded = true;
        }

        private void btLoadRule_Click(object sender, EventArgs e)
        {
            if (comboRule.SelectedItem != null)
            {
                DecryptRule(comboRuleSet.Text);
            }
        }

        private void DecryptRule(String ruleString)
        {
            if (ruleString.Contains("/"))
            {
                var parts = ruleString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    try
                    {
                        var stayPart = parts[0];
                        var livingPart = parts[1];

                        foreach (var cellRule in lifePanel.Rules)
                        {
                            cellRule.State = CellState.Die;
                        }
                        foreach (var cellRule in lifePanel.Rules)
                        {
                            foreach (char c in stayPart)
                            {
                                int n = int.Parse(c.ToString(CultureInfo.InvariantCulture));
                                if (cellRule.Index == n)
                                {
                                    cellRule.State = CellState.Stay;
                                }
                            }
                            foreach (char c in livingPart)
                            {
                                int n = int.Parse(c.ToString(CultureInfo.InvariantCulture));
                                if (cellRule.Index == n)
                                {
                                    cellRule.State = CellState.Live;
                                }
                            }
                        }
                        RefreshBindings();
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }
    }
}