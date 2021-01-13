using Ardalis.SmartEnum;

namespace Append.AntDesign.Components
{
    public sealed class SkeletonInputSize : SmartEnum<SkeletonInputSize>
    {
        public static readonly SkeletonInputSize Large = new SkeletonInputSize(nameof(Large).ToLower(), 1);
        public static readonly SkeletonInputSize Small = new SkeletonInputSize(nameof(Small).ToLower(), 2);
        public static readonly SkeletonInputSize Default = new SkeletonInputSize(nameof(Default).ToLower(), 3);

        public SkeletonInputSize(string name, int value) : base(name, value) {}
    }
}