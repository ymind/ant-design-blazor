using Ardalis.SmartEnum;

namespace Append.AntDesign.Components
{
    public sealed class DescriptionsSize : SmartEnum<DescriptionsSize>
    {
        public static readonly DescriptionsSize Default = new DescriptionsSize(nameof(Default).ToLower(), 1);
        public static readonly DescriptionsSize Small = new DescriptionsSize(nameof(Small).ToLower(), 2);
        public static readonly DescriptionsSize Middle = new DescriptionsSize(nameof(Middle).ToLower(), 3);

        private DescriptionsSize(string name, int value) : base(name, value)
        {
        }
    }
}
