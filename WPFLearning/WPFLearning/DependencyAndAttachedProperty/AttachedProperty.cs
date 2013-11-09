using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WPFLearning
{
    partial class AttachedProperty
    {
        public static readonly DependencyProperty AttachedPropertyExampleProperty = DependencyProperty.RegisterAttached(
        "AttachedPropertyExample", //nazwa propercji
        typeof(Boolean), //typ propercji
        typeof(Control), //typ klasy, która ma tą propercję zawierać
        new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender) //typ akcji, który zostanie podjęty po zmianie wartości
        );
        public static void SetAttachedPropertyExample(UIElement element, Boolean value)
        {
            element.SetValue(AttachedPropertyExampleProperty, value);
        }
        public static Boolean GetAttachedPropertyExample(UIElement element)
        {
            return (Boolean)element.GetValue(AttachedPropertyExampleProperty);
        }
    }
}
