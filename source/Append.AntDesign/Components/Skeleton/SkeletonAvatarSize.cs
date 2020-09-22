using Ardalis.SmartEnum;

namespace Append.AntDesign.Components
{
    public sealed class SkeletonAvatarSize : SmartEnum<SkeletonAvatarSize>
    {
        public static readonly SkeletonAvatarSize Large = new SkeletonAvatarSize(nameof(Large).ToLower(), 1);
        public static readonly SkeletonAvatarSize Small = new SkeletonAvatarSize(nameof(Small).ToLower(), 2);
        public static readonly SkeletonAvatarSize Default = new SkeletonAvatarSize(nameof(Default).ToLower(), 3);

        public SkeletonAvatarSize(string name, int value) : base(name, value) {}
    }
}