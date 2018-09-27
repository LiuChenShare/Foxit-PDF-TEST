# 接口说明
## 1.解锁SDK

```
UnLockActiveX(string lisence_id, string unlock_code);
```
示例：
```
m_AX.UnLockActiveX(_T("Licence_ID"),_T("Unlock_code"));
```

## 2.打开PDF文件

```
m_AX.OpenFile(fdg.GetPathName() ,NULL );
```

## 3.转到特定页面

```
m_AX.GoToPage(0);
```

## 4.放大和缩小页面

## 5.旋转页面

## 6.打印PDF文档

## 7.隐藏/显示UI元素

```
m_AX.ShowToolBar(false);    //隐藏界面组件
```

## 8.生成大纲（Iterate the tree outline of the PDF document）

## 9.搜索

