using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.Blob;
using Cognex.VisionPro.Caliper;
using Cognex.VisionPro.ImageProcessing;

namespace VisionPro
{
    public partial class Form1 : Form
    {
        CogImageFileTool m_cogImageFile;
        CogHistogramTool m_cogHistogramTool;
        CogCaliperTool m_cogCaliperTool;
        ROI m_roi;
        Panel panel;
        CogRectangle m_cogRec;
        CogRectangleAffine m_cogRectAffine;
        String edge0 = "Any Polarity";
        String edge1 = "Any Polarity";
        

        public Form1()
        {
            InitializeComponent();
            m_cogImageFile = new CogImageFileTool();
            m_cogHistogramTool = new CogHistogramTool();
            m_cogCaliperTool = new CogCaliperTool();
            m_cogRec = new CogRectangle();
            m_cogRectAffine = new CogRectangleAffine();

            m_roi = new ROI();
            Panel tempPanel = new Panel();
            panel = new Panel();
            panel.Height = 65;

            m_HistogramInput.Controls.Add(panel);
            panel.Controls.Add(tempPanel);
            tempPanel.Controls.Add(m_roi);

            m_roi.Dock = DockStyle.Fill;
            panel.Dock = DockStyle.Top;
            tempPanel.Dock = DockStyle.Top;

            m_roi.m_comboBoxROI.SelectedIndexChanged += m_comboBoxROI_SelectedIndexChanged;
        }

        private void m_OpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog m_ofd = new OpenFileDialog();
                m_ofd.Filter = "All files (*.*)|*.*";
                if(m_ofd.ShowDialog() == DialogResult.OK)
                {
                    m_cogImageFile.Operator.Open(m_ofd.FileName, CogImageFileModeConstants.Read);
                    m_cogImageFile.Run();
                    cogDisplay1.Display.Image = m_cogImageFile.OutputImage;
                    cogDisplay1.Display.Fit();
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void m_RunBtn_Click(object sender, EventArgs e)
        {
            if (m_cogImageFile.OutputImage == null)
            {
                MessageBox.Show("No Image Selected");
                return;
            }
            if (tabControl1.SelectedTab.Name == "m_HistogramTab")
                runHistogram();
            else if (tabControl1.SelectedTab.Name == "m_BlobTab")
                runBlob();
            else if (tabControl1.SelectedTab.Name == "m_CaliperTab")
                runCaliper();
            
        }

        private void runHistogram()
        {
            if(m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangle")
                m_cogHistogramTool.Region = m_cogRec;
            else if(m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangleAffine")
                m_cogHistogramTool.Region = m_cogRectAffine;

            m_cogHistogramTool.InputImage = m_cogImageFile.OutputImage;
            m_cogHistogramTool.Run();

            m_tbMin.Text = m_cogHistogramTool.Result.Minimum.ToString();
            m_tbMax.Text = m_cogHistogramTool.Result.Maximum.ToString();
            m_tbMedian.Text = m_cogHistogramTool.Result.Median.ToString();
            m_tbMode.Text = m_cogHistogramTool.Result.Mode.ToString();
            m_tbMean.Text = m_cogHistogramTool.Result.Mean.ToString("F4");
            m_tbSD.Text = m_cogHistogramTool.Result.StandardDeviation.ToString("F4");
            m_tbVariance.Text = m_cogHistogramTool.Result.Variance.ToString("F4");
            m_tbSample.Text = m_cogHistogramTool.Result.NumSamples.ToString();

            cogDisplay1.Tool = m_cogHistogramTool;

        }

        private void runBlob()
        {

        }

        private void runCaliper()
        {
            if (m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangleAffine")
                m_cogCaliperTool.Region = m_cogRectAffine;
            m_cogCaliperTool.InputImage = m_cogImageFile.OutputImage;
            m_cogCaliperTool.RunParams.EdgeMode = CogCaliperEdgeModeConstants.SingleEdge;
            m_cogCaliperTool.RunParams.Edge1Position = (double)m_NumEdgePairWidth.Value;

            switch (edge0)
            {
                case "Dark to Light":
                    m_cogCaliperTool.RunParams.Edge0Polarity = CogCaliperPolarityConstants.DarkToLight;
                    break;
                case "Light to Dark":
                    m_cogCaliperTool.RunParams.Edge0Polarity = CogCaliperPolarityConstants.LightToDark;
                    break;
                default:
                    m_cogCaliperTool.RunParams.Edge0Polarity = CogCaliperPolarityConstants.DontCare; break;
            }

            if(m_gbEdge1Polarity.Enabled)
            {
                m_cogCaliperTool.RunParams.EdgeMode = CogCaliperEdgeModeConstants.Pair;
                switch (edge1)
                {
                    case "Dark to Light":
                        m_cogCaliperTool.RunParams.Edge1Polarity = CogCaliperPolarityConstants.DarkToLight;
                        break;
                    case "Light to Dark":
                        m_cogCaliperTool.RunParams.Edge1Polarity = CogCaliperPolarityConstants.LightToDark;
                        break;
                    default:
                        m_cogCaliperTool.RunParams.Edge1Polarity = CogCaliperPolarityConstants.DontCare; break;
                }
                m_cogCaliperTool.RunParams.Edge0Position = -(double)m_NumEdgePairWidth.Value / 2;
                m_cogCaliperTool.RunParams.Edge0Position = (double)m_NumEdgePairWidth.Value / 2;
            }
           
            m_cogCaliperTool.RunParams.ContrastThreshold = (double)m_NumContrastThreshold.Value;
            m_cogCaliperTool.RunParams.FilterHalfSizeInPixels = (int)m_NumFilter.Value;
            m_cogCaliperTool.RunParams.MaxResults = (int)m_NumResult.Value;

            m_cogCaliperTool.Run();
            cogDisplay1.Tool = m_cogCaliperTool;
            showCaliperResult(m_cogCaliperTool.Results);
        }

        private void showCaliperResult(CogCaliperResults results)
        {
            DataTable dt = new DataTable();
            
            dt.Columns.Add("ID", typeof(int)).SetOrdinal(0);
            dt.Columns.Add("Score", typeof(double));
            dt.Columns.Add("Edge0", typeof(int));
            dt.Columns.Add("Position", typeof(double));
            dt.Columns.Add("X", typeof(double));
            dt.Columns.Add("Y", typeof(double));
            dt.Columns.Add("Scoring Function 0", typeof(double));
            dt.Columns.Add("Contrast (E0)", typeof(double));
            
            if (m_gbEdge1Polarity.Enabled)
            {
                dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("Distance (E0)",typeof(double)),
                    new DataColumn("X (E0)",typeof(double)),
                    new DataColumn("Y (E0)",typeof(double)),
                    new DataColumn("Contrast (E1)", typeof(double)),
                    new DataColumn("Distance (E1)",typeof(double)),
                    new DataColumn("X (E1)",typeof(double)),
                    new DataColumn("Y (E1)",typeof(double)),
                });
                dt.Columns.Add("Edge1", typeof(int)).SetOrdinal(3);
                dt.Columns.Add("Measured Width", typeof(double)).SetOrdinal(4);

                if (results != null)
                {
                    for (int i = 0; i < results.Count; i++)
                    {
                        CogCaliperResult res = results[i];
                        dt.Rows.Add(new object[]{
                            res.ID,
                            res.Score,
                            results.Edges.IndexOf(res.Edge0),
                            results.Edges.IndexOf(res.Edge1),
                            res.Width,
                            res.Position,
                            res.PositionX,
                            res.PositionY,
                            res.GetContributingScores()[0],
                            res.Edge0.Contrast,
                            res.Edge0.Position,
                            res.Edge0.PositionX,
                            res.Edge0.PositionY,
                            res.Edge1.Contrast,
                            res.Edge1.Position,
                            res.Edge1.PositionX,
                            res.Edge1.PositionY
                        }) ;
                    }
                }
            }
            else
            {
                if (results != null)
                {
                    foreach (CogCaliperResult res in results)
                    {
                        dt.Rows.Add(new object[]{
                        res.ID,
                        res.Score,
                        m_cogCaliperTool.Results.IndexOf(res),
                        res.Position,
                        res.PositionX,
                        res.PositionY,
                        res.GetContributingScores()[0],
                        res.Edge0.Contrast
                    }) ;
                    }
                }
            }
            
            //cogDisplay1.Container.Add(m_cogImageFile.OutputImage);
            m_CaliperRes.DataSource = dt;
        }

        private void m_comboBoxROI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_roi.m_comboBoxROI.SelectedIndex == 0)
            {
                if (cogDisplay1.Display.InteractiveGraphics.Count > 0)
                {
                    cogDisplay1.Display.InteractiveGraphics.Remove(0);
                }
                return;
            }

            if (cogDisplay1.Display.InteractiveGraphics.Count > 0)
                cogDisplay1.Display.InteractiveGraphics.Remove(0);

            ICogGraphicInteractive m_interactive = null;
            if (m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangle")
            {
                m_cogRec.X = m_roi.X;
                m_cogRec.Y = m_roi.Y;
                m_cogRec.Width = m_roi.Width;
                m_cogRec.Height = m_roi.Height;

                m_cogRec.TipText = "ROI";
                m_cogRec.Color = CogColorConstants.Green;

                m_interactive = m_cogRec as ICogGraphicInteractive;
                m_cogRec.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;
                m_cogRec.SelectedLineStyle = CogGraphicLineStyleConstants.Solid;
                m_cogRec.DragLineStyle = CogGraphicLineStyleConstants.Solid;

                m_cogRec.Changed += rectInteractiveChanged;
            }else if(m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangleAffine")
            {
                m_cogRectAffine.SetOriginLengthsRotationSkew(m_roi.X, m_roi.Y, m_roi.ROI_Width, m_roi.ROI_Height, m_roi.ROI_rotation,m_roi.ROI_skew);

                m_cogRectAffine.TipText = "ROI";
                m_cogRectAffine.Color = CogColorConstants.Green;

                m_interactive = m_cogRectAffine as ICogGraphicInteractive;
                m_cogRectAffine.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;
                m_cogRectAffine.SelectedLineStyle = CogGraphicLineStyleConstants.Solid;
                m_cogRectAffine.DragLineStyle = CogGraphicLineStyleConstants.Solid;

                m_cogRectAffine.Changed += rectAffineInteractiveChanged;
            }

            m_interactive.Interactive = true;
            m_interactive.GraphicDOFEnableBase = CogGraphicDOFConstants.All;
            m_interactive.LineStyle = CogGraphicLineStyleConstants.Solid;
            cogDisplay1.Display.InteractiveGraphics.Add(m_interactive, "test", false);
        }

        private void rectInteractiveChanged(object sender, CogChangedEventArgs e)
        {
            CogRectangle m_interactive = sender as CogRectangle;
            m_roi.X = m_interactive.X;
            m_roi.Y = m_interactive.Y;
            m_roi.ROI_Width = m_interactive.Width;
            m_roi.ROI_Height = m_interactive.Height;
        }

        private void rectAffineInteractiveChanged(object sender, CogChangedEventArgs e)
        {
            CogRectangleAffine m_interactive = sender as CogRectangleAffine;
            m_roi.X = m_cogRectAffine.CornerOriginX;
            m_roi.Y = m_cogRectAffine.CornerOriginY;
            m_roi.ROI_rotation = m_cogRectAffine.Rotation;
            m_roi.ROI_Width = m_cogRectAffine.SideXLength;
            m_roi.ROI_Height = m_cogRectAffine.SideYLength;
            m_roi.ROI_skew = m_cogRectAffine.Skew;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 0) //Histogram
            {
                if (!m_roi.m_comboBoxROI.Items.Contains("CogRectangle"))
                    m_roi.m_comboBoxROI.Items.Insert(1, "CogRectangle");
                m_HistogramInput.Controls.Add(panel);
            }
            else if (((TabControl)sender).SelectedIndex == 1) //Blob
            {
                if(!m_roi.m_comboBoxROI.Items.Contains("CogRectangle"))
                    m_roi.m_comboBoxROI.Items.Insert(1, "CogRectangle");
                m_BlobInput.Controls.Add(panel);
            }
            else if (((TabControl)sender).SelectedIndex == 2) //Caliper
            {
                m_roi.m_comboBoxROI.Items.Remove("CogRectangle"); //Remove CogRectangle
                m_CaliperInput.Controls.Add(panel);
                
            }
        }

        private void m_radioPair_CheckedChanged(object sender, EventArgs e)
        {
            if(m_radioPair.Checked) {
                m_gbEdge1Polarity.Enabled = true;
                m_NumEdgePairWidth.Enabled = true;
            }
            else
            {
                m_gbEdge1Polarity.Enabled = false;
                m_NumEdgePairWidth.Enabled = false;
            }
        }

        private void edge1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                edge1 = ((RadioButton)sender).Text;
        }

        private void edge0_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                edge0 = ((RadioButton)sender).Text;
        }
    }
}
