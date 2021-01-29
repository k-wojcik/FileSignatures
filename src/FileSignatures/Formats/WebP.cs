namespace FileSignatures.Formats
{
    public class WebP : Image
    {
        /// <summary>
        /// Specifies the format of a Google WebP image file.
        /// </summary>
        public WebP() : base(new byte?[] { 0x52, 0x49, 0x46, 0x46, null, null, null, null, 0x57, 0x45, 0x42, 0x50 }, "image/webp", "webp")
        {
        }
    }
}
