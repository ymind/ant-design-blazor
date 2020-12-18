Tabs make it easy to switch between different views.

### When To Use

Ant Design has 3 types of Tabs for different situations.

## API

### Tabs

| Property | Description | Type | Default | Version |
| --- | --- | --- | --- | --- |
| ActiveKey | Current TabPane's key | string |  |  |
| DefaultActiveKey | Initial active TabPane's key, if `ActiveKey` is not set. | string |  |  |
| Size | preset tab bar size | `TabsSize.Large` \| `TabsSize.Default` \| `TabsSize.Small` | `TabsSize.Default` |  |
| TabBarExtraContent | Extra content in tab bar | RenderFragment |  |  |
| TabBarGutter | The gap between tabs | int |  |  |
| TabPosition | Position of tabs | `TabDirection.Top` \| `TabDirection.Right` \| `TabDirection.Bottom` \| `TabDirection.Left` | `TabDirection.Top` |  |
| OnChange | Callback executed when active tab is changed | EventCallback<`string`> |  |  |
| OnTabClick | Callback executed when tab is clicked | EventCallback<`string`> |  |  |


### TabsTabPane

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| ForceRender | PreRenders all the tabpanes | bool | false |
| Key | TabPane's key | string | - |
| Tab | Show text in TabPane's head | Renderfragment |  |

