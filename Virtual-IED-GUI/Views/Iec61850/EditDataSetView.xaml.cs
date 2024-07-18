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

namespace Virtual_IED_GUI.Views.Iec61850
{
    /// <summary>
    /// Interaction logic for EditDataSetView.xaml
    /// </summary>
    public partial class EditDataSetView : UserControl
    {
        public EditDataSetView()
        {
            InitializeComponent();
        }

        private void TreeViewItem_ExpandedCollapsed(object sender, RoutedEventArgs e)
        {
            var treeViewItem = sender as TreeViewItem;
            if (treeViewItem == null) return;

            // Update HLine for this TreeViewItem and all ancestors
            

            e.Handled = true;
        }

        private void UpdateHLine(TreeViewItem treeViewItem)
        {
            var grid = FindVisualChild<Grid>(treeViewItem);
            if (grid != null)
            {
                var line = grid.FindName("HLine") as Line;
                if (line != null)
                {
                    var numDataShowed = treeViewItem.Items.SourceCollection;
                    var height = grid.ActualHeight * treeViewItem.Items.Count;
                    line.Y2 = treeViewItem.IsExpanded ? height : 0;
                }
            }
        }

        private void UpdateParentHLine(DependencyObject child)
        {
            var parent = VisualTreeHelper.GetParent(child);
            if (parent != null)
            {
                var parentItem = parent as TreeViewItem;
                if (parentItem != null)
                {
                    UpdateHLine(parentItem);
                    UpdateParentHLine(parentItem);
                }
            }
        }

        private T FindVisualChild<T>(DependencyObject parent) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is T)
                {
                    return (T)child;
                }
                var result = FindVisualChild<T>(child);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }

        private void EventSetter_OnHandler(object sender, RoutedEventArgs e)
        {
            var obj = e.OriginalSource as DependencyObject;
            while (obj != null && !(obj is TreeViewItem))
            {
                obj = VisualTreeHelper.GetParent(obj);
            }
            TreeViewItem item = obj as TreeViewItem;
            if (item == null) return;
            item.IsExpanded = !item.IsExpanded;



            UpdateHLine(item);
            UpdateParentHLine(item);


            e.Handled = true;
        }
    }
}
