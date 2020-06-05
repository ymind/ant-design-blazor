namespace Append.AntDesign.Components
{
    public class ResponsiveDescription
    {
        public int Xs { get; set; }
        public int Sm { get; set; }
        public int Md { get; set; }
        public int Lg { get; set; }
        public int Xl { get; set; }
        public int Xxl { get; set; }

        public int GetCurrentCulloms(BreakpointType breakpoint) {
            if (breakpoint == BreakpointType.Xs)
                return Xs;
            if (breakpoint == BreakpointType.Sm)
                return Sm;
            if (breakpoint == BreakpointType.Md)
                return Md;
            if (breakpoint == BreakpointType.Lg)
                return Lg;
            if (breakpoint == BreakpointType.Xl)
                return Xl;
            else
                return Xxl;
        }
        public ResponsiveDescription(int xs = 1, int sm = 2, int md = 3, int lg = 3, int xl = 3, int xxl = 3)
        {
            Xs = xs;
            Sm = sm;
            Md = md;
            Lg = lg;
            Xl = xl;
            Xxl = xxl;
        }
        
        public static implicit operator ResponsiveDescription(int val)
        {
            return new ResponsiveDescription(xs: val, sm: val, md: val, lg: val, xl: val, xxl: val);
        }
    }
}
