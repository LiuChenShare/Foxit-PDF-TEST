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

namespace Foxit_PDF_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PDFSignatureMgr m_SigFieldMgr;
        private bool state = true;
        private int m_nFileIndex = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
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
        /// 改变菜单状态
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

        /// <summary>
        /// 签章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (m_SigFieldMgr == null)
            {
                MessageBox.Show("Please check the KEY license information.\n\nIf you never have a KEY license ,please contact us at sales@foxitsoftware.com");
                return;
            }

            string strPath = System.Windows.Forms.Application.StartupPath;
            string strImagePath = strPath + "..\\..\\..\\res\\icon-close.png";
            
            m_SigFieldMgr.CreatePatternSigField(strImagePath, true, 0xFFFFFF, 50, 50);  //创建签名模板，可用于添加签名对象
            m_SigFieldMgr.SetCurPatternSigField(0);                                     //设置签名模板
            m_AX.CurrentTool = "ESignature Tool";                                       //设置 ActiveX 当前使用的工具
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //打开时指定默认路径
            var path = AppDomain.CurrentDomain.BaseDirectory + @"PDF\";
            Directory.CreateDirectory(path);
            m_nFileIndex++;
            string csFileIndex = m_nFileIndex.ToString() + ".pdf";

            saveFileDialog1.InitialDirectory = path;
            //saveFileDialog1.Filter = "ext files (*.txt)|*.txt|All files(*.*)|*>**";
            saveFileDialog1.Filter = "PDF文件(*.pdf)|*.pdf";
            saveFileDialog1.FileName = csFileIndex;
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                var name = saveFileDialog1.FileName;
                m_AX.SaveAs(name);
                MessageBox.Show("存储文件成功！", "保存文件");
            }
        }
    }
}
