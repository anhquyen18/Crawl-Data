   M S B A M L   `   `   `  ????O  KCrawDataFromHowKteam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CrawDataFromHowKteamCrawDataFromHowKteam  5   	   %    CrawDataFromHowKteam.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:CrawDataFromHowKteam     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??Auto ?6   6,   ?? 5      6    ? ColumnDefinitions 5   
   ?? 5      $	??250 ?6   6-   ?? 5      6"   .+?5   
   ? $??0??6   $??0??6   .+?5      ?? -   5        .??5   ,   	Load Data67   5      ? 5   
   $??1??6   $??0??6   .+?5      ?? -   5        .??5   *   Add item into tree view6C   5      R? 5   
   -   5         R?Name$ treeMain??5      $??0??6%   $??1??65   ??5      ?? 5       ?? ItemsSource 6+   ?? *Items+.R?5      ??  ?? Orientation$ 
Horizontal=?6!   .+?5      ?? ??6$   ?? *Name+6<   ?? 5      ??6!   ?? *URL+6;   5       5!      5#      (  "System.Windows.Controls.WebBrowser  5$   
   -   5          Name$ wbMain??5$      $??1??6%   $??1??65   6D   5%      5&      