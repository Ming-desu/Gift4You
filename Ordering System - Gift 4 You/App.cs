namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The main window of the application
    /// </summary>
    public partial class App : Form
    {
        #region Default Constructor

        public App()
        {
            InitializeComponent();

            Animator.FadeIn(this);
            ViewPage();
        } 

        #endregion

        #region Event Triggers

        /// <summary>
        /// The event to be triggered when a button on the toolbar was clicked
        /// </summary>
        /// <param name="sender">The object who triggered the event</param>
        /// <param name="e">The event itself</param>
        private void Button_Toolbar_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;

            // Check the name
            if (c.Name == "button_exit")
                Environment.Exit(0);
            else
                WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// The event to be triggered when a button was hovered
        /// </summary>
        /// <param name="sender">The object who triggered the event</param>
        /// <param name="e">The event itself</param>
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).Parent.BackColor = Color.FromArgb(235, 239, 245);
        }


        /// <summary>
        /// The event that triggers when the mouse leaves on button
        /// </summary>
        /// <param name="sender">The source of trigger</param>
        /// <param name="e">The event itself</param>
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).Parent.BackColor = Color.FromArgb(255, 255, 255);
        }

        /// <summary>
        /// The event to be triggered when a button on the navigation was clicked
        /// </summary>
        /// <param name="sender">The object who triggered the event</param>
        /// <param name="e">The event itself</param>
        private void Navigation_Click(object sender, EventArgs e)
        {
            var button = sender as Control;

            if (button.Tag != null)
                ViewPage(button.Tag.ToString());
        }

        /// <summary>
        /// The method that toggles the width of the navigation
        /// </summary>
        /// <param name="sender">The button that triggers this event</param>
        /// <param name="e">The event itself</param>
        private void Toggle_Sidebar(object sender, EventArgs e)
        {
            if (sidebar.Width == sidebar.MaximumSize.Width)
                sidebar.Width = sidebar.MinimumSize.Width;
            else
                sidebar.Width = sidebar.MaximumSize.Width;
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// The method that toggles between pages
        /// </summary>
        /// <param name="className">The name of the class of the object to be viewed</param>
        private void ViewPage(string className = "Ordering_System___Gift_4_You.Products")
        {
            // Check if there are any form in the parent
            if (main.Controls.Count != 0)
            {
                // Close each form present in the parent
                foreach (var control in main.Controls)
                {
                    var form = control as Form;
                    form.Close();
                }
            }

            // Set the breadcrumbs label to the current active page
            label_active.Text = "> " + className.Split('.')[className.Split('.').Length - 1];

            // Get the instance of the class name and cast it as form
            // so that we can manipulate its properties and work as a form
            var formObj = GetInstance(className) as Form;

            // Set some properties in order for the form to be viewed in a panel
            formObj.TopLevel = false;
            formObj.Dock = DockStyle.Fill;
            formObj.Parent = main;
            formObj.Show();
        }

        /// <summary>
        /// The method that will return an object
        /// base on the class name that passed on the parameter
        /// </summary>
        /// <param name="className">The name of the class to get the instance</param>
        /// <returns>object</returns>
        private object GetInstance(string className)
        {
            // Get the type of the class
            Type type = Type.GetType(className);

            if (type != null)
                // Return the instance of the type
                return Activator.CreateInstance(type);

            return null;
        }  

        #endregion
    }
}
