using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Append.AntDesign.Components
{
    public partial class TabPane : ITabPane
    {
        internal bool tabIsActive => Tabs._currentKey.Equals(Key);

        private readonly static string baseClass = "ant-tabs";
        private ClassBuilder navClasses => ClassBuilder.Create(Class)
            .AddClass($"{baseClass}-tab" )
            .AddClassWhen($"{baseClass}-tab-active", tabIsActive)
            .AddClassWhen($"{baseClass}-tab-disabled", Disabled);

        private ClassBuilder contentClasses => ClassBuilder.Create(Class)
            .AddClass($"{baseClass}-tabpane")
            .AddClassWhen($"{baseClass}-tabpane-active", tabIsActive);


        private StyleBuilder tabStyles => StyleBuilder.Create(Style)
            .AddStyleWhen($"margin-right: {Tabs.TabBarGutter}px;", Tabs.TabBarGutter != 0 && (Tabs.TabPosition == TabDirection.Top || Tabs.TabPosition == TabDirection.Bottom))
            .AddStyleWhen($"margin-bottom: {Tabs.TabBarGutter}px;", Tabs.TabBarGutter != 0 && (Tabs.TabPosition == TabDirection.Left || Tabs.TabPosition == TabDirection.Right));

        private StyleBuilder contentStyles => StyleBuilder.Create()
            .AddStyleWhen("display: none", !tabIsActive);

        [Inject] private IJSRuntime jsRuntime { get; set; }

        private ElementReference tabPaneRef;

        [Parameter] public bool FoceRender { get; set; }
        [Parameter] public string Key { get; set; }
        [Parameter] public bool Disabled { get; set; }
        [Parameter] public RenderFragment Tab { get; set; }
        [Parameter] public RenderFragment CloseIcon { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        [CascadingParameter] public Tabs Tabs { get; set; }

        protected override async void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            if (firstRender)
            {
                await Tabs.SetInkBarStyle();
            }      
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Tabs.Subscribe(this);
        }

        public RenderFragment GetTabNav()
        {
            return builder =>
            {
                builder.OpenElement(0, "button");
                builder.SetKey(Key);      
                builder.AddAttribute(1, "type", "button");
                builder.AddAttribute(2, "role", "tab");
                builder.AddAttribute(3, "aria-selected", tabIsActive ? "true" : "false");
                builder.AddAttribute(4, "tabindex", "0");
                builder.AddAttribute(5, "class", navClasses);
                builder.AddAttribute(6, "style", tabStyles);
                if (Disabled)
                    builder.AddAttribute(7, "disabled", true);
                builder.AddAttribute(8, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this,
                    async (e) => { 
                        Tabs._currentKey = Key;
                        await Tabs.SetInkBarStyle();
                        Tabs.OnChange.InvokeAsync(Key);
                        Tabs.OnTabClick.InvokeAsync(Key);
                    }));
                builder.AddElementReferenceCapture(9, (_value) => { tabPaneRef = _value; });
                builder.AddContent(10, Tab);
                
                builder.CloseElement();
            };
        }

        public RenderFragment GetTabConcent()
        {
            return builder =>
            {
                builder.OpenElement(0, "div");
                builder.SetKey(Key);
                builder.AddAttribute(1, "aria-hidden", tabIsActive ? "false" : "true");
                builder.AddAttribute(2, "role", "tabpanel");
                builder.AddAttribute(5, "class", contentClasses);
                builder.AddAttribute(6, "style", contentStyles);
                builder.AddContent(7, ChildContent);
                builder.CloseElement();
            };
        }

        public async Task<Dimension> GetDimensions()
        {
            return await tabPaneRef.GetDimension(jsRuntime);
        }
    }
}