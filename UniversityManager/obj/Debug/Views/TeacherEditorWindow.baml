   M S B A M L   `   `   `  ����L  HUniversityManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:UniversityManager.ViewsUniversityManager.Views  5   	   1    +UniversityManager.Views.TeacherEditorWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:UniversityManager.Views     5   	     � Title$"  Редактирование��5   	   $��324.636��6    $��430.457��61   .��5	      � .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ changePhotoButton��5      $
��Left=�60   $	��215��6K   $��	10,10,0,0q�6X   $	��Top=�6k   $	��215��6�   .��5      �� -   5         ��Name$ image��5      6E   5      �� 5      $��7,7,0,0q�6   $ Vertical=�6*   .+�5      �� $
��Bold"�6   $��Имя:��6.   �� 5      -   5         ��Name$ 	nameBlock��5      $	��150��6-   $	��150��6<   $��	15,3,0,20q�6K   �� 5      $
��Bold"�6   $��Фамилия:��6.   �� 5      -   5        $ surnameBlock��5      $	��150��60   $	��150��6?   $��	15,3,0,20q�6N   �� 5      $
��Bold"�6   $ ��Начало работы:��6.   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ startYearPicker��5      $	��150��66   $	��150��6E   $��15,3,0,5q�6T   5      5      �� 5   
   -   5        $ rejectButton��5      $��Отменить��6'   $
��Left=�6:   $��328,249,0,0q�6U   $	��Top=�6j   $��75��6�   6�   �� 5   
   -   5        $ deleteButton��5      $��Удалить��6'   $
��Left=�69   $��
90,249,0,0q�6T   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5        $ acceptButton��5      $��Применить��6'   $
��Left=�6;   $��
10,249,0,0q�6V   $	��Top=�6j   $��75��6�   6�   5      5      