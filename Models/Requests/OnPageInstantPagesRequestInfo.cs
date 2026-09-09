using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageInstantPagesRequestInfo 
    {

        /// <summary>
        /// target page urlrequired fieldabsolute URL of the target page;Note #1: results will be returned for the specified URL only;Note #2: to prevent denial-of-service events, tasks that contain a duplicate crawl host will be returned with a 40501 error;to prevent this error from occurring, avoid setting tasks with the same domain if at least one of your previous tasks with this domain (including a page URL on the domain) is still in a crawling queue
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// custom user agentoptional fieldcustom user agent for crawling a websiteexample: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36default value: Mozilla/5.0 (compatible; RSiteAuditor)
        /// </summary>
        [JsonProperty("custom_user_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomUserAgent { get; set; }

        /// <summary>
        /// preset for browser screen parametersoptional fieldif you use this field, you don't need to indicate browser_screen_width, browser_screen_height, browser_screen_scale_factorpossible values:desktop, mobile, tabletdesktop preset will apply the following values:browser_screen_width: 1920browser_screen_height: 1080browser_screen_scale_factor: 1mobile preset will apply the following values:browser_screen_width: 390browser_screen_height: 844browser_screen_scale_factor: 3tablet preset will apply the following values:browser_screen_width: 1024browser_screen_height: 1366browser_screen_scale_factor: 2Note: to use this parameter, set enable_javascript or enable_browser_rendering to true
        /// </summary>
        [JsonProperty("browser_preset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserPreset { get; set; }

        /// <summary>
        /// browser screen widthoptional fieldyou can set a custom browser screen width to perform audit for a particular device;if you use this field, you don't need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value, in pixels: 240maximum value, in pixels: 9999
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen heightoptional fieldyou can set a custom browser screen height to perform audit for a particular device;if you use this field, you don't need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value, in pixels: 240maximum value, in pixels: 9999
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factoroptional fieldyou can set a custom browser screen resolution ratio to perform audit for a particular device;if you use this field, you don't need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value: 0.5maximum value: 3
        /// </summary>
        [JsonProperty("browser_screen_scale_factor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// store HTML of a crawled pageoptional fieldset to true if you want get the HTML of the page using the OnPage Raw HTML endpointdefault value: false
        /// </summary>
        [JsonProperty("store_raw_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreRawHtml { get; set; }

        /// <summary>
        /// language header for accessing the websiteoptional fieldall locale formats are supported (xx, xx-XX, xxx-XX, etc.)Note: if you do not specify this parameter, some websites may deny access; in this case, pages will be returned with the 'type':'broken in the response array
        /// </summary>
        [JsonProperty("accept_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// load resourcesoptional fieldset to true if you want to load image, stylesheets, scripts, and broken resourcesdefault value: falseNote: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [JsonProperty("load_resources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadResources { get; set; }

        /// <summary>
        /// emulate browser rendering to measure Core Web Vitalsoptional fieldby using this parameter you will be able to emulate a browser when loading a web page;enable_browser_rendering loads styles, images, fonts, animations, videos, and other resources on a page;default value: falseset to true to obtain Core Web Vitals (FID, CLS, LCP) metrics in the response;if you use this field, parameters enable_javascript, and load_resources are enabled automatically;Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [JsonProperty("enable_browser_rendering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableBrowserRendering { get; set; }

        /// <summary>
        /// disable the cookie popup optional fieldset to true if you want to disable the popup requesting cookie consent from the user;default value:false
        /// </summary>
        [JsonProperty("disable_cookie_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableCookiePopup { get; set; }

        /// <summary>
        /// return data on pages despite the timeout erroroptional fieldif true, the data will be provided on pages that failed to load within 120 seconds and responded with a timeout error;default value: false
        /// </summary>
        [JsonProperty("return_despite_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnDespiteTimeout { get; set; }

        /// <summary>
        /// load javascript on a pageoptional fieldset to true if you want to load the scripts available on a pagedefault value: falseNote: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [JsonProperty("enable_javascript", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableJavascript { get; set; }

        /// <summary>
        /// enable XMLHttpRequest on a pageoptional fieldset to true if you want our crawler to request data from a web server using the XMLHttpRequest objectdefault value:falseif you use this field, enable_javascript must be set to true;
        /// </summary>
        [JsonProperty("enable_xhr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableXhr { get; set; }

        /// <summary>
        /// custom javascriptoptional fieldNote that the execution time for the script you enter here should be 700 ms maximum;for example, you can use the following JS snippet to check if the website contains Google Tag Manager as a scr attribute:let meta = { haveGoogleAnalytics: false, haveTagManager: false };rnfor (var i = 0; i = 0)rn      meta.haveGoogleAnalytics = true;rntif (src.indexOf('gtm.js') &gt;= 0)rn      meta.haveTagManager = true;rn  }rn}rnmeta;the returned value depends on what you specified in this field. For instance, if you specify the following script:meta = {}; meta.url = document.URL; meta.test = 'test'; meta;as a response you will receive the following data:'custom_js_response': {'url': 'https://dataforseo.com/','test': 'test'}
        /// </summary>
        [JsonProperty("custom_js", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomJs { get; set; }

        /// <summary>
        /// enable microdata validationoptional fieldif set to true, you can use the OnPage API Microdata endpoint with the id of the task;default value: false
        /// </summary>
        [JsonProperty("validate_micromarkup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateMicromarkup { get; set; }

        /// <summary>
        /// check spellingoptional fieldset to true to check spelling on a website using Hunspell librarydefault value: false
        /// </summary>
        [JsonProperty("check_spell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckSpell { get; set; }

        /// <summary>
        /// custom threshold values for checksoptional fieldyou can specify custom threshold values for the parameters included in the checks array of OnPage API responses;Note: only integer threshold values can be modified;
        /// </summary>
        [JsonProperty("checks_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ChecksThreshold { get; set; }

        /// <summary>
        /// switch proxy pooloptional fieldif true, additional proxy pools will be used to obtain the requested data;the parameter can be used if a multitude of tasks is set simultaneously, resulting in occasional rate-limit and/or site_unreachable errors
        /// </summary>
        [JsonProperty("switch_pool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchPool { get; set; }

        /// <summary>
        /// proxy pooloptional fieldyou can choose a location of the proxy pool that will be used to obtain the requested data;the parameter can be used if page content is inaccessible in one of the locations, resulting in occasional site_unreachable errorspossible values: us, de
        /// </summary>
        [JsonProperty("ip_pool_for_scan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IpPoolForScan { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}