   M S B A M L   `   `   `  ����  CRUD App    CRUD_App.GridData   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  GridData��5   	   $	��378��6   $	��480��6'   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��gridDemo��5      $
��Left=�5         AutoGenerateColumns .  $	��Top=�5
      ��5	      ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�      Header$ Employee ID��6�      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+ �� NotifyOnTargetUpdated .  �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�     5      $	 100 6�   $
 Name��6�    6%   �� *name+ . $ TwoWay=�$	 PropertyChanged=�6�     5      $	 100 6�   $	 Age��6�    6%   �� *age+ . $ TwoWay=�$	 PropertyChanged=�6�     5      $	 100 6�   $ Company��6�    6%   �� *	company+ . $ TwoWay=�$	 PropertyChanged=�6�   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Edit��6)   
   CellTemplate
 5      �� 5      .R�5      �� -   5        $��Update��5   %   ��6M   �� *id+6o   5      5        5      $ Action��6)   
 5      �� 5      .R�5      ��  ��Name$ 	btnDelete��66   -   5        $��Delete��5   %   
���  ��
���������5    9   �� *id+6v   5!      5$      5&      5(      5)      