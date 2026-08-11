# PageMetaInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>page title</em> |[optional]|
**Charset** | **int?** | <em><a href='https://en.wikipedia.org/wiki/Code_page' target='_blank' rel='noopener noreferrer'>code page</a></em><br>example: <code>65001</code> |[optional]|
**Follow** | **bool?** | <em>indicates whether a page's 'meta robots' allows crawlers to follow the links on the page</em><br>if <code>false</code>, the page's 'meta robots' tag contains 'nofollow' parameter instructing crawlers not to follow the links on the page |[optional]|
**Generator** | **string** | <em>meta tag generator</em> |[optional]|
**Htags** | **IDictionary<string, IEnumerable<string>>** | <em>HTML header tags</em> |[optional]|
**Description** | **string** | <em>content of the meta description tag</em> |[optional]|
**Favicon** | **string** | <em>favicon of the page</em> |[optional]|
**MetaKeywords** | **string** | <em>content of the <code>keywords</code> meta tag</em> |[optional]|
**Canonical** | **string** | <em>canonical page</em> |[optional]|
**InternalLinksCount** | **long?** | <em>number of internal links on the page</em> |[optional]|
**ExternalLinksCount** | **long?** | <em>number of external links on the page</em> |[optional]|
**InboundLinksCount** | **long?** | <em>number of internal links pointing at the page</em> |[optional]|
**ImagesCount** | **long?** | <em>number of images on the page</em> |[optional]|
**ImagesSize** | **int?** | <em>total size of images on the page measured in bytes</em> |[optional]|
**ScriptsCount** | **long?** | <em>number of scripts on the page</em> |[optional]|
**ScriptsSize** | **int?** | <em>total size of scripts on the page measured in bytes</em> |[optional]|
**StylesheetsCount** | **long?** | <em>number of stylesheets on the page</em> |[optional]|
**StylesheetsSize** | **int?** | <em>total size of stylesheets on the page measured in bytes</em> |[optional]|
**TitleLength** | **int?** | <em>length of the <code>title</code> tag in characters</em> |[optional]|
**DescriptionLength** | **int?** | <em>length of the <code>description</code> tag in characters</em> |[optional]|
**RenderBlockingScriptsCount** | **long?** | <em>number of scripts on the page that block page rendering</em> |[optional]|
**RenderBlockingStylesheetsCount** | **long?** | <em>number of CSS styles on the page that block page rendering</em> |[optional]|
**CumulativeLayoutShift** | **double?** | <em>Core Web Vitals metric measuring the layout stability of the page</em><br>measures the sum total of all individual layout shift scores for every unexpected layout shift that occurs during the entire lifespan of the page. <a href='https://web.dev/cls/'>Learn more.</a> |[optional]|
**MetaTitle** | **string** | <em>meta title of the page</em><br>meta tag in the head section of an HTML document that defines the title of a page |[optional]|
**Content** | **HtmlContentInfo** | <em>overall information about content of the page</em> |[optional]|
**DeprecatedTags** | **IEnumerable<string>** | <em>deprecated tags on the page</em> |[optional]|
**DuplicateMetaTags** | **IEnumerable<string>** | <em>duplicate meta tags on the page</em> |[optional]|
**Spell** | **HunspellInfo** | <em>spellcheck</em><br><a href='http://hunspell.github.io/' target='_blank' rel='noopener noreferrer'>hunspell</a> spellcheck errors |[optional]|
**SocialMediaTags** | **IDictionary<string, string>** | <em>object of social media tags found on the page</em><br>contains social media tags and their content<br>supported tags include but are not limited to <a href='https://ogp.me/'>Open Graph</a> and <a href='https://developer.twitter.com/en/docs/twitter-for-websites/cards/guides/getting-started'>Twitter card</a> |[optional]|
**BrokenHtml** | **OnPageResourceIssueInfo** | resource errors and warnings |[optional]|