# SslInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ValidCertificate** | **bool?** | <em>ssl certificate validity</em><br>indicates whether the ssl certificate detected on a website is not expired, suspended, revoked or invalid |[optional]|
**CertificateIssuer** | **string** | <em>ssl certificate authority</em><br>the entity that issued the detected ssl certificate |[optional]|
**CertificateSubject** | **string** | <em>ssl certificate subject</em><br>the entity associated with the public key |[optional]|
**CertificateVersion** | **int?** | <em>ssl certificate version</em><br>indicates the version of <a href='https://en.wikipedia.org/wiki/X.509' target='_blank' rel='noopener noreferrer'>X.509</a> used by an ssl certificate |[optional]|
**CertificateHash** | **string** | <em>ssl certificate hash</em><br>the version of the ssl certificate's hash function |[optional]|
**CertificateExpirationDate** | **string** | <em>ssl certificate expiration date</em><br>the date and time when the ssl certificate expires<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|