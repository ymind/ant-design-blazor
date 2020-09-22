using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class Skeleton
    {
        private static readonly string prefix = "ant-skeleton";

        private ClassBuilder classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClassWhen($"{prefix}-active", active);

        private ClassBuilder avatarClasses => ClassBuilder.Create(Class)
            .AddClass($"{prefix}-avatar")
            .AddClassWhen($"{prefix}-avatar-lg", avatar.size == SkeletonAvatarSize.Large)
            .AddClassWhen($"{prefix}-avatar-circle", avatar.shape == SkeletonAvatarShape.Circle);

        [Parameter] public bool active { get; set; } = false;
        [Parameter] public SkeletonAvatarProps avatar { get; set; } = new SkeletonAvatarProps();
        [Parameter] public bool loading { get; set; } = true;
        [Parameter] public SkeletonParagraphProps paragraph { get; set; } = new SkeletonParagraphProps();
        [Parameter] public SkeletonTitleProps title { get; set; } = new SkeletonTitleProps();
        [Parameter] public bool round { get; set; } = false;
    }
}
