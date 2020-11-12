using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class SkeletonButton
    {
        private const string prefix = "ant-skeleton";

        private ClassBuilder classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClass($"{prefix}-element")
            .AddClassWhen($"{prefix}-active", Active);

        private ClassBuilder buttonClasses => ClassBuilder.Create(Class)
            .AddClass($"{prefix}-button")
            .AddClassWhen($"{prefix}-button-lg", Size == SkeletonButtonSize.Large)
            .AddClassWhen($"{prefix}-button-sm", Size == SkeletonButtonSize.Small)
            .AddClassWhen($"{prefix}-button-circle", Shape == SkeletonButtonShape.Circle)
            .AddClassWhen($"{prefix}-button-round", Shape == SkeletonButtonShape.Round);

        /// <summary>
        /// Show animation effect
        /// </summary>
        [Parameter]
        public bool Active { get; set; } = false;
        /// <summary>
        /// Set the size of avatar
        /// </summary>
        [Parameter]
        public SkeletonButtonSize Size { get; set; } = SkeletonButtonSize.Default;
        /// <summary>
        /// Set the shape of avatar
        /// </summary>
        [Parameter]
        public SkeletonButtonShape Shape { get; set; } = SkeletonButtonShape.Default;
    }
}
