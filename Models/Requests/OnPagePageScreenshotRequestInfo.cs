using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPagePageScreenshotRequestInfo 
    {

        /// <summary>
        /// page url
        /// <br/>required field
        /// <br/>absolute URL of the page to snap
        /// <br/>note: if the URL you indicate here returns a 404 status code or the indicated value is not a valid URL, you will obtain <c>'error_message':'Screenshot is empty'</c> in the response array
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// language header for accessing the website
        /// <br/>optional field
        /// <br/>all locale formats are supported (xx, xx-XX, xxx-XX, etc.)
        /// <br/>note: if you do not specify this parameter, some websites may deny access; in this case, you will obtain <c>'error_message':'Screenshot is empty'</c> in the response array
        /// </summary>
        [JsonProperty("accept_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

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
        /// <br/>possible values:
        /// <br/><c>desktop</c>, <c>mobile</c>, <c>tablet</c>
        /// <br/><c>desktop</c> preset will apply the following values:
        /// <br/><c>browser_screen_width: 1920</c>
        /// <br/><c>browser_screen_height: 1080</c>
        /// <br/><c>browser_screen_scale_factor: 1</c>
        /// <br/><c>mobile</c> preset will apply the following values:
        /// <br/><c>browser_screen_width: 390</c>
        /// <br/><c>browser_screen_height: 844</c>
        /// <br/><c>browser_screen_scale_factor: 3</c>
        /// <br/><c>tablet</c> preset will apply the following values:
        /// <br/><c>browser_screen_width: 1024</c>
        /// <br/><c>browser_screen_height: 1366</c>
        /// <br/><c>browser_screen_scale_factor: 2</c>
        /// <br/>Note: in this endpoint, the <c>enable_browser_rendering</c>, <c>enable_javascript</c>, <c>load_resources</c>, and <c>enable_xhr</c> parameters are always enabled.
        /// </summary>
        [JsonProperty("browser_preset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserPreset { get; set; }

        /// <summary>
        /// browser screen width
        /// <br/>optional field
        /// <br/>you can set a custom browser screen width to perform audit for a particular device;
        /// <br/>if you use this field, you don't need to indicate <c>browser_preset</c> as it will be ignored;
        /// <br/>minimum value, in pixels: <c>240</c> 
        /// <br/>maximum value, in pixels: <c>9999</c>
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen height
        /// <br/>optional field
        /// <br/>you can set a custom browser screen height to perform audit for a particular device;
        /// <br/>if you use this field, you don't need to indicate <c>browser_preset</c> as it will be ignored;
        /// <br/>minimum value, in pixels: <c>240</c> 
        /// <br/>maximum value, in pixels: <c>9999</c>
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factor
        /// <br/>optional field
        /// <br/>you can set a custom browser screen resolution ratio to perform audit for a particular device;
        /// <br/>if you use this field, you don't need to indicate <c>browser_preset</c> as it will be ignored;
        /// <br/>minimum value: <c>0.5</c> 
        /// <br/>maximum value: <c>3</c>
        /// </summary>
        [JsonProperty("browser_screen_scale_factor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// take a screenshot of the full page
        /// <br/>optional field
        /// <br/>set to <c>false</c> if you want to capture only the part of the page displayed before scrolling
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("full_page_screenshot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FullPageScreenshot { get; set; }

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

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}