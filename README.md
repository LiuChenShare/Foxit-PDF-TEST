# Foxit-PDF-TEST
对接福晰SDK

## 1.需验证如下功能
1. 打开pdf文件
2. 展示pdf文件
3. 跳转到指定页面
4. pdf设置（隐藏或者显示界面组件）
5. 插入图片或者图章
6. 插入的图片或者图章可以移动、修改大小和删除
7. 获取插入图片的坐标
8. 插入图片到绘制的区域
9. pdf单击、双击是事件获取
10. 保存pdf文件

## 2.Demo说明

**Foxit-PDF-Demo** 项目可以满足签名功能

### 2.1 初始工作

    注册 FoxitPDFSDK_AX_Pro.ocx

    并将 FoxitPDFSDK Pro Control 引用至工具箱

    使用 AxFoxitPDFSDKProLib.AxFoxitPDFSDK 控件

    解锁SDK：
            void UnLockActiveX(string lisence_id, string unlock_code);

    隐藏控件Title：  
            void ShowTitleBar(bool bShow);

    隐藏控件工具栏：
            void ShowToolBar(bool bShow);

### 2.2 打开pdf文件并展示

    打开pdf文件并展示：
            bool OpenFile(string file_path, string password);

### 2.3 图片签名

    获取签名:
            PDFSignatureMgr GetPDFSignatureMgr();

    创建签名模板，用于添加签名对象：
            bool CreatePatternSigField(string ImageFilePath, bool bSetMask, [ComAliasName("stdole.OLE_COLOR")] uint clrMask, float Height, float Width);

    设置签名模板：
            bool SetCurPatternSigField(short nIndex);

    设置AxFoxitPDFSDK的当前工具：
            AxFoxitPDFSDK.CurrentTool = "ESignature Tool";

    另存pdf文件：
            void SaveAs(string fileName);

## 3.相关接口文档


