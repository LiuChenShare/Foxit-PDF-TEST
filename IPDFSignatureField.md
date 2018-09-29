# IPDFSignatureField
**IPDFSignatureField** 帮助访问和操作签名字段。

## Properties

## Methods

### 1.SetAPOptions

    说明：自定义签名外观。

    原型：boolean SetAPOptions(long opts);

    opts：指示自定义签名外观的值。它可以被设置为：
        显示全部- 511  
        显示文本-0x100L  
        显示图像-0x080L  
        显示签名器-0x040L  
        显示位置-0x020L  
        显示DN-0x010L  
        显示时间-0x008L  
        显示原因-0x004L  
        显示标签-0x002L  
        显示FxITFLAG -0x001L

    注：应该在调用签名文档之前完成。

### 2.SetAPText

    说明：为签名外观设置文本。
    
    原型：boolean SetAPText(BSTR text); 

    text：要显示的文本。

    注：应该在调用签名文档之前完成。

### 3.SetAPImage

    说明：为签名外观设置图像。

    原型：boolean SetAPImage(BSTR imageFilePath, boolean bSetMask, OLE_COLOR clrMask);

    imageFilePath：要显示的图像的文件路径。

    bSetMask：指定是否为背景图像设置掩码的值。请注意背景图像必须是纯的。

    clrMask：颜色。

    注：应该在调用签名文档之前完成。


### 4.SetAPImageData

### 5.IsSigned

    说明：检查签名字段是否已签名。
    
    原型：boolean IsSigned(); 

### 6.SetSignerDN

    说明：为证书设置一个可识别的名称。

    原型：Boolean SetSignerDN(string dn); 

    dn：证书的可分辨名称。

    注：应该在调用签名文档之前完成。

### 7.SetStatusImage

    说明：设置状态图像。

### 8.SetStatusImageData 

### 9.GetPageIndex 

    说明：获取签名字段所在的页的索引。

### 10.GetSourceBuffer

    说明：获取源PDF进行签名或验证。

### 11.GetSourceBufferLen 

    说明：获取要签名或验证的源PDF的长度。

### 12.GetSignedBuffer

    说明：获取签名PDF内容。

### 13.GetSignedBufferLen

    说明：获取签名PDF内容的长度。

### 14.CreateSignedDoc

    说明：创建一个由第三方处理程序签名的PDF签名

### 15.SetVerifyResult

    说明：自定义用于验证第三方签名处理程序的签名的结果。

### 16.SetCertPath

    说明：设置证书。

### 17.SetCertData

    说明：设置认证数据。

### 18.SetCertContext

    说明：设置证书上下文。

### 19.TurnGray

    说明：将签名外观变为灰色。

### 20.TurnBlur

    说明：模糊签名字段。

### 21.SetVisible

    说明：设置签名是可见的。

### 22.GrayPrint

    说明：将PDF打印的签名外观变为灰色。

### 23.SetStraddleType

    说明：设置跨骑标志的类型。

### 24.SetStraddlePos

    说明：设置跨骑标志的位置。

### 25.SetStraddleBitmap

    说明：设置图像的跨标志外观。

### 26.SetStraddlePages

    说明：设置跨页标志放置的页面范围。

### 27.SetStraddleFirstPagePercent

    说明：设置分叉符号的百分比，并在第一个PDF页面中显示。

### 28.SetSigFieldAlpha

    说明：设置签名图像的透明度。

### 29.Refresh

    说明：刷新签名字段。

### 30.SetDefaultContentsLength

    说明：当使用第三方加密算法时，要加密的内容的设置长度。