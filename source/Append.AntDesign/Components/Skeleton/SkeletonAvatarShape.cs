using Ardalis.SmartEnum;

namespace Append.AntDesign.Components
{
    public sealed class SkeletonAvatarShape : SmartEnum<SkeletonAvatarShape>
    {
        public static readonly SkeletonAvatarShape Circle = new SkeletonAvatarShape(nameof(Circle).ToLower(), 1);
        public static readonly SkeletonAvatarShape Square = new SkeletonAvatarShape(nameof(Square).ToLower(), 2);
        public static readonly SkeletonAvatarShape Default = new SkeletonAvatarShape(nameof(Default).ToLower(), 3);

        public SkeletonAvatarShape(string name, int value) : base(name, value) { }
    }
}