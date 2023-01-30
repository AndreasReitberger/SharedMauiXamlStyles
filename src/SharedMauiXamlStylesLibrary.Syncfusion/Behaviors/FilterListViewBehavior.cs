﻿using Syncfusion.Maui.ListView;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AndreasReitberger.Shared")]
namespace AndreasReitberger.Shared.Syncfusion.Behaviors.Syncfusion
{
    internal class FilterListViewBehavior : Behavior<SfListView>
    {
        protected override void OnAttachedTo(SfListView listView)
        {
            //listView.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(listView);
        }

        protected override void OnDetachingFrom(SfListView listView)
        {
            //entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(listView);
        }
    }
}
