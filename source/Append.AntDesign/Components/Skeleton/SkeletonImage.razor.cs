using Append.AntDesign.Core;

namespace Append.AntDesign.Components
{
    public partial class SkeletonImage
    {
        private const string prefix = "ant-skeleton";

        private ClassBuilder classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClass($"{prefix}-element");
    }
}
