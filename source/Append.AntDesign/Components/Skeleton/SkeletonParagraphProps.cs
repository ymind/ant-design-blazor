namespace Append.AntDesign.Components
{
    public class SkeletonParagraphProps
    {
        /// <summary>
        /// Set the row count of paragraph
        /// </summary>
        public int Rows { get; set; } = 3;
        /// <summary>
        /// Set the width of paragraphs in percent. Set the width of each row, if only one sets the last row width
        /// </summary>
        public int[] Width { get; set; } = { 61 };
    }
}