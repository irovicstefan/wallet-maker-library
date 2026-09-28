namespace Passbook.Generator.Fields
{
    /// <summary>
    /// Barcode format
    /// </summary>
    public enum BarcodeType
    {
        /// <summary>
        /// QRCode
        /// </summary>
        PKBarcodeFormatQR = 1,
        /// <summary>
        /// PDF-417
        /// </summary>
        PKBarcodeFormatPDF417,
        /// <summary>
        /// Aztec
        /// </summary>
        PKBarcodeFormatAztec,
        /// <summary>
        /// Code128
        /// </summary>
        PKBarcodeFormatCode128,
        /// <summary>
        /// Code 39
        /// </summary>
        PKBarcodeFormatCode39 = 5,
        /// <summary>
        /// Codabar
        /// </summary>
        PKBarcodeFormatCodabar = 6,
        /// <summary>
        /// EAN-13
        /// </summary>
        PKBarcodeFormatEAN13 = 7,
        /// <summary>
        /// Interleaved 2 of 5
        /// </summary>
        PKBarcodeFormatI2of5 = 8,
    }
}
