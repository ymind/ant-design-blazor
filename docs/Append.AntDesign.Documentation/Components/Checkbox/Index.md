Checkbox component.

## When To Use

- Used for selecting multiple values from several options.
- If you use only one checkbox, it is the same as using Switch to toggle between two states. The difference is that Switch will trigger the state change directly, but Checkbox just marks the state as changed and this needs to be submitted.

## API

### Props

#### Checkbox

| Property | Description | Type | Default | Version |
| --- | --- | --- | --- | --- |
| Checked | Specifies whether the checkbox is selected. | bool? |  |  |
| DefaultChecked | Specifies the initial state: whether or not the checkbox is selected. | bool | false |  |
| Disabled | Disable checkbox | bool | false |  |
| Indeterminate | indeterminate checked state of checkbox | bool | false |  |
| OnChange | The callback function that is triggered when the state changes. | `EventCallback<bool>` |  |  |

#### CheckboxGroup

| Property | Description | Type | Default | Version |
| --- | --- | --- | --- | --- |
| DefaultValue | Default selected value | `List<string>` | `new List<string>()` |  |
| Disabled | Disable all checkboxes | bool | false |  |
| Name | The `name` property of all `input[type="checkbox"]` children | string |  |  |
| Options | Specifies options | `List<string>` | `new List<string>()` |  |
| Value | Used for setting the currently selected values. | `List<CheckboxGroupOption>` | `new List<CheckboxGroupOption>()` |  |
| OnChange | The callback function that is triggered when the state changes. | `EventCallback<List<string>>` |  |  |