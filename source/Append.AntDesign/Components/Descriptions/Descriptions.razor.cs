using Append.AntDesign.Core;
using Append.AntDesign.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Append.AntDesign.Components
{
    public partial class Descriptions
    {
        private static string prefix = "ant-descriptions";
        private ClassBuilder classes => ClassBuilder.Create(Class)
                .AddClass(prefix)
                .AddClassWhen($"{prefix}-{Size}", Size != DescriptionsSize.Default)
                .AddClassWhen($"{prefix}-bordered", Bordered);

        [Inject] public IWindowService WindowService { get; set; }
        [Parameter] public RenderFragment Title { get; set; }
        [Parameter] public bool Bordered { get; set; }
        [Parameter] public bool Colon { get; set; } = true;
        [Parameter] public ResponsiveDescription Column { get; set; } = new ResponsiveDescription(3);
        [Parameter] public DescriptionsSize Size { get; set; } = DescriptionsSize.Default;
        [Parameter] public DescriptionsDirection Direction { get; set; } = DescriptionsDirection.Horizontal;
        [Parameter] public RenderFragment ChildContent { get; set; }
        internal List<DescriptionsItem> _children = new List<DescriptionsItem>();
        internal BreakpointType currentBreakpointType = BreakpointType.Xxl;

        public void AddChildItem(DescriptionsItem item)
        {
            _children.Add(item);
            StateHasChanged();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                var dimensions = await WindowService.GetDimensions();
                await WindowService.RegisterOnWindowResizeHandler(this);
                OptimizeColumns(dimensions.Width);
            }
        }

        [JSInvokable]
        public void OnWindowResize(int windowWidth)
        {
            OptimizeColumns(windowWidth);
        }
        private void OptimizeColumns(int windowWidth)
        {
            ChangeBreakpointType(windowWidth);
            StateHasChanged();
        }


        private void ChangeBreakpointType(int windowWith)
        {
            if (windowWith < currentBreakpointType.Width)
            {
                if (currentBreakpointType != BreakpointType.Sm)
                    currentBreakpointType = BreakpointType.FromValue(currentBreakpointType.Value - 1);
                ChangeBreakpointType(windowWith);
            }
            if (windowWith > currentBreakpointType.Width)
            {
                if (currentBreakpointType != BreakpointType.Xxl) {
                    if (windowWith > BreakpointType.FromValue(currentBreakpointType.Value + 1).Width)
                    {
                        currentBreakpointType = BreakpointType.Xxl;
                        ChangeBreakpointType(windowWith);
                    }
                }
            }
        }


        private List<List<DescriptionsItem>> GetRows(List<DescriptionsItem> children, BreakpointType breakpoint)
        {
            List<List<DescriptionsItem>> rows = new List<List<DescriptionsItem>>();
            List<DescriptionsItem> tmpRow = new List<DescriptionsItem>();

            int rowRestColumn = Column.GetCurrentCulloms(breakpoint);

            foreach (DescriptionsItem item in children)
            {
                int mergedSpan = item.Span;

                // Additional handle last one
                if (item.Index == children.Count - 1)
                {
                    item.AdjustSpanRestOfRow(rowRestColumn);
                    tmpRow.Add(item);
                    rows.Add(tmpRow);
                    return rows;
                }

                if (mergedSpan < rowRestColumn)
                {
                    rowRestColumn -= mergedSpan;
                    tmpRow.Add(item);
                }
                else
                {
                    if (mergedSpan > rowRestColumn)
                    {
                        item.AdjustSpanRestOfRow(rowRestColumn);
                    }
                    tmpRow.Add(item);
                    rows.Add(tmpRow);
                    rowRestColumn = Column.GetCurrentCulloms(breakpoint);
                    tmpRow = new List<DescriptionsItem>();
                }
            }
            return rows;
        }

        private RenderFragment BuildDescriptions()
        {
            RenderFragment descriptions = builder =>
            {
                //div
                builder.OpenElement(3, "div");
                builder.AddMultipleAttributes(4, Attributes);
                builder.AddAttribute(5, "class", classes);
                    //div title
                    builder.OpenElement(6, "div");
                    builder.AddAttribute(7, "class", $"{prefix}-title");
                    builder.AddContent(8, Title);
                    builder.CloseElement();
                    //div view
                    builder.OpenElement(9, "div");
                    builder.AddAttribute(10, "class", $"{prefix}-view");
                        //table
                        builder.OpenElement(11, "table");
                            //tbody
                            builder.OpenElement(12, "tbody");
                            builder.AddContent(13, BuildItems());
                            builder.CloseElement();
                        //close table
                        builder.CloseElement();
                    //close div view
                    builder.CloseElement();
                //close div
                builder.CloseElement();
            };
            return descriptions;
        }

        private RenderFragment BuildItems()
        {
            List<List<DescriptionsItem>> rows = GetRows(_children, currentBreakpointType);
            RenderFragment items = b =>
            {
                foreach (List<DescriptionsItem> row in rows)
                {

                    if(Direction == DescriptionsDirection.Horizontal)
                    {
                        b.OpenElement(1, "tr");
                        b.AddAttribute(2, "class", $"{prefix}-row");
                            foreach (DescriptionsItem item in row)
                            {
                                if (Bordered)
                                {
                                    b.AddContent(3, BorderedLabel(item));
                                    b.AddContent(4, BorderedContent(item));
                                }
                                else
                                {
                                    b.OpenElement(3, "td");
                                    b.AddAttribute(4, "class", $"{prefix}-item");
                                    b.AddAttribute(5, "colspan", item.Span);
                                    b.AddContent(6, NotBorderedLabel(item));
                                    b.AddContent(7, NotBorderedContent(item));
                                    b.CloseElement();
                                }
                            }
                        b.CloseElement();
                    }
                    else
                    {
                        //vertical
                        b.OpenElement(1, "tr");
                        b.AddAttribute(2, "class", $"{prefix}-row");
                        foreach (DescriptionsItem item in row)
                        {
                            if (Bordered)
                            {
                                b.AddContent(3, BorderedLabel(item));
                            }
                            else
                            {
                                b.OpenElement(3, "th");
                                b.AddAttribute(4, "class", $"{prefix}-item");
                                b.AddAttribute(5, "colspan", item.Span);
                                b.AddContent(6, NotBorderedLabel(item));
                                b.CloseElement();
                            }
                        }
                        b.CloseElement();
                        b.OpenElement(7, "tr");
                        b.AddAttribute(8, "class", $"{prefix}-row");
                        foreach (DescriptionsItem item in row)
                        {
                            if (Bordered)
                            {
                                b.AddContent(9, BorderedContent(item));
                            }
                            else
                            {
                                b.OpenElement(9, "td");
                                b.AddAttribute(10, "class", $"{prefix}-item");
                                b.AddAttribute(11, "colspan", item.Span);
                                b.AddContent(12, NotBorderedContent(item));
                                b.CloseElement();
                            }
                        }
                        b.CloseElement();
                    }
                }
            };
            return items;
        }

        private RenderFragment NotBorderedLabel(DescriptionsItem item)
        {
            RenderFragment notBorderedLabel = b =>
            {
                b.OpenElement(1, "span");
                b.AddAttribute(2, "class", $"{prefix}-item-label");
                if (!Colon)
                {
                    b.AddAttribute(3, "class", $"{prefix}-item-no-colon");
                }
                b.AddContent(4, item.Label);
                b.CloseElement();
                
            };
            return notBorderedLabel;
        }
        private RenderFragment NotBorderedContent(DescriptionsItem item)
        {
            RenderFragment notBorderedContent = b =>
            { 
                b.OpenElement(1, "span");
                b.AddAttribute(2, "class", $"{prefix}-item-content");
                b.AddContent(3, item.Content);
                b.CloseElement();
            };
            return notBorderedContent;
        }
        private RenderFragment BorderedLabel(DescriptionsItem item)
        {
            RenderFragment borderedLabel = b =>
            {
                b.OpenElement(1, "th");
                b.AddAttribute(2, "class", $"{prefix}-item-label");
                if (Direction == DescriptionsDirection.Horizontal)
                {
                    b.AddAttribute(3, "colspan", 1);
                }
                else
                {
                    b.AddAttribute(3, "colspan", item.Span);
                }
                b.AddContent(4, item.Label);
                b.CloseElement();

            };
            return borderedLabel;
        }

        private RenderFragment BorderedContent(DescriptionsItem item)
        {
            RenderFragment borderedContent = b =>
            {
                b.OpenElement(1, "td");
                b.AddAttribute(2, "class", $"{prefix}-item-content");
                if (Direction == DescriptionsDirection.Horizontal)
                {
                    b.AddAttribute(3, "colspan", item.Span * 2 - 1);
                }
                else
                {
                    b.AddAttribute(3, "colspan", item.Span);
                }
                b.AddContent(4, item.Content);
                b.CloseElement();
            };
            return borderedContent;
        }
    }
}
