   M S B A M L   `   `   `  ����H  Dprog2500_imdb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:prog2500_imdbprog2500_imdb  5   	       prog2500_imdb.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:prog2500_imdb     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
         	HomeImage �� 	UriSource  MoviesImage  ActorsImage  
GenreImage�� 5   
   %�   &	        &	 /     &	 d     &	 �     �� 5      $ /images/home.png?�6,   6K   �� 5      $ /images/film-slate.png?�6.   6S   �� 5      $ /images/actor.png?�6.   6N   �� 5      $ /images/genre.png?�6-   6M   5      .��5      ]� ���#ccc3b6.+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $��_Exit��6   6,   5      m� 5      $��Pages��6   .@�5      m� -   5         m�Name$
 Home��5      $��_Home��6)    m� Icon 5      �� 5      #��[  6    6F   5      m� 5       -   5        $ 
ViewMovies��5       $��_View Movies��6/    5!      �� 5#      #��[ 6    6H   5&      m� 5'      -   5        $ 
ViewActors��5'      $��_View Actors��6/    5(      �� 5*      #��[ 6    6H   5-      m� 5.      -   5        $ 
ViewGenres��5.      $��_View Genres��6/    5/      �� 51      #��[ 6    6G   54      55      56      c� 57   
   $
��Left=�6   ���#708692.@�58      ��  �� Orientation$ Vertical=�6   $��65��60   .+�5:      ��   BorderStyle#��[ 6   $��70��6>   ._�5;      �� -   5         ��Name$ 
HomeButton��5;       � ToolTip$
 Home��6J    5<       �� 
TargetType	 �� Property
 �� Value��%c   '��       �� 5=      " ��6$   .�5>   "   �� 	 �@��CornerRadius$
 5��6A   6M   5?      5@      .��5A      �� #��[  6    6F   5B      5C      �� 5E      #��[ 6   $��70��6>   ._�5F      �� -   5        $ MoviesButton��5F      $ Movies��6O    5G      ��%c   '��       �� 5H      " ��6$   .�5I   "   �� 	 �@��CornerRadius$
 5��6A   6M   5J      5K      .��5L      �� #��[ 6    6H   5M      5N      �� 5P      #��[ 6   $��70��6>   ._�5Q      �� -   5        $ ActorsButton��5Q      $ Actors��6N    5R      ��%c   '��       �� 5S      " ��6$   .�5T   "   �� 	 �@��CornerRadius$
 5��6A   6M   5U      5V      .��5W      �� #��[ 6    6H   5X      5Y      �� 5[      #��[ 6   $��70��6>   ._�5\      �� -   5        $ GenresButton��5\      $ Genres��6N    5]      ��%c   '��       �� 5^      " ��6$   .�5_   "   �� 	 �@��CornerRadius$
 5��6A   6M   5`      5a      .��5b      �� #��[ 6    6G   5c      5d      5f      5g       � 5h   
   -	   5          �Name$ 	mainFrame��5h      $
��Auto��6#   $
��Auto��61     � NavigationUIVisibility$ Hidden=�6>   $��Bottom=�5i      5j      5k      5l      