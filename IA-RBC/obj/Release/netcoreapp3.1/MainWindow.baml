   M S B A M L   `   `   `  ���� A  =IA-RBC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:IA_RBCIA_RBC      IA_RBC.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:IA_RBC       � Title$	  RBC��$	��600��$
��1200��.��� ���	#FF003A7B � ColumnDefinitions �� ��  � RowDefinitions �� $	��90* ��� $	��10* �.+�� $��0�����	#FF003A7B.+��� $��0��$ ��Selecione o caso desejado:��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��257��
�������$��Courier New)�$��14(�&   System.Windows.Controls.DataGrid  -     Name$ database��$��0��   AutoGenerateColumns$ False��$��10,40,10,10q�����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 true��   Header$ Index:��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� 	 �� Path$	 Index�  $
 true��$ Nome:�� �� $
	 Nome�  $
 true��$ Artista:�� �� $	 Artista�  $
 true��$ Energia:�� �� $	 Energia�  $
 true��$ Barulho:�� �� $	 Barulho�  $
 true��$ 
Acústica:�� �� $	 Acustica�  $
 true��$ Positividade:�� �� $	 Positividade�  $
 true��$ 
Dançavel:�� �� $	 Dancavel�  $
 true��$ Lançamento:�� �� $	 
Lancamento�� $��1�����	#FF003A7B.+��� $��Resultados:��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��154��$��28��
�������$��Courier New)�$��14(�  -   $ result��$��0��$ False��$��10,40,10,10q�����    $
 true��$ Index:�� �� $	 Index�  $
 true��$ Nome:�� �� $	 CasoAnalisado.Nome�  $
 true��$ Artista:�� �� $	 CasoAnalisado.Artista�  $
 true��$ Similaridade:�� �� $	 SimTotal�4  .System.Windows.Controls.DataGridTemplateColumn  $ Detalhes��
   CellTemplate
 �� .R��� -   $��Ver Detalhes���� -   $��1��$��Calcular semelhanças��$��Center=�$��Center=�$	��152���� -   $��1��$��1��$��Visualizar/Editar pesos��$��Center=�$��Center=�$	��152��