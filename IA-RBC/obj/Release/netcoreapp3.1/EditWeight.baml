   M S B A M L   `   `   `  ���� A  =IA-RBC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:IA_RBCIA_RBC      IA_RBC.EditWeight   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:IA_RBC       � Title$  Editar pesos��$	��265��$	��287��.��� $��0,0,0,1q����	#FF003A7B � ColumnDefinitions �� $��1* ��� $��1* �.+��� $��Energia:��$��Center=�$��0,16,0,0q�$	��Top=�$��14(�
�������$��Courier New)��� $��
Acústica:��$��Center=�$��0,78,0,0q�$	��Top=�$��14(�
�������$��Courier New)��� $��
Dançavel:��$��Center=�$��	0,140,0,0q�$	��Top=�$��14(�
�������$��Courier New)��� $��Barulho:��$��Center=�$��0,47,0,0q�$	��Top=�$��14(�
�������$��Courier New)��� $��Positividade:��$��Center=�$��	0,109,0,0q�$	��Top=�$��14(�
�������$��Courier New)��� $��Lançamento:��$��Center=�$��	0,171,0,0q�$	��Top=�$��14(�
�������$��Courier New)�� $��1��$��24��$	��Top=�$��
16,18,16,0q� �� $��* ��� $��12 � � RowDefinitions �� $��12 ��� $��12 �.+��� -    ��Name$ energia��$��0��$��0��$��2�� �� 
IsReadOnly$
 True�� �� TextAlignment$ Center=�$��0,0,12,0q�$��2���� -   $��	energiaUp��$��1��$��0��$��8(�$��Marlett)�$��Center=�$��Center=�.��5�� -   $��energiaDown��$��1��$��1��$��8(�$��Marlett)�$��Center=�$��Center=�$��12��$��Bottom=�.��6� $��1��$��24��$	��Top=�$��
16,49,16,0q� �� $��* ��� $��12 � �� $��12 ��� $��12 �.+��� -   $ barulho��$��0��$��0��$��2��$
 True��$ Center=�$��0,0,12,0q�$��2���� -   $��	barulhoUp��$��1��$��0��$��8(�$��Marlett)�$��Center=�$��Center=�.��5�� -   $��barulhoDown��$��1��$��1��$��8(�$��Marlett)�$��Center=�$��Center=�$��12��$��Bottom=�.��6� $��1��$��24��$	��Top=�$��
16,80,16,0q� �� $��* ��� $��12 � �� $��12 ��� $��12 �.+��� -   $ acustica��$��0��$��0��$��2��$
 True��$ Center=�$��0,0,12,0q�$��2���� -   $��
acusticaUp��$��1��$��0��$��8(�$��Marlett)�$��Center=�$��Center=�.��5�� -	   $��acusticaDown��$��1��$��1��$��8(�$��Marlett)�$��Center=�$��Center=�$��12��$��Bottom=�.��6� $��1��$��24��$	��Top=�$��16,109,16,0q� �� $��* ��� $��12 � �� $��12 ��� $��12 �.+��� -
   $ positividade��$��0��$��0��$��2��$
 True��$ Center=�$��0,0,12,0q�$��2���� -   $��positividadeUp��$��1��$��0��$��8(�$��Marlett)�$��Center=�$��Center=�.��5�� -   $��positividadeDown��$��1��$��1��$��8(�$��Marlett)�$��Center=�$��Center=�$��12��$��Bottom=�.��6� $��1��$��24��$	��Top=�$��16,140,16,0q� �� $��* ��� $��12 � �� $��12 ��� $��12 �.+��� -   $ dancavel��$��0��$��0��$��2��$
 True��$ Center=�$��0,0,12,0q�$��2���� -   $��
dancavelUp��$��1��$��0��$��8(�$��Marlett)�$��Center=�$��Center=�.��5�� -   $��dancavelDown��$��1��$��1��$��8(�$��Marlett)�$��Center=�$��Center=�$��12��$��Bottom=�.��6� $��1��$��24��$	��Top=�$��16,171,16,0q� �� $��* ��� $��12 � �� $��12 ��� $��12 �.+��� -   $ 
lancamento��$��0��$��0��$��2��$
 True��$ Center=�$��0,0,12,0q�$��2���� -   $��lancamentoUp��$��1��$��0��$��8(�$��Marlett)�$��Center=�$��Center=�$
��Left=�$��12��.��5�� -   $��lancamentoDown��$��1��$��1��$��8(�$��Marlett)�$��Center=�$��Center=�$��12��$��Bottom=�.��6