using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class Skeleton
    {
        private static readonly string prefix = "ant-skeleton";

        private ClassBuilder classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClassWhen($"{prefix}-active", Active || Loading);

        private ClassBuilder avatarClasses => ClassBuilder.Create(Class)
            .AddClass($"{prefix}-avatar")
            .AddClassWhen($"{prefix}-avatar-lg", Avatar != null && Avatar.Size == SkeletonAvatarSize.Large)
            .AddClassWhen($"{prefix}-avatar-sm", Avatar != null && Avatar.Size == SkeletonAvatarSize.Small)
            .AddClassWhen($"{prefix}-avatar-circle", Avatar != null && (Avatar.Shape == SkeletonAvatarShape.Circle || Avatar.Shape == SkeletonAvatarShape.Default))
            .AddClassWhen($"{prefix}-avatar-square", Avatar != null && Avatar.Shape == SkeletonAvatarShape.Square);

        private ClassBuilder titleClasses => ClassBuilder.Create(Class)
            .AddClass($"{prefix}-title");

        private StyleBuilder titleStyles => StyleBuilder.Create(Style)
            .AddStyleWhen($"width: {Title.Width}%;", Title.Width > 0 && Title.Width <= 100);

        /// <summary>
        /// Show animation effect
        /// </summary>
        [Parameter] public bool Active { get; set; } = false;
        /// <summary>
        /// Show avatar placeholder
        /// </summary>
        [Parameter] public SkeletonAvatarProps Avatar { get; set; } = null;
        [Parameter] public RenderFragment ChildContent { get; set; } = null;
        /// <summary>
        /// Display the skeleton when true
        /// </summary>
        [Parameter] public bool Loading { get; set; } = false;
        /// <summary>
        /// Show paragraph placeholder
        /// </summary>
        [Parameter] public SkeletonParagraphProps Paragraph { get; set; } = new SkeletonParagraphProps();
        /// <summary>
        /// Show paragraph and title radius when true
        /// </summary>
        [Parameter] public bool Round { get; set; } = false;
        /// <summary>
        /// Show title placeholder
        /// </summary>
        [Parameter] public SkeletonTitleProps Title { get; set; } = new SkeletonTitleProps();
    }
}
