# RankChanges


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**PreviousRankAbsolute** | **int?** | <em>previous absolute rank in SERP</em><br>            indicates previous rank of the element in Google SERP;<br>            if this element is new, the value will be <code>null</code> |[optional]|
**IsNew** | **bool?** | <em>number of new ranked elements</em><br>            indicates how many new ranked elements were found for this domain or webpage |[optional]|
**IsUp** | **bool?** | <em>rank went up</em><br>            indicates how many ranked elements of this target went up in Google Search |[optional]|
**IsDown** | **bool?** | <em>rank went down</em><br>            indicates how many ranked elements of this target went down in Google Search |[optional]|