
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
        }
    }
}
