# BaseOnPageLinkItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**DomainFrom** | **string** | <em>referring domain</em><br>the link was found on this domain |[optional]|
**DomainTo** | **string** | <em>referenced domain</em><br>the link is pointing to this domain |[optional]|
**PageFrom** | **string** | <em>referring page</em><br>relative URL of the page on which the link was found |[optional]|
**PageTo** | **string** | <em>referenced page</em><br>relative URL of the page to which the link is pointing |[optional]|
**LinkFrom** | **string** | <em>referring page</em><br>absolute URL of the page on which the link was found |[optional]|
**LinkTo** | **string** | <em>referenced page</em><br>absolute URL of the page to which the link is pointing |[optional]|
**Dofollow** | **bool?** | <em>indicates whether the link is dofollow</em><br>if the value is <code>true</code>, the link doesn't have a <code>rel='nofollow'</code> attribute |[optional]|
**PageFromScheme** | **string** | <em><a href='https://en.wikipedia.org/wiki/List_of_URI_schemes' target='_blank' rel='noopener noreferrer'>url scheme</a> of the referring page</em> |[optional]|
**PageToScheme** | **string** | <em><a href='https://en.wikipedia.org/wiki/List_of_URI_schemes' target='_blank' rel='noopener noreferrer'>url scheme</a> of the referenced page</em> |[optional]|
**Direction** | **string** | <em>direction of the link</em><br>possible values: <code>internal</code>, <code>external</code> |[optional]|
**IsBroken** | **bool?** | <em>link is broken</em><br>indicates whether a link is directing to a broken page or resource |[optional]|
**IsLinkRelationConflict** | **bool?** | <em>indicates that the link may have a conflict with another link</em><br>if <code>true</code>, at least one link pointing to <code>link_to</code> has a <code>rel='nofollow'</code> attribute <strong>and</strong> at least one is dofollow |[optional]|
**PageToStatusCode** | **int?** | <em>status code of the referenced page</em><br>status code of the page to which the link is pointing |[optional]|