# YoutubeVideoInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>            position within a group of elements with identical <code>type</code> values<br>            positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em> absolute rank in SERP for the target domain</em><br>            absolute position among all the elements in SERP |[optional]|
**VideoId** | **string** | <em>ID of the video received in a POST array</em> |[optional]|
**Title** | **string** | <em>title of the video</em> |[optional]|
**Url** | **string** | <em>URL of the video</em> |[optional]|
**ThumbnailUrl** | **string** | <em>the URL of the page where the thumbnail is hosted</em> |[optional]|
**ChannelId** | **string** | <em>the ID of the channel where the video is published</em> |[optional]|
**ChannelName** | **string** | <em>the name of the channel where the video is published</em> |[optional]|
**ChannelUrl** | **string** | <em>the URL of the channel where the video is published</em> |[optional]|
**ChannelLogo** | **string** | <em>the URL of the page where the logo image of the channel is hosted</em> |[optional]|
**Description** | **string** | <em>description of the video</em> |[optional]|
**ViewsCount** | **long?** | <em>number of views of the video</em> |[optional]|
**LikesCount** | **long?** | <em>number of likes on the video</em> |[optional]|
**CommentsCount** | **long?** | <em>number of comments on the video</em> |[optional]|
**ChannelSubscribersCount** | **ChannelSubscribersCount** | <em>number of subscribers of the channel</em> |[optional]|
**PublicationDate** | **string** | <em>the date when the video is published</em> |[optional]|
**Timestamp** | **string** | <em>date and time when the result is published</em><br>            in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>            example:<br>            <code>2022-11-15 12:57:46 +00:00</code> |[optional]|
**Keywords** | **IEnumerable<string>** | <em>keywords relevant to the video</em><br>            also known as 'YouTube tags' |[optional]|
**Category** | **string** | <em>the category the video belongs to</em> |[optional]|
**IsLive** | **bool?** | <em>indicates whether the video is on live</em> |[optional]|
**IsEmbeddable** | **bool?** | <em>indicates whether the video is embeddable</em> |[optional]|
**DurationTime** | **string** | <em>duration of the video</em> |[optional]|
**DurationTimeSeconds** | **int?** | <em>duration of the video in seconds</em> |[optional]|
**Subtitles** | **IEnumerable<Subtitles>** | <em>array of elements describing properties of subtitles in the video</em> |[optional]|
**StreamingQuality** | **IEnumerable<StreamingQualityElement>** | <em>array of elements that contain information about all possible streaming qualities of the video</em> |[optional]|