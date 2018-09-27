namespace Foxit_PDF_TEST
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.m_AX = new AxFoxitPDFSDKProLib.AxFoxitPDFSDK();
            ((System.ComponentModel.ISupportInitialize)(this.m_AX)).BeginInit();
            this.SuspendLayout();
            // 
            // m_AX
            // 
            this.m_AX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_AX.Enabled = true;
            this.m_AX.Location = new System.Drawing.Point(0, 0);
            this.m_AX.Name = "m_AX";
            this.m_AX.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("m_AX.OcxState")));
            this.m_AX.Size = new System.Drawing.Size(856, 721);
            this.m_AX.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 721);
            this.Controls.Add(this.m_AX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_AX)).EndInit();
            this.ResumeLayout(false);

        }

        private AxFoxitPDFSDKProLib.AxFoxitPDFSDK m_AX;



        #endregion

        //private AxFoxitPDFSDKProLib.AxFoxitPDFSDK m_AX;
    }
}

