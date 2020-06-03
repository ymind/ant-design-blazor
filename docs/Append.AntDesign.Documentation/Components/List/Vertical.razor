<Codebox Title="Vertical">
    <Description>
        <p>
            Set the <code>ItemLayout</code> property to <code>ItemLayout.Vertical</code> to create a vertical list.
        </p>
    </Description>
    <Demo>
        <AntList DataSource="sampleData"
                 RowKey="Title"
                 ItemLayout="ItemLayout.Vertical"
                 Size="AntListSize.Large"
                 Footer="footer"
                 RenderItem="RenderItem" />
    </Demo>
</Codebox>
@code{
    private List<ListDataItem> sampleData = new List<ListDataItem>();

    private RenderFragment footer = @<div><b>ant design</b> footer part</div>;

    // refactor actions when ant-space is finished
    private static RenderFragment action1 = @<div class="ant-space ant-space-horizontal ant-space-align-center">
                                                 <div class="ant-space-item" style="margin-right: 8px;">
                                                     <Icon Type="IconType.Outlined.Star"></Icon>
                                                 </div>
                                                 <div class="ant-space-item">156</div>
                                             </div>;
    private static RenderFragment action2 = @<div class="ant-space ant-space-horizontal ant-space-align-center">
                                                 <div class="ant-space-item" style="margin-right: 8px;">
                                                     <Icon Type="IconType.Outlined.Like"></Icon>
                                                 </div>
                                                 <div class="ant-space-item">158</div>
                                             </div>;
    private static RenderFragment action3 = @<div class="ant-space ant-space-horizontal ant-space-align-center">
                                                 <div class="ant-space-item" style="margin-right: 8px;">
                                                     <Icon Type="IconType.Outlined.Message"></Icon>
                                                 </div>
                                                <div class="ant-space-item">2</div>
                                             </div>;

    private List<RenderFragment> actions = new List<RenderFragment>(new []{action1, action2, action3});

    private RenderFragment extra = @<img width="272" alt="logo" src="https://gw.alipayobjects.com/zos/rmsportal/mqaQswcyDLcXyDKnZfES.png" />;

    public Vertical()
    {
        for (var i = 0; i < 2; i++)
        {
            sampleData.Add(new ListDataItem(
                "#",
                $"ant design part {i}",
                "https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png",
                "Ant Design, a design language for background applications, is refined by Ant UED Team.",
                "We supply a series of design principles, practical patterns and high quality design resources (Sketch and Axure), to help people create their product prototypes beautifully and efficiently."));
        }
    }

    private RenderFragment RenderItem(ListDataItem listDataItem)
    {
        RenderFragment avatar =@<Avatar ImageSource="@listDataItem.Avatar" />;
        RenderFragment title = @<a href="@listDataItem.Href">@listDataItem.Title</a>;
        RenderFragment description = @<span>@listDataItem.Description</span>;


        return @<ListItem
                    Actions="actions"
                    Extra="extra"
                    >
                   <ListItemMeta Avatar="avatar"
                                 Title="title"
                                 Description="description"/>
                   @listDataItem.Content
               </ListItem>;;
    }


    private class ListDataItem
    {
        public string Href { get; set; }
        public string Title { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public ListDataItem(string href, string title, string avatar, string description, string content)
        {
            Href = href;
            Title = title;
            Avatar = avatar;
            Description = description;
            Content = content;
        }
    }
}