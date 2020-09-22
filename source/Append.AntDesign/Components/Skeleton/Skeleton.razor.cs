using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class Skeleton
    {
        private static readonly string prefix = "ant-skeleton";

        private ClassBuilder classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClassWhen($"{prefix}-active", active || loading);

        private ClassBuilder avatarClasses => ClassBuilder.Create(Class)
            .AddClass($"{prefix}-avatar")
            .AddClassWhen($"{prefix}-avatar-lg", avatar != null && avatar.size == SkeletonAvatarSize.Large)
            .AddClassWhen($"{prefix}-avatar-sm", avatar != null && avatar.size == SkeletonAvatarSize.Small)
            .AddClassWhen($"{prefix}-avatar-circle", avatar != null && (avatar.shape == SkeletonAvatarShape.Circle || avatar.shape == SkeletonAvatarShape.Default))
            .AddClassWhen($"{prefix}-avatar-square", avatar != null && avatar.shape == SkeletonAvatarShape.Square);

        private ClassBuilder titleClasses => ClassBuilder.Create(Class)
            .AddClass($"{prefix}-title");

        private StyleBuilder titleStyles => StyleBuilder.Create(Style)
            .AddStyleWhen($"width: {title.width}%;", title.width > 0 && title.width <= 100);

        [Parameter] public bool active { get; set; } = false;
        [Parameter] public SkeletonAvatarProps avatar { get; set; } = null;
        [Parameter] public RenderFragment ChildContent { get; set; } = null;
        [Parameter] public bool loading { get; set; } = false;
        [Parameter] public SkeletonParagraphProps paragraph { get; set; } = new SkeletonParagraphProps();
        [Parameter] public bool round { get; set; } = false;
        [Parameter] public SkeletonTitleProps title { get; set; } = new SkeletonTitleProps();
    }
}
