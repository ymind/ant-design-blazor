namespace Append.AntDesign.Components
{
    public class CheckboxGroupOption
    {
        public string Label { get; set; }
        public string Value { get; set; }
        public bool Disabled { get; set; }

        private CheckboxGroupOption(string label, string value, bool disabled)
        {
            Label = label;
            Value = value;
            Disabled = disabled;
        }
        
        public static CheckboxGroupOption Create(string label, string value, bool disabled) => new CheckboxGroupOption(label, value, disabled);
        public static CheckboxGroupOption Create(string label) => Create(label, null, false);
        public static CheckboxGroupOption Create(string label, string value) => Create(label, value, false);
    }
}