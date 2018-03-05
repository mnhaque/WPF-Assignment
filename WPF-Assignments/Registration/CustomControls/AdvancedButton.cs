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
        public static readonly DependencyProperty IsExpandProperty = DependencyProperty.Register("IsExpand", typeof(bool), typeof(AdvancedButton), new UIPropertyMetadata(true, OnValueChanged));

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            if (IsExpand)
            {
                this.Height = this.Height * 2;
                this.Width = this.Width * 2;
            }
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = d as AdvancedButton;
            if (button.IsInitialized)
            {
                if ((bool)e.NewValue)
                {
                    button.Height = button.Height*2;
                    button.Width = button.Width*2;
                }
                else
                {
                    button.Height = button.Height / 2;
                    button.Width = button.Width / 2;
                }
            }
        }

        public bool IsExpand
        {
            get { return (bool)GetValue(IsExpandProperty); }
            set { SetValue(IsExpandProperty, value); }
        }
    }
}
