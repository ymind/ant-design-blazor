<Codebox Title="Load more">
    <Description>
        <p>
            Load more of the list with the <code>LoadMore</code> property.
        </p>
    </Description>
    <Demo>
        <AntList class="demo-loadmore-list"
                 DataSource="dataSource"
                 ItemLayout="ItemLayout.Horizontal"
                 RenderItem="RenderItem"
                 Loading="_loading">
            <LoadMore>
                <div class="load-more-button-div">
                    <Button OnClick="LoadMoreIntoDataSource" Label="Load more"></Button>
                </div>
            </LoadMore>
        </AntList>
    </Demo>
</Codebox>
<style>
    .demo-loadmore-list {
        min-height: 350px;
    }

    .load-more-button-div {
        text-align: center;
        margin-top: 12px;
        height: 32px;
        line-height: 32px;
    }
</style>
@code{
    private List<string> dataSource = new List<string>(new [] { "Employee #1", "Employee #2", "Employee #3" });
    private bool _loading = false;

    private async Task LoadMoreIntoDataSource()
    {
        _loading = true;
        await Task.Delay(1000);

        for (var i = 0; i < 3; i++)
        {
            dataSource.Add($"Employee #{dataSource.Count + 1}");
        }
        _loading = false;
    }

    private RenderFragment RenderItem(string item)
    {
        RenderFragment avatar = @<Avatar ImageSource="https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png"/>;
        RenderFragment title = @<a href="#">@item</a>;
        RenderFragment description = @<span>Ant Design, a design language for background applications, is refined by Ant UED Team</span>;

        RenderFragment action1 = @<a key="list-loadmore-edit">edit</a>;
        RenderFragment action2 = @<a key="list-loadmore-more">more</a>;

        return @<ListItem>
                   <ListItem
                        Actions="new List<RenderFragment>( new [] {action1, action2})"
                       >
                       <ListItemMeta
                           Avatar="avatar"
                           Title="title"
                           Description="description"
                       />
                   </ListItem>
               </ListItem>;
    }
}