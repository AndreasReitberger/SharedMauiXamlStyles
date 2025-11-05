using AndreasReitberger.Shared.Syncfusion.Events;
using Syncfusion.Maui.DataSource;
using Syncfusion.Maui.ListView;
using System.Collections;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AndreasReitberger.Shared.Syncfusion.Controls
{
    public partial class EnhancedListView : SfListView
    {
        #region Fields

        /// <summary>
        /// Gets or sets the text value used to search.
        /// </summary>
        //SortDescriptor? defaultSortDescriptor;
        #endregion

        #region Bindings

        public static readonly BindableProperty SelectedItemsListProperty =
            BindableProperty.Create(nameof(SelectedItemsList), typeof(IList), typeof(EnhancedListView), new ArrayList(), BindingMode.TwoWay, null, OnSelectionChanged);

        /// <summary>
        /// Gets or sets the text value used to search.
        /// </summary>
        public static readonly BindableProperty SearchTextProperty =
            BindableProperty.Create(nameof(SearchText), typeof(string), typeof(EnhancedListView), string.Empty, BindingMode.TwoWay, null, OnSearchTextChanged);

        public static readonly BindableProperty FilterObjectProperty =
            BindableProperty.Create(nameof(Filter), typeof(object), typeof(EnhancedListView), null, BindingMode.TwoWay, null, OnFilterChanged);

        public static readonly BindableProperty IsFilterProperty =
            BindableProperty.Create(nameof(IsFiltered), typeof(bool), typeof(EnhancedListView), false, BindingMode.OneWay, null);

        public static readonly BindableProperty DefaultSortDescriptorProperty =
            BindableProperty.Create(nameof(DefaultSortDescriptor), typeof(SortDescriptor), typeof(EnhancedListView), null, BindingMode.TwoWay, null, OnDefaultSortDescriptorChanged);

        public static readonly BindableProperty CurrentPageProperty =
           BindableProperty.Create(nameof(CurrentPage), typeof(int), typeof(EnhancedListView), 0);

        public static readonly BindableProperty FilterCommandProperty =
            BindableProperty.Create(nameof(FilterCommand), typeof(ICommand), typeof(EnhancedListView), null);

        public static readonly BindableProperty FilterCommandParameterProperty =
            BindableProperty.Create(nameof(FilterCommandParameter), typeof(object), typeof(EnhancedListView), null);

        public static readonly BindableProperty OnFilterChangedCommandProperty =
            BindableProperty.Create(nameof(OnFilterChangedCommand), typeof(ICommand), typeof(EnhancedListView), null);

        public static readonly BindableProperty OnFilterChangedCommandParameterProperty =
            BindableProperty.Create(nameof(OnFilterChangedCommandParameter), typeof(object), typeof(EnhancedListView), null);

        public static readonly BindableProperty SortCommandProperty =
            BindableProperty.Create(nameof(SortCommand), typeof(ICommand), typeof(EnhancedListView), null);

        public static readonly BindableProperty SortCommandParameterProperty =
            BindableProperty.Create(nameof(SortCommandParameter), typeof(object), typeof(EnhancedListView), null);

        public static readonly BindableProperty ClearFilterCommandProperty =
            BindableProperty.Create(nameof(ClearFilterCommand), typeof(ICommand), typeof(EnhancedListView), null);

        public static readonly BindableProperty ClearFilterCommandParameterProperty =
            BindableProperty.Create(nameof(ClearFilterCommandParameter), typeof(object), typeof(EnhancedListView), null);

        public static readonly BindableProperty ValueBackCommandProperty =
            BindableProperty.Create(nameof(ValueBackCommand), typeof(ICommand), typeof(EnhancedListView), null);

        public static readonly BindableProperty ValueNextCommandProperty =
            BindableProperty.Create(nameof(ValueNextCommand), typeof(ICommand), typeof(EnhancedListView), null);

        #endregion

        #region Property

        public IList SelectedItemsList
        {
            get => (IList)GetValue(SelectedItemsListProperty);
            set => SetValue(SelectedItemsListProperty, value);
        }
        /// <summary>
        /// Gets or sets the text value used to search.
        /// </summary>
        public string SearchText
        {
            get { return (string)GetValue(SearchTextProperty); }
            set { SetValue(SearchTextProperty, value); }
        }
        public object? Filter
        {
            get { return GetValue(FilterObjectProperty); }
            set { SetValue(FilterObjectProperty, value); }
        }
        public bool IsFiltered
        {
            get { return (bool)GetValue(IsFilterProperty); }
            set { SetValue(IsFilterProperty, value); }
        }
        public SortDescriptor? DefaultSortDescriptor
        {
            get { return (SortDescriptor)GetValue(DefaultSortDescriptorProperty); }
            set { SetValue(DefaultSortDescriptorProperty, value); }
        }
        public int CurrentPage
        {
            get { return (int)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }
        public ICommand? FilterCommand
        {
            get { return (ICommand)GetValue(FilterCommandProperty); }
            set { SetValue(FilterCommandProperty, value); }
        }
        public object? FilterCommandParameter
        {
            get { return GetValue(FilterCommandParameterProperty); }
            set { SetValue(FilterCommandParameterProperty, value); }
        }
        public ICommand? OnFilterChangedCommand
        {
            get { return (ICommand)GetValue(OnFilterChangedCommandProperty); }
            set { SetValue(OnFilterChangedCommandProperty, value); }
        }
        public object? OnFilterChangedCommandParameter
        {
            get { return GetValue(OnFilterChangedCommandParameterProperty); }
            set { SetValue(OnFilterChangedCommandParameterProperty, value); }
        }
        public ICommand? SortCommand
        {
            get { return (ICommand)GetValue(SortCommandProperty); }
            set { SetValue(SortCommandProperty, value); }
        }
        public object? SortCommandParameter
        {
            get { return GetValue(SortCommandParameterProperty); }
            set { SetValue(SortCommandParameterProperty, value); }
        }
        public ICommand? ClearFilterCommand
        {
            get { return (ICommand)GetValue(ClearFilterCommandProperty); }
            set { SetValue(ClearFilterCommandProperty, value); }
        }
        public object? ClearFilterCommandParameter
        {
            get { return GetValue(ClearFilterCommandParameterProperty); }
            set { SetValue(ClearFilterCommandParameterProperty, value); }
        }
        public ICommand? ValueNextCommand
        {
            get { return (ICommand)GetValue(ValueNextCommandProperty); }
            set { SetValue(ValueNextCommandProperty, value); }
        }
        public ICommand? ValueBackCommand
        {
            get { return (ICommand)GetValue(ValueBackCommandProperty); }
            set { SetValue(ValueBackCommandProperty, value); }
        }
        #endregion

        #region Method
        void ItemSelect_SelectionChanged(object? sender, ItemSelectionChangedEventArgs e)
        {
            ArrayList list = new(SelectedItemsList);
            // Add new items
            if (e?.AddedItems is not null)
                foreach (var item in e.AddedItems)
                    if (!list.Contains(item))
                        list.Add(item);

            // Remove items
            if (e?.RemovedItems is not null)
                foreach (var item in e.RemovedItems)
                    if (list.Contains(item))
                        list.Remove(item);
            // Update list
            SelectedItemsList = list;
        }

        static void OnSelectionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            EnhancedListView? listView = bindable as EnhancedListView;
            if (newValue is IList selectedItems)
            {
                listView?.SetValue(SelectedItemsListProperty, selectedItems);
                if (selectedItems?.Count > 0 && listView?.SelectedItems?.Count == 0)
                {
                    foreach (var item in selectedItems)
                        listView.SelectedItems.Add(item);
                    //args.AddedItems.Add(item);
                    // Fire blank event
                    ItemSelectionChangedEventArgs args = new();
                    listView.ItemSelect_SelectionChanged(listView, args);
                };
            }
        }

        /// <summary>
        /// Invoked when the search text is changed.
        /// </summary>
        /// <param name="bindable">The SfListView</param>
        /// <param name="oldValue">The old value</param>
        /// <param name="newValue">The new value</param>
        /**/
        static void OnFilterChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is not EnhancedListView listView) return;
            try
            {
                if (newValue != null && listView.DataSource != null)
                {
                    OnFilterChanged(bindable, oldValue, newValue);
                }
                else if (listView.DataSource != null)
                {
                    //listView.filter = null;
                    listView.IsFiltered = false;
                    listView.DataSource.Filter = null;
                    listView.DataSource.RefreshFilter();
                }
                if (listView.OnFilterChangedCommand?.CanExecute(listView.OnFilterChangedCommandParameter) is true)
                    listView.OnFilterChangedCommand?.Execute(listView.OnFilterChangedCommandParameter);
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Exception: {exc?.Message}");
            }
        }

        static void OnSearchTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            //var listView = bindable as EnhancedListView;
            return;
        }

        static void OnDefaultSortDescriptorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            try
            {
                if (bindable is not EnhancedListView listView) return;
                if (newValue != null && listView.DataSource != null)
                {
                    listView.DefaultSortDescriptor = (SortDescriptor)newValue;
                    listView.DataSource.SortDescriptors.Clear();
                    if (listView.DefaultSortDescriptor != null)
                        listView.DataSource.SortDescriptors.Add(listView.DefaultSortDescriptor);

                    listView.DataSource.Refresh();
                    //listView.DataSource.RefreshFilter();
                    // Refresh causes exception if LayoutBase is GridLayout
                    if (listView?.ItemsLayout?.GetType() == typeof(LinearLayout))
                        listView.RefreshView();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Exception: {exc?.Message}");
            }
        }

        #endregion

        #region Constructor
        public EnhancedListView()
        {
            //Filter = null;
            DefaultSortDescriptor = null;

            SelectionChanged -= ItemSelect_SelectionChanged;
            SelectionChanged += ItemSelect_SelectionChanged;

            PropertyChanged -= SearchableListView_PropertyChanged;
            PropertyChanged += SearchableListView_PropertyChanged;
            //SelectionChanged += ItemSelect_SelectionChanged;
        }

        void SearchableListView_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            EnhancedListView? listView = (EnhancedListView?)sender;
            if (e == null) return;
            string? propertyName = e.PropertyName;
            if (!string.IsNullOrEmpty(propertyName))
            {
                if (listView != null)
                {
                    switch (propertyName)
                    {
                        case nameof(ItemsSource):
                            // clear selection on source change
                            listView.SelectedItemsList = new ArrayList(); ;
                            if (listView.DataSource != null && DefaultSortDescriptor != null)
                            {
                                listView.DataSource.SortDescriptors.Clear();
                                listView.DataSource.SortDescriptors.Add(DefaultSortDescriptor);
                                listView.DataSource.Refresh();

                            }
                            break;
                        case nameof(SelectedItems):
                            if (listView.SelectedItems != null)
                            {
                                listView.SelectedItems.CollectionChanged -= SelectedItems_CollectionChanged;
                                listView.SelectedItems.CollectionChanged += SelectedItems_CollectionChanged;
                            }
                            break;
                        case nameof(DataSource):
                            if (listView.DataSource != null && DefaultSortDescriptor != null)
                            {
                                listView.DataSource.SortDescriptors.Clear();
                                listView.DataSource.SortDescriptors.Add(DefaultSortDescriptor);
                                listView.DataSource.Refresh();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        void SelectedItems_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (sender is ObservableCollection<object> items)
            {
                if (SelectedItemsList.Count > items.Count)
                {
                    /*
                    foreach(object item in this.SelectedItemsList)
                    {
                        this.SelectedItems.Add(item);
                    }
                    */
                }
            }
        }
        #endregion

        #region Event Handlers
        public event EventHandler<EnhancedListViewFilterChangedEventArgs>? FilterChanged;
        protected virtual void OnFilterChanged(EnhancedListViewFilterChangedEventArgs e)
        {
            FilterChanged?.Invoke(this, e);
        }
        #endregion
    }
}
