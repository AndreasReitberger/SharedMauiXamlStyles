namespace AndreasReitberger.Shared.Controls
{
    public partial class BorderlessEditor : Editor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BorderlessEditor"/> class.
        /// </summary>
        public BorderlessEditor()
        {
            TextChanged += ExtendableEditor_TextChanged;
        }

        #region Methods

        /// <summary>
        /// Invoked when editor text is changed.
        /// </summary>
        /// <param name="sender">The editor</param>
        /// <param name="e">Text changed event args</param>
        void ExtendableEditor_TextChanged(object? sender, TextChangedEventArgs e)
        {
            InvalidateMeasure();
        }

        #endregion
    }
}
