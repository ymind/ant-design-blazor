using System;
using System.Collections.Generic;
using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class CheckboxGroup
    {
        private readonly static string baseClass = "ant-checkbox";
        private ClassBuilder classes => ClassBuilder.Create(Class)
            .AddClass($"{baseClass}-group");

        internal List<string> _currentValues = new List<string>();
        [Parameter] public List<string> DefaultValue { get; set; } = new List<string>();
        [Parameter] public bool Disabled { get; set; }
        [Parameter] public string Name { get; set; }
        [Parameter] public List<CheckboxGroupOption> Options { get; set; } = new List<CheckboxGroupOption>();
        [Parameter] public List<string> Value { get; set; }
        [Parameter] public EventCallback<List<string>> OnChange { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        internal void OnCheckboxChanged(string value, bool checkedState)
        {
            if (checkedState)
                _currentValues.Add(value);
            else
                _currentValues.Remove(value);

            OnChange.InvokeAsync(_currentValues);
            StateHasChanged();
        }

        protected override void OnInitialized() => _currentValues = Value ?? DefaultValue;

        protected override void OnParametersSet()
        {
            if (Value != null)
            {
                _currentValues = Value;
            }
        }
    }
}