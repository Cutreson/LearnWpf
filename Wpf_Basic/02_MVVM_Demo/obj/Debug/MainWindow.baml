   M S B A M L   `   `   `  ????G  C02_MVVM_Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:_02_MVVM_Demo_02_MVVM_Demo  5   	   A%clr-namespace:_02_MVVM_Demo.ViewModel_02_MVVM_Demo.ViewModel  5   	       _02_MVVM_Demo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:_02_MVVM_Demo     5   	   =MyViewModel%clr-namespace:_02_MVVM_Demo.ViewModel     5   	     ? Title$  
MainWindow??5	   	   $	??400??6   $	??400??6)    ? DataContext 5
      -   '_02_MVVM_Demo.ViewModel.SimpleViewModel  5   
   6(   .??5      ? $??0,0,0,-6q?6    ? ColumnDefinitions 5   
   ?? 5      $??3* ?6   ?? 5      $??7* ?6    ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      $	??200 ?6   .+?5   
   ?? $??A??6   $??Center=?6   69   ?? 5   
   $??1??6   $??B??6   $??Center=?6)   6F   ?? 5   
   $??2??6   $??A + B??6   $??Center=?6-   6J   ?? 5   
   -   5        $
??txtA??5      $??1??6m   $??Center=?6}   ??6   ?? *FirstNumber+ ?? Mode$ TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5   
   -   5        $
??txtB??5      $??1??6n   $??1??6~   $??Center=?6?   ??6   ?? *SecondNumber+$ TwoWay=?$ PropertyChanged=?6?   ?? 5   
   -   5        $??txtSum??5      $??1??6g   $??2??6w   $??Center=?6?   ??6    ?? *Sum+$ TwoWay=?$ PropertyChanged=?6?   ?? 5   
   -   5        $??btnSum??5      $	??Sum??6A   $??1??6O   $??3??6_   $??Center=?6l   $??Center=?6?   ??6   ?? *SubmitCommand+6?   &   System.Windows.Controls.DataGrid  5    
   $??4??6   $??2??6?   ??6    ?? *lstSum+6U   5!      5"      