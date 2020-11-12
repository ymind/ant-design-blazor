<Codebox Title="Check all">
    <Description>
        The <code>Indeterminate</code> property can help you indicate not all but some checkboxes are checked.
    </Description>
    <Demo>
        <Checkbox Checked="_checkedState" Indeterminate="_indeterminateState" OnChange="OnChangeMainCheckbox">
            Check all
        </Checkbox>
        <br />
        <br />
        <CheckboxGroup Value="_checkboxgroupCheckedState" OnChange="DetermineIndeterminateState" Options="options1" />
    </Demo>
</Codebox>
@code{
    private bool _indeterminateState = true;
    private bool _checkedState;
    private List<string> _checkboxgroupCheckedState = new List<string>(new string[] { apple, pear });
    private static readonly string apple = "Apple";
    private static readonly string pear = "Pear";
    private static readonly string orange = "Orange";
    List<CheckboxGroupOption> options1 = new List<CheckboxGroupOption>(new CheckboxGroupOption[] { CheckboxGroupOption.Create(apple), CheckboxGroupOption.Create(pear), CheckboxGroupOption.Create(orange) });

    private void DetermineIndeterminateState(List<string> values)
    {
        System.Diagnostics.Debug.WriteLine(string.Join(',', values));
        _indeterminateState = values.Count > 0 && values.Count < options1.Count;
        _checkedState = values.Count == options1.Count;
    }
    private void OnChangeMainCheckbox(bool flag)
    {
        _checkedState = flag;
        _checkboxgroupCheckedState = flag ? new List<string>(new string[] { apple, pear, orange }) : new List<string>();
        _indeterminateState = false;
        System.Diagnostics.Debug.Write("hi");
    }
}