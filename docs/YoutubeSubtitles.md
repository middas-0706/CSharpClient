# YoutubeSubtitles


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em> absolute rank in SERP for the target domain</em><br>absolute position among all the elements in SERP |[optional]|
**Text** | **string** | <em>text translated in subtitles</em> |[optional]|
**StartTime** | **double?** | <em>the second subtitled text starts</em> |[optional]|
**EndTime** | **double?** | <em>the second subtitled text ends</em> |[optional]|
**DurationTime** | **double?** | <em>duration of subtitles in seconds</em> |[optional]|