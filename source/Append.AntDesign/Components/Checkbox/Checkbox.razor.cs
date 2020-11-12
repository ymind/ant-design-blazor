using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class Checkbox
    {
        private string baseClass = "ant-checkbox";
        private bool CheckboxNameDefined => CheckboxGroup != null && !string.IsNullOrEmpty(CheckboxGroup.Name);

        private ClassBuilder wrapperClasses => ClassBuilder.Create(Class)
            .AddClass($"{baseClass}-wrapper")
            .AddClassWhen($"{baseClass}-wrapper-checked", _checkedState && CheckboxGroup != null)
            .AddClassWhen($"{baseClass}-wrapper-disabled", Disabled);

        private ClassBuilder classes => ClassBuilder.Create()
            .AddClass(baseClass)
            .AddClassWhen($"{baseClass}-indeterminate", Indeterminate)
            .AddClassWhen($"{baseClass}-checked", _checkedState)
            .AddClassWhen($"{baseClass}-disabled", Disabled);

        private void OnCheckboxClicked()
        {
            if (Disabled)
                return;
            _checkedState = !_checkedState;
            OnChange.InvokeAsync(_checkedState);
            CheckboxGroup?.OnCheckboxChanged(Value, _checkedState);
        }

        private bool _checkedState;
        [Parameter] public bool? Checked { get; set; }
        [Parameter] public bool DefaultChecked { get; set; }
        [Parameter] public string Value { get; set; }
        [Parameter] public bool Disabled { get; set; }
        [Parameter] public bool Indeterminate { get; set; }
        [Parameter] public EventCallback<bool> OnChange { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        [CascadingParameter] public CheckboxGroup CheckboxGroup { get; set; }

        protected override void OnInitialized()
        {
            _checkedState = Checked ?? DefaultChecked;
        }

        protected override void OnParametersSet()
        {
            _checkedState = Checked ?? _checkedState;
            if (CheckboxGroup == null) return;
            _checkedState = CheckboxGroup._currentValues.Contains(Value);
            Disabled = Disabled ? Disabled : CheckboxGroup.Disabled;
        }
    }
}