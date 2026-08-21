using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageContentParsingLiveRequestInfo 
    {

        /// <summary>
        /// URL of the content to parse
        /// <br/>required field
        /// <br/>URL of the page to parse
        /// <br/>example:
        /// <br/>`https://www.fujielectric.com/`
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// custom user agent
        /// <br/>optional field
        /// <br/>custom user agent for crawling a website
        /// <br/>example: <c>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36</c>
        /// <br/>default value: <c>Mozilla/5.0 (compatible; RSiteAuditor)</c>
        /// </summary>
        [JsonProperty("custom_user_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomUserAgent { get; set; }

        /// <summary>
        /// preset for browser screen parameters
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to indicate <c>browser_screen_width</c>, <c>browser_screen_height</c>, <c>browser_screen_scale_factor</c>
        /// <br/>            possible values:
        /// <br/><c>desktop</c>, <c>mobile</c>, <c>tablet</c>
        /// <br/>            <c>desktop</c> preset will apply the following values:
        /// <br/>            <c>browser_screen_width: 1920</c>
        /// <br/><c>browser_screen_height: 1080</c>
        /// <br/><c>browser_screen_scale_factor: 1</c>
        /// <br/>            <c>mobile</c> preset will apply the following values:
        /// <br/>            <c>browser_screen_width: 390</c>
        /// <br/><c>browser_screen_height: 844</c>
        /// <br/><c>browser_screen_scale_factor: 3</c>
        /// <br/>            <c>tablet</c> preset will apply the following values:
        /// <br/>            <c>browser_screen_width: 1024</c>
        /// <br/><c>browser_screen_height: 1366</c>
        /// <br/><c>browser_screen_scale_factor: 2</c>
        /// <br/>            Note: to use this parameter, set <c>enable_javascript</c> or <c>enable_browser_rendering</c> to <c>true</c>
        /// </summary>
        [JsonProperty("browser_preset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserPreset { get; set; }

        /// <summary>
        /// browser screen width
        /// <br/>optional field
        /// <br/>you can set a custom browser screen width to perform audit for a particular device;
        /// <br/>if you use this field, you don't need to indicate <c>browser_preset</c> as it will be ignored;
        /// <br/>            Note: to use this parameter, set <c>enable_javascript</c> or <c>enable_browser_rendering</c> to <c>true</c>
        /// <br/>            minimum value, in pixels: <c>240</c>
        /// <br/>maximum value, in pixels: <c>9999</c>
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen height
        /// <br/>optional field
        /// <br/>you can set a custom browser screen height to perform audit for a particular device;
        /// <br/>if you use this field, you don't need to indicate <c>browser_preset</c> as it will be ignored;
        /// <br/>            Note: to use this parameter, set <c>enable_javascript</c> or <c>enable_browser_rendering</c> to <c>true</c>
        /// <br/>            minimum value, in pixels: <c>240</c>
        /// <br/>maximum value, in pixels: <c>9999</c>
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factor
        /// <br/>optional field
        /// <br/>you can set a custom browser screen resolution ratio to perform audit for a particular device;
        /// <br/>if you use this field, you don't need to indicate <c>browser_preset</c> as it will be ignored;
        /// <br/>            Note: to use this parameter, set <c>enable_javascript</c> or <c>enable_browser_rendering</c> to <c>true</c>
        /// <br/>            minimum value: <c>0.5</c>
        /// <br/>maximum value: <c>3</c>
        /// </summary>
        [JsonProperty("browser_screen_scale_factor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// store HTML of a crawled page
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to get the HTML of the page using the <see href="/v3/on_page/raw_html/">OnPage Raw HTML endpoint</see>
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("store_raw_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreRawHtml { get; set; }

        /// <summary>
        /// disable the cookie popup 
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to disable the popup requesting cookie consent from the user;
        /// <br/>default value:
        /// <br/><c>false</c>
        /// </summary>
        [JsonProperty("disable_cookie_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableCookiePopup { get; set; }

        /// <summary>
        /// language header for accessing the website
        /// <br/>optional field
        /// <br/>all locale formats are supported (xx, xx-XX, xxx-XX, etc.)
        /// <br/>Note: if you do not specify this parameter, some websites may deny access; in this case, pages will be returned with the <c>'type':'broken</c> in the response array
        /// </summary>
        [JsonProperty("accept_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// load javascript on a page
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to load the scripts available on a page
        /// <br/>default value: <c>false</c>
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter <see href="https://dataforseo.com/help-center/cost-of-onpage-api-parameters">in our help article</see>; the cost can be calculated on the <see href="https://dataforseo.com/pricing/on-page/onpage-api">Pricing Page</see>
        /// </summary>
        [JsonProperty("enable_javascript", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableJavascript { get; set; }

        /// <summary>
        /// emulate browser rendering to measure Core Web Vitals
        /// <br/>optional field
        /// <br/>by using this parameter you will be able to emulate a browser when loading a web page;
        /// <br/><c>enable_browser_rendering</c> loads styles, images, fonts, animations, videos, and other resources on a page;
        /// <br/>default value: <c>false</c>
        /// <br/>set to <c>true</c> to obtain Core Web Vitals (FID, CLS, LCP) metrics in the response;
        /// <br/>if you use this field, <c>enable_javascript</c>, and <c>load_resources</c> parameters must be set to <c>true</c>
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter <see href="https://dataforseo.com/help-center/cost-of-onpage-api-parameters">in our help article</see>; the cost can be calculated on the <see href="https://dataforseo.com/pricing/on-page/onpage-api">Pricing Page</see>
        /// </summary>
        [JsonProperty("enable_browser_rendering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableBrowserRendering { get; set; }

        /// <summary>
        /// enable XMLHttpRequest on a page
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want our crawler to request data from a web server using the XMLHttpRequest object
        /// <br/>default value:
        /// <br/><c>false</c>
        /// <br/>            if you use this field, <c>enable_javascript</c> must be set to <c>true</c>;
        /// </summary>
        [JsonProperty("enable_xhr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableXhr { get; set; }

        /// <summary>
        /// switch proxy pool
        /// <br/>optional field
        /// <br/>if <c>true</c>, additional proxy pools will be used to obtain the requested data;
        /// <br/>the parameter can be used if a multitude of tasks is set simultaneously, resulting in occasional <c>rate-limit</c> and/or <c>site_unreachable</c> errors
        /// </summary>
        [JsonProperty("switch_pool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchPool { get; set; }

        /// <summary>
        /// proxy pool
        /// <br/>optional field
        /// <br/>you can choose a location of the proxy pool that will be used to obtain the requested data;
        /// <br/>the parameter can be used if page content is inaccessible in one of the locations, resulting in occasional <c>site_unreachable</c> errors
        /// <br/>possible values: <c>us</c>, <c>de</c>
        /// </summary>
        [JsonProperty("ip_pool_for_scan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IpPoolForScan { get; set; }

        /// <summary>
        /// return page content as markdown
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, the markdown-formatted content of the page will be returned in the <c>page_as_markdown</c> field of the response;
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("markdown_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MarkdownView { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}