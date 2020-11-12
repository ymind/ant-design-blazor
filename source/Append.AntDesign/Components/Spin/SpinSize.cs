using Ardalis.SmartEnum;

namespace Append.AntDesign.Components
{
    public sealed class SpinSize : SmartEnum<SpinSize>
    {
        public static readonly SpinSize Default = new SpinSize(nameof(Default).ToLower(), 1);
        public static readonly SpinSize Small = new SpinSize(nameof(Small).ToLower(), 2);
        public static readonly SpinSize Large = new SpinSize(nameof(Large).ToLower(), 3);

        private SpinSize(string name, int value) : base(name, value)
        {
        }
    }
}
