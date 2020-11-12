using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class SkeletonAvatar
    {
        private const string prefix = "ant-skeleton";

        private ClassBuilder classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClass($"{prefix}-element")
            .AddClassWhen($"{prefix}-active", Active);

        private ClassBuilder avatarClasses => ClassBuilder.Create(Class)
            .AddClass($"{prefix}-avatar")
            .AddClassWhen($"{prefix}-avatar-lg", Size == SkeletonAvatarSize.Large)
            .AddClassWhen($"{prefix}-avatar-sm", Size == SkeletonAvatarSize.Small)
            .AddClassWhen($"{prefix}-avatar-circle",
                Shape == SkeletonAvatarShape.Circle || Shape == SkeletonAvatarShape.Default)
            .AddClassWhen($"{prefix}-avatar-square", Shape == SkeletonAvatarShape.Square);

        /// <summary>
        /// Show animation effect
        /// </summary>
        [Parameter]
        public bool Active { get; set; } = true;
        /// <summary>
        /// Set the size of avatar
        /// </summary>
        [Parameter]
        public SkeletonAvatarSize Size { get; set; } = SkeletonAvatarSize.Default;
        /// <summary>
        /// Set the shape of avatar
        /// </summary>
        [Parameter]
        public SkeletonAvatarShape Shape { get; set; } = SkeletonAvatarShape.Default;
    }
}
