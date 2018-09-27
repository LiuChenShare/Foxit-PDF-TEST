# Foxit-PDF-TEST
对接福晰SDK

## 验证如下功能
### 1. 打开pdf文件

```
m_AX.OpenFile(strFilePath, "");
```

### 2. 展示pdf文件

使用AxFoxitPDFSDKProLib.AxFoxitPDFSDK

### 3. 跳转到指定页面

使用AxFoxitPDFSDKProLib.AxFoxitPDFSDK界面组件

### 4. pdf设置（隐藏或者显示界面组件）

```
m_AX.ShowToolBar(false);    //隐藏界面组件
```

### 5. 插入图片或者图章

```
sigfield.SetAPImage(strImagePath, true, 0xFFFFFF);
```

### 6. 插入的图片或者图章可以移动、修改大小和删除

```
m_SigFieldMgr.Add(0, 100, 300, 300, 150);   //页码，左，上，右，下。0点位置为左下角
```

### 7. 获取插入图片的坐标

坐标为add时设置

8. 插入图片到绘制的区域
9. pdf单击、双击是事件获取
10. 保存pdf文件


## 相关接口文档

[IPDFSignatureField](IPDFSignatureField.md)：帮助访问和操作签名字段。
