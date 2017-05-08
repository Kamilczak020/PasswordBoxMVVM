﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PasswordBoxMVVM
{
    class HasBeenEnabledEventArgs : RoutedEventArgs
    {
        public bool Value { get; private set; }

        public HasBeenEnabledEventArgs(RoutedEvent routedEvent, bool value)
            : base(routedEvent)
        {
            Value = value;
        }
    }
}
