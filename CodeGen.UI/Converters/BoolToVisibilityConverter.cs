﻿// -----------------------------------------------------------------------
// <copyright file="BoolToVisibilityConverter.cs" company="">
// Copyright (c) Code Generator. All rights reserved. 
// </copyright>
// -----------------------------------------------------------------------

namespace CodeGen.UI.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// This class represents BoolToVisibilityConverter class.
    /// </summary>
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
