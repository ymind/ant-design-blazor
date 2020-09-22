using Ardalis.SmartEnum;

namespace Append.AntDesign.Components
{
    public class SkeletonButtonShape : SmartEnum<SkeletonButtonShape>
    {
        public static readonly SkeletonButtonShape Circle = new SkeletonButtonShape(nameof(Circle).ToLower(), 1);
        public static readonly SkeletonButtonShape Round = new SkeletonButtonShape(nameof(Round).ToLower(), 2);
        public static readonly SkeletonButtonShape Default = new SkeletonButtonShape(nameof(Default).ToLower(), 3);

        public SkeletonButtonShape(string name, int value) : base(name, value) { }
    }
}