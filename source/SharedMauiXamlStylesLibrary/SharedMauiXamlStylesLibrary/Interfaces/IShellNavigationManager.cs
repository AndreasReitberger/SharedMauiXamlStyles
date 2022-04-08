namespace AndreasReitberger.Shared.Interfaces
{
    public interface IShellNavigationManager
    {
        #region Properties
        string CurrentRoute { get; }
        string PreviousRoute { get; }
        string RootPage { get; }
        List<string> AvailableEntryPages { get; }
        #endregion

        #region Methods

        Task<bool> GoToAsync(string target, bool flyoutIsPresented = false, int delay = -1, bool animate = true);
        Task GoBackAsync(bool flyoutIsPresented = false, int delay = -1, bool animate = true);
        bool IsCurrentPathRoot();
        void RegisterRoutes();
        #endregion
    }
}
