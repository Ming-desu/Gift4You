namespace Ordering_System___Gift_4_You
{
    using System.Windows.Forms;

    /// <summary>
    /// A helper class that animates a window form
    /// </summary>
    public class Animator
    {
        /// <summary>
        /// The method that provides a fade in effect to the window
        /// </summary>
        /// <param name="form">The window to be animated</param>
        public static void FadeIn(Form form)
        {
            form.Opacity = 0;
            Timer t = new Timer();
            t.Interval = 1;
            t.Tick += (sender, e) => {
                if (form.Opacity < 1)
                    form.Opacity += 0.05;
                else
                    t.Stop();

                form.Invalidate();
            };
            t.Start();
        }
    }
}
