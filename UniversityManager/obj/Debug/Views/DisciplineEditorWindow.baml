   M S B A M L   `   `   `  ����L  HUniversityManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:UniversityManager.ViewsUniversityManager.Views  5   	   4    .UniversityManager.Views.DisciplineEditorWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:UniversityManager.Views     5   	     � Title$"  Редактирование��5   	   $��278.8��6    $��370.4��6/   .��5	      � .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��7,7,0,0q�6   $ Vertical=�6*   .+�5      �� $
��Bold"�6   $��Название:��6.   �� 5      -   5         ��Name$ nameBox��5      $	��150��6+   $	��150��6:   $��15,3,0,5q�6I   �� 5      $
��Bold"�6   $��Код:��6.   �� 5      -   5        $ codeBox��5      $	��150��6+   $	��150��6:   $��15,3,0,5q�6I   �� 5      $
��Bold"�6   $9��3Начало академического года:��6.   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ startAcademicYearPicker��5      $	��150��6>   $	��150��6M   $��15,3,0,5q�6\   �� 5      $
��Bold"�6   $7��1Конец академического года:��6.     5      -   5        $ endAcademicYearPicker��5      $	��150��6<   $	��150��6K   $��15,3,0,5q�6Z   5      �� 5      $ Vertical=�6   $��7,7,0,0q�60   .+�5      �� $
��Bold"�6   $��Группа:��6.   �� 5      -   5         ��Name$ 
listGroups��5      $	��150��6/   $	��150��6>   $��15,3,0,5q�6M    �� DisplayMemberPath$
 Name��6_   �� 5      $
��Bold"�6   $!��Преподаватель:��6.   �� 5      -   5        $ listTeachers��5      $	��150��61   $	��150��6@   $��15,3,0,5q�6O   �� 5      $
��Bold"�6   $&�� Количество часов:��6.   �� 5       -   5        $ totalHoursBox��5       $	��150��61   $	��150��6@   $��15,3,0,5q�6O   5!      5"      �� 5#   
   -   5         ��Name$ rejectButton��5#      $��Отменить��6'   $
��Left=�6:   $��279,219,0,0q�6U   $	��Top=�6j   $��75��6�   6�   �� 5$   
   -	   5        $ deleteButton��5$      $��Удалить��6'   $
��Left=�69   $��
90,219,0,0q�6T   $	��Top=�6h   $��75��6�   6�   �� 5%   
   -
   5        $ acceptButton��5%      $��Применить��6'   $
��Left=�6;   $��
10,219,0,0q�6V   $	��Top=�6j   $��75��6�   6�   5'      5(      