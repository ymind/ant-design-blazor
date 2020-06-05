

using Ardalis.SmartEnum;

namespace Append.AntDesign.Components
{
    public sealed class DescriptionsDirection : SmartEnum<DescriptionsDirection>
    {
        public static readonly DescriptionsDirection Horizontal = new DescriptionsDirection(nameof(Horizontal).ToLower(), 1);
        public static readonly DescriptionsDirection Vertical = new DescriptionsDirection(nameof(Vertical).ToLower(), 2);

        private DescriptionsDirection(string name, int value) : base(name, value)
        {
        }
    }
}
