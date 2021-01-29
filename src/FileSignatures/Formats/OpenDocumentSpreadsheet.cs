﻿namespace FileSignatures.Formats
{
    /// <summary>
    /// Specifies the format of a OffsetFileFormat file.
    /// </summary>
    public class OpenDocumentSpreadsheet : FileFormat
    {
        public OpenDocumentSpreadsheet() : base(new byte?[] {
            0x6D, 0x69, 0x6D, 0x65, 0x74, 0x79, 0x70, 0x65, 0x61, 0x70, 0x70, 0x6C, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6F,
            0x6E, 0x2F, 0x76, 0x6E, 0x64, 0x2E, 0x6F, 0x61, 0x73, 0x69, 0x73, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x64, 0x6F,
            0x63, 0x75, 0x6D, 0x65, 0x6E, 0x74, 0x2E, 0x73, 0x70, 0x72, 0x65, 0x61, 0x64, 0x73, 0x68, 0x65, 0x65, 0x74
        }, "application/vnd.oasis.opendocument.spreadsheet", "ods", 30)
        {
        }
    }
}
