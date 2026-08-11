# KeywordKpiItemInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AdPosition** | **string** | <em>represents the position of the relevant ad in SERP</em><br>can take the following values:<br><code>FirstPage1</code>: The first ad to appear on the right side of the first search results page<br><code>FirstPage2</code>: The second ad to appear on the right side of the first search results page<br><code>FirstPage3</code>: The third ad to appear on the right side of the first search results page<br><code>FirstPage4</code>: The fourth ad to appear on the right side of the first search results page<br><code>FirstPage5</code>: The fifth ad to appear on the right side of the first search results page<br><code>FirstPage6</code>: The sixth ad to appear on the right side of the first search results page<br><code>FirstPage7</code>: The seventh ad to appear on the right side of the first search results page<br><code>FirstPage8</code>: The eighth ad to appear on the right side of the first search results page<br><code>FirstPage9</code>: The ninth ad to appear on the right side of the first search results page<br><code>FirstPage10</code>: The tenth ad to appear on the right side of the first search results page<br><code>MainLine1</code>: The first ad to appear at the top of the search results page<br><code>MainLine2</code>: The second ad to appear at the top of the search results page<br><code>MainLine3</code>: The third ad to appear at the top of the search results page<br><code>MainLine4</code>: The fourth ad to appear at the top of the search results page |[optional]|
**Clicks** | **int?** | <em>ad clicks</em><br>the number of clicks that the keyword and match type generated during the last month |[optional]|
**Impressions** | **int?** | <em>ad impressions</em><br>the number of impressions that the keyword and match type generated during the last month |[optional]|
**AverageCpc** | **double?** | <em>average cost per click, USD</em><br>calculated by dividing the cost of all clicks by the number of clicks |[optional]|
**Ctr** | **double?** | <em>click-through rate as a percentage</em><br>calculated by dividing the number of clicks by the number of impressions and multiplying the result by 100 |[optional]|
**TotalCost** | **double?** | <em>total cost of an ad, USD</em><br>the cost of using the specified keyword and match type during the last month |[optional]|
**AverageBid** | **double?** | <em>average bid of the keyword</em> |[optional]|