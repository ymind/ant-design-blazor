namespace Append.AntDesign.Components
{
    public class SkeletonAvatarProps
    {
        /// <summary>
        /// Show animation effect, only valid when used avatar independently
        /// </summary>
        public bool Active { get; set; } = false;
        /// <summary>
        /// Set the size of avatar
        /// </summary>
        public SkeletonAvatarSize Size { get; set; } = SkeletonAvatarSize.Default;
        /// <summary>
        /// Set the shape of avatar
        /// </summary>
        public SkeletonAvatarShape Shape { get; set; } = SkeletonAvatarShape.Default;
    }
}