using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Registration.CustomControls
{
    public class AdvancedButton : Button
    {
        public static readonly DependencyProperty IsExpandProperty = DependencyProperty.Register("IsExpand", typeof(bool?), typeof(AdvancedButton), new PropertyMetadata(false,OnValueChanged));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = d as AdvancedButton;
            if ((bool)e.NewValue)
            {
                button.Height = 2 * button.ActualHeight;
                button.Width = 2 * button.ActualWidth;
            }
            else
            {
                button.Height = button.ActualHeight/2;
                button.Width = button.ActualWidth/2;
            }
        }

        public bool IsExpand
        {
            get { return (bool)GetValue(IsExpandProperty); }
            set { SetValue(IsExpandProperty, value); }
        }
    }
}
