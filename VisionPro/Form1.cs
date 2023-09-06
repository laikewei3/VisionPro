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
using Cognex.VisionPro.Implementation;
using System.Reflection;
using System.Collections;
using System.Security.Policy;
using System.Reflection.Emit;
using System.Diagnostics;
using System.Linq.Dynamic.Core.Parser;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Cognex.VisionPro.DSCameraSetup.Implementation.Internal;
using Cognex.VisionPro.Display;

namespace VisionPro
{
    public partial class Form1 : Form
    {
        CogImageFileTool m_cogImageFile;
        CogHistogramTool m_cogHistogramTool;
        CogCaliperTool m_cogCaliperTool;
        CogBlobTool m_cogBlobTool;
        ROI m_roi;
        Panel panel;
        CogRectangle m_cogRec;
        CogRectangleAffine m_cogRectAffine;
        String edge0 = "Any Polarity";
        String edge1 = "Any Polarity";
        Dictionary<String, ArrayList> m_dictBlobFilters = new Dictionary<String, ArrayList>();

        /*
        Dictionary<String,String> m_dictBlobFilters = new Dictionary<String, String>();
        String m_strBlobsFilter = "";
        private void createFilterString()
        {
            if (m_dictBlobFilters.Count == 0)
            {
                m_strBlobsFilter = "";
                return;
            }
            if (m_strBlobsFilter == "")
                m_strBlobsFilter = "res => ";
            foreach (var condition in m_dictBlobFilters)
            {
                String m_strName = condition.Key;
                String m_strValue = condition.Value;
                
                String[] c = m_strValue.Split(',');
                
                if (c[0] == "Exclude")
                {
                    if (m_strBlobsFilter.Length > 7)
                        m_strBlobsFilter += " && ";
                    if (m_strName == "ConnectivityLabel")
                    {
                        if (c[1] == "0")
                            c[1] = "Hole";
                        else
                            c[1] = "Blob";

                        if (c[2] == "0")
                            c[2] = "Hole";
                        else
                            c[2] = "Blob";

                        m_strBlobsFilter += " res." + m_strName + " != \"" + c[1] + "\" && res." + m_strName + " != \"" + c[2]+ "\"";
                        return;
                    }

                    m_strBlobsFilter += " res." + m_strName + " < " + c[1] + " || res." + m_strName + " > " + c[2];
                }
                else
                {
                    if (m_strBlobsFilter.Length > 7)
                        m_strBlobsFilter += " && ";
                    if (m_strName == "ConnectivityLabel")
                    {
                        if (c[1] == "0")
                            c[1] = "Hole";
                        else
                            c[1] = "Blob";

                        if (c[2] == "0")
                            c[2] = "Hole";
                        else
                            c[2] = "Blob";

                        m_strBlobsFilter += " res." + m_strName + " == \"" + c[1] + "\" || res." + m_strName + " == \"" + c[2] + "\"";
                        return;
                    }

                    m_strBlobsFilter += " res." + m_strName + " >= " + c[1] + " && res." + m_strName + " <= " + c[2];
                }
            }
        }
        */
        public Form1()
        {
            InitializeComponent();
            m_cogImageFile = new CogImageFileTool();
            m_cogHistogramTool = new CogHistogramTool();
            m_cogCaliperTool = new CogCaliperTool();
            m_cogBlobTool = new CogBlobTool();
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
            cogDisplay1.Display.Click += displayClicked;

            for (int i = 3; i >= 0; i--)
                m_cbBlobProperties.SelectedIndex = i;

            m_cbSegMode.SelectedIndex = 2;
            m_cbSegPolarity.SelectedIndex = 0;
            m_cbConnectMode.SelectedIndex = 0;
            m_cbConnectClean.SelectedIndex = 2;


            cogDisplay1.Display.MultiSelectionEnabled = false;
        }

        

        private void m_OpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog m_ofd = new OpenFileDialog();
                m_ofd.Filter = "All files (*.*)|*.*";
                if (m_ofd.ShowDialog() == DialogResult.OK)
                {
                    m_cogImageFile.Operator.Open(m_ofd.FileName, CogImageFileModeConstants.Read);
                    m_cogImageFile.Run();
                    cogDisplay1.Display.Image = m_cogImageFile.OutputImage;
                    cogDisplay1.Display.Fit();
                }
            }
            catch (Exception ex)
            {
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
            m_cogImageFile.Run();
            cogDisplay1.Display.Image = m_cogImageFile.OutputImage;
            cogDisplay1.Display.Fit();
            if (tabControl1.SelectedTab.Name == "m_HistogramTab")
                runHistogram();
            else if (tabControl1.SelectedTab.Name == "m_BlobTab")
                runBlob();
            else if (tabControl1.SelectedTab.Name == "m_CaliperTab")
                runCaliper();
        }

        private void runHistogram()
        {
            if (m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangle")
                m_cogHistogramTool.Region = m_cogRec;
            else if (m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangleAffine")
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
            m_dgvBlobResults.Columns.Clear();
            m_dgvBlobResults.Rows.Clear();
            m_dgvBlobResults.Refresh();

            if (m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangle")
                m_cogBlobTool.Region = m_cogRec;
            else if (m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangleAffine")
                m_cogBlobTool.Region = m_cogRectAffine;

            m_cogBlobTool.InputImage = m_cogImageFile.OutputImage;

            m_cogBlobTool.RunParams.ConnectivityMinPixels = (int)m_NumConnectionMin.Value;

            if (m_cbSegPolarity.SelectedItem.ToString() == "Dark blobs, Light background")
                m_cogBlobTool.RunParams.SegmentationParams.Polarity = CogBlobSegmentationPolarityConstants.DarkBlobs;
            else
                m_cogBlobTool.RunParams.SegmentationParams.Polarity = CogBlobSegmentationPolarityConstants.LightBlobs;

            m_cogBlobTool.Run();

            List<blobResults> m_listResults = new List<blobResults>();

            CogBlobResultCollection m_cogBlobResults = m_cogBlobTool.Results.GetBlobs();
            for (int i = 0; i < m_cogBlobResults.Count; i++)
            {
                CogBlobResult m_res = m_cogBlobResults[i];
                blobResults m_blobResults = new blobResults(
                    i, m_res.ID, m_res.Area, m_res.CenterOfMassX, m_res.CenterOfMassY, m_res.Label.ToString(), m_res.Angle,
                    m_res.GetBoundary().LineWidthInScreenPixels, m_res.Perimeter, m_res.NumChildren, m_res.InertiaX,
                    m_res.InertiaY, m_res.InertiaMin, m_res.InertiaMax, m_res.Elongation, m_res.Acircularity, m_res.AcircularityRms,
                    m_res.GetBoundingBox(CogBlobAxisConstants.SelectedSpace).CenterX, m_res.GetBoundingBox(CogBlobAxisConstants.SelectedSpace).CenterY,
                    m_res.GetBoundingBox(CogBlobAxisConstants.SelectedSpace).CornerOriginX, m_res.GetBoundingBox(CogBlobAxisConstants.SelectedSpace).CornerOppositeX,
                    m_res.GetBoundingBox(CogBlobAxisConstants.SelectedSpace).CornerOriginY, m_res.GetBoundingBox(CogBlobAxisConstants.SelectedSpace).CornerOppositeY,
                    m_res.GetBoundingBox(CogBlobAxisConstants.SelectedSpace).SideXLength, m_res.GetBoundingBox(CogBlobAxisConstants.SelectedSpace).SideYLength,
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, m_res.NotClipped);
                m_listResults.Add(m_blobResults);
            }
            /*
            createFilterString();
            if (m_strBlobsFilter != "")
            {
                var options = ScriptOptions.Default.AddReferences(typeof(blobResults).Assembly);
                Func<blobResults, bool> discountFilterExpression = await CSharpScript.EvaluateAsync<Func<blobResults, bool>>(m_strBlobsFilter, options);
                m_listResults = m_listResults.Where(discountFilterExpression).ToList();
            }
            m_strBlobsFilter = "";*/


            cogDisplay1.Tool = m_cogBlobTool;
            showBlobResult(m_BlobMeasurementTable.Rows, m_listResults);
        }

        private void showBlobResult(DataGridViewRowCollection rows, List<blobResults> m_listResults)
        {
            int i = 2;
            List<string> m_listData = new List<string>();
            m_dgvBlobResults.Columns.Add("m_measure0", "N");
            m_dgvBlobResults.Columns.Add("m_measure1", "ID");
            m_listData.Add("N");
            m_listData.Add("ID");

            foreach (DataGridViewRow r in rows)
            {
                m_dgvBlobResults.Columns.Add("m_measure" + i++, r.Cells[0].Value.ToString());
                m_listData.Add(r.Cells[0].Value.ToString());
            }
            foreach (blobResults r in m_listResults)
            {
                i = 0;
                string[] m_listTemp = new string[m_listData.Count];
                foreach (string name in m_listData)
                {
                    PropertyInfo propInfo = typeof(blobResults).GetProperty(name);
                    if (propInfo != null)
                    {
                        object value = propInfo.GetValue(r);
                        m_listTemp[i++] = (value.ToString());
                    }
                }
                m_dgvBlobResults.Rows.Add(m_listTemp);
            }

        }

        private void runCaliper()
        {
            m_CaliperRes.Columns.Clear();
            m_CaliperRes.Rows.Clear();
            m_CaliperRes.Refresh();
            if (m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangleAffine")
                m_cogCaliperTool.Region = m_cogRectAffine;
            else
                m_cogCaliperTool.Region = null;
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

            if (m_gbEdge1Polarity.Enabled)
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
            CogCaliperResults results = m_cogCaliperTool.Results;
            for (int i = 0; i < results.Count; i++)
            {
                foreach (CogCaliperEdge e in results.Edges)
                {
                    //MessageBox.Show(results.Edges.IndexOf(results.Edges[]) +":"+results.Edges.IndexOf(e)+": "+e.Position + ", " + e.PositionX + ", " + e.PositionY + "\n" + (results[i].Edge0.Position + ", " + results[i].Edge0.PositionX + ", " + results[i].Edge0.PositionY) + "\n" + (results[i].Edge1.Position + ", " + results[i].Edge1.PositionX + ", " + results[i].Edge1.PositionY) + "\n" + e.GetHashCode() + "\n" + results[i].GetHashCode() + "\n" + results.GetHashCode());
                }
            }
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
                        });
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
                    });
                    }
                }
            }
            m_CaliperRes.DataSource = dt;
        }

        private void m_comboBoxROI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_roi.m_comboBoxROI.SelectedIndex == 0)
            {
                if (cogDisplay1.Display.InteractiveGraphics.Count > 0)
                    cogDisplay1.Display.InteractiveGraphics.Remove(0);
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
            }
            else if (m_roi.m_comboBoxROI.SelectedItem.ToString() == "CogRectangleAffine")
            {
                m_cogRectAffine.SetOriginLengthsRotationSkew(m_roi.X, m_roi.Y, m_roi.ROI_Width, m_roi.ROI_Height, m_roi.ROI_rotation, m_roi.ROI_skew);

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
                if (!m_roi.m_comboBoxROI.Items.Contains("CogRectangle"))
                    m_roi.m_comboBoxROI.Items.Insert(1, "CogRectangle");
                m_BlobInput.Controls.Add(panel);
            }
            else if (((TabControl)sender).SelectedIndex == 2) //Caliper
            {
                if (m_roi.m_comboBoxROI.SelectedIndex != 0 && m_roi.m_comboBoxROI.SelectedIndex != 2)
                    m_roi.m_comboBoxROI.SelectedIndex = 2;
                m_roi.m_comboBoxROI.Items.Remove("CogRectangle"); //Remove CogRectangle
                m_CaliperInput.Controls.Add(panel);

            }
        }

        private void m_radioPair_CheckedChanged(object sender, EventArgs e)
        {
            if (m_radioPair.Checked)
            {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox m_comboBox = (ComboBox)sender;
            String m_strName = m_comboBox.SelectedItem.ToString();
            int index = m_BlobMeasurementTable.Rows.Add();
            m_BlobMeasurementTable.Rows[index].Cells[0].Value = m_strName;
            ((DataGridViewComboBoxCell)m_BlobMeasurementTable.Rows[index].Cells[1]).Value = "Runtime";

            CogBlobMeasure m_cogBlobMeasure = new CogBlobMeasure();
            CogBlobMeasureConstants measureConstants;
            Enum.TryParse<CogBlobMeasureConstants>(m_strName, out measureConstants);
            if (m_strName == "ConnectivityLabel")
                Enum.TryParse<CogBlobMeasureConstants>("Label", out measureConstants);
            m_cogBlobMeasure.Measure = measureConstants;
            m_cogBlobMeasure.FilterMode = CogBlobFilterModeConstants.ExcludeBlobsInRange;
            m_cogBlobMeasure.FilterRangeHigh = 0;
            m_cogBlobMeasure.FilterRangeLow = 0;
            m_cogBlobMeasure.Mode = CogBlobMeasureModeConstants.PreCompute;
            m_cogBlobTool.RunParams.RunTimeMeasures.Add(m_cogBlobMeasure);
            ArrayList m_tempAL = new ArrayList();
            m_tempAL.Add(m_cogBlobTool.RunParams.RunTimeMeasures.IndexOf(m_cogBlobMeasure));
            m_tempAL.Add(m_cogBlobMeasure);

            m_dictBlobFilters.Add(m_strName, m_tempAL);
            m_comboBox.Items.RemoveAt(m_cbBlobProperties.SelectedIndex);
        }

        private void m_BlobMeasurementTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridView m_dataGridView = (DataGridView)sender;
            int m_intRow = e.RowIndex;
            int m_intColumn = e.ColumnIndex;
            DataGridViewRow m_dgvRow = m_dataGridView.Rows[m_intRow];
            DataGridViewCell m_dgvCell = m_dgvRow.Cells[m_intColumn];
            String m_strName = m_dgvRow.Cells[0].Value.ToString();
            if (!m_dictBlobFilters.ContainsKey(m_strName))
                return;
            ArrayList m_measure = m_dictBlobFilters[m_strName];
            CogBlobMeasure m_cogBlobMeasure = (CogBlobMeasure)m_measure[1];

            if (m_intColumn == 1)
            {
                if (m_dgvCell.Value.ToString() != "Filter")
                {
                    if (m_dgvCell.Value.ToString() == "Runtime")
                        m_cogBlobMeasure.Mode = CogBlobMeasureModeConstants.PreCompute;
                    else
                        m_cogBlobMeasure.Mode = CogBlobMeasureModeConstants.None;
                    //m_dictBlobFilters.Clear();
                    //m_strBlobsFilter = "";
                    m_dgvRow.Cells[2].Value = "";
                    m_dgvRow.Cells[3].Value = "";
                    m_dgvRow.Cells[4].Value = "";
                    m_dgvRow.Cells[2].ReadOnly = true;
                    m_dgvRow.Cells[3].ReadOnly = true;
                    m_dgvRow.Cells[4].ReadOnly = true;
                }
                else
                {
                    m_cogBlobMeasure.Mode = CogBlobMeasureModeConstants.Filter;
                    m_dgvRow.Cells[2].Value = "Exclude";
                    m_dgvRow.Cells[3].Value = "0";
                    m_dgvRow.Cells[4].Value = "0";
                    m_dgvRow.Cells[2].ReadOnly = false;
                    m_dgvRow.Cells[3].ReadOnly = false;
                    m_dgvRow.Cells[4].ReadOnly = false;
                    //m_dictBlobFilters[m_dgvRow.Cells[0].Value.ToString()] = m_dgvRow.Cells[2].Value + "," + m_dgvRow.Cells[3].Value + "," + m_dgvRow.Cells[4].Value;
                }
                m_cogBlobTool.RunParams.RunTimeMeasures[(int)m_measure[0]] = m_cogBlobMeasure;
            }
            else if (m_intColumn == 2)
            {
                if (m_dgvCell.Value.ToString() == "Include")
                    m_cogBlobMeasure.FilterMode = CogBlobFilterModeConstants.IncludeBlobsInRange;
                else if (m_dgvCell.Value.ToString() == "Exclude")
                    m_cogBlobMeasure.FilterMode = CogBlobFilterModeConstants.ExcludeBlobsInRange;
                //m_dictBlobFilters[m_dgvRow.Cells[0].Value.ToString()] = m_dgvRow.Cells[2].Value + "," + m_dgvRow.Cells[3].Value + "," + m_dgvRow.Cells[4].Value;
            }
            else if (m_intColumn == 3)
            {
                //m_dictBlobFilters[m_dgvRow.Cells[0].Value.ToString()] = m_dgvRow.Cells[2].Value + "," + m_dgvRow.Cells[3].Value + "," + m_dgvRow.Cells[4].Value;
                try { m_cogBlobMeasure.FilterRangeLow = double.Parse(m_dgvCell.Value.ToString()); } catch (Exception) { }
            }
            else if (m_intColumn == 4)
            {
                //m_dictBlobFilters[m_dgvRow.Cells[0].Value.ToString()] = m_dgvRow.Cells[2].Value + "," + m_dgvRow.Cells[3].Value + "," + m_dgvRow.Cells[4].Value;
                try { m_cogBlobMeasure.FilterRangeHigh = double.Parse(m_dgvCell.Value.ToString()); } catch (Exception) { }
            }
        }

        private void m_BlobMeasurementTable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            m_BlobMeasurementTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void m_cbSegMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string m_CogBlobSegmentationModeConstants = m_cbSegMode.SelectedItem.ToString();
            switch (m_CogBlobSegmentationModeConstants)
            {
                case "None":
                    m_cogBlobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.None;
                    m_labelPolarity.Visible = false; m_cbSegPolarity.Visible = false;
                    m_labelSeg1.Text = "Scaling Value";
                    m_NumSegmentation1.Value = 150;
                    m_labelSeg2.Visible = false; m_NumSegmentation2.Visible = false;
                    m_labelSeg3.Visible = false; m_NumSegmentation3.Visible = false;
                    m_labelSeg4.Visible = false; m_NumSegmentation4.Visible = false;
                    m_labelSeg5.Visible = false; m_NumSegmentation5.Visible = false;
                    m_SegMap.Visible = false;
                    break;
                case "Map":
                    m_cogBlobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.Map;
                    m_labelPolarity.Visible = false; m_cbSegPolarity.Visible = false;
                    m_labelSeg1.Text = "Scaling Value";
                    m_NumSegmentation1.Value = 150;
                    m_labelSeg2.Visible = false; m_NumSegmentation2.Visible = false;
                    m_labelSeg3.Visible = false; m_NumSegmentation3.Visible = false;
                    m_labelSeg4.Visible = false; m_NumSegmentation4.Visible = false;
                    m_labelSeg5.Visible = false; m_NumSegmentation5.Visible = false;
                    m_SegMap.Visible = true;
                    break;
                case "Hard Threshold (Relative)":
                    m_cogBlobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.HardRelativeThreshold;
                    m_labelPolarity.Visible = true; m_cbSegPolarity.Visible = true;
                    m_labelSeg1.Text = "Threshold: "; m_NumSegmentation1.Value = 50;
                    m_labelSeg2.Visible = true; m_NumSegmentation2.Visible = true;
                    m_labelSeg2.Text = "Low Tail: "; m_NumSegmentation2.Value = 0;
                    m_labelSeg3.Visible = true; m_NumSegmentation3.Visible = true;
                    m_labelSeg3.Text = "High Tail: "; m_NumSegmentation3.Value = 0;
                    m_labelSeg4.Visible = false; m_NumSegmentation4.Visible = false;
                    m_labelSeg5.Visible = false; m_NumSegmentation5.Visible = false;
                    m_SegMap.Visible = false;
                    break;
                case "Hard Threshold (Dynamic)":
                    m_cogBlobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.HardDynamicThreshold;
                    m_labelPolarity.Visible = true; m_cbSegPolarity.Visible = true;
                    m_labelSeg1.Text = "Low Tail: "; m_NumSegmentation1.Value = 0;
                    m_labelSeg2.Visible = true; m_NumSegmentation2.Visible = true;
                    m_labelSeg2.Text = "High Tail: "; m_NumSegmentation2.Value = 0;
                    m_labelSeg3.Visible = false; m_NumSegmentation3.Visible = false;
                    m_labelSeg4.Visible = false; m_NumSegmentation4.Visible = false;
                    m_labelSeg5.Visible = false; m_NumSegmentation5.Visible = false;
                    m_SegMap.Visible = false;
                    break;
                case "Soft Threshold (Fixed)":
                    m_cogBlobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.SoftFixedThreshold;
                    m_labelPolarity.Visible = true; m_cbSegPolarity.Visible = true;
                    m_labelSeg1.Text = "Low Threshold: "; m_NumSegmentation1.Value = 100;
                    m_labelSeg2.Visible = true; m_NumSegmentation2.Visible = true;
                    m_labelSeg2.Text = "High Threshold: "; m_NumSegmentation2.Value = 128;
                    m_labelSeg3.Visible = true; m_NumSegmentation3.Visible = true;
                    m_labelSeg3.Text = "Softness: "; m_NumSegmentation3.Value = 254;
                    m_labelSeg4.Visible = false; m_NumSegmentation4.Visible = false;
                    m_labelSeg5.Visible = false; m_NumSegmentation5.Visible = false;
                    m_SegMap.Visible = false;
                    break;
                case "Soft Threshold (Relative)":
                    m_cogBlobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.SoftRelativeThreshold;
                    m_labelPolarity.Visible = true; m_cbSegPolarity.Visible = true;
                    m_labelSeg1.Text = "Low Threshold: "; m_NumSegmentation1.Value = 40;
                    m_labelSeg2.Visible = true; m_NumSegmentation2.Visible = true;
                    m_labelSeg2.Text = "High Threshold: "; m_NumSegmentation2.Value = 60;
                    m_labelSeg3.Visible = true; m_NumSegmentation3.Visible = true;
                    m_labelSeg3.Text = "Low Tail: "; m_NumSegmentation3.Value = 0;
                    m_labelSeg4.Visible = true; m_NumSegmentation4.Visible = true;
                    m_labelSeg4.Text = "High Tail: "; m_NumSegmentation4.Value = 0;
                    m_labelSeg5.Visible = true; m_NumSegmentation5.Visible = true;
                    m_labelSeg5.Text = "Softness: "; m_NumSegmentation5.Value = 254;
                    m_SegMap.Visible = false;
                    break;
                //case "Subtraction Image":
                // m_cogBlobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.SubtractionImage;
                //break;
                default:
                    m_cogBlobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.HardFixedThreshold;
                    m_labelPolarity.Visible = true; m_cbSegPolarity.Visible = true;
                    m_labelSeg1.Text = "Threshold:";
                    m_NumSegmentation1.Value = 128;
                    m_labelSeg2.Visible = false; m_NumSegmentation2.Visible = false;
                    m_labelSeg3.Visible = false; m_NumSegmentation3.Visible = false;
                    m_labelSeg4.Visible = false; m_NumSegmentation4.Visible = false;
                    m_labelSeg5.Visible = false; m_NumSegmentation5.Visible = false;
                    m_SegMap.Visible = false;
                    break;
            }
        }

        private void m_NumSegmentation1_ValueChanged(object sender, EventArgs e)
        {
            string m_CogBlobSegmentationModeConstants = m_cbSegMode.SelectedItem.ToString();
            switch (m_CogBlobSegmentationModeConstants)
            {
                case "None":
                case "Map":
                    m_cogBlobTool.RunParams.SegmentationParams.ScalingValue = (int)m_NumSegmentation1.Value;
                    break;
                case "Hard Threshold (Relative)":
                    m_cogBlobTool.RunParams.SegmentationParams.HardRelativeThreshold = (int)m_NumSegmentation1.Value;
                    break;
                case "Hard Threshold (Dynamic)":
                    m_cogBlobTool.RunParams.SegmentationParams.TailLow = (int)m_NumSegmentation1.Value;
                    break;
                case "Soft Threshold (Fixed)":
                    m_cogBlobTool.RunParams.SegmentationParams.SoftFixedThresholdLow = (int)m_NumSegmentation1.Value;
                    break;
                case "Soft Threshold (Relative)":
                    m_cogBlobTool.RunParams.SegmentationParams.SoftRelativeThresholdLow = (int)m_NumSegmentation1.Value;
                    break;
                //case "Subtraction Image":
                //break;
                default:
                    m_cogBlobTool.RunParams.SegmentationParams.HardFixedThreshold = (int)m_NumSegmentation1.Value;
                    break;
            }
        }

        private void m_NumSegmentation2_ValueChanged(object sender, EventArgs e)
        {
            string m_CogBlobSegmentationModeConstants = m_cbSegMode.SelectedItem.ToString();
            switch (m_CogBlobSegmentationModeConstants)
            {
                case "Hard Threshold (Relative)":
                    m_cogBlobTool.RunParams.SegmentationParams.TailLow = (int)m_NumSegmentation2.Value;
                    break;
                case "Hard Threshold (Dynamic)":
                    m_cogBlobTool.RunParams.SegmentationParams.TailHigh = (int)m_NumSegmentation2.Value;
                    break;
                case "Soft Threshold (Fixed)":
                    m_cogBlobTool.RunParams.SegmentationParams.SoftFixedThresholdHigh = (int)m_NumSegmentation2.Value;
                    break;
                case "Soft Threshold (Relative)":
                    m_cogBlobTool.RunParams.SegmentationParams.SoftRelativeThresholdHigh = (int)m_NumSegmentation2.Value;
                    break;
                default:
                    break;
            }
        }

        private void m_NumSegmentation3_ValueChanged(object sender, EventArgs e)
        {
            string m_CogBlobSegmentationModeConstants = m_cbSegMode.SelectedItem.ToString();
            switch (m_CogBlobSegmentationModeConstants)
            {
                case "Hard Threshold (Relative)":
                    m_cogBlobTool.RunParams.SegmentationParams.TailHigh = (int)m_NumSegmentation3.Value;
                    break;
                case "Soft Threshold (Fixed)":
                    m_cogBlobTool.RunParams.SegmentationParams.Softness = (int)m_NumSegmentation3.Value;
                    break;
                case "Soft Threshold (Relative)":
                    m_cogBlobTool.RunParams.SegmentationParams.TailLow = (int)m_NumSegmentation2.Value;
                    break;
                default:
                    break;
            }
        }

        private void m_NumSegmentation4_ValueChanged(object sender, EventArgs e)
        {
            string m_CogBlobSegmentationModeConstants = m_cbSegMode.SelectedItem.ToString();
            switch (m_CogBlobSegmentationModeConstants)
            {
                case "Soft Threshold (Relative)":
                    m_cogBlobTool.RunParams.SegmentationParams.TailHigh = (int)m_NumSegmentation4.Value;
                    break;
                default:
                    break;
            }
        }

        private void m_NumSegmentation5_ValueChanged(object sender, EventArgs e)
        {
            string m_CogBlobSegmentationModeConstants = m_cbSegMode.SelectedItem.ToString();
            switch (m_CogBlobSegmentationModeConstants)
            {
                case "Soft Threshold (Relative)":
                    m_cogBlobTool.RunParams.SegmentationParams.Softness = (int)m_NumSegmentation5.Value;
                    break;
                default:
                    break;
            }
        }

        private void m_cbConnectClean_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_NumConnectionMin.Enabled = true;
            if (m_cbConnectClean.SelectedItem.ToString() == "Fill")
                m_cogBlobTool.RunParams.ConnectivityCleanup = CogBlobConnectivityCleanupConstants.Fill;
            else if (m_cbConnectClean.SelectedItem.ToString() == "Prune")
                m_cogBlobTool.RunParams.ConnectivityCleanup = CogBlobConnectivityCleanupConstants.Prune;
            else
            {
                m_cogBlobTool.RunParams.ConnectivityCleanup = CogBlobConnectivityCleanupConstants.None;
                m_NumConnectionMin.Enabled = false;
            }


        }

        private void m_cbConnectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_cbConnectMode.SelectedItem.ToString() == "Whole Image")
            {
                m_cogBlobTool.RunParams.ConnectivityMode = CogBlobConnectivityModeConstants.WholeImageGreyScale;
                m_cbConnectClean.Enabled = false;
                m_NumConnectionMin.Enabled = false;
            }
            else
            {
                if (m_cbConnectMode.SelectedItem.ToString() == "Labeled")
                    m_cogBlobTool.RunParams.ConnectivityMode = CogBlobConnectivityModeConstants.Labeled;
                else
                    m_cogBlobTool.RunParams.ConnectivityMode = CogBlobConnectivityModeConstants.GreyScale;
                m_cbConnectClean.Enabled = true;
                m_NumConnectionMin.Enabled = true;
            }
        }

        private void m_dgvBlobResults_SelectionChanged(object sender, EventArgs e)
        {
            if (m_dgvBlobResults.Rows.Count == 0) { return; }
            if (m_dgvBlobResults.SelectedRows.Count == 0) { return; }
            
            try
            {
                int m_intNum = m_dgvBlobResults.SelectedRows[0].Index;
                int ID = int.Parse(m_dgvBlobResults.SelectedRows[0].Cells[1].Value.ToString());

                if (cogDisplay1.Display.InteractiveGraphics.Count >= m_intNum)
                {
                    CogInteractiveGraphicsContainer m_cogInteractContainer = cogDisplay1.Display.InteractiveGraphics;
                    int i = 0;
                    foreach (var graphic in m_cogInteractContainer)
                    {
                        Cognex.VisionPro.Interop.CogCompositeShape select = (Cognex.VisionPro.Interop.CogCompositeShape)graphic;
                        int id = select.ID;
                        if (id == ID)
                        {
                            cogDisplay1.Display.InteractiveGraphics[i].Selected = true;
                        }
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void displayClicked(object sender, EventArgs e)
        {
            CogGraphicInteractiveCollection m_gic = cogDisplay1.Display.Selection;
            if (m_gic.Count == 0)
                return;
            
            if (tabControl1.SelectedIndex == 1)
            {
                CogCompositeShape m_cogPolygon = (CogCompositeShape)m_gic[0];
                int ID = m_cogPolygon.ID;
                int index = int.Parse(m_cogBlobTool.Results.GetBlobs().IndexOf(m_cogBlobTool.Results.GetBlobByID(ID)).ToString());
                m_dgvBlobResults.ClearSelection();
                DataGridViewRow row = m_dgvBlobResults.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[0].Value.ToString().Equals(index.ToString())).First();
                row.Selected = true;
            }

        }
    }
}
