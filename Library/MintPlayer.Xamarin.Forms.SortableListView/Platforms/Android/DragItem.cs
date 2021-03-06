﻿namespace MintPlayer.Xamarin.Forms.SortableListView.Platforms.Android
{
    internal class DragItem : Java.Lang.Object
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DragItem"/> class.
        /// </summary>
        /// <param name="index">
        /// The initial index for the data item.
        /// </param>
        /// <param name="view">
        /// The view element that is being dragged.
        /// </param>
        /// <param name="dataItem">
        /// The data item that is bound to the view.
        /// </param>
        public DragItem(int index, global::Android.Views.View view, object dataItem)
        {
            OriginalIndex = Index = index;
            View = view;
            Item = dataItem;
        }

        /// <summary>
        /// Gets or sets the current index for the data item.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Gets the original index for the data item
        /// </summary>
        public int OriginalIndex { get; }

        /// <summary>
        /// Gets the data item that is being dragged
        /// </summary>
        public object Item { get; }

        /// <summary>
        /// Gets the view that is being dragged
        /// </summary>
        public global::Android.Views.View View { get; }
    }
}
