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
        CogRectangle m_cogRectangle;

        public Form1()
        {
            InitializeComponent();
            m_comboBoxHisROI.SelectedIndex = 0;
            m_cogImageFile = new CogImageFileTool();
            m_cogHistogramTool = new CogHistogramTool();
            m_cogRectangle = new CogRectangle();
            m_cogRectangle.Width = 100;
            m_cogRectangle.Height = 100;
            m_cogRectangle.Color = CogColorConstants.Red;
            cogDisplay1.InteractiveGraphics.Add(m_cogRectangle,"xx",false);
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
                    cogDisplay1.Image = m_cogImageFile.OutputImage;
                    cogDisplay1.Fit();
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void m_RunBtn_Click(object sender, EventArgs e)
        {
            if(m_cogImageFile.OutputImage != null)
            {
                if (tabControl1.SelectedTab.Name == "m_HistogramTab")
                    runHistogram();
                else if (tabControl1.SelectedTab.Name == "m_BlobTab")
                    runBlob();
                else if (tabControl1.SelectedTab.Name == "m_CaliperTab")
                    runCaliper();
            }
        }

        private void runHistogram()
        {
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

            //cogDisplay1.Image = m_cogHistogramTool.Result.GetHistogram();

        }

        private void runBlob()
        {

        }

        private void runCaliper()
        {

        }

        private void m_comboBoxHisROI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
