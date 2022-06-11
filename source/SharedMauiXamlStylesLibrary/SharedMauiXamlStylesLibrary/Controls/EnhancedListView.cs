using AndreasReitberger.Shared.Events;
using Syncfusion.Maui.DataSource;
using Syncfusion.Maui.ListView;
using System.Collections;
using System.Collections.ObjectModel;

namespace AndreasReitberger.Shared.Controls
{
    public partial class EnhancedListView : SfListView
    {
        #region Field

        public IList SelectedItemsList
        {
            get => (IList)GetValue(SelectedItemsListProperty);
            set => SetValue(SelectedItemsListProperty, value);
        }

        public static readonly BindableProperty SelectedItemsListProperty =
            BindableProperty.Create(nameof(SelectedItemsList),
                typeof(IList),
                typeof(EnhancedListView),
                new ArrayList(),
                BindingMode.TwoWay,
                null,
                OnSelectionChanged);

        /// <summary>
        /// Gets or sets the text value used to search.
        /// </summary>
        public static readonly BindableProperty SearchTextProperty =
            BindableProperty.Create(nameof(SearchText), typeof(string), typeof(EnhancedListView), string.Empty, BindingMode.TwoWay, null, OnSearchTextChanged);

        /**/
        public static readonly BindableProperty FilterObjectProperty =
            BindableProperty.Create(nameof(Filter), typeof(object), typeof(EnhancedListView), null, BindingMode.TwoWay, null, OnFilterChanged);
        
        public static readonly BindableProperty IsFilterProperty =
            BindableProperty.Create(nameof(IsFiltered), typeof(bool), typeof(EnhancedListView), false, BindingMode.OneWay, null);

        public static readonly BindableProperty DefaultSortDescriptorProperty =
            BindableProperty.Create(nameof(DefaultSortDescriptor), typeof(SortDescriptor), typeof(EnhancedListView), null, BindingMode.TwoWay, null, OnDefaultSortDescriptorChanged);

        /// <summary>
        /// Gets or sets the text value used to search.
        /// </summary>
        //string searchText;
        //ListViewFilterBase filter;
        SortDescriptor defaultSortDescriptor;
        #endregion

        #region Property

        /// <summary>
        /// Gets or sets the text value used to search.
        /// </summary>
        public string SearchText
        {
            get { return (string)GetValue(SearchTextProperty); }
            set { SetValue(SearchTextProperty, value); }
        }
        /**/
        public object Filter
        {
            get { return GetValue(FilterObjectProperty); }
            set { SetValue(FilterObjectProperty, value); }
        }
        
        //bool _isFiltered = false;
        public bool IsFiltered
        {
            get { return (bool)GetValue(IsFilterProperty); }
            set { SetValue(IsFilterProperty, value); }
        }

        public SortDescriptor DefaultSortDescriptor
        {
            get { return (SortDescriptor)GetValue(DefaultSortDescriptorProperty); }
            set { SetValue(DefaultSortDescriptorProperty, value); }
        }
        #endregion

        #region Method
        void ItemSelect_SelectionChanged(object sender, ItemSelectionChangedEventArgs e)
        {

            ArrayList list = new(SelectedItemsList);
            // Add new items
            foreach (var item in e.AddedItems)
                if (!list.Contains(item))
                    list.Add(item);

            // Remove items
            foreach (var item in e.RemovedItems)
                if (list.Contains(item))
                    list.Remove(item);

            // Update list
            SelectedItemsList = list;
        }

        static void OnSelectionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            EnhancedListView listView = bindable as EnhancedListView;
            if (newValue is IList selectedItems)
            {
                listView.SetValue(SelectedItemsListProperty, selectedItems);
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

        /// <summary>
        /// Filtering the list view items based on the search text.
        /// </summary>
        /// <param name="obj">The list view item</param>
        /// <returns>Returns the filtered item</returns>
        /*
        public virtual bool FilterListView(object obj)
        {
            if (Filter == null)
            {
                return false;
            }
            return true;
        }
        */

        static void OnDefaultSortDescriptorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            try
            {
                if (bindable is not EnhancedListView listView) return;
                if (newValue != null && listView.DataSource != null)
                {
                    listView.defaultSortDescriptor = (SortDescriptor)newValue;
                    listView.DataSource.SortDescriptors.Clear();
                    if (listView.DefaultSortDescriptor != null)
                        listView.DataSource.SortDescriptors.Add(listView.defaultSortDescriptor);

                    listView.DataSource.Refresh();
                    //listView.DataSource.RefreshFilter();
                    // Refresh causes exception if LayoutBase is GridLayout
                    if (listView.ItemsLayout.GetType() == typeof(LinearLayout))
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

        void SearchableListView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            EnhancedListView listView = (EnhancedListView)sender;
            if (e == null) return;
            string propertyName = e.PropertyName;
            if (!string.IsNullOrEmpty(propertyName))
            {
                if (listView != null)
                {
                    switch (propertyName)
                    {
                        case nameof(ItemsSource):
                            // clear selection on source change
                            listView.SelectedItemsList = new ArrayList(); ;
                            if (listView.DataSource != null && defaultSortDescriptor != null)
                            {
                                listView.DataSource.SortDescriptors.Clear();
                                listView.DataSource.SortDescriptors.Add(defaultSortDescriptor);
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
                            if (listView.DataSource != null && defaultSortDescriptor != null)
                            {
                                listView.DataSource.SortDescriptors.Clear();
                                listView.DataSource.SortDescriptors.Add(defaultSortDescriptor);
                                listView.DataSource.Refresh();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        void SelectedItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
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
        public event EventHandler<EnhancedListViewFilterChangedEventArgs> FilterChanged;
        protected virtual void OnFilterChanged(EnhancedListViewFilterChangedEventArgs e)
        {
            FilterChanged?.Invoke(this, e);
        }
        #endregion
    }
}
