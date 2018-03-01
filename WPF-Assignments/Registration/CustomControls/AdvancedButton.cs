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
        public static readonly DependencyProperty IsExpandProperty = DependencyProperty.Register("IsExpand ", typeof(bool), typeof(AdvancedButton));
        public bool IsExpand
        {
            get { return (bool)GetValue(IsExpandProperty); }
            set { SetValue(IsExpandProperty, value); }
        }
    }
}
