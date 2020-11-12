using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class SpaceItem : ComponentBase
    {
        [CascadingParameter] public Space Parent { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        private static readonly Hashtable _spaceSize = new Hashtable
        {
            ["small"] = 8,
            ["middle"] = 16,
            ["large"] = 24
        };

        private string _marginStyle = "";

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if (Parent == null)
                return;

            var size = Parent.Size;
            var direction = Parent.Direction;

            var marginSize = new List<string> {"small", "middle", "large"}.Any(x => x == size) ? _spaceSize[size] : size;

            _marginStyle = direction == "horizontal" ? $"margin-right:{marginSize}px;" : $"margin-bottom:{marginSize}px;";
        }
    }
}