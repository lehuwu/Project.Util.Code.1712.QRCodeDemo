   M S B A M L   `   `   `  ����   QRCodeTools)    #QRCode生成解析工具.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  QRCode生成解析工具��$��620.4��$��1081.6�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�$��Microsoft YaHei)� � Icon$ QR.ico��
�������.��� .+��� -   $��	imgQRcode��$	��265��$
��None=�$
��Left=�$��
19,304,0,0q�$	��Top=�$	��265���� -   $��imgLogo��$	��185��$
��Left=�$��309,383,0,0q�$
��Fill=�$	��Top=�$	��185���� -   $��btnCreateQRCode��$��生成��$��23��$
��Left=�$��347,167,0,0q�$	��Top=�$��75���� -   $��btnSave��$��保存��$��23��$
��Left=�$��428,167,0,0q�$	��Top=�$��75���� -   $��
cboVersion��$��23��$
��Left=�$��243,167,0,0q�$	��Top=�$��92���� -   $��
textBlock1��$��23��$
��Left=�$��171,170,0,0q�$��二维码版本:��$	��Top=�$��68���� -   $��
textBlock2��$��23��$
��Left=�$��
16,171,0,0q�$��二维码尺寸:��$	��Top=�$��73���� -   $��txtSize��$��23��$
��Left=�$��
87,167,0,0q�$	��Top=�$��74��$��4���� -	   $��
textBlock3��$��23��$
��Left=�$��301,306,0,0q�$��自定义Logo:��$	��Top=�$��68���� -
   $��
btnAddLogo��$��	添加...��$��23��$
��Left=�$��375,304,0,0q�$	��Top=�$��75���� -   $��border1��
�������$��1q�$	��200��$
��Left=�$��301,376,0,0q�$	��Top=�$	��200���� -   $��border2��
�������$��1q�$	��280��$
��Left=�$��
12,296,0,0q�$	��Top=�$	��280���� -   $��
textBlock4��$��23��$
��Left=�$��301,342,0,0q�$��Logo尺寸:��$	��Top=�$��60���� -   $��txtLogoSize��$��23��$
��Left=�$��374,340,0,0q�$	��Top=�$	��127��$��30���� -   $��
textBlock5��$��23��$
��Left=�$��	15,15,0,0q�$��二维码内容:��$	��Top=�$��73���� -   $��txtQRCodeContent��$	��150��$
��Left=�$��	87,12,0,0q�$	��Top=�$	��416�� �� MaxLines$ 10��$����BEGIN:VCARD
VERSION:3.0
FN:此处输入名字
TEL:此处输入电话
EMAIL:此处输入email
ADR:此处输出地址
ORG:此处输入组织
END:VCARD���� -   $��	groupBox1��$��二维码解码��$��96��$
��Left=�$��
12,195,0,0q�$	��Top=�$	��493��.���� .+��� -   $��btnOpenQRCode��$��打开二维码...��$��23��$	��104�� �� Left$ 6��
 �� Top$ 7���� -   $��btnDecodeQRCode��$��解码��$��23��$��75��$	 116��$ 7���� -   $��
textBlock6��$ 6��$ 42��$��23��$��二维码内容:��$��67��$��Microsoft YaHei)��� -   $��btnClipboard��$	 199��$ 7��$��复制到剪切板��$��23��$��98���� -   $��tbDecodeResult�� �� 
IsReadOnly . $��0q�$ 77��$ 41��$��23��$�� ��$	��398��$��Microsoft YaHei)�� -    �Name$ 
GridOutPut��$
��Left=�$	��564��$��
510,12,0,0q�$	��Top=�$	��555��.+��� -   	 ��Name$	 LstBoxShowUserInfo��$
��Left=�$	��564��$	��Top=�$	��361��
 J� RenderTransformOrigin$
 0.5,0.5&�z�V� .~��� ��  �� AngleY$
 -0.4Q��� T�  T� Y$ -0.793Q����� .R�A�  A� Columns$ 3��.@��� $��姓名��