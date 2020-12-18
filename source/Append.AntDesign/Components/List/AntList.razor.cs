using Append.AntDesign.Core;
using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Append.AntDesign.Components
{
    public partial class AntList<TItem> : IAntList
    {
        private static readonly string prefix = "ant-list";

        private ClassBuilder classes => ClassBuilder.Create(Class)
                .AddClass(prefix)
                .AddClassWhen($"{prefix}-vertical", ItemLayout == ItemLayout.Vertical)
                .AddClassWhen($"{prefix}-sm", Size == AntListSize.Small)
                .AddClassWhen($"{prefix}-lg", Size == AntListSize.Large)
                .AddClassWhen($"{prefix}-loading", Loading)
                .AddClassWhen($"{prefix}-bordered", Bordered)
                .AddClassWhen($"{prefix}-split", Split)
                .AddClassWhen($"{prefix}-something-after-last-item", Footer != null || LoadMore != null);

        private IEnumerable<RenderFragment> _internalDataSource;

        [Parameter] public bool Bordered { get; set; }
        [Parameter] public bool Split { get; set; } = true;
        [Parameter] public AntListSize Size { get; set; } = AntListSize.Default;
        [Parameter] public ItemLayout ItemLayout { get; set; } = ItemLayout.Horizontal;
        [Parameter] public bool Loading { get; set; }

        [Parameter] public RenderFragment LoadMore { get; set; }
        [Parameter] public RenderFragment Footer { get; set; }
        [Parameter] public RenderFragment Header { get; set; }

        [Parameter] public IEnumerable<TItem> DataSource { get; set; }
        [Parameter] public Func<TItem, RenderFragment> RenderItem { get; set; }

        [Parameter] public string RowKey { get; set; }
        [Parameter] public Func<TItem, string> RowKeyFunction { get; set; } // alternative for rowkey

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            RenderItem ??= DefaultRenderItem;
            _internalDataSource = DataSource?.Select(g => RenderItem(g)) ?? new List<RenderFragment>();
        }

        private string GetKey(TItem item)
        {
            if (RowKey != null && RowKey.Equals(""))
                throw new ArgumentException($"An empty {nameof(RowKey)} is not supported.");

            if (RowKeyFunction != null)
                return RowKeyFunction(item);
            if (!string.IsNullOrEmpty(RowKey))
              return item.GetType().GetProperty(RowKey)?.GetValue(item).ToString();

            return null;
        }

        private RenderFragment DefaultRenderItem(TItem item)
        {
            return builder =>
            {
                builder.OpenComponent<ListItem>(0);
                builder.SetKey(GetKey(item) ?? (object)item);
                builder.AddAttribute(1, "style", Style);
                builder.AddAttribute(2, "ChildContent", (RenderFragment)((builder2) =>
                {
                    builder2.AddContent(3, item.ToString());
                }));
                builder.CloseComponent();
            };
        }

        public ItemLayout GetItemLayout()
        {
            return ItemLayout;
        }
    }

    public sealed class AntListSize : SmartEnum<AntListSize>
    {
        public static readonly AntListSize Large = new AntListSize(nameof(Large).ToLower(), 0);
        public static readonly AntListSize Default = new AntListSize(nameof(Default).ToLower(), 1);
        public static readonly AntListSize Small = new AntListSize(nameof(Small).ToLower(), 2);

        private AntListSize(string name, int value) : base(name, value)
        {
        }
    }

    public sealed class ItemLayout : SmartEnum<ItemLayout>
    {
        public static readonly ItemLayout Vertical = new ItemLayout(nameof(Vertical).ToLower(), 0);
        public static readonly ItemLayout Horizontal = new ItemLayout(nameof(Horizontal).ToLower(), 1);

        private ItemLayout(string name, int value) : base(name, value)
        {
        }
    }
}