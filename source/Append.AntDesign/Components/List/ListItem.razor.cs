using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Append.AntDesign.Components
{
    public partial class ListItem
    {
        private readonly static string prefix = "ant-list-item";

        private ClassBuilder classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClassWhen($"{prefix}-no-flex", AntList.GetItemLayout() == ItemLayout.Horizontal);
            // not good yet

        [Parameter] public RenderFragment Extra { get; set; }
        [Parameter] public List<RenderFragment> Actions { get; set; } = new List<RenderFragment>();

        [Parameter] public RenderFragment ChildContent { get; set; }
        [CascadingParameter] public IAntList AntList { get; set; }

        private RenderFragment GenerateMainContent()
        {
            return builder =>
            {
                if (Extra != null)
                {
                    builder.OpenElement(0,"div");
                    builder.AddAttribute(1, "class","ant-list-item-main");
                }

                builder.AddContent(2, b =>
                {
                    b.AddContent(3, ChildContent);
                });

                builder.AddContent(4, BuildActions());

                if (Extra != null) { builder.CloseElement(); }

                builder.AddContent(5, BuildExtra());
            };
        }

        private RenderFragment BuildExtra()
        {
            return builder =>
            {
                if (Extra == null) return;

                builder.OpenElement(0, "div");
                builder.AddAttribute(1, "class", "ant-list-item-extra");

                builder.AddContent(2, b =>
                {
                    b.AddContent(3, Extra);
                });

                builder.CloseElement();
            };
        }

        private RenderFragment BuildActions()
        {
            return builder =>
            {
                if (Actions.Count == 0) return;

                builder.OpenElement(0, "ul");
                builder.AddAttribute(1, "class", "ant-list-item-action");

                for (var i = 0; i < Actions.Count; i++)
                {
                    builder.AddContent(i +  2, BuildAction(Actions[i]));
                }

                builder.CloseElement();
            };
        }

        private RenderFragment BuildAction(RenderFragment action)
        {
            return builder =>
            {
                builder.OpenElement(0, "li");

                builder.AddContent(1, b =>
                {
                    b.AddContent(2, action);
                });

                builder.OpenElement(3, "em");
                builder.AddAttribute(4, "class", "ant-list-item-action-split");
                builder.CloseElement();

                builder.CloseElement();
            };
        }
    }
}