using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LighthouseAuditAggregator.InputReaderModel
{
    
    public partial class InputModelRoot
    {
        [JsonProperty("audits")]
        public Dictionary<string, Audit> Audits { get; set; }

        [JsonProperty("categories")]
        public Categories Categories { get; set; }

        [JsonProperty("categoryGroups")]
        public CategoryGroups CategoryGroups { get; set; }

        [JsonProperty("configSettings")]
        public ConfigSettings ConfigSettings { get; set; }

        [JsonProperty("environment")]
        public Environment Environment { get; set; }

        [JsonProperty("fetchTime")]
        public DateTimeOffset FetchTime { get; set; }

        [JsonProperty("finalUrl")]
        public Uri FinalUrl { get; set; }

        [JsonProperty("i18n")]
        public I18N I18N { get; set; }

        [JsonProperty("lighthouseVersion")]
        public string LighthouseVersion { get; set; }

        [JsonProperty("requestedUrl")]
        public Uri RequestedUrl { get; set; }

        [JsonProperty("runWarnings")]
        public List<object> RunWarnings { get; set; }

        [JsonProperty("stackPacks")]
        public List<object> StackPacks { get; set; }

        [JsonProperty("timing")]
        public Timing Timing { get; set; }

        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }
    }

    public class Audit
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public Details Details { get; set; }

        [JsonProperty("displayValue", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayValue { get; set; }

        [JsonProperty("explanation", NullValueHandling = NullValueHandling.Ignore)]
        public string Explanation { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("numericValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? NumericValue { get; set; }

        [JsonProperty("score")]
        public double? Score { get; set; }

        [JsonProperty("scoreDisplayMode")]
        public ScoreDisplayMode ScoreDisplayMode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("warnings", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Warnings { get; set; }
    }

    public class Details
    {
        [JsonProperty("chains", NullValueHandling = NullValueHandling.Ignore)]
        public Chains Chains { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        [JsonProperty("debugData", NullValueHandling = NullValueHandling.Ignore)]
        public DetailsDebugData DebugData { get; set; }

        [JsonProperty("headings", NullValueHandling = NullValueHandling.Ignore)]
        public List<Heading> Headings { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }

        [JsonProperty("longestChain", NullValueHandling = NullValueHandling.Ignore)]
        public LongestChain LongestChain { get; set; }

        [JsonProperty("overallSavingsBytes", NullValueHandling = NullValueHandling.Ignore)]
        public long? OverallSavingsBytes { get; set; }

        [JsonProperty("overallSavingsMs", NullValueHandling = NullValueHandling.Ignore)]
        public double? OverallSavingsMs { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public long? Scale { get; set; }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public Summary Summary { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }

        [JsonProperty("timing", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timing { get; set; }

        [JsonProperty("type")]
        public DebugDataType Type { get; set; }
    }

    public class Chains
    {
        [JsonProperty("91A70AD299CACBDAFFBAED8F7698F985")]
        public The91A70Ad299Cacbdaffbaed8F7698F985 The91A70Ad299Cacbdaffbaed8F7698F985 { get; set; }
    }

    public class The91A70Ad299Cacbdaffbaed8F7698F985
    {
        [JsonProperty("children")]
        public Dictionary<string, Child> Children { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }
    }

    public class Child
    {
        [JsonProperty("request")]
        public Request Request { get; set; }
    }

    public class Request
    {
        [JsonProperty("endTime")]
        public double EndTime { get; set; }

        [JsonProperty("responseReceivedTime")]
        public double ResponseReceivedTime { get; set; }

        [JsonProperty("startTime")]
        public double StartTime { get; set; }

        [JsonProperty("transferSize")]
        public long TransferSize { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public class DetailsDebugData
    {
        [JsonProperty("impact")]
        public string Impact { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("type")]
        public DebugDataType Type { get; set; }
    }

    public class Heading
    {
        [JsonProperty("displayUnit", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayUnit { get; set; }

        [JsonProperty("granularity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Granularity { get; set; }

        [JsonProperty("itemType", NullValueHandling = NullValueHandling.Ignore)]
        public ItemTypeEnum? ItemType { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public Label? Label { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("valueType", NullValueHandling = NullValueHandling.Ignore)]
        public ValueType? ValueType { get; set; }
    }

    public class Item
    {
        [JsonProperty("cacheHitProbability", NullValueHandling = NullValueHandling.Ignore)]
        public double? CacheHitProbability { get; set; }

        [JsonProperty("cacheLifetimeMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? CacheLifetimeMs { get; set; }

        [JsonProperty("coverage", NullValueHandling = NullValueHandling.Ignore)]
        public string Coverage { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        [JsonProperty("debugData", NullValueHandling = NullValueHandling.Ignore)]
        public ItemDebugData DebugData { get; set; }

        [JsonProperty("detectedLib", NullValueHandling = NullValueHandling.Ignore)]
        public DetectedLib DetectedLib { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public double? Duration { get; set; }

        [JsonProperty("element", NullValueHandling = NullValueHandling.Ignore)]
        public ElementUnion? Element { get; set; }

        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public double? EndTime { get; set; }

        [JsonProperty("entity", NullValueHandling = NullValueHandling.Ignore)]
        public DetectedLib Entity { get; set; }

        [JsonProperty("estimatedInputLatency", NullValueHandling = NullValueHandling.Ignore)]
        public long? EstimatedInputLatency { get; set; }

        [JsonProperty("failures", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Failures { get; set; }

        [JsonProperty("firstContentfulPaint", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirstContentfulPaint { get; set; }

        [JsonProperty("firstCPUIdle", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirstCpuIdle { get; set; }

        [JsonProperty("firstMeaningfulPaint", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirstMeaningfulPaint { get; set; }

        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public string FontSize { get; set; }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        [JsonProperty("groupLabel", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupLabel { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

        [JsonProperty("highestSeverity", NullValueHandling = NullValueHandling.Ignore)]
        public string HighestSeverity { get; set; }

        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }

        [JsonProperty("interactive", NullValueHandling = NullValueHandling.Ignore)]
        public long? Interactive { get; set; }

        [JsonProperty("isParseFailure", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsParseFailure { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("lineNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? LineNumber { get; set; }

        [JsonProperty("mainDocumentTransferSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? MainDocumentTransferSize { get; set; }

        [JsonProperty("mainThreadTime", NullValueHandling = NullValueHandling.Ignore)]
        public double? MainThreadTime { get; set; }

        [JsonProperty("maxRtt", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxRtt { get; set; }

        [JsonProperty("maxServerLatency", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxServerLatency { get; set; }

        [JsonProperty("mimeType", NullValueHandling = NullValueHandling.Ignore)]
        public string MimeType { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("node", NullValueHandling = NullValueHandling.Ignore)]
        public Node Node { get; set; }

        [JsonProperty("npm", NullValueHandling = NullValueHandling.Ignore)]
        public string Npm { get; set; }

        [JsonProperty("numFonts", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumFonts { get; set; }

        [JsonProperty("numRequests", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumRequests { get; set; }

        [JsonProperty("numScripts", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumScripts { get; set; }

        [JsonProperty("numStylesheets", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumStylesheets { get; set; }

        [JsonProperty("numTasks", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumTasks { get; set; }

        [JsonProperty("numTasksOver100ms", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumTasksOver100Ms { get; set; }

        [JsonProperty("numTasksOver10ms", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumTasksOver10Ms { get; set; }

        [JsonProperty("numTasksOver25ms", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumTasksOver25Ms { get; set; }

        [JsonProperty("numTasksOver500ms", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumTasksOver500Ms { get; set; }

        [JsonProperty("numTasksOver50ms", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumTasksOver50Ms { get; set; }

        [JsonProperty("observedDomContentLoaded", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedDomContentLoaded { get; set; }

        [JsonProperty("observedDomContentLoadedTs", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedDomContentLoadedTs { get; set; }

        [JsonProperty("observedFirstContentfulPaint", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedFirstContentfulPaint { get; set; }

        [JsonProperty("observedFirstContentfulPaintTs", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedFirstContentfulPaintTs { get; set; }

        [JsonProperty("observedFirstMeaningfulPaint", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedFirstMeaningfulPaint { get; set; }

        [JsonProperty("observedFirstMeaningfulPaintTs", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedFirstMeaningfulPaintTs { get; set; }

        [JsonProperty("observedFirstPaint", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedFirstPaint { get; set; }

        [JsonProperty("observedFirstPaintTs", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedFirstPaintTs { get; set; }

        [JsonProperty("observedFirstVisualChange", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedFirstVisualChange { get; set; }

        [JsonProperty("observedFirstVisualChangeTs", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedFirstVisualChangeTs { get; set; }

        [JsonProperty("observedLastVisualChange", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedLastVisualChange { get; set; }

        [JsonProperty("observedLastVisualChangeTs", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedLastVisualChangeTs { get; set; }

        [JsonProperty("observedLoad", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedLoad { get; set; }

        [JsonProperty("observedLoadTs", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedLoadTs { get; set; }

        [JsonProperty("observedNavigationStart", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedNavigationStart { get; set; }

        [JsonProperty("observedNavigationStartTs", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedNavigationStartTs { get; set; }

        [JsonProperty("observedSpeedIndex", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedSpeedIndex { get; set; }

        [JsonProperty("observedSpeedIndexTs", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedSpeedIndexTs { get; set; }

        [JsonProperty("observedTraceEnd", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedTraceEnd { get; set; }

        [JsonProperty("observedTraceEndTs", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObservedTraceEndTs { get; set; }

        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Origin { get; set; }

        [JsonProperty("outerHTML", NullValueHandling = NullValueHandling.Ignore)]
        public string OuterHtml { get; set; }

        [JsonProperty("overlappingTarget", NullValueHandling = NullValueHandling.Ignore)]
        public Node OverlappingTarget { get; set; }

        [JsonProperty("overlappingTargetScore", NullValueHandling = NullValueHandling.Ignore)]
        public double? OverlappingTargetScore { get; set; }

        [JsonProperty("overlapScoreRatio", NullValueHandling = NullValueHandling.Ignore)]
        public double? OverlapScoreRatio { get; set; }

        [JsonProperty("parseFailureReason", NullValueHandling = NullValueHandling.Ignore)]
        public string ParseFailureReason { get; set; }

        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public string Rel { get; set; }

        [JsonProperty("requestCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? RequestCount { get; set; }

        [JsonProperty("requestStartTime", NullValueHandling = NullValueHandling.Ignore)]
        public double? RequestStartTime { get; set; }

        [JsonProperty("resourceSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResourceSize { get; set; }

        [JsonProperty("resourceType", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        [JsonProperty("rtt", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rtt { get; set; }

        [JsonProperty("scripting", NullValueHandling = NullValueHandling.Ignore)]
        public double? Scripting { get; set; }

        [JsonProperty("scriptParseCompile", NullValueHandling = NullValueHandling.Ignore)]
        public double? ScriptParseCompile { get; set; }

        [JsonProperty("selector", NullValueHandling = NullValueHandling.Ignore)]
        public string Selector { get; set; }

        [JsonProperty("serverResponseTime", NullValueHandling = NullValueHandling.Ignore)]
        public double? ServerResponseTime { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public Size? Size { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("speedIndex", NullValueHandling = NullValueHandling.Ignore)]
        public long? SpeedIndex { get; set; }

        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public double? StartTime { get; set; }

        [JsonProperty("statistic", NullValueHandling = NullValueHandling.Ignore)]
        public string Statistic { get; set; }

        [JsonProperty("statusCode", NullValueHandling = NullValueHandling.Ignore)]
        public long? StatusCode { get; set; }

        [JsonProperty("tapTarget", NullValueHandling = NullValueHandling.Ignore)]
        public Node TapTarget { get; set; }

        [JsonProperty("tapTargetScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? TapTargetScore { get; set; }

        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        [JsonProperty("themeColor")]
        public object ThemeColor { get; set; }

        [JsonProperty("throughput", NullValueHandling = NullValueHandling.Ignore)]
        public double? Throughput { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Timestamp { get; set; }

        [JsonProperty("timing", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timing { get; set; }

        [JsonProperty("timingType", NullValueHandling = NullValueHandling.Ignore)]
        public TimingType? TimingType { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; }

        [JsonProperty("totalBlockingTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalBlockingTime { get; set; }

        [JsonProperty("totalBytes", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalBytes { get; set; }

        [JsonProperty("totalByteWeight", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalByteWeight { get; set; }

        [JsonProperty("totalTaskTime", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalTaskTime { get; set; }

        [JsonProperty("transferSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? TransferSize { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("vulnCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? VulnCount { get; set; }

        [JsonProperty("wastedBytes", NullValueHandling = NullValueHandling.Ignore)]
        public double? WastedBytes { get; set; }

        [JsonProperty("wastedMs", NullValueHandling = NullValueHandling.Ignore)]
        public double? WastedMs { get; set; }

        [JsonProperty("wastedPercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? WastedPercent { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }
    }

    public class ItemDebugData
    {
        [JsonProperty("max-age")]
        public long MaxAge { get; set; }

        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public { get; set; }

        [JsonProperty("type")]
        public DebugDataType Type { get; set; }
    }

    public class DetectedLib
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public ItemTypeEnum Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ElementClass
    {
        [JsonProperty("type")]
        public ItemTypeEnum Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Node
    {
        [JsonProperty("explanation", NullValueHandling = NullValueHandling.Ignore)]
        public string Explanation { get; set; }

        [JsonProperty("nodeLabel")]
        public string NodeLabel { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("selector")]
        public string Selector { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("type")]
        public ItemTypeEnum Type { get; set; }
    }

    public class LongestChain
    {
        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("length")]
        public long Length { get; set; }

        [JsonProperty("transferSize")]
        public long TransferSize { get; set; }
    }

    public class Summary
    {
        [JsonProperty("wastedBytes", NullValueHandling = NullValueHandling.Ignore)]
        public double? WastedBytes { get; set; }

        [JsonProperty("wastedMs", NullValueHandling = NullValueHandling.Ignore)]
        public double? WastedMs { get; set; }
    }

    public class Categories
    {
        [JsonProperty("accessibility")]
        public Accessibility Accessibility { get; set; }

        [JsonProperty("best-practices")]
        public BestPractices BestPractices { get; set; }

        [JsonProperty("performance")]
        public Performance Performance { get; set; }

        [JsonProperty("pwa")]
        public Accessibility Pwa { get; set; }

        [JsonProperty("seo")]
        public Accessibility Seo { get; set; }
    }

    public class Accessibility
    {
        [JsonProperty("auditRefs")]
        public List<AccessibilityAuditRef> AuditRefs { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("manualDescription")]
        public string ManualDescription { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class AccessibilityAuditRef
    {
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }

    public class BestPractices
    {
        [JsonProperty("auditRefs")]
        public List<BestPracticesAuditRef> AuditRefs { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class BestPracticesAuditRef
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }

    public class Performance
    {
        [JsonProperty("auditRefs")]
        public List<AccessibilityAuditRef> AuditRefs { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CategoryGroups
    {
        [JsonProperty("a11y-aria")]
        public A11YAria A11YAria { get; set; }

        [JsonProperty("a11y-audio-video")]
        public A11YAria A11YAudioVideo { get; set; }

        [JsonProperty("a11y-best-practices")]
        public A11YAria A11YBestPractices { get; set; }

        [JsonProperty("a11y-color-contrast")]
        public A11YAria A11YColorContrast { get; set; }

        [JsonProperty("a11y-language")]
        public A11YAria A11YLanguage { get; set; }

        [JsonProperty("a11y-names-labels")]
        public A11YAria A11YNamesLabels { get; set; }

        [JsonProperty("a11y-navigation")]
        public A11YAria A11YNavigation { get; set; }

        [JsonProperty("a11y-tables-lists")]
        public A11YAria A11YTablesLists { get; set; }

        [JsonProperty("budgets")]
        public A11YAria Budgets { get; set; }

        [JsonProperty("diagnostics")]
        public A11YAria Diagnostics { get; set; }

        [JsonProperty("load-opportunities")]
        public A11YAria LoadOpportunities { get; set; }

        [JsonProperty("metrics")]
        public Metrics Metrics { get; set; }

        [JsonProperty("pwa-fast-reliable")]
        public Metrics PwaFastReliable { get; set; }

        [JsonProperty("pwa-installable")]
        public Metrics PwaInstallable { get; set; }

        [JsonProperty("pwa-optimized")]
        public Metrics PwaOptimized { get; set; }

        [JsonProperty("seo-content")]
        public A11YAria SeoContent { get; set; }

        [JsonProperty("seo-crawl")]
        public A11YAria SeoCrawl { get; set; }

        [JsonProperty("seo-mobile")]
        public A11YAria SeoMobile { get; set; }
    }

    public class A11YAria
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class Metrics
    {
        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ConfigSettings
    {
        [JsonProperty("additionalTraceCategories")]
        public object AdditionalTraceCategories { get; set; }

        [JsonProperty("auditMode")]
        public bool AuditMode { get; set; }

        [JsonProperty("blockedUrlPatterns")]
        public object BlockedUrlPatterns { get; set; }

        [JsonProperty("budgets")]
        public object Budgets { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("disableStorageReset")]
        public bool DisableStorageReset { get; set; }

        [JsonProperty("emulatedFormFactor")]
        public string EmulatedFormFactor { get; set; }

        [JsonProperty("extraHeaders")]
        public object ExtraHeaders { get; set; }

        [JsonProperty("gatherMode")]
        public bool GatherMode { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("maxWaitForFcp")]
        public long MaxWaitForFcp { get; set; }

        [JsonProperty("maxWaitForLoad")]
        public long MaxWaitForLoad { get; set; }

        [JsonProperty("onlyAudits")]
        public object OnlyAudits { get; set; }

        [JsonProperty("onlyCategories")]
        public object OnlyCategories { get; set; }

        [JsonProperty("output")]
        public List<string> Output { get; set; }

        [JsonProperty("precomputedLanternData")]
        public object PrecomputedLanternData { get; set; }

        [JsonProperty("skipAudits")]
        public object SkipAudits { get; set; }

        [JsonProperty("throttling")]
        public Throttling Throttling { get; set; }

        [JsonProperty("throttlingMethod")]
        public string ThrottlingMethod { get; set; }
    }

    public class Throttling
    {
        [JsonProperty("cpuSlowdownMultiplier")]
        public long CpuSlowdownMultiplier { get; set; }

        [JsonProperty("downloadThroughputKbps")]
        public double DownloadThroughputKbps { get; set; }

        [JsonProperty("requestLatencyMs")]
        public double RequestLatencyMs { get; set; }

        [JsonProperty("rttMs")]
        public long RttMs { get; set; }

        [JsonProperty("throughputKbps")]
        public double ThroughputKbps { get; set; }

        [JsonProperty("uploadThroughputKbps")]
        public long UploadThroughputKbps { get; set; }
    }

    public class Environment
    {
        [JsonProperty("benchmarkIndex")]
        public long BenchmarkIndex { get; set; }

        [JsonProperty("hostUserAgent")]
        public string HostUserAgent { get; set; }

        [JsonProperty("networkUserAgent")]
        public string NetworkUserAgent { get; set; }
    }

    public class I18N
    {
        [JsonProperty("icuMessagePaths")]
        public IcuMessagePaths IcuMessagePaths { get; set; }

        [JsonProperty("rendererFormattedStrings")]
        public RendererFormattedStrings RendererFormattedStrings { get; set; }
    }

    public class IcuMessagePaths
    {
        [JsonProperty("lighthouse-core/audits/accessibility/accesskeys.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityAccesskeysJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/accesskeys.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityAccesskeysJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-allowed-attr.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaAllowedAttrJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-allowed-attr.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaAllowedAttrJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-required-attr.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaRequiredAttrJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-required-attr.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaRequiredAttrJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-required-children.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaRequiredChildrenJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-required-children.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaRequiredChildrenJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-required-parent.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaRequiredParentJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-required-parent.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaRequiredParentJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-roles.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaRolesJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-roles.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaRolesJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-valid-attr.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaValidAttrJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-valid-attr.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaValidAttrJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-valid-attr-value.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaValidAttrValueJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/aria-valid-attr-value.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityAriaValidAttrValueJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/audio-caption.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityAudioCaptionJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/audio-caption.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityAudioCaptionJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/axe-audit.js | failingElementsHeader")]
        public List<string> LighthouseCoreAuditsAccessibilityAxeAuditJsFailingElementsHeader { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/button-name.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityButtonNameJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/button-name.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityButtonNameJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/bypass.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityBypassJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/bypass.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityBypassJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/color-contrast.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityColorContrastJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/color-contrast.js | failureTitle")]
        public List<string> LighthouseCoreAuditsAccessibilityColorContrastJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/definition-list.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityDefinitionListJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/definition-list.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityDefinitionListJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/dlitem.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityDlitemJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/dlitem.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityDlitemJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/document-title.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityDocumentTitleJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/document-title.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityDocumentTitleJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/duplicate-id.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityDuplicateIdJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/duplicate-id.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityDuplicateIdJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/frame-title.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityFrameTitleJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/frame-title.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityFrameTitleJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/html-has-lang.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityHtmlHasLangJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/html-has-lang.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityHtmlHasLangJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/html-lang-valid.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityHtmlLangValidJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/html-lang-valid.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityHtmlLangValidJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/image-alt.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityImageAltJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/image-alt.js | failureTitle")]
        public List<string> LighthouseCoreAuditsAccessibilityImageAltJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/input-image-alt.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityInputImageAltJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/input-image-alt.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityInputImageAltJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/label.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityLabelJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/label.js | failureTitle")]
        public List<string> LighthouseCoreAuditsAccessibilityLabelJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/layout-table.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityLayoutTableJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/layout-table.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityLayoutTableJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/link-name.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityLinkNameJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/link-name.js | failureTitle")]
        public List<string> LighthouseCoreAuditsAccessibilityLinkNameJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/listitem.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityListitemJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/listitem.js | failureTitle")]
        public List<string> LighthouseCoreAuditsAccessibilityListitemJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/list.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityListJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/list.js | failureTitle")]
        public List<string> LighthouseCoreAuditsAccessibilityListJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/meta-refresh.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityMetaRefreshJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/meta-refresh.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityMetaRefreshJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/meta-viewport.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityMetaViewportJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/meta-viewport.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityMetaViewportJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/object-alt.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityObjectAltJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/object-alt.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityObjectAltJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/tabindex.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityTabindexJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/tabindex.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityTabindexJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/td-headers-attr.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityTdHeadersAttrJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/td-headers-attr.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityTdHeadersAttrJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/th-has-data-cells.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityThHasDataCellsJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/th-has-data-cells.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityThHasDataCellsJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/valid-lang.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityValidLangJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/valid-lang.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityValidLangJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/video-caption.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityVideoCaptionJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/video-caption.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityVideoCaptionJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/video-description.js | description")]
        public List<string> LighthouseCoreAuditsAccessibilityVideoDescriptionJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/accessibility/video-description.js | title")]
        public List<string> LighthouseCoreAuditsAccessibilityVideoDescriptionJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/apple-touch-icon.js | description")]
        public List<string> LighthouseCoreAuditsAppleTouchIconJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/apple-touch-icon.js | failureTitle")]
        public List<string> LighthouseCoreAuditsAppleTouchIconJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/bootup-time.js | columnScriptEval")]
        public List<string> LighthouseCoreAuditsBootupTimeJsColumnScriptEval { get; set; }

        [JsonProperty("lighthouse-core/audits/bootup-time.js | columnScriptParse")]
        public List<string> LighthouseCoreAuditsBootupTimeJsColumnScriptParse { get; set; }

        [JsonProperty("lighthouse-core/audits/bootup-time.js | columnTotal")]
        public List<string> LighthouseCoreAuditsBootupTimeJsColumnTotal { get; set; }

        [JsonProperty("lighthouse-core/audits/bootup-time.js | description")]
        public List<string> LighthouseCoreAuditsBootupTimeJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/bootup-time.js | failureTitle")]
        public List<string> LighthouseCoreAuditsBootupTimeJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/efficient-animated-content.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyEfficientAnimatedContentJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/efficient-animated-content.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyEfficientAnimatedContentJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/offscreen-images.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyOffscreenImagesJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/offscreen-images.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyOffscreenImagesJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/render-blocking-resources.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyRenderBlockingResourcesJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/render-blocking-resources.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyRenderBlockingResourcesJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/total-byte-weight.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyTotalByteWeightJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/total-byte-weight.js | displayValue")]
        public List<LighthouseCoreAuditsByteEfficiencyTotalByteWeightJsDisplayValue> LighthouseCoreAuditsByteEfficiencyTotalByteWeightJsDisplayValue { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/total-byte-weight.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyTotalByteWeightJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/unminified-css.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUnminifiedCssJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/unminified-css.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUnminifiedCssJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/unminified-javascript.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUnminifiedJavascriptJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/unminified-javascript.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUnminifiedJavascriptJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/unused-css-rules.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUnusedCssRulesJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/unused-css-rules.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUnusedCssRulesJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-long-cache-ttl.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUsesLongCacheTtlJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-long-cache-ttl.js | displayValue")]
        public List<LighthouseCoreAuditsJsDisplayValue> LighthouseCoreAuditsByteEfficiencyUsesLongCacheTtlJsDisplayValue
        {
            get;
            set;
        }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-long-cache-ttl.js | failureTitle")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUsesLongCacheTtlJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-optimized-images.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUsesOptimizedImagesJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-optimized-images.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUsesOptimizedImagesJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-responsive-images.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUsesResponsiveImagesJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-responsive-images.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUsesResponsiveImagesJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-text-compression.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUsesTextCompressionJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-text-compression.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUsesTextCompressionJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-webp-images.js | description")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUsesWebpImagesJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/byte-efficiency/uses-webp-images.js | title")]
        public List<string> LighthouseCoreAuditsByteEfficiencyUsesWebpImagesJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/critical-request-chains.js | description")]
        public List<string> LighthouseCoreAuditsCriticalRequestChainsJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/critical-request-chains.js | displayValue")]
        public List<LighthouseCoreAuditsJsDisplayValue> LighthouseCoreAuditsCriticalRequestChainsJsDisplayValue
        {
            get;
            set;
        }

        [JsonProperty("lighthouse-core/audits/critical-request-chains.js | title")]
        public List<string> LighthouseCoreAuditsCriticalRequestChainsJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/deprecations.js | columnDeprecate")]
        public List<string> LighthouseCoreAuditsDeprecationsJsColumnDeprecate { get; set; }

        [JsonProperty("lighthouse-core/audits/deprecations.js | columnLine")]
        public List<string> LighthouseCoreAuditsDeprecationsJsColumnLine { get; set; }

        [JsonProperty("lighthouse-core/audits/deprecations.js | description")]
        public List<string> LighthouseCoreAuditsDeprecationsJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/deprecations.js | displayValue")]
        public List<LighthouseCoreAuditsJsDisplayValue> LighthouseCoreAuditsDeprecationsJsDisplayValue { get; set; }

        [JsonProperty("lighthouse-core/audits/deprecations.js | failureTitle")]
        public List<string> LighthouseCoreAuditsDeprecationsJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/appcache-manifest.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebAppcacheManifestJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/appcache-manifest.js | title")]
        public List<string> LighthouseCoreAuditsDobetterwebAppcacheManifestJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/doctype.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebDoctypeJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/doctype.js | title")]
        public List<string> LighthouseCoreAuditsDobetterwebDoctypeJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/dom-size.js | columnElement")]
        public List<string> LighthouseCoreAuditsDobetterwebDomSizeJsColumnElement { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/dom-size.js | columnStatistic")]
        public List<string> LighthouseCoreAuditsDobetterwebDomSizeJsColumnStatistic { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/dom-size.js | columnValue")]
        public List<string> LighthouseCoreAuditsDobetterwebDomSizeJsColumnValue { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/dom-size.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebDomSizeJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/dom-size.js | displayValue")]
        public List<LighthouseCoreAuditsJsDisplayValue> LighthouseCoreAuditsDobetterwebDomSizeJsDisplayValue
        {
            get;
            set;
        }

        [JsonProperty("lighthouse-core/audits/dobetterweb/dom-size.js | failureTitle")]
        public List<string> LighthouseCoreAuditsDobetterwebDomSizeJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/dom-size.js | statisticDOMDepth")]
        public List<string> LighthouseCoreAuditsDobetterwebDomSizeJsStatisticDomDepth { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/dom-size.js | statisticDOMElements")]
        public List<string> LighthouseCoreAuditsDobetterwebDomSizeJsStatisticDomElements { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/dom-size.js | statisticDOMWidth")]
        public List<string> LighthouseCoreAuditsDobetterwebDomSizeJsStatisticDomWidth { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/external-anchors-use-rel-noopener.js | columnRel")]
        public List<string> LighthouseCoreAuditsDobetterwebExternalAnchorsUseRelNoopenerJsColumnRel { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/external-anchors-use-rel-noopener.js | columnTarget")]
        public List<string> LighthouseCoreAuditsDobetterwebExternalAnchorsUseRelNoopenerJsColumnTarget { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/external-anchors-use-rel-noopener.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebExternalAnchorsUseRelNoopenerJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/external-anchors-use-rel-noopener.js | failureTitle")]
        public List<string> LighthouseCoreAuditsDobetterwebExternalAnchorsUseRelNoopenerJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/geolocation-on-start.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebGeolocationOnStartJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/geolocation-on-start.js | title")]
        public List<string> LighthouseCoreAuditsDobetterwebGeolocationOnStartJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/js-libraries.js | columnName")]
        public List<string> LighthouseCoreAuditsDobetterwebJsLibrariesJsColumnName { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/js-libraries.js | columnVersion")]
        public List<string> LighthouseCoreAuditsDobetterwebJsLibrariesJsColumnVersion { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/js-libraries.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebJsLibrariesJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/js-libraries.js | title")]
        public List<string> LighthouseCoreAuditsDobetterwebJsLibrariesJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/no-document-write.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebNoDocumentWriteJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/no-document-write.js | failureTitle")]
        public List<string> LighthouseCoreAuditsDobetterwebNoDocumentWriteJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/notification-on-start.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebNotificationOnStartJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/notification-on-start.js | title")]
        public List<string> LighthouseCoreAuditsDobetterwebNotificationOnStartJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/no-vulnerable-libraries.js | columnSeverity")]
        public List<string> LighthouseCoreAuditsDobetterwebNoVulnerableLibrariesJsColumnSeverity { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/no-vulnerable-libraries.js | columnVersion")]
        public List<string> LighthouseCoreAuditsDobetterwebNoVulnerableLibrariesJsColumnVersion { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/no-vulnerable-libraries.js | columnVuln")]
        public List<string> LighthouseCoreAuditsDobetterwebNoVulnerableLibrariesJsColumnVuln { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/no-vulnerable-libraries.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebNoVulnerableLibrariesJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/no-vulnerable-libraries.js | displayValue")]
        public List<LighthouseCoreAuditsJsDisplayValue> LighthouseCoreAuditsDobetterwebNoVulnerableLibrariesJsDisplayValue { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/no-vulnerable-libraries.js | failureTitle")]
        public List<string> LighthouseCoreAuditsDobetterwebNoVulnerableLibrariesJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/no-vulnerable-libraries.js | rowSeverityMedium")]
        public List<string> LighthouseCoreAuditsDobetterwebNoVulnerableLibrariesJsRowSeverityMedium { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/password-inputs-can-be-pasted-into.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebPasswordInputsCanBePastedIntoJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/password-inputs-can-be-pasted-into.js | title")]
        public List<string> LighthouseCoreAuditsDobetterwebPasswordInputsCanBePastedIntoJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/uses-http2.js | columnProtocol")]
        public List<string> LighthouseCoreAuditsDobetterwebUsesHttp2JsColumnProtocol { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/uses-http2.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebUsesHttp2JsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/uses-http2.js | displayValue")]
        public List<LighthouseCoreAuditsJsDisplayValue> LighthouseCoreAuditsDobetterwebUsesHttp2JsDisplayValue
        {
            get;
            set;
        }

        [JsonProperty("lighthouse-core/audits/dobetterweb/uses-http2.js | failureTitle")]
        public List<string> LighthouseCoreAuditsDobetterwebUsesHttp2JsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/uses-passive-event-listeners.js | description")]
        public List<string> LighthouseCoreAuditsDobetterwebUsesPassiveEventListenersJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/dobetterweb/uses-passive-event-listeners.js | failureTitle")]
        public List<string> LighthouseCoreAuditsDobetterwebUsesPassiveEventListenersJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/errors-in-console.js | description")]
        public List<string> LighthouseCoreAuditsErrorsInConsoleJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/errors-in-console.js | title")]
        public List<string> LighthouseCoreAuditsErrorsInConsoleJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/font-display.js | description")]
        public List<string> LighthouseCoreAuditsFontDisplayJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/font-display.js | title")]
        public List<string> LighthouseCoreAuditsFontDisplayJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/image-aspect-ratio.js | description")]
        public List<string> LighthouseCoreAuditsImageAspectRatioJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/image-aspect-ratio.js | title")]
        public List<string> LighthouseCoreAuditsImageAspectRatioJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/is-on-https.js | columnInsecureURL")]
        public List<string> LighthouseCoreAuditsIsOnHttpsJsColumnInsecureUrl { get; set; }

        [JsonProperty("lighthouse-core/audits/is-on-https.js | description")]
        public List<string> LighthouseCoreAuditsIsOnHttpsJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/is-on-https.js | displayValue")]
        public List<LighthouseCoreAuditsJsDisplayValue> LighthouseCoreAuditsIsOnHttpsJsDisplayValue { get; set; }

        [JsonProperty("lighthouse-core/audits/is-on-https.js | failureTitle")]
        public List<string> LighthouseCoreAuditsIsOnHttpsJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/load-fast-enough-for-pwa.js | description")]
        public List<string> LighthouseCoreAuditsLoadFastEnoughForPwaJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/load-fast-enough-for-pwa.js | displayValueText")]
        public List<LighthouseCore> LighthouseCoreAuditsLoadFastEnoughForPwaJsDisplayValueText { get; set; }

        [JsonProperty("lighthouse-core/audits/load-fast-enough-for-pwa.js | failureTitle")]
        public List<string> LighthouseCoreAuditsLoadFastEnoughForPwaJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/mainthread-work-breakdown.js | columnCategory")]
        public List<string> LighthouseCoreAuditsMainthreadWorkBreakdownJsColumnCategory { get; set; }

        [JsonProperty("lighthouse-core/audits/mainthread-work-breakdown.js | description")]
        public List<string> LighthouseCoreAuditsMainthreadWorkBreakdownJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/mainthread-work-breakdown.js | failureTitle")]
        public List<string> LighthouseCoreAuditsMainthreadWorkBreakdownJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/estimated-input-latency.js | description")]
        public List<string> LighthouseCoreAuditsMetricsEstimatedInputLatencyJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/estimated-input-latency.js | title")]
        public List<string> LighthouseCoreAuditsMetricsEstimatedInputLatencyJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/first-contentful-paint.js | description")]
        public List<string> LighthouseCoreAuditsMetricsFirstContentfulPaintJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/first-contentful-paint.js | title")]
        public List<string> LighthouseCoreAuditsMetricsFirstContentfulPaintJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/first-cpu-idle.js | description")]
        public List<string> LighthouseCoreAuditsMetricsFirstCpuIdleJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/first-cpu-idle.js | title")]
        public List<string> LighthouseCoreAuditsMetricsFirstCpuIdleJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/first-meaningful-paint.js | description")]
        public List<string> LighthouseCoreAuditsMetricsFirstMeaningfulPaintJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/first-meaningful-paint.js | title")]
        public List<string> LighthouseCoreAuditsMetricsFirstMeaningfulPaintJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/interactive.js | description")]
        public List<string> LighthouseCoreAuditsMetricsInteractiveJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/interactive.js | title")]
        public List<string> LighthouseCoreAuditsMetricsInteractiveJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/max-potential-fid.js | description")]
        public List<string> LighthouseCoreAuditsMetricsMaxPotentialFidJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/max-potential-fid.js | title")]
        public List<string> LighthouseCoreAuditsMetricsMaxPotentialFidJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/speed-index.js | description")]
        public List<string> LighthouseCoreAuditsMetricsSpeedIndexJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/speed-index.js | title")]
        public List<string> LighthouseCoreAuditsMetricsSpeedIndexJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/total-blocking-time.js | description")]
        public List<string> LighthouseCoreAuditsMetricsTotalBlockingTimeJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/metrics/total-blocking-time.js | title")]
        public List<string> LighthouseCoreAuditsMetricsTotalBlockingTimeJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/network-rtt.js | description")]
        public List<string> LighthouseCoreAuditsNetworkRttJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/network-rtt.js | title")]
        public List<string> LighthouseCoreAuditsNetworkRttJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/network-server-latency.js | description")]
        public List<string> LighthouseCoreAuditsNetworkServerLatencyJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/network-server-latency.js | title")]
        public List<string> LighthouseCoreAuditsNetworkServerLatencyJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/performance-budget.js | description")]
        public List<string> LighthouseCoreAuditsPerformanceBudgetJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/performance-budget.js | title")]
        public List<string> LighthouseCoreAuditsPerformanceBudgetJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/redirects.js | description")]
        public List<string> LighthouseCoreAuditsRedirectsJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/redirects.js | title")]
        public List<string> LighthouseCoreAuditsRedirectsJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/resource-summary.js | description")]
        public List<string> LighthouseCoreAuditsResourceSummaryJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/resource-summary.js | displayValue")]
        public List<LighthouseCoreAuditsResourceSummaryJsDisplayValue> LighthouseCoreAuditsResourceSummaryJsDisplayValue
        {
            get;
            set;
        }

        [JsonProperty("lighthouse-core/audits/resource-summary.js | title")]
        public List<string> LighthouseCoreAuditsResourceSummaryJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/canonical.js | description")]
        public List<string> LighthouseCoreAuditsSeoCanonicalJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/canonical.js | title")]
        public List<string> LighthouseCoreAuditsSeoCanonicalJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/font-size.js | description")]
        public List<string> LighthouseCoreAuditsSeoFontSizeJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/font-size.js | displayValue")]
        public List<LighthouseCoreAuditsSeoJsDisplayValue> LighthouseCoreAuditsSeoFontSizeJsDisplayValue { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/font-size.js | title")]
        public List<string> LighthouseCoreAuditsSeoFontSizeJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/hreflang.js | description")]
        public List<string> LighthouseCoreAuditsSeoHreflangJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/hreflang.js | title")]
        public List<string> LighthouseCoreAuditsSeoHreflangJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/http-status-code.js | description")]
        public List<string> LighthouseCoreAuditsSeoHttpStatusCodeJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/http-status-code.js | title")]
        public List<string> LighthouseCoreAuditsSeoHttpStatusCodeJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/is-crawlable.js | description")]
        public List<string> LighthouseCoreAuditsSeoIsCrawlableJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/is-crawlable.js | title")]
        public List<string> LighthouseCoreAuditsSeoIsCrawlableJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/link-text.js | description")]
        public List<string> LighthouseCoreAuditsSeoLinkTextJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/link-text.js | title")]
        public List<string> LighthouseCoreAuditsSeoLinkTextJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/manual/structured-data.js | description")]
        public List<string> LighthouseCoreAuditsSeoManualStructuredDataJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/manual/structured-data.js | title")]
        public List<string> LighthouseCoreAuditsSeoManualStructuredDataJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/meta-description.js | description")]
        public List<string> LighthouseCoreAuditsSeoMetaDescriptionJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/meta-description.js | title")]
        public List<string> LighthouseCoreAuditsSeoMetaDescriptionJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/plugins.js | description")]
        public List<string> LighthouseCoreAuditsSeoPluginsJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/plugins.js | title")]
        public List<string> LighthouseCoreAuditsSeoPluginsJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/robots-txt.js | description")]
        public List<string> LighthouseCoreAuditsSeoRobotsTxtJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/robots-txt.js | title")]
        public List<string> LighthouseCoreAuditsSeoRobotsTxtJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/tap-targets.js | description")]
        public List<string> LighthouseCoreAuditsSeoTapTargetsJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/tap-targets.js | displayValue")]
        public List<LighthouseCoreAuditsSeoJsDisplayValue> LighthouseCoreAuditsSeoTapTargetsJsDisplayValue { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/tap-targets.js | failureTitle")]
        public List<string> LighthouseCoreAuditsSeoTapTargetsJsFailureTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/tap-targets.js | overlappingTargetHeader")]
        public List<string> LighthouseCoreAuditsSeoTapTargetsJsOverlappingTargetHeader { get; set; }

        [JsonProperty("lighthouse-core/audits/seo/tap-targets.js | tapTargetHeader")]
        public List<string> LighthouseCoreAuditsSeoTapTargetsJsTapTargetHeader { get; set; }

        [JsonProperty("lighthouse-core/audits/third-party-summary.js | columnMainThreadTime")]
        public List<string> LighthouseCoreAuditsThirdPartySummaryJsColumnMainThreadTime { get; set; }

        [JsonProperty("lighthouse-core/audits/third-party-summary.js | columnThirdParty")]
        public List<string> LighthouseCoreAuditsThirdPartySummaryJsColumnThirdParty { get; set; }

        [JsonProperty("lighthouse-core/audits/third-party-summary.js | description")]
        public List<string> LighthouseCoreAuditsThirdPartySummaryJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/third-party-summary.js | displayValue")]
        public List<LighthouseCoreAuditsJsDisplayValue> LighthouseCoreAuditsThirdPartySummaryJsDisplayValue
        {
            get;
            set;
        }

        [JsonProperty("lighthouse-core/audits/third-party-summary.js | title")]
        public List<string> LighthouseCoreAuditsThirdPartySummaryJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/time-to-first-byte.js | description")]
        public List<string> LighthouseCoreAuditsTimeToFirstByteJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/time-to-first-byte.js | displayValue")]
        public List<LighthouseCore> LighthouseCoreAuditsTimeToFirstByteJsDisplayValue { get; set; }

        [JsonProperty("lighthouse-core/audits/time-to-first-byte.js | title")]
        public List<string> LighthouseCoreAuditsTimeToFirstByteJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/user-timings.js | columnDuration")]
        public List<string> LighthouseCoreAuditsUserTimingsJsColumnDuration { get; set; }

        [JsonProperty("lighthouse-core/audits/user-timings.js | columnName")]
        public List<string> LighthouseCoreAuditsUserTimingsJsColumnName { get; set; }

        [JsonProperty("lighthouse-core/audits/user-timings.js | columnStartTime")]
        public List<string> LighthouseCoreAuditsUserTimingsJsColumnStartTime { get; set; }

        [JsonProperty("lighthouse-core/audits/user-timings.js | columnType")]
        public List<string> LighthouseCoreAuditsUserTimingsJsColumnType { get; set; }

        [JsonProperty("lighthouse-core/audits/user-timings.js | description")]
        public List<string> LighthouseCoreAuditsUserTimingsJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/user-timings.js | displayValue")]
        public List<LighthouseCoreAuditsJsDisplayValue> LighthouseCoreAuditsUserTimingsJsDisplayValue { get; set; }

        [JsonProperty("lighthouse-core/audits/user-timings.js | title")]
        public List<string> LighthouseCoreAuditsUserTimingsJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/uses-rel-preconnect.js | crossoriginWarning")]
        public List<LighthouseCoreAuditsUsesRelPreconnectJsCrossoriginWarning> LighthouseCoreAuditsUsesRelPreconnectJsCrossoriginWarning { get; set; }

        [JsonProperty("lighthouse-core/audits/uses-rel-preconnect.js | description")]
        public List<string> LighthouseCoreAuditsUsesRelPreconnectJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/uses-rel-preconnect.js | title")]
        public List<string> LighthouseCoreAuditsUsesRelPreconnectJsTitle { get; set; }

        [JsonProperty("lighthouse-core/audits/uses-rel-preload.js | description")]
        public List<string> LighthouseCoreAuditsUsesRelPreloadJsDescription { get; set; }

        [JsonProperty("lighthouse-core/audits/uses-rel-preload.js | title")]
        public List<string> LighthouseCoreAuditsUsesRelPreloadJsTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yAriaGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YAriaGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yAriaGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YAriaGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yAudioVideoGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YAudioVideoGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yAudioVideoGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YAudioVideoGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yBestPracticesGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YBestPracticesGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yBestPracticesGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YBestPracticesGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yCategoryDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YCategoryDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yCategoryManualDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YCategoryManualDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yCategoryTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YCategoryTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yColorContrastGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YColorContrastGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yColorContrastGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YColorContrastGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yLanguageGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YLanguageGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yLanguageGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YLanguageGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yNamesLabelsGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YNamesLabelsGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yNamesLabelsGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YNamesLabelsGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yNavigationGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YNavigationGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yNavigationGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YNavigationGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yTablesListsVideoGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YTablesListsVideoGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | a11yTablesListsVideoGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsA11YTablesListsVideoGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | bestPracticesCategoryTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsBestPracticesCategoryTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | budgetsGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsBudgetsGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | budgetsGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsBudgetsGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | diagnosticsGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsDiagnosticsGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | diagnosticsGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsDiagnosticsGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | loadOpportunitiesGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsLoadOpportunitiesGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | loadOpportunitiesGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsLoadOpportunitiesGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | metricGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsMetricGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | performanceCategoryTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsPerformanceCategoryTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | pwaFastReliableGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsPwaFastReliableGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | pwaInstallableGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsPwaInstallableGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | pwaOptimizedGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsPwaOptimizedGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | seoCategoryDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsSeoCategoryDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | seoCategoryManualDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsSeoCategoryManualDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | seoCategoryTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsSeoCategoryTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | seoContentGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsSeoContentGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | seoContentGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsSeoContentGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | seoCrawlingGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsSeoCrawlingGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | seoCrawlingGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsSeoCrawlingGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | seoMobileGroupDescription")]
        public List<string> LighthouseCoreConfigDefaultConfigJsSeoMobileGroupDescription { get; set; }

        [JsonProperty("lighthouse-core/config/default-config.js | seoMobileGroupTitle")]
        public List<string> LighthouseCoreConfigDefaultConfigJsSeoMobileGroupTitle { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | columnCacheTTL")]
        public List<string> LighthouseCoreLibI18NI18NJsColumnCacheTtl { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | columnLocation")]
        public List<string> LighthouseCoreLibI18NI18NJsColumnLocation { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | columnRequests")]
        public List<string> LighthouseCoreLibI18NI18NJsColumnRequests { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | columnResourceType")]
        public List<string> LighthouseCoreLibI18NI18NJsColumnResourceType { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | columnSize")]
        public List<string> LighthouseCoreLibI18NI18NJsColumnSize { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | columnTimeSpent")]
        public List<string> LighthouseCoreLibI18NI18NJsColumnTimeSpent { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | columnTransferSize")]
        public List<string> LighthouseCoreLibI18NI18NJsColumnTransferSize { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | columnURL")]
        public List<string> LighthouseCoreLibI18NI18NJsColumnUrl { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | columnWastedBytes")]
        public List<string> LighthouseCoreLibI18NI18NJsColumnWastedBytes { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | displayValueByteSavings")]
        public List<LighthouseCoreLibI18NI18NJsDisplayValueByteSaving> LighthouseCoreLibI18NI18NJsDisplayValueByteSavings { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | displayValueMsSavings")]
        public List<LighthouseCoreLibI18NI18NJsDisplayValueMsSaving> LighthouseCoreLibI18NI18NJsDisplayValueMsSavings
        {
            get;
            set;
        }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | documentResourceType")]
        public List<string> LighthouseCoreLibI18NI18NJsDocumentResourceType { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | fontResourceType")]
        public List<string> LighthouseCoreLibI18NI18NJsFontResourceType { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | imageResourceType")]
        public List<string> LighthouseCoreLibI18NI18NJsImageResourceType { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | mediaResourceType")]
        public List<string> LighthouseCoreLibI18NI18NJsMediaResourceType { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | ms")]
        public List<LighthouseCore> LighthouseCoreLibI18NI18NJsMs { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | otherResourceType")]
        public List<string> LighthouseCoreLibI18NI18NJsOtherResourceType { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | scriptResourceType")]
        public List<string> LighthouseCoreLibI18NI18NJsScriptResourceType { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | seconds")]
        public List<LighthouseCore> LighthouseCoreLibI18NI18NJsSeconds { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | stylesheetResourceType")]
        public List<string> LighthouseCoreLibI18NI18NJsStylesheetResourceType { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | thirdPartyResourceType")]
        public List<string> LighthouseCoreLibI18NI18NJsThirdPartyResourceType { get; set; }

        [JsonProperty("lighthouse-core/lib/i18n/i18n.js | totalResourceType")]
        public List<string> LighthouseCoreLibI18NI18NJsTotalResourceType { get; set; }
    }

    public class LighthouseCoreAuditsByteEfficiencyTotalByteWeightJsDisplayValue
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("values")]
        public LighthouseCoreAuditsByteEfficiencyTotalByteWeightJsDisplayValueValues Values { get; set; }
    }

    public class LighthouseCoreAuditsByteEfficiencyTotalByteWeightJsDisplayValueValues
    {
        [JsonProperty("totalBytes")]
        public long TotalBytes { get; set; }
    }

    public class LighthouseCoreAuditsJsDisplayValue
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("values")]
        public LighthouseCoreAuditsByteEfficiencyUsesLongCacheTtlJsDisplayValueValues Values { get; set; }
    }

    public class LighthouseCoreAuditsByteEfficiencyUsesLongCacheTtlJsDisplayValueValues
    {
        [JsonProperty("itemCount")]
        public long ItemCount { get; set; }
    }

    public class LighthouseCore
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("values")]
        public LighthouseCoreAuditsLoadFastEnoughForPwaJsDisplayValueTextValues Values { get; set; }
    }

    public class LighthouseCoreAuditsLoadFastEnoughForPwaJsDisplayValueTextValues
    {
        [JsonProperty("timeInMs")]
        public double TimeInMs { get; set; }
    }

    public class LighthouseCoreAuditsResourceSummaryJsDisplayValue
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("values")]
        public LighthouseCoreAuditsResourceSummaryJsDisplayValueValues Values { get; set; }
    }

    public class LighthouseCoreAuditsResourceSummaryJsDisplayValueValues
    {
        [JsonProperty("byteCount")]
        public long ByteCount { get; set; }

        [JsonProperty("requestCount")]
        public long RequestCount { get; set; }
    }

    public class LighthouseCoreAuditsSeoJsDisplayValue
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("values")]
        public LighthouseCoreAuditsSeoFontSizeJsDisplayValueValues Values { get; set; }
    }

    public class LighthouseCoreAuditsSeoFontSizeJsDisplayValueValues
    {
        [JsonProperty("decimalProportion")]
        public double DecimalProportion { get; set; }
    }

    public class LighthouseCoreAuditsUsesRelPreconnectJsCrossoriginWarning
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("values")]
        public LighthouseCoreAuditsUsesRelPreconnectJsCrossoriginWarningValues Values { get; set; }
    }

    public class LighthouseCoreAuditsUsesRelPreconnectJsCrossoriginWarningValues
    {
        [JsonProperty("securityOrigin")]
        public Uri SecurityOrigin { get; set; }
    }

    public class LighthouseCoreLibI18NI18NJsDisplayValueByteSaving
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("values")]
        public LighthouseCoreLibI18NI18NJsDisplayValueByteSavingValues Values { get; set; }
    }

    public class LighthouseCoreLibI18NI18NJsDisplayValueByteSavingValues
    {
        [JsonProperty("wastedBytes")]
        public double WastedBytes { get; set; }
    }

    public class LighthouseCoreLibI18NI18NJsDisplayValueMsSaving
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("values")]
        public LighthouseCoreLibI18NI18NJsDisplayValueMsSavingValues Values { get; set; }
    }

    public class LighthouseCoreLibI18NI18NJsDisplayValueMsSavingValues
    {
        [JsonProperty("wastedMs")]
        public double WastedMs { get; set; }
    }

    public class RendererFormattedStrings
    {
        [JsonProperty("auditGroupExpandTooltip")]
        public string AuditGroupExpandTooltip { get; set; }

        [JsonProperty("crcInitialNavigation")]
        public string CrcInitialNavigation { get; set; }

        [JsonProperty("crcLongestDurationLabel")]
        public string CrcLongestDurationLabel { get; set; }

        [JsonProperty("errorLabel")]
        public string ErrorLabel { get; set; }

        [JsonProperty("errorMissingAuditInfo")]
        public string ErrorMissingAuditInfo { get; set; }

        [JsonProperty("labDataTitle")]
        public string LabDataTitle { get; set; }

        [JsonProperty("lsPerformanceCategoryDescription")]
        public string LsPerformanceCategoryDescription { get; set; }

        [JsonProperty("manualAuditsGroupTitle")]
        public string ManualAuditsGroupTitle { get; set; }

        [JsonProperty("notApplicableAuditsGroupTitle")]
        public string NotApplicableAuditsGroupTitle { get; set; }

        [JsonProperty("opportunityResourceColumnLabel")]
        public string OpportunityResourceColumnLabel { get; set; }

        [JsonProperty("opportunitySavingsColumnLabel")]
        public string OpportunitySavingsColumnLabel { get; set; }

        [JsonProperty("passedAuditsGroupTitle")]
        public string PassedAuditsGroupTitle { get; set; }

        [JsonProperty("snippetCollapseButtonLabel")]
        public string SnippetCollapseButtonLabel { get; set; }

        [JsonProperty("snippetExpandButtonLabel")]
        public string SnippetExpandButtonLabel { get; set; }

        [JsonProperty("thirdPartyResourcesLabel")]
        public string ThirdPartyResourcesLabel { get; set; }

        [JsonProperty("toplevelWarningsMessage")]
        public string ToplevelWarningsMessage { get; set; }

        [JsonProperty("varianceDisclaimer")]
        public string VarianceDisclaimer { get; set; }

        [JsonProperty("warningAuditsGroupTitle")]
        public string WarningAuditsGroupTitle { get; set; }

        [JsonProperty("warningHeader")]
        public string WarningHeader { get; set; }
    }

    public class Timing
    {
        [JsonProperty("entries")]
        public List<Entry> Entries { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class Entry
    {
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public double? Duration { get; set; }

        [JsonProperty("entryType", NullValueHandling = NullValueHandling.Ignore)]
        public EntryType? EntryType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startTime")]
        public double StartTime { get; set; }

        [JsonProperty("timingType", NullValueHandling = NullValueHandling.Ignore)]
        public TimingType? TimingType { get; set; }
    }

    public enum DebugDataType
    {
        Criticalrequestchain,

        Debugdata,

        Filmstrip,

        Opportunity,

        Screenshot,

        Table
    }

    public enum ItemTypeEnum
    {
        Bytes,

        Code,

        Link,

        Ms,

        Node,

        Numeric,

        Text,

        Url
    }

    public enum Label
    {
        Empty,

        PotentialSavings,

        Size,

        Url
    }

    public enum ValueType
    {
        Bytes,

        Thumbnail,

        TimespanMs,

        Url
    }

    public enum TimingType
    {
        Mark,

        Measure
    }

    public enum ScoreDisplayMode
    {
        Binary,

        Informative,

        Manual,

        NotApplicable,

        Numeric
    }

    public enum EntryType
    {
        Measure
    }

    public struct ElementUnion
    {
        public ElementClass ElementClass;

        public string String;

        public static implicit operator ElementUnion(ElementClass ElementClass)
        {
            return new ElementUnion { ElementClass = ElementClass };
        }

        public static implicit operator ElementUnion(string String)
        {
            return new ElementUnion { String = String };
        }
    }

    public struct Size
    {
        public long? Integer;

        public string String;

        public static implicit operator Size(long Integer)
        {
            return new Size { Integer = Integer };
        }

        public static implicit operator Size(string String)
        {
            return new Size { String = String };
        }
    }

    public partial class InputModelRoot
    {
        public static InputModelRoot FromJson(string json)
        {
            return JsonConvert.DeserializeObject<InputModelRoot>(json, Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this InputModelRoot self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
                                                                     {
                                                                         MetadataPropertyHandling =
                                                                             MetadataPropertyHandling.Ignore,
                                                                         DateParseHandling = DateParseHandling.None,
                                                                         Converters =
                                                                             {
                                                                                 DebugDataTypeConverter.Singleton,
                                                                                 ItemTypeEnumConverter.Singleton,
                                                                                 LabelConverter.Singleton,
                                                                                 ValueTypeConverter.Singleton,
                                                                                 ElementUnionConverter.Singleton,
                                                                                 SizeConverter.Singleton,
                                                                                 TimingTypeConverter.Singleton,
                                                                                 ScoreDisplayModeConverter.Singleton,
                                                                                 EntryTypeConverter.Singleton,
                                                                                 new IsoDateTimeConverter
                                                                                     {
                                                                                         DateTimeStyles =
                                                                                             DateTimeStyles
                                                                                                 .AssumeUniversal
                                                                                     }
                                                                             }
                                                                     };
    }

    internal class DebugDataTypeConverter : JsonConverter
    {
        public static readonly DebugDataTypeConverter Singleton = new DebugDataTypeConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(DebugDataType) || t == typeof(DebugDataType?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "criticalrequestchain":
                    return DebugDataType.Criticalrequestchain;
                case "debugdata":
                    return DebugDataType.Debugdata;
                case "filmstrip":
                    return DebugDataType.Filmstrip;
                case "opportunity":
                    return DebugDataType.Opportunity;
                case "screenshot":
                    return DebugDataType.Screenshot;
                case "table":
                    return DebugDataType.Table;
            }

            throw new Exception("Cannot unmarshal type DebugDataType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (DebugDataType)untypedValue;
            switch (value)
            {
                case DebugDataType.Criticalrequestchain:
                    serializer.Serialize(writer, "criticalrequestchain");
                    return;
                case DebugDataType.Debugdata:
                    serializer.Serialize(writer, "debugdata");
                    return;
                case DebugDataType.Filmstrip:
                    serializer.Serialize(writer, "filmstrip");
                    return;
                case DebugDataType.Opportunity:
                    serializer.Serialize(writer, "opportunity");
                    return;
                case DebugDataType.Screenshot:
                    serializer.Serialize(writer, "screenshot");
                    return;
                case DebugDataType.Table:
                    serializer.Serialize(writer, "table");
                    return;
            }

            throw new Exception("Cannot marshal type DebugDataType");
        }
    }

    internal class ItemTypeEnumConverter : JsonConverter
    {
        public static readonly ItemTypeEnumConverter Singleton = new ItemTypeEnumConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(ItemTypeEnum) || t == typeof(ItemTypeEnum?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bytes":
                    return ItemTypeEnum.Bytes;
                case "code":
                    return ItemTypeEnum.Code;
                case "link":
                    return ItemTypeEnum.Link;
                case "ms":
                    return ItemTypeEnum.Ms;
                case "node":
                    return ItemTypeEnum.Node;
                case "numeric":
                    return ItemTypeEnum.Numeric;
                case "text":
                    return ItemTypeEnum.Text;
                case "url":
                    return ItemTypeEnum.Url;
            }

            throw new Exception("Cannot unmarshal type ItemTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ItemTypeEnum)untypedValue;
            switch (value)
            {
                case ItemTypeEnum.Bytes:
                    serializer.Serialize(writer, "bytes");
                    return;
                case ItemTypeEnum.Code:
                    serializer.Serialize(writer, "code");
                    return;
                case ItemTypeEnum.Link:
                    serializer.Serialize(writer, "link");
                    return;
                case ItemTypeEnum.Ms:
                    serializer.Serialize(writer, "ms");
                    return;
                case ItemTypeEnum.Node:
                    serializer.Serialize(writer, "node");
                    return;
                case ItemTypeEnum.Numeric:
                    serializer.Serialize(writer, "numeric");
                    return;
                case ItemTypeEnum.Text:
                    serializer.Serialize(writer, "text");
                    return;
                case ItemTypeEnum.Url:
                    serializer.Serialize(writer, "url");
                    return;
            }

            throw new Exception("Cannot marshal type ItemTypeEnum");
        }
    }

    internal class LabelConverter : JsonConverter
    {
        public static readonly LabelConverter Singleton = new LabelConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(Label) || t == typeof(Label?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Label.Empty;
                case "Potential Savings":
                    return Label.PotentialSavings;
                case "Size":
                    return Label.Size;
                case "URL":
                    return Label.Url;
            }

            throw new Exception("Cannot unmarshal type Label");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (Label)untypedValue;
            switch (value)
            {
                case Label.Empty:
                    serializer.Serialize(writer, string.Empty);
                    return;
                case Label.PotentialSavings:
                    serializer.Serialize(writer, "Potential Savings");
                    return;
                case Label.Size:
                    serializer.Serialize(writer, "Size");
                    return;
                case Label.Url:
                    serializer.Serialize(writer, "URL");
                    return;
            }

            throw new Exception("Cannot marshal type Label");
        }
    }

    internal class ValueTypeConverter : JsonConverter
    {
        public static readonly ValueTypeConverter Singleton = new ValueTypeConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(ValueType) || t == typeof(ValueType?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bytes":
                    return ValueType.Bytes;
                case "thumbnail":
                    return ValueType.Thumbnail;
                case "timespanMs":
                    return ValueType.TimespanMs;
                case "url":
                    return ValueType.Url;
            }

            throw new Exception("Cannot unmarshal type ValueType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ValueType)untypedValue;
            switch (value)
            {
                case ValueType.Bytes:
                    serializer.Serialize(writer, "bytes");
                    return;
                case ValueType.Thumbnail:
                    serializer.Serialize(writer, "thumbnail");
                    return;
                case ValueType.TimespanMs:
                    serializer.Serialize(writer, "timespanMs");
                    return;
                case ValueType.Url:
                    serializer.Serialize(writer, "url");
                    return;
            }

            throw new Exception("Cannot marshal type ValueType");
        }
    }

    internal class ElementUnionConverter : JsonConverter
    {
        public static readonly ElementUnionConverter Singleton = new ElementUnionConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(ElementUnion) || t == typeof(ElementUnion?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ElementUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ElementClass>(reader);
                    return new ElementUnion { ElementClass = objectValue };
            }

            throw new Exception("Cannot unmarshal type ElementUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ElementUnion)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }

            if (value.ElementClass != null)
            {
                serializer.Serialize(writer, value.ElementClass);
                return;
            }

            throw new Exception("Cannot marshal type ElementUnion");
        }
    }

    internal class SizeConverter : JsonConverter
    {
        public static readonly SizeConverter Singleton = new SizeConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(Size) || t == typeof(Size?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Size { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Size { String = stringValue };
            }

            throw new Exception("Cannot unmarshal type Size");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Size)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }

            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }

            throw new Exception("Cannot marshal type Size");
        }
    }

    internal class TimingTypeConverter : JsonConverter
    {
        public static readonly TimingTypeConverter Singleton = new TimingTypeConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(TimingType) || t == typeof(TimingType?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Mark":
                    return TimingType.Mark;
                case "Measure":
                    return TimingType.Measure;
            }

            throw new Exception("Cannot unmarshal type TimingType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TimingType)untypedValue;
            switch (value)
            {
                case TimingType.Mark:
                    serializer.Serialize(writer, "Mark");
                    return;
                case TimingType.Measure:
                    serializer.Serialize(writer, "Measure");
                    return;
            }

            throw new Exception("Cannot marshal type TimingType");
        }
    }

    internal class ScoreDisplayModeConverter : JsonConverter
    {
        public static readonly ScoreDisplayModeConverter Singleton = new ScoreDisplayModeConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(ScoreDisplayMode) || t == typeof(ScoreDisplayMode?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "binary":
                    return ScoreDisplayMode.Binary;
                case "informative":
                    return ScoreDisplayMode.Informative;
                case "manual":
                    return ScoreDisplayMode.Manual;
                case "notApplicable":
                    return ScoreDisplayMode.NotApplicable;
                case "numeric":
                    return ScoreDisplayMode.Numeric;
            }

            throw new Exception("Cannot unmarshal type ScoreDisplayMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ScoreDisplayMode)untypedValue;
            switch (value)
            {
                case ScoreDisplayMode.Binary:
                    serializer.Serialize(writer, "binary");
                    return;
                case ScoreDisplayMode.Informative:
                    serializer.Serialize(writer, "informative");
                    return;
                case ScoreDisplayMode.Manual:
                    serializer.Serialize(writer, "manual");
                    return;
                case ScoreDisplayMode.NotApplicable:
                    serializer.Serialize(writer, "notApplicable");
                    return;
                case ScoreDisplayMode.Numeric:
                    serializer.Serialize(writer, "numeric");
                    return;
            }

            throw new Exception("Cannot marshal type ScoreDisplayMode");
        }
    }

    internal class EntryTypeConverter : JsonConverter
    {
        public static readonly EntryTypeConverter Singleton = new EntryTypeConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(EntryType) || t == typeof(EntryType?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "measure") return EntryType.Measure;
            throw new Exception("Cannot unmarshal type EntryType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (EntryType)untypedValue;
            if (value == EntryType.Measure)
            {
                serializer.Serialize(writer, "measure");
                return;
            }

            throw new Exception("Cannot marshal type EntryType");
        }
    }
}