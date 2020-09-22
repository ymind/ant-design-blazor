Provide a placeholder while you wait for content to load, or to visualise content that doesn't exist yet.

## When To Use

- When a resource needs long time to load.

- When the component contains lots of information, such as List or Card.

- Only works when loading data for the first time.

- Could be replaced by Spin in any situation, but can provide a better user experience.

## API

Skeleton

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| active | Show animation effect | boolean | false |
| avatar | Show avatar placeholder | boolean | false |
| loading | Display the skeleton when true | boolean | - |
| paragraph | Show paragraph placeholder | boolean | true |
| title | Show title placeholder | boolean | true |
| round | Show paragraph and title radius when true | boolean | false |

SkeletonAvatarProps

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| active | Show animation effect, only valid when used avatar independently | boolean | false |
| size | Set the size of avatar | AvatarSize | - |
| shape | Set the shape of avatar | AvatarShape | - |

SkeletonTitleProps

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| width | Set the width of title | integer &#124; Array<integer> | 68% |
 
SkeletonParagraphProps

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| rows | Set the row count of paragraph | integer | 3 |
| width | Set the width of paragraph. When width is an Array, it can set the width of each row. Otherwise only set the last row width | integer &#124; Array<integer> | 68% |

SkeletonButtonProps

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| active | Show animation effect | boolean | false |
| size | Set the size of button | ButtonSize | - |
| shape | Set the shape of button | ButtonShape | - |

SkeletonInputProps

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| active | Show animation effect | boolean | false |
| size | Set the size of input | InputSize | - |


## FAQ
> Ask your questions on Github, they might end up here.
