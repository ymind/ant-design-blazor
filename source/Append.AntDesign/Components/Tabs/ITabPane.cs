using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Append.AntDesign.Components
{
    public interface ITabPane
    {
        Task<Dimension> GetDimensions();
        RenderFragment GetTabConcent();
        RenderFragment GetTabNav();
    }
}