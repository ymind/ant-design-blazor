A spinner for displaying loading state of a page or a section.

## When To Use

When part of the page is waiting for asynchronous data or during a rendering process, an appropriate loading animation can effectively alleviate users' inquietude.

## API

| Property | Description | Type | Default Value |
| --- | --- | --- | --- |
| Delay | Specifies a delay in milliseconds for loading state (prevent flush) | number (milliseconds) | - |
| Indicator | RenderFragment of the spinning indicator | RenderFragment | - |
| Size | Size of Spin, options: `SpinSize.Small`, `SpinSize.Default` and `SpinSize.Large` | SpinSize | `SpinSize.Default` |
| Spinning | Whether Spin is spinning | bool | true |
| Label | Customize description content when Spin has children | string | - |

<!--
### Static Method

- `Spin.setDefaultIndicator(indicator: ReactNode)`

  You can define default spin element globally.
-->