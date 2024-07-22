using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Virtual_IED_GUI.Interfaces;

namespace Virtual_IED_GUI.Components
{
    public class DragDropBehaviour
    {
        public static readonly DependencyProperty IsDragSourceProperty =
         DependencyProperty.RegisterAttached("IsDragSource", typeof(bool), typeof(DragDropBehaviour), new PropertyMetadata(false, OnIsDragSourceChanged));

        public static readonly DependencyProperty IsDropTargetProperty =
            DependencyProperty.RegisterAttached("IsDropTarget", typeof(bool), typeof(DragDropBehaviour), new PropertyMetadata(false, OnIsDropTargetChanged));

        public static readonly DependencyProperty DragCommandProperty =
            DependencyProperty.RegisterAttached("DragCommand", typeof(ICommand), typeof(DragDropBehaviour));

        public static readonly DependencyProperty DropCommandProperty =
            DependencyProperty.RegisterAttached("DropCommand", typeof(ICommand), typeof(DragDropBehaviour));

        public static bool GetIsDragSource(DependencyObject obj) => (bool)obj.GetValue(IsDragSourceProperty);
        public static void SetIsDragSource(DependencyObject obj, bool value) => obj.SetValue(IsDragSourceProperty, value);

        public static bool GetIsDropTarget(DependencyObject obj) => (bool)obj.GetValue(IsDropTargetProperty);
        public static void SetIsDropTarget(DependencyObject obj, bool value) => obj.SetValue(IsDropTargetProperty, value);

        public static ICommand GetDragCommand(DependencyObject obj) => (ICommand)obj.GetValue(DragCommandProperty);
        public static void SetDragCommand(DependencyObject obj, ICommand value) => obj.SetValue(DragCommandProperty, value);

        public static ICommand GetDropCommand(DependencyObject obj) => (ICommand)obj.GetValue(DropCommandProperty);
        public static void SetDropCommand(DependencyObject obj, ICommand value) => obj.SetValue(DropCommandProperty, value);

        private static void OnIsDragSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UIElement uiElement)
            {
                if ((bool)e.NewValue)
                    uiElement.PreviewMouseLeftButtonDown += OnMouseLeftButtonDown;
                else
                    uiElement.PreviewMouseLeftButtonDown -= OnMouseLeftButtonDown;
            }
        }

        private static void OnIsDropTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UIElement uiElement)
            {
                if ((bool)e.NewValue)
                    uiElement.Drop += OnDrop;
                else
                    uiElement.Drop -= OnDrop;
            }
        }

        private static void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (sender is TreeView treeItem)
                {
                    if (treeItem.Items.Count == 0)
                    {
                        DragDrop.DoDragDrop(treeItem, treeItem, DragDropEffects.Move);
                    }
                }
            }
        }

        private static void OnDrop(object sender, DragEventArgs e)
        {
            if (sender is UIElement uiElement)
            {
                var command = GetDropCommand(uiElement);
                if (command != null && command.CanExecute(e))
                {
                    command.Execute(e);
                }
            }
        }
    }
}
