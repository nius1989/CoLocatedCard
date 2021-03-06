﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace CoLocatedCardSystem.CollaborationWindow
{
    class UIHelper
    {
        /// <summary>
        /// Update the render transform
        /// </summary>
        /// <param name="position"></param>
        /// <param name="rotation"></param>
        /// <param name="scale"></param>
        /// <param name="element"></param>
        public static void InitializeUI(Point position, double rotation, double scale, Size size, FrameworkElement element)
        {
            element.Width = size.Width;
            element.Height = size.Height;
            ScaleTransform st = new ScaleTransform();
            st.ScaleX = scale;
            st.ScaleY = scale;
            RotateTransform rt = new RotateTransform();
            rt.Angle = rotation;
            TranslateTransform tt = new TranslateTransform();
            tt.X = position.X;
            tt.Y = position.Y;
            TransformGroup transGroup = new TransformGroup();
            transGroup.Children.Add(st);
            transGroup.Children.Add(rt);
            transGroup.Children.Add(tt);
            element.RenderTransform = transGroup;
        }
    }
}
