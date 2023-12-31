﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using WPFDemo.ViewModel;
using MaterialDesignThemes.Wpf;

namespace WPFDemo
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			var menuRegister = new List<SubItem>();
			menuRegister.Add(new SubItem("客户"));
			menuRegister.Add(new SubItem("供应商"));
			menuRegister.Add(new SubItem("员工"));
			menuRegister.Add(new SubItem("产品"));
			var item6 = new ItemMenu("登记", menuRegister, PackIconKind.Register);

			var menuSchedule = new List<SubItem>();
			menuSchedule.Add(new SubItem("服务"));
			menuSchedule.Add(new SubItem("会议"));
			var item1 = new ItemMenu("预约", menuSchedule, PackIconKind.Schedule);

			var menuReports = new List<SubItem>();
			menuReports.Add(new SubItem("客户"));
			menuReports.Add(new SubItem("供应商"));
			menuReports.Add(new SubItem("产品"));
			menuReports.Add(new SubItem("库存"));
			menuReports.Add(new SubItem("销售额"));
			var item2 = new ItemMenu("报告", menuReports, PackIconKind.FileReport);

			var menuExpenses = new List<SubItem>();
			menuExpenses.Add(new SubItem("固定资产"));
			menuExpenses.Add(new SubItem("流动资金"));
			var item3 = new ItemMenu("费用", menuExpenses, PackIconKind.ShoppingBasket);

			var menuFinancial = new List<SubItem>();
			menuFinancial.Add(new SubItem("现金流"));
			var item4 = new ItemMenu("财务", menuFinancial, PackIconKind.ScaleBalance);

			Menu.Children.Add(new UserControlMenuItem(item6, this));
			Menu.Children.Add(new UserControlMenuItem(item1, this));
			Menu.Children.Add(new UserControlMenuItem(item2, this));
			Menu.Children.Add(new UserControlMenuItem(item3, this));
			Menu.Children.Add(new UserControlMenuItem(item4, this));
		}
		internal void SwitchScreen(object sender)
		{
			var screen = ((UserControl)sender);

			if (screen != null)
			{
				frmMain.Children.Clear();
				frmMain.Children.Add(screen);
			}
			else
			{
				frmMain.Children.Clear();
			}
		}
		private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
		{
			ButtonOpenMenu.Visibility = Visibility.Collapsed; 
			ButtonCloseMenu.Visibility = Visibility.Visible;
		}

		private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
		{
			ButtonOpenMenu.Visibility = Visibility.Visible;
			ButtonCloseMenu.Visibility = Visibility.Collapsed;
		}

		private void Window_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				this.DragMove();
			}
		}
	}
}
