# CyberSource.Model.PtsV2PaymentsPost201ResponsePointOfSaleInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Emv** | [**PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv**](PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv.md) |  | [optional] 
**AmexCapnData** | **string** | Point-of-sale details for the transaction. This value is returned only for **American Express Direct**. CyberSource generates this value, which consists of a series of codes that identify terminal capability, security data, and specific conditions present at the time the transaction occurred. To comply with the CAPN requirements, this value must be included in all subsequent follow-on requests, such as captures and follow-on credits.  When you perform authorizations, captures, and credits through CyberSource, CyberSource passes this value from the authorization service to the subsequent services for you. However, when you perform authorizations through CyberSource and perform subsequent services through other financial institutions, you must ensure that your requests for captures and credits include this value.  For details, see &#x60;auth_pos_data&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

