   M S B A M L   `   `   `  ����A  =IA-RBC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:IA_RBCIA_RBC  5   	       IA_RBC.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:IA_RBC     5   	     � Title$	  RBC��5   	   $	��600��6   $
��1200��6"   .��5      � ���	#FF003A7B � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��90* �6   �� 5      $	��10* �6   .+�5   
   � $��0��6   ���	#FF003A7B.+�5      �� $��0��6   $ ��Selecione o caso desejado:��6!   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   $	��257��6�   
�������$��Courier New)�6�   $��14(�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ database��5   $   $��0��6      AutoGenerateColumns$ False��66   $��10,40,10,10q�6j   ��6R   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 true��6)      Header$ Index:��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� 	 �� Path$	 Index�  5      $
 true��6)   $ Nome:��6;    6J   �� $
	 Nome�  5      $
 true��6)   $ Artista:��6;    6M   �� $	 Artista�  5      $
 true��6)   $ Energia:��6;    6M   �� $	 Energia�  5      $
 true��6)   $ Barulho:��6;    6M   �� $	 Barulho�  5      $
 true��6)   $ 
Acústica:��6;    6N   �� $	 Acustica�  5      $
 true��6)   $ Positividade:��6;    6R   �� $	 Positividade�  5       $
 true��6)   $ 
Dançavel:��6;    6N   �� $	 Dancavel�  5!      $
 true��6)   $ Lançamento:��6;    6P   �� $	 
Lancamento�5#      5$      � 5%   
   $��1��6   ���	#FF003A7B.+�5&      �� $��Resultados:��6   $
��Left=�6*   $��	10,10,0,0q�6E   $	��Top=�6X   $	��154��6p   $��28��6|   
�������$��Courier New)�6�   $��14(�6�     5'      -   5        $ result��5'   $   $��0��6   $ False��64   $��10,40,10,10q�6h   
 J� 	AllowDrop$

 True��6}      CanUserAddRows$ False��6�   ��6P   ��  5(        5)      $
 true��6)   $ Index:��6;    6K   �� $	 Index�  5*      $
 true��6)   $ Nome:��6;    6J   �� $	 CasoAnalisado.Nome�  5+      $
 true��6)   $ Artista:��6;    6M   �� $	 CasoAnalisado.Artista�  5,      $
 true��6)   $ Similaridade:��6;    6R   �� $	 SimTotal�4  .System.Windows.Controls.DataGridTemplateColumn  5-      $ Detalhes��6-      CellTemplate 5.      �� 5/      .R�50   "   �� -   5        $��Ver Detalhes��50   )   6@   51      53      55      56      �� 57   
   -   5        $��1��57      $��Calcular semelhanças��6   $��Center=�6=   $��Center=�6Z   $	��152��6u   6�   �� 58   
   -   5        $��1��58      $��1��6!   $��Visualizar/Editar pesos��6.   $��Center=�6P   $��Center=�6m   $	��152��6�   6�   59      5:      