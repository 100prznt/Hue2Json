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
        public SensorCapability SensorResources { get; set; }

        public CapabilitySensorDetailsView(SensorCapability sensorCapabilities)
        {
            SensorResources = sensorCapabilities;

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
            cat_Capabilities.Series["clip"].Points.AddY(SensorResources.Clip.InUsePercent);
            cat_Capabilities.Series["clip"].IsVisibleInLegend = false;
            cat_Capabilities.Series["clip"].Label = "Clip";
            //cat_Capabilities.Series["clip"].CustomProperties = "MinPixelPointWidth=150";
            //cat_Capabilities.Series["clip"].SetCustomProperty("MinPixelPointWidth", "80");
            cat_Capabilities.Series["clip"]["MinPixelPointWidth"] = "230";

            cat_Capabilities.Series.Add("zgp");
            cat_Capabilities.Series["zgp"].Points.AddY(SensorResources.Zgp.InUsePercent);
            cat_Capabilities.Series["zgp"].IsVisibleInLegend = false;
            cat_Capabilities.Series["zgp"].Label = "ZGP";
            //cat_Capabilities.Series["zgp"].SetCustomProperty("MinPixelPointWidth", "80");
            cat_Capabilities.Series["zgp"]["MinPixelPointWidth"] = "230";

            cat_Capabilities.Series.Add("zll");
            cat_Capabilities.Series["zll"].Points.AddY(SensorResources.Zll.InUsePercent);
            cat_Capabilities.Series["zll"].IsVisibleInLegend = false;
            cat_Capabilities.Series["zll"].Label = "ZLL";
            //cat_Capabilities.Series["zll"].SetCustomProperty("MinPixelPointWidth", "80");
            cat_Capabilities.Series["zll"]["MinPixelPointWidth"] = "230";

            cat_Capabilities.Update();
            cat_Capabilities.PerformLayout();

            lbl_Clip.Text = SensorResources.Clip.InUse + "/" + SensorResources.Clip.Available + " (" + SensorResources.Clip.InUsePercent.ToString("F1") + " %)";
            lbl_Zll.Text = SensorResources.Zll.InUse + "/" + SensorResources.Zll.Available + " (" + SensorResources.Zll.InUsePercent.ToString("F1") + " %)";
            lbl_Zgp.Text = SensorResources.Zgp.InUse + "/" + SensorResources.Zgp.Available + " (" + SensorResources.Zgp.InUsePercent.ToString("F1") + " %)";

            lbl_DimmerSwitch.Text = DeviceRessources.HueDimmerSwitch.GetMaxAmountString(SensorResources).ToString();
            lbl_MotionSensor.Text = DeviceRessources.HueMotionSensor.GetMaxAmountString(SensorResources).ToString();
            lbl_SmartButton.Text = DeviceRessources.HueSmartButton.GetMaxAmountString(SensorResources).ToString();
        }

        private class DeviceRessources
        {
            public int ZllCount { get; }
            public int ZgpCount { get; }
            public int ClipCount { get; }

            public DeviceRessources(int zll, int zgp, int clip)
            {
                ZllCount = zll;
                ZgpCount = zgp;
                ClipCount = clip;
            }

            public string GetMaxAmountString(SensorCapability capability)
            {
                var spaces = new List<int>
                {
                    (int)Math.Floor((double)capability.Zll.Available / ZllCount),
                    (int)Math.Floor((double)capability.Zgp.Available / ZgpCount),
                    (int)Math.Floor((double)capability.Clip.Available / ClipCount)
                };

                var i = spaces.IndexOf(spaces.Min());

                var result = new StringBuilder(spaces[i].ToString());

                //Schön ist anders...
                switch (i)
                {
                    case 0:
                        result.Append($" ({spaces[i] * ZllCount} ZLL)");
                        break;
                    case 1:
                        result.Append($" ({spaces[i] * ZgpCount} ZGP)");
                        break;
                    case 2:
                        result.Append($" ({spaces[i] * ClipCount} Clip)");
                        break;
                    default:
                        break;
                }

                return result.ToString();
            }

            public static DeviceRessources HueMotionSensor => new DeviceRessources(1, 0, 0);
            public static DeviceRessources HueDimmerSwitch => new DeviceRessources(1, 0, 0);
            public static DeviceRessources HueSmartButton => new DeviceRessources(1, 0, 0);
        }
    }
}