using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Rca.Hue2Json.View
{
    public partial class CapabilitySensorDetailsView : Form
    {
        public HueCapabilities Capabilities { get; set; }

        public CapabilitySensorDetailsView(HueCapabilities capabilities)
        {
            Capabilities = capabilities;

            InitializeComponent();

            drawChart();
        }

        private void drawChart()
        {
            cat_Capabilities.Series.Clear();

            cat_Capabilities.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            cat_Capabilities.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            cat_Capabilities.ChartAreas[0].AxisY.Interval = 10;
            cat_Capabilities.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;
            cat_Capabilities.ChartAreas[0].AxisY.Minimum = 0;
            cat_Capabilities.ChartAreas[0].AxisY.Maximum = 100;
            cat_Capabilities.ChartAreas[0].AxisY.Title = "Belegung in %";

            cat_Capabilities.Series.Add("clip");
            cat_Capabilities.Series["clip"].Points.AddY(Capabilities.RulesInUsePercent.Count);
            cat_Capabilities.Series["clip"].IsVisibleInLegend = false;
            cat_Capabilities.Series["clip"].Label = "Clip";
            //cat_Capabilities.Series["clip"].CustomProperties = "MinPixelPointWidth=150";
            //cat_Capabilities.Series["clip"].SetCustomProperty("MinPixelPointWidth", "80");
            cat_Capabilities.Series["clip"]["MinPixelPointWidth"] = "230";

            cat_Capabilities.Series.Add("zgp");
            cat_Capabilities.Series["zgp"].Points.AddY(Capabilities.RulesInUsePercent.Actions);
            cat_Capabilities.Series["zgp"].IsVisibleInLegend = false;
            cat_Capabilities.Series["zgp"].Label = "ZGP";
            //cat_Capabilities.Series["zgp"].SetCustomProperty("MinPixelPointWidth", "80");
            cat_Capabilities.Series["zgp"]["MinPixelPointWidth"] = "230";

            cat_Capabilities.Series.Add("zll");
            cat_Capabilities.Series["zll"].Points.AddY(Capabilities.RulesInUsePercent.Conditions);
            cat_Capabilities.Series["zll"].IsVisibleInLegend = false;
            cat_Capabilities.Series["zll"].Label = "ZLL";
            //cat_Capabilities.Series["zll"].SetCustomProperty("MinPixelPointWidth", "80");
            cat_Capabilities.Series["zll"]["MinPixelPointWidth"] = "230";

            cat_Capabilities.Update();
            cat_Capabilities.PerformLayout();

            lbl_Rules.Text = Capabilities.RulesInUse.Count + "/" + Capabilities.RulesAvailable.Count + " (" + Capabilities.RulesInUsePercent.Count.ToString("F1") + " %)";
            lbl_Conditions.Text = Capabilities.RulesInUse.Conditions + "/" + Capabilities.RulesAvailable.Conditions + " (" + Capabilities.RulesInUsePercent.Conditions.ToString("F1") + " %)";
            lbl_Actions.Text = Capabilities.RulesInUse.Actions + "/" + Capabilities.RulesAvailable.Actions + " (" + Capabilities.RulesInUsePercent.Actions.ToString("F1") + " %)";

            lbl_ActionsPerRule.Text = Capabilities.MeanActions.ToString("F2");
            lbl_ConditionsPerRule.Text = Capabilities.MeanConditions.ToString("F2");

            double maxValue = Capabilities.RulesInUsePercent.Count;
            string freeSpaceText = (Capabilities.RulesAvailable.Count - Capabilities.RulesInUse.Count) + " Regeln (Regellimit)";
            if (Capabilities.RulesInUsePercent.Conditions > maxValue)
            {
                maxValue = Capabilities.RulesInUsePercent.Conditions;
                freeSpaceText = (Capabilities.RulesAvailable.Conditions - Capabilities.RulesInUse.Conditions) + " Regeln (Bedingungslimit)";
            }
            if (Capabilities.RulesInUsePercent.Actions > maxValue)
                freeSpaceText = (Capabilities.RulesAvailable.Actions - Capabilities.RulesInUse.Actions) + " Regeln (Aktionslimit)";
            

            lbl_FreeSpace.Text = freeSpaceText;
        }
    }
}