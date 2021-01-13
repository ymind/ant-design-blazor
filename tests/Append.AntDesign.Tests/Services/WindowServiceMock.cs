using Append.AntDesign.Components;
using Append.AntDesign.Core;
using Append.AntDesign.Services;
using System.Threading.Tasks;

namespace Append.AntDesign.Tests.Services
{
    public class WindowServiceMock : IWindowService
    {
        public async ValueTask<Dimension> GetDimensions()
        {
            await Task.CompletedTask;
            Dimension mockDimension = new Dimension() { Width = 1920, Height = 1080 };
            return mockDimension;
        }

        public ValueTask RegisterOnWindowResizeHandler(AntComponent component)
        {
            return new ValueTask(Task.CompletedTask);
        }
    }
}