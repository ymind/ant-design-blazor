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
| Active | Show animation effect | boolean | false |
| Avatar | Show avatar placeholder | SkeletonAvatarProps | false |
| Loading | Display the skeleton when true | boolean | - |
| Paragraph | Show paragraph placeholder | SkeletonParagraphProps | true |
| Round | Show paragraph and title radius when true | boolean | false |
| Title | Show title placeholder | SkeletonTitleProps | true |

SkeletonAvatarProps

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| Active | Show animation effect, only valid when used avatar independently | boolean | false |
| Size | Set the size of avatar | SkeletonAvatarSize | - |
| Shape | Set the shape of avatar | SkeletonAvatarShape | - |

SkeletonTitleProps

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| Width | Set the width of title in percent | integer | 68% |
 
SkeletonParagraphProps

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| Rows | Set the row count of paragraph | integer | 3 |
| Width | Set the width of paragraphs. Set the width of each row, or if single value in array sets the last row width | Array<integer> | 68% |

SkeletonButtonProps

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| Active | Show animation effect | boolean | false |
| Size | Set the size of button | SkeletonButtonSize | - |
| Shape | Set the shape of button | SkeletonButtonShape | - |

SkeletonInputProps

| Property | Description | Type | Default |
| --- | --- | --- | --- |
| Active | Show animation effect | boolean | false |
| Size | Set the size of input | SkeletonInputSize | - |


## FAQ
> Ask your questions on Github, they might end up here.
