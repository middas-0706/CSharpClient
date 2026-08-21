# SerpApiYoutubeVideoPaidElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>title of the video</em> |[optional]|
**VideoId** | **string** | <em>ID of the video</em> |[optional]|
**ThumbnailUrl** | **string** | <em>the URL of the page where the thumbnail is hosted</em> |[optional]|
**ChannelName** | **string** | <em>the name of the channel where the video is published</em> |[optional]|
**ChannelUrl** | **string** | <em>the URL of the channel where the video is published</em> |[optional]|
**ChannelLogo** | **string** | <em>the URL of the page where the logo image of the channel is hosted</em> |[optional]|
**Description** | **string** | <em>description of the channel</em> |[optional]|
**Highlighted** | **IEnumerable<string>** | <em>highlighted keywords in the description</em> |[optional]|
**Badges** | **IEnumerable<string>** | <em>video badges</em><br>            example:<br>            <code>New</code>, <code>CC</code>, <code>4K</code><br> |[optional]|
**IsLive** | **bool?** | <em>indicates whether the video is a live broadcast</em> |[optional]|
**IsShorts** | **bool?** | <em>indicates whether the video is shorts</em> |[optional]|
**IsMovie** | **bool?** | <em>indicates whether the video is a movie</em> |[optional]|
**ViewsCount** | **long?** | <em>number of views of the video</em> |[optional]|
**PublicationDate** | **string** | <em>the date when the video is published</em> |[optional]|
**Timestamp** | **string** | <em>date and time when the result is published</em><br>            in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>            example:<br>            <code>2022-11-15 12:57:46 +00:00</code><br> |[optional]|
**DurationTime** | **string** | <em>duration of the video</em> |[optional]|
**DurationTimeSeconds** | **int?** | <em>duration of the video in seconds</em> |[optional]|