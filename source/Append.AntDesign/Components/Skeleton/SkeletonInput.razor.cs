﻿using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class SkeletonInput
    {
        private const string prefix = "ant-skeleton";

        private ClassBuilder classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClass($"{prefix}-element")
            .AddClassWhen($"{prefix}-active", Active);

        private ClassBuilder inputClasses => ClassBuilder.Create(Class)
            .AddClass($"{prefix}-input")
            .AddClassWhen($"{prefix}-input-lg", Size == SkeletonAvatarSize.Large)
            .AddClassWhen($"{prefix}-input-sm", Size == SkeletonAvatarSize.Small);

        private StyleBuilder inputStyles => StyleBuilder.Create(Style);

        /// <summary>
        /// Show animation effect
        /// </summary>
        [Parameter]
        public bool Active { get; set; } = false;
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
