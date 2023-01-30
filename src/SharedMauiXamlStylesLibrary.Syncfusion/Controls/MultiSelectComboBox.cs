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

        void ComboBoxItemSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection is not IList list)
            {
                // Single item (if token is set to 'none')
                list = new ArrayList
                {
                    e.CurrentSelection
                };
            }
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
