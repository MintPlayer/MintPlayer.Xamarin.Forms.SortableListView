﻿using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using MintPlayer.Xamarin.Forms.SortableListView.Platforms.Android;

[assembly: ResolutionGroupName("MintPlayer.Xamarin.Forms.SortableListView")]
[assembly: ExportEffect(typeof(SortableListViewEffect), nameof(SortableListViewEffect))]
namespace MintPlayer.Xamarin.Forms.SortableListView.Platforms.Android
{
    public class SortableListViewEffect : PlatformEffect
    {
        private DragListAdapter dragListAdapter = null;

        protected override void OnAttached()
        {
            var element = Element as ListView;

            if (Control is global::Android.Widget.ListView listView)
            {
                dragListAdapter = new DragListAdapter(listView, element);
                listView.Adapter = dragListAdapter;
                listView.SetOnDragListener(dragListAdapter);
                listView.OnItemLongClickListener = dragListAdapter;
            }
        }

        protected override void OnDetached()
        {
            if (Control is global::Android.Widget.ListView listView)
            {
                listView.Adapter = dragListAdapter.WrappedAdapter;
                listView.SetOnDragListener(null);
                listView.OnItemLongClickListener = null;
                dragListAdapter.Dispose();
            }
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            if (args.PropertyName == Common.Sorting.IsSortableProperty.PropertyName)
            {
                dragListAdapter.DragDropEnabled = Common.Sorting.GetIsSortable(Element);
            }
        }
    }
}
