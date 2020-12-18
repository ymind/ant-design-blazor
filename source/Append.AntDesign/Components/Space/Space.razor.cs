using System.Collections.Generic;
using System.Linq;
using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class Space
    {
        [Parameter] public string Align { get; set; }

        [Parameter] public string Direction { get; set; } = "horizontal";

        [Parameter] public string Size { get; set; } = "small";

        [Parameter] public RenderFragment ChildContent { get; set; }

        private bool HasAlign => new List<string> {"start", "end", "center", "baseline"}.Any(x => x == Align);

        private const string PrefixCls = "ant-space";

        private ClassBuilder Classes => ClassBuilder.Create(Class)
            .AddClass(PrefixCls)
            .AddClassWhen($"{PrefixCls}-{Direction}", Direction.Equals("horizontal") || Direction.Equals("vertical"))
            .AddClassWhen($"{PrefixCls}-align-{Align}", HasAlign)
            .AddClassWhen($"{PrefixCls}-align-center", !HasAlign && Direction == "horizontal");
    }
}