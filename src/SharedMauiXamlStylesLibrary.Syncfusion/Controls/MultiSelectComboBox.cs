using Syncfusion.Maui.Inputs;
using System.Collections;
using SelectionChangedEventArgs = Syncfusion.Maui.Inputs.SelectionChangedEventArgs;

namespace AndreasReitberger.Shared.Syncfusion.Controls
{
    public class MultiSelectComboBox : SfComboBox
    {
        public MultiSelectComboBox()
        {
            SelectionChanged += ComboBoxItemSelect_SelectionChanged;
        }

        void ComboBoxItemSelect_SelectionChanged(object? sender, SelectionChangedEventArgs e)
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

        public IList SelectedItemsList
        {
            get => (IList)GetValue(SelectedItemsListProperty);
            set => SetValue(SelectedItemsListProperty, value);
        }

        public static readonly BindableProperty SelectedItemsListProperty =
            BindableProperty.Create(nameof(SelectedItemsList),
                typeof(IList),
                typeof(MultiSelectComboBox),
                new ArrayList(),
                BindingMode.Default,
                null,
                OnSelectionChanged);

        static void OnSelectionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            //var comboBox = bindable as MultiSelectComboBox;
            if (bindable is MultiSelectComboBox control && newValue is IList selectedItems)
            {
                control.SetValue(SelectedItemsListProperty, selectedItems);
            }
        }
    }
}
