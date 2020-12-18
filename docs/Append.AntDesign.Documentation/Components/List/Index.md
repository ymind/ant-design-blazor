Simple List.

## When To Use

A list can be used to display content related to a single subject. The content can consist of multiple elements of varying type and size.

## API

### List

| Property | Description | Type | Default | Version |
| --- | --- | --- | --- | --- |
| Bordered | Toggles rendering of the border around the list | bool | false |  |
| Footer | List footer renderer | Renderfragment | - |  |
| Header | List header renderer | Renderfragment | - |  |
| ItemLayout | The layout of list, default is `ItemLayout.Horizontal`, If a vertical list is desired, set the itemLayout property to `ItemLayout.Vertical` | ItemLayout | ItemLayout.Horizontal |  |
| RowKey | Item's unique key, this is the name of the property that is unique (case sensitive) | string |  |
| RowKeyFunction | Function to generate the list item's unique key| Func<TItem, string> |   |  |
| LoadMore | Shows a load more content | Renderfragment |  |  |
| Loading | Shows a loading indicator while the contents of the list are being fetched | bool | false |  |
| Size | Size of list | `AntListSize.Default` \| `AntListSize.Large` \| `AntListSize.Small` | `AntListSize.Default` |  |
| Split | Toggles rendering of the split under the list item | bool | true |  |
| DataSource | dataSource array for the list | List<`TItem`> |  |  |
| RenderItem | customize list item when using `dataSource` | Func<TItem, RenderFragment> | |  |


### ListItem

| Property | Description | Type | Default | Version |
| --- | --- | --- | --- | --- |
| Actions | The actions content of list item. If `ItemLayout` is `ItemLayout.Vertical`, shows the content on bottom, otherwise shows content on the far right. | List<`Renderfragment`> |  |  |
| Extra | The extra content of list item. If `ItemLayout` is `ItemLayout.Vertical`, shows the content on right, otherwise shows content on the far right. | Renderfragment |  |  |

### ListItemMeta

| Property    | Description                  | Type              | Default | Version |
| ----------- | ---------------------------- | ----------------- | ------- | ------- |
| Avatar      | The avatar of list item      | Renderfragment |  |  |
| Description | The description of list item | Renderfragment |  |  |
| Title       | The title of list item       | Renderfragment |  |  |