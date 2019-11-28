namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// A custom notification dialog
    /// </summary>
    public partial class Notification : Form
    {
        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Notification()
        {
            InitializeComponent();

            // Start the timer to create a fade in effect
            timer1.Start();
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="caption">The caption of the dialog</param>
        /// <param name="title">The title of the dialog</param>
        public Notification(string caption, string title = "Awesome!", MessageType type = MessageType.Success)
        {
            InitializeComponent();

            if (type != MessageType.Success)
                picture_icon.Image = Ordering_System___Gift_4_You.Properties.Resources.icon_error;

            // Set the descriptions to the labels
            label_title.Text = title;
            label_caption.Text = caption;

            // Make sure that the labels are centered
            label_title.Left = (label_title.Parent.Width - label_title.Width) / 2;
            label_caption.Left = (label_caption.Parent.Width - label_caption.Width) / 2;

            // Start the timer to create a fade in effect
            timer1.Start();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// The event that will trigger when a button was clicked
        /// </summary>
        /// <param name="sender">The object who trigger the event</param>
        /// <param name="e">The event itself</param>
        private void Button_Click(object sender, EventArgs e)
        {
            // Start the timer to create a fade out effect
            timer2.Start();
        }

        /// <summary>
        /// The event that will create the fade in effect
        /// </summary>
        /// <param name="sender">The timer</param>
        /// <param name="e">The event itself</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Every tick will add 0.5% to the opacity
            if (Opacity < 1)
                Opacity += 0.05;
            else
                timer1.Stop();
        }

        /// <summary>
        /// The event that will create the fade out effect
        /// </summary>
        /// <param name="sender">The timer</param>
        /// <param name="e">The event itself</param>
        private void Timer2_Tick(object sender, EventArgs e)
        {
            // Every tick will deduct 0.5% to the opacity
            if (Opacity > 0)
                Opacity -= 0.05;
            else
                // Close the form after the fade out effect
                this.Close();
        }

        #endregion
    }

    /// <summary>
    /// The message type of the notification
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// The message was success
        /// </summary>
        Success = 0,

        /// <summary>
        /// The message has encountered error
        /// </summary>
        Danger = 1
    }
}
