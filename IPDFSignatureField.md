# IPDFSignatureField
**IPDFSignatureField** �������ʺͲ���ǩ���ֶΡ�

## Properties

## Methods

### 1.SetAPOptions

    ˵�����Զ���ǩ����ۡ�

    ԭ�ͣ�boolean SetAPOptions(long opts);

    opts��ָʾ�Զ���ǩ����۵�ֵ�������Ա�����Ϊ��
        ��ʾȫ��- 511  
        ��ʾ�ı�-0x100L  
        ��ʾͼ��-0x080L  
        ��ʾǩ����-0x040L  
        ��ʾλ��-0x020L  
        ��ʾDN-0x010L  
        ��ʾʱ��-0x008L  
        ��ʾԭ��-0x004L  
        ��ʾ��ǩ-0x002L  
        ��ʾFxITFLAG -0x001L

    ע��Ӧ���ڵ���ǩ���ĵ�֮ǰ��ɡ�

### 2.SetAPText

    ˵����Ϊǩ����������ı���
    
    ԭ�ͣ�boolean SetAPText(BSTR text); 

    text��Ҫ��ʾ���ı���

    ע��Ӧ���ڵ���ǩ���ĵ�֮ǰ��ɡ�

### 3.SetAPImage

    ˵����Ϊǩ���������ͼ��

    ԭ�ͣ�boolean SetAPImage(BSTR imageFilePath, boolean bSetMask, OLE_COLOR clrMask);

    imageFilePath��Ҫ��ʾ��ͼ����ļ�·����

    bSetMask��ָ���Ƿ�Ϊ����ͼ�����������ֵ����ע�ⱳ��ͼ������Ǵ��ġ�

    clrMask����ɫ��

    ע��Ӧ���ڵ���ǩ���ĵ�֮ǰ��ɡ�


### 4.SetAPImageData

### 5.IsSigned

    ˵�������ǩ���ֶ��Ƿ���ǩ����
    
    ԭ�ͣ�boolean IsSigned(); 

### 6.SetSignerDN

    ˵����Ϊ֤������һ����ʶ������ơ�

    ԭ�ͣ�Boolean SetSignerDN(string dn); 

    dn��֤��Ŀɷֱ����ơ�

    ע��Ӧ���ڵ���ǩ���ĵ�֮ǰ��ɡ�

### 7.SetStatusImage

    ˵��������״̬ͼ��

### 8.SetStatusImageData 

### 9.GetPageIndex 

    ˵������ȡǩ���ֶ����ڵ�ҳ��������

### 10.GetSourceBuffer

    ˵������ȡԴPDF����ǩ������֤��

### 11.GetSourceBufferLen 

    ˵������ȡҪǩ������֤��ԴPDF�ĳ��ȡ�

### 12.GetSignedBuffer

    ˵������ȡǩ��PDF���ݡ�

### 13.GetSignedBufferLen

    ˵������ȡǩ��PDF���ݵĳ��ȡ�

### 14.CreateSignedDoc

    ˵��������һ���ɵ������������ǩ����PDFǩ��

### 15.SetVerifyResult

    ˵�����Զ���������֤������ǩ����������ǩ���Ľ����

### 16.SetCertPath

    ˵��������֤�顣

### 17.SetCertData

    ˵����������֤���ݡ�

### 18.SetCertContext

    ˵��������֤�������ġ�

### 19.TurnGray

    ˵������ǩ����۱�Ϊ��ɫ��

### 20.TurnBlur

    ˵����ģ��ǩ���ֶΡ�

### 21.SetVisible

    ˵��������ǩ���ǿɼ��ġ�

### 22.GrayPrint

    ˵������PDF��ӡ��ǩ����۱�Ϊ��ɫ��

### 23.SetStraddleType

    ˵�������ÿ����־�����͡�

### 24.SetStraddlePos

    ˵�������ÿ����־��λ�á�

### 25.SetStraddleBitmap

    ˵��������ͼ��Ŀ��־��ۡ�

### 26.SetStraddlePages

    ˵�������ÿ�ҳ��־���õ�ҳ�淶Χ��

### 27.SetStraddleFirstPagePercent

    ˵�������÷ֲ���ŵİٷֱȣ����ڵ�һ��PDFҳ������ʾ��

### 28.SetSigFieldAlpha

    ˵��������ǩ��ͼ���͸���ȡ�

### 29.Refresh

    ˵����ˢ��ǩ���ֶΡ�

### 30.SetDefaultContentsLength

    ˵������ʹ�õ����������㷨ʱ��Ҫ���ܵ����ݵ����ó��ȡ�