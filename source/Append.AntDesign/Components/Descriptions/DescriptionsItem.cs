using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;
using System;

namespace Append.AntDesign.Components
{
    public partial class DescriptionsItem : AntComponent
    {
        [Parameter] public RenderFragment Label { get; set; }
        [Parameter] public int Span { get; set; } = 1;
        [Parameter] public RenderFragment Content { get; set; }
        [CascadingParameter] public Descriptions Parent { get; set; }
        internal int Index { get; set; }

        protected override void OnInitialized()
        {
            Parent.AddChildItem(this);
            Index = Parent._children.Count - 1;
            
        }
        public void AdjustSpanRestOfRow(int newSpan)
        {
            Span = newSpan;
        }
    }
}
