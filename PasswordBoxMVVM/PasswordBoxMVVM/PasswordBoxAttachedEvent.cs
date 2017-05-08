using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PasswordBoxMVVM
{
    public static class PasswordBoxAttachedEvent
    {
        public static readonly RoutedEvent HasBeenDisabledEvent = EventManager.RegisterRoutedEvent("HasBeenDisabled", RoutingStrategy.Bubble, typeof(HasBeenDisabledEventArgs), typeof(PasswordBoxAttachedEvent));
        public static readonly RoutedEvent HasBeenEnabledEvent = EventManager.RegisterRoutedEvent("HasBeenEnabled", RoutingStrategy.Bubble, typeof(HasBeenEnabledEventArgs), typeof(PasswordBoxAttachedEvent));

        public static void AddHasBeenDisabledHandler(DependencyObject d, RoutedEventHandler handler)
        {
            UIElement uie = d as UIElement;
            if (uie != null)
            {
                uie.AddHandler(PasswordBoxMVVM.PasswordBoxAttachedEvent.HasBeenDisabledEvent, handler);
            }
        }
        public static void RemoveHasBeenDisabledHandler(DependencyObject d, RoutedEventHandler handler)
        {
            UIElement uie = d as UIElement;
            if (uie != null)
            {
                uie.RemoveHandler(PasswordBoxMVVM.PasswordBoxAttachedEvent.HasBeenDisabledEvent, handler);
            }
        }

        public static void AddHasBeenEnabledHandler(DependencyObject d, RoutedEventHandler handler)
        {
            UIElement uie = d as UIElement;
            if (uie != null)
            {
                uie.AddHandler(PasswordBoxMVVM.PasswordBoxAttachedEvent.HasBeenEnabledEvent, handler);
            }
        }
        public static void RemoveHasBeenEnabledHandler(DependencyObject d, RoutedEventHandler handler)
        {
            UIElement uie = d as UIElement;
            if (uie != null)
            {
                uie.RemoveHandler(PasswordBoxMVVM.PasswordBoxAttachedEvent.HasBeenEnabledEvent, handler);
            }
        }
    }
}
