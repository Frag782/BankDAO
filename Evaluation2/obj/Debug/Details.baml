   M S B A M L   `   `   `  ����F  BEvaluation2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Evaluation2Evaluation2  5   	       Evaluation2.Details   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Evaluation2     5   	     � Title$  Détails��5   	    � WindowStartupLocation$ CenterScreen=�6    � SizeToContent$ WidthAndHeight=�6>   .��5
      �� $��10, 20, 10, 20q�6   .+�5   
   �� 
�������$��Détails du compte��6"   �� 5   
   $��Center=�6   .+�5      �� $��Numéro de compte��6   �� 5      -   5         ��Name$ 	lblNumero��5      $��Center=�6'   �� 5      $��Date de création��6   �� 5      -   5        $ lblCreation��5      $��Center=�6)   �� 5      $��Solde du compte��6   �� 5      -   5        $ lblSolde��5      $��Center=�6&   5      �� 5   
   $.��(________________________________________��6   $��Center=�5      
������� J� Opacity$	 0.2Q�6;   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5       �� $��0, 0, 50, 0q�6   .+�5!      �� 
�������$��Dépôt��6*   �� 5"      $��Montant du dépôt��6   �� 5#      -   5         ��Name$ txtMontantDepot��5#      $��Center=�63   $	��100��6P   �� 5$      -   5         ��Name$ 
btnDeposer��5$      $��Deposer��6-   $��
0,10, 0, 0q�6?   6S   5%      �� 5'      $��50, 0, 0, 0q�6   .+�5(      �� 
�������$��Retrait��6*   �� 5)      $��Montant du retrait��6   �� 5*      -   5        $ txtMontantRetrait��5*      $��Center=�65   $	��100��6R   �� 5+      -   5        $ 
btnRetirer��5+      $��Retirer��6-   $��
0,10, 0, 0q�6?   6S   5,      5.      �� 50   
   $.��(________________________________________��6   $��Center=�51      
�������$	 0.2Q�63   �� 54   
   
�������$��Supprimer le compte��6"   �� 56   
   $��Center=�6   $��Italic$�61   .,Toute suppression de compte est définitive.�� 57   9   ecEn cliquant sur le bouton 'Supprimer', vous confirmez avoir pris connaissance de cette information.59      �� 5;   
   -   5        $ btnSupprimer��5;      $��	Supprimer��6'   $��Center=�5<      $	��100��6*   $��0, 10, 0, 0q�69   6N   5>      5?      