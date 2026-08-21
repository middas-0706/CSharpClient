# PageContentInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Header** | **PageSectionContentInfo** | <em>parsed content of the header</em><br> |[optional]|
**Footer** | **PageSectionContentInfo** | <em>content of the footer of the table</em><br> |[optional]|
**MainTopic** | **IEnumerable<TopicInfo>** | <em>main topic on the page</em><br>            you can find more information about topic priority calculation in this <a href='https://dataforseo.com/help-center/difference-between-primary-and-secondary-content#topics' rel='noopener noreferrer' target='_blank'>help center article</a><br> |[optional]|
**SecondaryTopic** | **IEnumerable<TopicInfo>** | <em>secondary topic on the page</em><br>            you can find more information about topic priority calculation in this <a href='https://dataforseo.com/help-center/difference-between-primary-and-secondary-content#topics' rel='noopener noreferrer' target='_blank'>help center article</a><br> |[optional]|
**Ratings** | **IEnumerable<ContentRatingInfo>** | <em>contains objects with rating information for the products displayed on the page</em><br> |[optional]|
**Offers** | **IEnumerable<ContentOfferInfo>** | <em>array of products displayed on the page</em><br>            contains objects with information on products displayed on the page |[optional]|
**Comments** | **IEnumerable<ContentCommentInfo>** | <em>array of comments displayed on the page</em><br>            contains objects with information on comments related to displayed products |[optional]|
**Contacts** | **Contacts** | <em>contact information</em><br>            contains contact information displayed on the page |[optional]|