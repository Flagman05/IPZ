   M S B A M L   `   `   `  ����  IPZ System bus tickets sale)    #IPZ_System_bus_tickets_sale.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   $��366.743��5   	   $��753.075��6   .��5      � 
�������$��	0,0,-8,-3q�6     J� RenderTransformOrigin$  0.363,1.089&�61   .+�5   
   �� -   5        $��	Add route��5      $
��Left=�6%   $��	39,24,0,0q�6@   $	��Top=�6S   $	��100��6k   $  0.96,2.5&�6w   $��31��6�   �� 5   
   $��
Departure:��6   $
��Left=�6%   $��
210,24,0,0q�6@   $	��Top=�6T   �� 5   
   $��Destination:��6   $
��Left=�6'   $��
401,24,0,0q�6B   $	��Top=�6V   �� 5	   
   -   5         ��Name$ label4��5	      $��Current routes:��6    $
��Left=�6:   $��
39,123,0,0q�6U   $	��Top=�6i   �� 5
   
   -   5        $��Search��5
      $
��Left=�6"   $��
576,56,0,0q�6=   $	��Top=�6Q   $	��135��6i   $��31��6u   6�   �� 5   
   -   5         ��Name$ 	comboBox1��5      $
��Left=�6&   $��
210,58,0,0q�6A   $	��Top=�6U   $	��131��6m    �� ItemStringFormat$  ��6y   .@�5      �� $��Centre��6   6.   �� 5      $��Politechnika��6   64   �� 5      $��Railway station��6   67   �� 5      $��Viktoria Gardens��6   68   �� 5      $��Ashan��6   6-   �� 5      $��AquaPark��6   60   �� 5      $��Knahyny Olgy��6   64    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   -   5        $ 	comboBox2��5      $
��Left=�6&   $��
401,58,0,0q�6A   $	��Top=�6U   $	��131��6m   .@�5      �� $��Centre��6   6.   �� 5      $��Politechnika��6   64   �� 5      $��Railway station��6   67   �� 5      $��Viktoria Gardens��6   68   �� 5      $��Ashan��6   6-   �� 5      $��AquaPark��6   60   �� 5      $��Knahyny Olgy��6   64    5        5       5"      �� 5#   
   -   5         ��Name$ 	listView1��5#      $
��Left=�6&   $	��162��6A   $��
39,154,0,0q�6N   $	��Top=�6b   $	��672��6z    �� View 5$      �� 5%      .P�5&      �� $��	Departure��6%    �� Width$ 90��68    �� DisplayMemberBinding 6C   �� *	Departure+�� 5'      $��Destination��6%   $ 90��6:    6E   �� *Destination+�� 5(      $��Intermediate stops��6%   $	 300��6A    6M   �� *IntermediateStops+�� 5)      $��Type of transport��6%   $	 100��6@    6L   �� *TrasnsportType+5*      .@�5,      �� $	��100��6   $	��100��6#   5-      5/      50      