using Append.AntDesign.Core;
using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append.AntDesign.Components
{
    public partial class Tabs
    {

        private readonly static string baseClass = "ant-tabs";
        private ClassBuilder classes => ClassBuilder.Create(Class);

        private ClassBuilder classesFirstDiv => ClassBuilder.Create()
           .AddClass(baseClass)
           .AddClass($"{baseClass}-{TabPosition}")
           .AddClassWhen($"{baseClass}-large", Size == TabsSize.Large)
           .AddClassWhen($"{baseClass}-small", Size == TabsSize.Small);

        private ClassBuilder classesSecondDiv => ClassBuilder.Create()
           .AddClass($"{baseClass}");

        private List<TabPane> _tabPanes = new List<TabPane>();

        internal string _currentKey { get; set; }

        [Parameter] public string ActiveKey { get; set; }
        [Parameter] public string DefaultActiveKey { get; set; }
        [Parameter] public TabsSize Size { get; set; }
        [Parameter] public int TabBarGutter { get; set; }
        [Parameter] public TabDirection TabPosition { get; set; } = TabDirection.Top;
       
        [Parameter] public RenderFragment TabBarExtraContent { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter] public EventCallback<string> OnChange { get; set; }
        [Parameter] public EventCallback<string> OnTabClick { get; set; }

        private StyleBuilder inkBarStyle = StyleBuilder.Create();

        public async Task SetInkBarStyle()
        {
            var widthOrHeight = await CalculateWidthOrHeight(_tabPanes.FirstOrDefault(g => g.tabIsActive));
            var leftOrRight = await CalculateLeftOrRight();

            inkBarStyle = StyleBuilder.Create()
                .AddStyle(widthOrHeight)
                .AddStyle(leftOrRight);

            StateHasChanged();
        }

        private async Task<string> CalculateLeftOrRight()
        {

            if(TabPosition == TabDirection.Top || TabPosition == TabDirection.Bottom)
            {
                var tabPane = _tabPanes.FirstOrDefault(g => g.tabIsActive);
                if (tabPane == null)
                    return "";
                var index = _tabPanes.IndexOf(tabPane);
                var left = 0;
                for (int i = 0; i < index; i++)
                {
                    var dimensions = await _tabPanes[i].GetDimensions();
                    left = left + (TabBarGutter == 0 ? 32 : TabBarGutter) + dimensions.Width;
                }
                return $"left: {left}px";
            } else
            {
                var tabPane = _tabPanes.FirstOrDefault(g => g.tabIsActive);
                if (tabPane == null)
                    return "";
                var index = _tabPanes.IndexOf(tabPane);
                var top = 0;
                for (int i = 0; i < index; i++)
                {
                    var dimensions = await _tabPanes[i].GetDimensions();
                    top = top + (TabBarGutter == 0 ? 16 : TabBarGutter) + dimensions.Height;
                }
                return $"top: {top}px";
            }
           
        }
        private async Task<string> CalculateWidthOrHeight(TabPane tabPane)
        {
            if (TabPosition == TabDirection.Left || TabPosition == TabDirection.Right)
            {
                var dimensions = await tabPane.GetDimensions();
                return $"height: {dimensions.Height}px";  
            } else
            {
                if (tabPane == null)
                {
                    return "";
                }
                else
                {
                    var dimensions = await tabPane.GetDimensions();
                    return $"width: {dimensions.Width}px";
                }
            }       
        }

        internal void Subscribe(TabPane tabPane)
        {
            _tabPanes.Add(tabPane);
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            _currentKey = ActiveKey ?? DefaultActiveKey;
        }

      
    }

    internal class TabsParametersDTO
    {
        public int MyProperty { get; set; }
    }

    public sealed class TabsSize : SmartEnum<TabsSize>
    {
        public static readonly TabsSize Large = new TabsSize(nameof(Large).ToLower(), 0);
        public static readonly TabsSize Default = new TabsSize(nameof(Default).ToLower(), 1);
        public static readonly TabsSize Small = new TabsSize(nameof(Small).ToLower(), 2);

        private TabsSize(string name, int value) : base(name, value)
        {
        }
    }

    public sealed class TabDirection : SmartEnum<TabDirection>
    {
        public static readonly TabDirection Top = new TabDirection(nameof(Top).ToLower(), 0);
        public static readonly TabDirection Right = new TabDirection(nameof(Right).ToLower(), 1);
        public static readonly TabDirection Bottom = new TabDirection(nameof(Bottom).ToLower(), 2);
        public static readonly TabDirection Left = new TabDirection(nameof(Left).ToLower(), 3);

        private TabDirection(string name, int value) : base(name, value)
        {
        }
    }
}