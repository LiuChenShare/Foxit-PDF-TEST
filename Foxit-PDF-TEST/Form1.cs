
using AxFoxitPDFSDKProLib;
using FoxitPDFSDKProLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foxit_PDF_TEST
{
    public partial class Form1 : Form
    {

        private PDFSignatureMgr m_SigFieldMgr;

        private int m_nFileIndex = 0;
        bool state = true;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //use UnLockActiveX Method to UnLock ActiveX 
            //m_AX.UnLockActiveX("Licence_ID", "Unlock_code");
            m_AX.UnLockActiveX("Licence_ID", "Unlock_code");

            m_AX.ShowTitleBar(false);


            string strPath = System.Windows.Forms.Application.StartupPath;
            //string strFilePath = strPath + "..\\..\\..\\res\\test.pdf";
            string strFilePath = strPath + "..\\..\\..\\res\\王二蛋+询问笔录+第0次.pdf";
            bool ret = m_AX.OpenFile(strFilePath, "");
            m_SigFieldMgr = m_AX.GetPDFSignatureMgr();
            if (m_SigFieldMgr == null)
            {
                MessageBox.Show("Please check the KEY license information.\n\nIf you never have a KEY license ,please contact us at sales@foxitsoftware.com");
            }

            //m_AX.OnClick += OnClick;

            //右键菜单
            m_AX.SetContextMenuString("啦啦啦");
            m_AX.OnContextMenuIndex += OnContextMenuIndex;

            m_AX.ShowContextMenu(false);        //隐藏右键


            m_AX.OnRButtonClick += axFoxitReaderSDK1_OnRButtonClick;    //绑定右键事件

            InitMj_List();  //设置右键菜单
        }


        /// <summary>
        /// 隐藏或者显示菜单界面组件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (state)
            {
                state = false;
            }
            else
            {
                state = true;
            }
            m_AX.ShowToolBar(state);
        }

        #region 签字

        private void button2_Click(object sender, EventArgs e)
        {
            if (m_SigFieldMgr == null)
            {
                MessageBox.Show("Please check the KEY license information.\n\nIf you never have a KEY license ,please contact us at sales@foxitsoftware.com");
                return;
            }

            PDFSignatureField sigfield = m_SigFieldMgr.Add(0, 100, 300, 300, 150);
            //Prepare Signature info
            sigfield.Reason = "签名盖章";
            sigfield.Signer = "LC";
            sigfield.SetSignerDN("XXXX-XXX-XXXXXXXXX");
            sigfield.Location = "China,HeFei";
            bool ret = sigfield.SetAPOptions(Convert.ToInt32("0x080", 16));      //只显示图片
            ret = sigfield.SetAPText("签名样本");

            //Set display image
            string strPath = System.Windows.Forms.Application.StartupPath;
            string strImagePath = strPath + "..\\..\\..\\res\\icon-close.png";
            ret = sigfield.SetAPImage(strImagePath, true, 0xFFFFFF);

            //string pageRange = "0-1";
            //sigfield.SetStraddlePages(pageRange);

            //Set digital certification. This is need to be set if you will sign by default ,but not by customer algorithm.
            string strCertPath = strPath + "..\\..\\..\\res\\foxit.pfx";
            ret = sigfield.SetCertPath(strCertPath, "123456");

            //Sign and save as pdf
            m_nFileIndex++;
            string csFileIndex = m_nFileIndex.ToString() + ".pdf";
            var path = AppDomain.CurrentDomain.BaseDirectory + @"PDF\";
            Directory.CreateDirectory(path);
            string strSignedFile = path + csFileIndex;
            ret = m_SigFieldMgr.SignDocument(sigfield, strSignedFile, true);
            if (!ret)
            {
                MessageBox.Show("签署文件失败.", "Default Sign");

            }
        }

        /// <summary>
        /// 盖在最后一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (m_SigFieldMgr == null)
            {
                MessageBox.Show("Please check the KEY license information.\n\nIf you never have a KEY license ,please contact us at sales@foxitsoftware.com");
                return;
            }

            var index = m_AX.PageCount - 1;

            PDFSignatureField sigfield = m_SigFieldMgr.Add(index, 100, 300, 300, 150);
            //Prepare Signature info
            bool ret = sigfield.SetAPOptions(Convert.ToInt32("0x080", 16));      //只显示图片

            //Set display image
            string strPath = System.Windows.Forms.Application.StartupPath;
            string strImagePath = strPath + "..\\..\\..\\res\\icon-close.png";
            ret = sigfield.SetAPImage(strImagePath, true, 0xFFFFFF);

            //string pageRange = "0,1";
            //sigfield.SetStraddlePages(pageRange);

            //Set digital certification. This is need to be set if you will sign by default ,but not by customer algorithm.
            string strCertPath = strPath + "..\\..\\..\\res\\foxit.pfx";
            ret = sigfield.SetCertPath(strCertPath, "123456");

            //Sign and save as pdf
            m_nFileIndex++;
            string csFileIndex = m_nFileIndex.ToString() + ".pdf";
            var path = AppDomain.CurrentDomain.BaseDirectory + @"PDF\";
            Directory.CreateDirectory(path);
            string strSignedFile = path + csFileIndex;
            ret = m_SigFieldMgr.SignDocument(sigfield, strSignedFile, true);
            if (!ret)
            {
                MessageBox.Show("签署文件失败.", "Default Sign");

            }
        }

        /// <summary>
        /// 控制大小和位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (m_SigFieldMgr == null)
            {
                MessageBox.Show("Please check the KEY license information.\n\nIf you never have a KEY license ,please contact us at sales@foxitsoftware.com");
                return;
            }

            var index = m_AX.PageCount - 1;

            PDFSignatureField sigfield = m_SigFieldMgr.Add(0, 400, 100, 450, 50);
            //Prepare Signature info
            bool ret = sigfield.SetAPOptions(Convert.ToInt32("0x080", 16));      //只显示图片

            //Set display image
            string strPath = System.Windows.Forms.Application.StartupPath;
            string strImagePath = strPath + "..\\..\\..\\res\\icon-close.png";
            ret = sigfield.SetAPImage(strImagePath, true, 0xFFFFFF);

            //string pageRange = "0,1";
            //sigfield.SetStraddlePages(pageRange);

            //Set digital certification. This is need to be set if you will sign by default ,but not by customer algorithm.
            string strCertPath = strPath + "..\\..\\..\\res\\foxit.pfx";
            ret = sigfield.SetCertPath(strCertPath, "123456");

            //Sign and save as pdf
            m_nFileIndex++;
            string csFileIndex = m_nFileIndex.ToString() + ".pdf";
            var path = AppDomain.CurrentDomain.BaseDirectory + @"PDF\";
            Directory.CreateDirectory(path);
            string strSignedFile = path + csFileIndex;
            ret = m_SigFieldMgr.SignDocument(sigfield, strSignedFile, true);
            if (!ret)
            {
                MessageBox.Show("签署文件失败.", "Default Sign");

            }
            //MessageBox.Show("下面我将删除签名.", "Default Sign");
            //m_SigFieldMgr.Clear(sigfield);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("下面我将删除签名.", "Default Sign");

            var sigfield = m_SigFieldMgr.Get(0);

            if (!m_SigFieldMgr.Remove(sigfield))
            {
                m_SigFieldMgr.Clear(sigfield);
            }

        }

        /// <summary>
        /// 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClick(object sender, _DFoxitPDFSDKEvents_OnClickEvent e)
        {
            try
            {
                if (m_SigFieldMgr == null)
                {
                    MessageBox.Show("Please check the KEY license information.\n\nIf you never have a KEY license ,please contact us at sales@foxitsoftware.com");
                    return;
                }

                int index = 0;
                float pageX = 0;
                float pageY = 0;

                m_AX.ConvertClientCoordToPageCoord(e.clientX, e.clientY, ref index, ref pageX, ref pageY);
                PDFSignatureField sigfield = m_SigFieldMgr.Add(index, pageX, pageY + 50, pageX + 50, pageY);
                //PDFSignatureField sigfield = m_SigFieldMgr.Add(0, 100, 300, 300, 150);
                //Prepare Signature info
                bool ret = sigfield.SetAPOptions(Convert.ToInt32("0x080", 16));      //只显示图片

                //Set display image
                string strPath = System.Windows.Forms.Application.StartupPath;
                string strImagePath = strPath + "..\\..\\..\\res\\timestamp.png";
                ret = sigfield.SetAPImage(strImagePath, true, 0xFFFFFF);

                ////Set digital certification. This is need to be set if you will sign by default ,but not by customer algorithm.
                string strCertPath = strPath + "..\\..\\..\\res\\foxit.pfx";
                ret = sigfield.SetCertPath(strCertPath, "123456");

                ////Sign and save as pdf
                m_nFileIndex++;
                string csFileIndex = m_nFileIndex.ToString() + ".pdf";
                var path = AppDomain.CurrentDomain.BaseDirectory + @"PDF\";
                Directory.CreateDirectory(path);
                string strSignedFile = path + csFileIndex;
                m_AX.SaveAs(strSignedFile);
                //ret = m_SigFieldMgr.SignDocument(sigfield, strSignedFile, true);
                //if (!ret)
                //{
                //    MessageBox.Show("签署文件失败.", "Default Sign");

                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }


        /// <summary>
        /// 啦啦啦
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnContextMenuIndex(object sender, _DFoxitPDFSDKEvents_OnContextMenuIndexEvent e)
        {
            if (true)
            {

            }
        }

        #endregion

        #region 签章
        /// <summary>
        /// 签章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (m_SigFieldMgr == null)
            {
                MessageBox.Show("Please check the KEY license information.\n\nIf you never have a KEY license ,please contact us at sales@foxitsoftware.com");
                return;
            }

            //Set display image
            string strPath = System.Windows.Forms.Application.StartupPath;
            string strImagePath = strPath + "..\\..\\..\\res\\icon-close.png";

            //var Pattern = m_SigFieldMgr.CreatePatternSigField(strImagePath, false, 0xFFFFFF, 50, 50);
            m_SigFieldMgr.CreatePatternSigField(strImagePath, true, 0xFFFFFF, 50, 50);
            m_SigFieldMgr.SetCurPatternSigField(0);
            m_AX.CurrentTool = "ESignature Tool";
            m_AX.bHighlightFormFields = false;
        }

        /// <summary>
        /// 图章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            m_AX.CurrentTool = "ESignature Tool";

            IPDFPageAnnots m_PageAnnots = m_AX.GetPageAnnots(0);

            string strPath = System.Windows.Forms.Application.StartupPath;
            string strImagePath = strPath + "..\\..\\..\\res\\icon-close.png";
            
            var annot = m_PageAnnots.AddAnnot(null, "Image", 100, 300, 300, 150);
            annot.SetMediaPoster(strImagePath);
            annot.Thickness = 0;
        }

        /// <summary>
        /// 插入图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            m_AX.CurrentTool = "ESignature Tool";
            m_AX.CurrentTool = "Image Tool";
            string strPath = System.Windows.Forms.Application.StartupPath;
            string strImagePath = strPath + "..\\..\\..\\res\\icon-close.png";
            m_AX.AddImageObject(0, 200, 200, 50, 50, strImagePath, 120, 0);
        }
        #endregion

        #region 右键菜单

        private void axFoxitReaderSDK1_OnRButtonClick(object sender, _DFoxitPDFSDKEvents_OnRButtonClickEvent e)
        {
            float xx = 0;
            float yy = 0;
            int page = 0;
            m_AX.ConvertClientCoordToPageCoord(e.clientX, e.clientY, ref page, ref xx, ref yy);
            xx = xx - 10;
            yy = yy - 10;


            int Rx = e.clientX + 120;
            int Ry = e.clientY + 240;
            MJList.Show(new Point(Rx, Ry));
        }

        public void InitMj_List()
        {
            MJList.Items.Clear();
            MJList.Visible = true;

            ToolStripMenuItem menu = new ToolStripMenuItem
            {
                Text = "\n111文本\n",
                Name = "111名称",
                Tag = "111类型",
                //Margin = new Padding(0, 10, 0, 10)
                //Size = new Size(200, 50),
                //AutoSize = false
            };
            MJList.Items.Add(menu);
            ToolStripMenuItem menu2 = new ToolStripMenuItem
            {
                Text = "222文本",
                Name = "222名称",
                Tag = "222类型",
                //Margin = new Padding(0, 10, 0, 10)
                //Size = new Size(200, 50),
                //AutoSize = false
                Font = new Font(new FontFamily("Microsoft YaHei UI") { }, 24)
            };
            MJList.Items.Add(menu2);

        }
        #endregion
    }
}