namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// A custom confirm dialog 
    /// </summary>
    public partial class Confirm : Form
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Confirm()
        {
            InitializeComponent();

            // Start the timer to create fade in effect
            timer1.Start();
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="caption">The caption of the dialog</param>
        /// <param name="title">The title of the dialog</param>
        public Confirm(string caption, string title="Attention!")
        {
            InitializeComponent();

            // Set the descriptions to the labels
            label_title.Text = title;
            label_caption.Text = caption;

            // Make sure that the labels are centered
            label_title.Left = (label_title.Parent.Width - label_title.Width) / 2;
            label_caption.Left = (label_caption.Parent.Width - label_caption.Width) / 2;

            // Start the timer to create fade in effect
            timer1.Start();
        }

        #endregion

        #region Private Members

        /// <summary>
        /// The result of the dialog
        /// </summary>
        private static DialogResult result;

        #endregion

        #region Public Methods

        /// <summary>
        /// A method that will return DialogResult.Yes or DialogResult.No
        /// </summary>
        /// <returns>DialogResult</returns>
        public new DialogResult Show()
        {
            ShowDialog();
            return result;
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
            if ((sender as Control).Name == "button_yes")
                result = DialogResult.Yes;
            else
                result = DialogResult.No;

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
}
