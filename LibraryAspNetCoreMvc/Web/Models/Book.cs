using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Web.Models
{
    public class VolumeCollection
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("items")]
        public List<Volume> Items { get; set; }
    }

    public class Volume
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("selfLink")]
        public string SelfLink { get; set; }

        [JsonProperty("volumeInfo")]
        public VolumeInfo VolumeInfo { get; set; }

        [JsonProperty("saleInfo")]
        public SalesInfo SaleInfo { get; set; }

        [JsonProperty("accessInfo")]
        public AccessInfo AccessInfo { get; set; }

        [JsonProperty("searchInfo")]
        public SearchInfo SearchInfo { get; set; }
    }

    public class VolumeInfo
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string SubTitle { get; set; }

        [JsonProperty("authors")]
        public List<string> Authors { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("industryIdentifiers")]
        public List<IndustryIdentifier> IndustryIdentifiers { get; set; }

        [JsonProperty("readingModes")]
        public ReadingMode ReadingModes { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("printType")]
        public string PrintType { get; set; }

        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        [JsonProperty("averageRating")]
        public decimal AverageRating { get; set; }

        [JsonProperty("ratingsCount")]
        public int RatingsCount { get; set; }

        [JsonProperty("maturityRating")]
        public string MaturityRating { get; set; }

        [JsonProperty("allowAnonLogging")]
        public bool AllowNonLogging { get; set; }

        [JsonProperty("contentVersion")]
        public string ContentVersion { get; set; }

        [JsonProperty("panelizationSummary")]
        public PanelizationSummary PanelizationSummary { get; set; }

        [JsonProperty("imageLinks")]
        public ImageLinks ImageLinks { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("previewLink")]
        public string PreviewLink { get; set; }

        [JsonProperty("infoLink")]
        public string InfoLink { get; set; }

        [JsonProperty("canonicalVolumeLink")]
        public string CanonicalVolumeLink { get; set; }
    }

    public class IndustryIdentifier
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }

    public class ReadingMode
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class PanelizationSummary
    {
        [JsonProperty("containsEpubBubbles")]
        public bool ContainsEpubBubbles { get; set; }

        [JsonProperty("containsImageBubbles")]
        public bool ContainsImageBubbles { get; set; }
    }

    public class ImageLinks
    {
        [JsonProperty("smallThumbnail")]
        public string SmallThumbnail { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public class SalesInfo
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("saleability")]
        public string Saleability { get; set; }

        [JsonProperty("isEbook")]
        public bool IsEbook { get; set; }
    }

    public class AccessInfo
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("viewability")]
        public string Viewability { get; set; }

        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty("publicDomain")]
        public bool PublicDomain { get; set; }

        [JsonProperty("textToSpeechPermission")]
        public string TextToSpeechPermission { get; set; }

        [JsonProperty("epub")]
        public Epub Epub { get; set; }

        [JsonProperty("pdf")]
        public Pdf Pdf { get; set; }

        [JsonProperty("webReaderLink")]
        public string WebReaderLink { get; set; }

        [JsonProperty("accessViewStatus")]
        public string AccessViewStatus { get; set; }

        [JsonProperty("quoteSharingAllowed")]
        public bool QuoteSharingAllowed { get; set; }
    }

    public class Epub
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }
    }

    public class Pdf
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("acsTokenLink")]
        public string AcsTokenLink { get; set; }
    }

    public class SearchInfo
    {
        [JsonProperty("textSnippet")]
        public string TextSnippet { get; set; }
    }
}
