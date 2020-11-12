Descriptions component.

## When To Use

Commonly displayed on the details page.

## API

### Props

### Descriptions

| Property | Description | Type | Default | Version |
| --- | --- | --- | --- | --- |
| Title | The title of the description list, placed at the top | RenderFragment | - |  |
| Bordered | Whether to display the border | bool | false |  |
| Column | The number of `DescriptionItems` in a row,could be an object like `new ResponsiveDescription(2)` to set the colums equal to 2 or a object like `new ResponsiveDescription( xs: 8, sm: 16, md: 24)` for a responsive layout| ResponsiveDescription | 3 or  when more values are given fills values with { xs: 1,  sm: 2,  md: 3,  lg: 3,  xl: 3,  xxl: 3} |  |
| Size | Set the size of the list. Can be set to `DescriptionsSize.Middle`,`DescriptionsSize.Small`, or not filled | `DescriptionsSize.Default` \| `DescriptionsSize.Middle` \| `DescriptionsSize.Small` | DescriptionsSize.Default |  |
| Direction | Define description layout | DescriptionsDirection | DescriptionsDirection.Horizontal |  |
| Colon | Change default props `colon` value of `Descriptions.Item` | bool | true |  |

### DescriptionItem

| Property | Description                    | Type      | Default | Version |
| -------- | ------------------------------ | --------- | ------- | ------- |
| Label    | description of the content     | RenderFragment | -       |         |
| Span     | The number of columns included | int    | 1       |         |

> The number of span DescriptionItem, Span=2, takes up the width of two DescriptionItems.