using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class ListItemMeta 
    {
      [Parameter] public RenderFragment Avatar { get; set; }
      [Parameter] public RenderFragment Description { get; set; }
      [Parameter] public RenderFragment Title { get; set; }

      [Parameter] public RenderFragment ChildContent { get; set; }
    }
}