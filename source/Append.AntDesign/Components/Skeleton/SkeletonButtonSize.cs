using Ardalis.SmartEnum;

namespace Append.AntDesign.Components
{
    public class SkeletonButtonSize : SmartEnum<SkeletonButtonSize> {
        public static readonly SkeletonButtonSize Large = new SkeletonButtonSize(nameof(Large).ToLower(), 1);
        public static readonly SkeletonButtonSize Small = new SkeletonButtonSize(nameof(Small).ToLower(), 2);
        public static readonly SkeletonButtonSize Default = new SkeletonButtonSize(nameof(Default).ToLower(), 3);

        public SkeletonButtonSize(string name, int value) : base(name, value) {}
    }
}