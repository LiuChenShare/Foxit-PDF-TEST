
using FoxitPDFSDKProLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foxit_PDF_TEST
{
    public partial class Form1 : Form
    {

        private PDFSignatureMgr m_SigFieldMgr;

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
        /// 隐藏或者显示界面组件
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
    }
}
