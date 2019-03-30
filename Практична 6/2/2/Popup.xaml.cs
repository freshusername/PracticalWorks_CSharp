using System;
using System.Windows;
using System.Windows.Threading;

public partial class NotificationWindow
{
    public NotificationWindow()
    {
        InitializeComponent();

        Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            //Top = 0;
            //Left = 0;
            Width = System.Windows.SystemParameters.WorkArea.Width / 7 ;
            Height = System.Windows.SystemParameters.WorkArea.Height / 7 ;
            var workingArea = System.Windows.SystemParameters.WorkArea;
            var transform = PresentationSource.FromVisual(this).CompositionTarget.TransformFromDevice;
            var corner = transform.Transform(new Point(workingArea.Right, workingArea.Bottom));

            this.Left = corner.X;
            this.Top = corner.Y;
        }));
    }
}