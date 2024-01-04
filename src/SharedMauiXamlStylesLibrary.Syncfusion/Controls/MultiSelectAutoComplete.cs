using Syncfusion.Maui.Inputs;
using System.Collections;
using SelectionChangedEventArgs = Syncfusion.Maui.Inputs.SelectionChangedEventArgs;

namespace AndreasReitberger.Shared.Syncfusion.Controls
{
    public class MultiSelectAutoComplete : SfAutocomplete
    {
        public MultiSelectAutoComplete()
        {
            SelectionChanged -= MultiSelectAutoComplete_SelectionChanged;
            SelectionChanged += MultiSelectAutoComplete_SelectionChanged;
        }

        void MultiSelectAutoComplete_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ArrayList list = new(SelectedItemsList);
            // Add new items
            if (e?.AddedItems is not null)
                foreach (var item in e?.AddedItems)
                    if (!list.Contains(item))
                        list.Add(item);
            // Remove items
            if (e?.RemovedItems is not null)
                foreach (var item in e?.RemovedItems)
                    if (list.Contains(item))
                        list.Remove(item);
            // Update list
            SelectedItemsList = list;
        }

        public IList SelectedItemsList
        {
            get => (IList)GetValue(SelectedItemsListProperty);
            set => SetValue(SelectedItemsListProperty, value);
        }

        public static readonly BindableProperty SelectedItemsListProperty =
            BindableProperty.Create(nameof(SelectedItemsList),
                typeof(IList),
                typeof(MultiSelectAutoComplete),
                new ArrayList(),
                BindingMode.Default,
                null,
                OnSelectionChanged);

        static void OnSelectionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            //MultiSelectAutoComplete control = bindable as MultiSelectAutoComplete;
            if (bindable is MultiSelectAutoComplete control && newValue is IList selectedItems)
            {
                control.SetValue(SelectedItemsListProperty, selectedItems);
            }
        }
    }
}
