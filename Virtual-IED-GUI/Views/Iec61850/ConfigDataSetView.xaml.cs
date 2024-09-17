using System;
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
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.ViewModels.Iec61850;

namespace Virtual_IED_GUI.Views.Iec61850
{
    /// <summary>
    /// Interaction logic for ConfigDataSetView.xaml
    /// </summary>
    public partial class ConfigDataSetView : UserControl
    {
        public ConfigDataSetView()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty DropCommandProperty =
            DependencyProperty.RegisterAttached("DropCommand", typeof(ICommand), typeof(ConfigDataSetView));

        public static ICommand GetDropCommand(DependencyObject obj) => (ICommand)obj.GetValue(DropCommandProperty);
        public static void SetDropCommand(DependencyObject obj, ICommand value) => obj.SetValue(DropCommandProperty, value);

        private void TreeViewItem_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            var obj = e.OriginalSource as DependencyObject;
            while (obj != null && !(obj is TreeViewItem))
            {
                obj = VisualTreeHelper.GetParent(obj);
            }
            TreeViewItem item = obj as TreeViewItem;
            if (item == null) return;
            item.IsExpanded = !item.IsExpanded;
            e.Handled = true;
        }

        private void TreeViewItem_MouseEnterEventHandler(object sender, MouseEventArgs e)
        {
            if (sender is TreeViewItem item)
            {
                if (item.Items.Count == 0)
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                    //if (e.LeftButton == MouseButtonState.Pressed)
                    //{
                    //    DragDrop.DoDragDrop(item, item.DataContext, DragDropEffects.Move);
                    //}
                }
            }
            e.Handled = true;
        }

        private void TreeViewItem_MouseLeaveEventHandler(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
            e.Handled = true;
        }

        private void TreeViewItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            var obj = e.OriginalSource as DependencyObject;
            while (obj != null && !(obj is TreeViewItem))
            {
                obj = VisualTreeHelper.GetParent(obj);
            }
            TreeViewItem item = obj as TreeViewItem;

            if (item.Items.Count == 0)
            {
                DragDrop.DoDragDrop(item, item.DataContext, DragDropEffects.Move);
            }
            e.Handled = true;
        }

        private void ListView_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(SCLTreeNode)))
            {
                var treeNode = e.Data.GetData(typeof(SCLTreeNode)) as SCLTreeNode;
                if (treeNode != null)
                {
                    var command = ((ICommand)ListViewDataSet.GetValue(DropCommandProperty));
                    command.Execute(treeNode);
                }
            }
        }


        private void ListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                var listView = sender as ListView;
                var viewModel = listView.DataContext as ConfigDataSetViewModel;

                var selectedItem = listView.SelectedItem as SCLTreeNode;
                if (selectedItem != null && viewModel.DeleteDataSetItemCommand.CanExecute(selectedItem))
                {
                    viewModel.DeleteDataSetItemCommand.Execute(selectedItem);
                }
            }
        }
    
    
    }
}
