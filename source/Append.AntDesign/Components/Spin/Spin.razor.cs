using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;
using System.Timers;

namespace Append.AntDesign.Components
{
    public partial class Spin
    {
        private static readonly string prefix = "ant-spin";

        private ClassBuilder classes => ClassBuilder.Create(Class)
                .AddClass(prefix)
                .AddClassWhen($"{prefix}-spinning", _isLoading)
                .AddClassWhen($"{prefix}-lg", Size == SpinSize.Large)
                .AddClassWhen($"{prefix}-sm", Size == SpinSize.Small)
                .AddClassWhen($"{prefix}-show-text", !string.IsNullOrWhiteSpace(Label));

        private ClassBuilder containerClass => ClassBuilder.Create()
                .AddClass("ant-spin-container")
                .AddClassWhen($"{prefix}-blur", _isLoading);

        [Parameter] public RenderFragment Indicator { get; set; }
        [Parameter] public bool Spinning { get; set; } = true;
        [Parameter] public SpinSize Size { get; set; } = SpinSize.Default;
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public string Label { get; set; }
        [Parameter] public int Delay { get; set; } = 0;
        private bool _isLoading = true;
        private Timer _delayTimer;

        private RenderFragment BuildDot => builder =>
        {
            builder.OpenElement(1, "span");
            builder.AddAttribute(2, "class", "ant-spin-dot ant-spin-dot-spin");
            builder.AddContent(3, BuildDotItem);
            builder.AddContent(4, BuildDotItem);
            builder.AddContent(5, BuildDotItem);
            builder.AddContent(6, BuildDotItem);
            builder.CloseElement();
        };

        private RenderFragment BuildDotItem => builder =>
        {
            builder.OpenElement(1, "i");
            builder.AddAttribute(2, "class", "ant-spin-dot-item");
            builder.CloseElement();
        };

        private RenderFragment BuildLabel => builder =>
        {
            if (string.IsNullOrWhiteSpace(Label))
                return;

            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "ant-spin-text");
            builder.AddContent(3, Label);
            builder.CloseElement();
        };

        protected override void OnInitialized()
        {
            _isLoading = Spinning;

            if (Delay > 0)
            {
                _delayTimer = new Timer(Delay);
                _delayTimer.Elapsed += DelayElapsed;
            }

            base.OnInitialized();
        }
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if (_delayTimer != null)
            {
                if (_isLoading != Spinning)
                {
                    _delayTimer.Stop();
                    _delayTimer.Start();
                }
                else
                {
                    _delayTimer.Stop();
                }
            } else
            {
                _isLoading = Spinning;
            }
        }
        private void DelayElapsed(object sender, ElapsedEventArgs args)
        {
            _isLoading = Spinning;
            InvokeAsync(StateHasChanged);
        }
    }
}
