   M S B A M L   `   `   `  ����D  @SecondDay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SecondDay.WindowsSecondDay.Windows  5   	   -    'SecondDay.Windows.AddNewCostumersWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SecondDay.Windows     5   	     � Title$K  EБалтика - Добавление нового заказчика��5   	   $	��300��67   $	��500��6D   $��16(�6P   
������ � WindowStartupLocation$ CenterScreen=�6v   .��5	      �� $��Center=�6   $��Center=�6.   .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� $ ��Наименование: ��6    �� Left$ 77��6.   
 �� Top$ 16��6?   �� 5      -   5         ��Name$ tbxName��5       �� 	MaxLength$ 30��6'   $	��250��6^   ��66   ��  �� Path$
 Name� �� Mode$ TwoWay=�6^   5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��                 ИНН: ��6   $	 152��66   $ 46��6H   �� 5      -   5        $ tbxINN��5      $ 10��6&   $	��250��6\   ��65   �� $	 INN�$ TwoWay=�6\   5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $!��                 Банк: ��6   $	 153��67   $ 74��6I   �� 5      -   5        $ tbxBank��5      $ 60��6'   $	��250��6^   ��66   �� $
 Bank�$ TwoWay=�6^   5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $!��             Адресс: ��6   $	 136��65   $	 100��6G   �� 5      -   5        $ 
tbxAddress��5      $ 80��6*   $	��250��6d   ��69   �� $ Address�$ TwoWay=�6d   5      �� 5   
   -   5        $��Добавить��5   .   $��10q�6A   5      5      