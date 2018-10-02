/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// InlineResponse201PaymentInformationAccountFeatures
    /// </summary>
    [DataContract]
    public partial class InlineResponse201PaymentInformationAccountFeatures :  IEquatable<InlineResponse201PaymentInformationAccountFeatures>, IValidatableObject
    {
        /// <summary>
        /// Sign for the remaining balance on the account. Returned only when the processor returns this value. Possible values: 
        /// </summary>
        /// <value>Sign for the remaining balance on the account. Returned only when the processor returns this value. Possible values: </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BalanceSignEnum
        {
            
            /// <summary>
            /// Enum Plus for "+"
            /// </summary>
            [EnumMember(Value = "+")]
            Plus,
            
            /// <summary>
            /// Enum Minus for "-"
            /// </summary>
            [EnumMember(Value = "-")]
            Minus
        }

        /// <summary>
        /// Sign for the remaining balance on the account. Returned only when the processor returns this value. Possible values: 
        /// </summary>
        /// <value>Sign for the remaining balance on the account. Returned only when the processor returns this value. Possible values: </value>
        [DataMember(Name="balanceSign", EmitDefaultValue=false)]
        public BalanceSignEnum? BalanceSign { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse201PaymentInformationAccountFeatures" /> class.
        /// </summary>
        /// <param name="AccountType">Type of account. This value is returned only if you requested a balance inquiry. Possible values:   - **00**: Not applicable or not specified  - **10**: Savings account  - **20**: Checking account  - **30**: Credit card account  - **40**: Universal account .</param>
        /// <param name="AccountStatus">Possible values:   - **N**: Nonregulated  - **R**: Regulated  &#x60;Note&#x60; This field is returned only for CyberSource through VisaNet. .</param>
        /// <param name="BalanceAmount">Remaining balance on the account. .</param>
        /// <param name="BalanceAmountType">Type of amount. This value is returned only if you requested a balance inquiry. The issuer determines the value that is returned. Possible values for deposit accounts:   - **01**: Current ledger (posted) balance.  - **02**: Current available balance, which is typically the ledger balance less outstanding authorizations.  Some depository institutions also include pending deposits and the credit or overdraft line associated with the account. Possible values for credit card accounts:   - **01**: Credit amount remaining for customer (open to buy).  - **02**: Credit limit. .</param>
        /// <param name="Currency">Currency of the remaining balance on the account. For the possible values, see the ISO Standard Currency Codes. .</param>
        /// <param name="BalanceSign">Sign for the remaining balance on the account. Returned only when the processor returns this value. Possible values: .</param>
        /// <param name="AffluenceIndicator">**Chase Paymentech Solutions**  Indicates whether a customer has high credit limits. This information enables you to market high cost items to these customers and to understand the kinds of cards that high income customers are using.  This field is supported for Visa, Mastercard, Discover, and Diners Club. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown  **Litle**  Flag that indicates that a Visa cardholder or Mastercard cardholder is in one of the affluent categories. Possible values:   - **AFFLUENT**: High income customer with high spending pattern (&gt;100k USD annual income and &gt;40k USD annual    card usage).  - **MASS AFFLUENT**: High income customer (&gt;100k USD annual income).  **Processor specific maximum length**:   - Chase Paymentech Solutions: 1  - Litle: 13 .</param>
        /// <param name="Category">**CyberSource through VisaNet**  Visa product ID.  **GPN**  Visa or Mastercard product ID.  **Litle**  Type of card used in the transaction. The only possible value is:   - PREPAID: Prepaid Card  **RBS WorldPay Atlanta**  Type of card used in the transaction. Possible values:   - **B**: Business Card  - **O**: Noncommercial Card  - **R**: Corporate Card  - **S**: Purchase Card  - **Blank**: Purchase card not supported  **Maximum length for processors**:   - CyberSource through VisaNet: 3  - GPN: 3  - Litle: 7  - RBS WorldPay Atlanta: 1 .</param>
        /// <param name="Commercial">Indicates whether the card is a commercial card, which enables you to include Level II data in your transaction requests. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown .</param>
        /// <param name="Group">Type of commercial card. This field is supported only for CyberSource through VisaNet. Possible values:   - **B**: Business card  - **R**: Corporate card  - **S**: Purchasing card  - **0**: Noncommercial card .</param>
        /// <param name="HealthCare">Indicates whether the card is a healthcare card. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown .</param>
        /// <param name="Payroll">Indicates whether the card is a payroll card. This field is supported for Visa, Discover, Diners Club, and JCB on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown .</param>
        /// <param name="Level3Eligible">Indicates whether the card is eligible for Level III interchange fees, which enables you to include Level III data in your transaction requests. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown .</param>
        /// <param name="PinlessDebit">Indicates whether the card is a PINless debit card. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown .</param>
        /// <param name="SignatureDebit">Indicates whether the card is a signature debit card. This information enables you to alter the way an order is processed. For example, you might not want to reauthorize a transaction for a signature debit card, or you might want to perform reversals promptly for a signature debit card. This field is supported for Visa, Mastercard, and Maestro (International) on Chase Paymentech Solutions. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown .</param>
        /// <param name="Prepaid">Indicates whether the card is a prepaid card. This information enables you to determine when a gift card or prepaid card is presented for use when establishing a new recurring, installment, or deferred billing relationship.  This field is supported for Visa, Mastercard, Discover, Diners Club, and JCB on Chase Paymentech Solutions. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown .</param>
        /// <param name="Regulated">Indicates whether the card is regulated according to the Durbin Amendment. If the card is regulated, the card issuer is subject to price caps and interchange rules. This field is supported for Visa, Mastercard, Discover, Diners Club, and JCB on Chase Paymentech Solutions. Possible values:   - **Y**: Yes (assets greater than 10B USD)  - **N**: No (assets less than 10B USD)  - **X**: Not applicable / Unknown .</param>
        public InlineResponse201PaymentInformationAccountFeatures(string AccountType = default(string), string AccountStatus = default(string), string BalanceAmount = default(string), string BalanceAmountType = default(string), string Currency = default(string), BalanceSignEnum? BalanceSign = default(BalanceSignEnum?), string AffluenceIndicator = default(string), string Category = default(string), string Commercial = default(string), string Group = default(string), string HealthCare = default(string), string Payroll = default(string), string Level3Eligible = default(string), string PinlessDebit = default(string), string SignatureDebit = default(string), string Prepaid = default(string), string Regulated = default(string))
        {
            this.AccountType = AccountType;
            this.AccountStatus = AccountStatus;
            this.BalanceAmount = BalanceAmount;
            this.BalanceAmountType = BalanceAmountType;
            this.Currency = Currency;
            this.BalanceSign = BalanceSign;
            this.AffluenceIndicator = AffluenceIndicator;
            this.Category = Category;
            this.Commercial = Commercial;
            this.Group = Group;
            this.HealthCare = HealthCare;
            this.Payroll = Payroll;
            this.Level3Eligible = Level3Eligible;
            this.PinlessDebit = PinlessDebit;
            this.SignatureDebit = SignatureDebit;
            this.Prepaid = Prepaid;
            this.Regulated = Regulated;
        }
        
        /// <summary>
        /// Type of account. This value is returned only if you requested a balance inquiry. Possible values:   - **00**: Not applicable or not specified  - **10**: Savings account  - **20**: Checking account  - **30**: Credit card account  - **40**: Universal account 
        /// </summary>
        /// <value>Type of account. This value is returned only if you requested a balance inquiry. Possible values:   - **00**: Not applicable or not specified  - **10**: Savings account  - **20**: Checking account  - **30**: Credit card account  - **40**: Universal account </value>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Possible values:   - **N**: Nonregulated  - **R**: Regulated  &#x60;Note&#x60; This field is returned only for CyberSource through VisaNet. 
        /// </summary>
        /// <value>Possible values:   - **N**: Nonregulated  - **R**: Regulated  &#x60;Note&#x60; This field is returned only for CyberSource through VisaNet. </value>
        [DataMember(Name="accountStatus", EmitDefaultValue=false)]
        public string AccountStatus { get; set; }

        /// <summary>
        /// Remaining balance on the account. 
        /// </summary>
        /// <value>Remaining balance on the account. </value>
        [DataMember(Name="balanceAmount", EmitDefaultValue=false)]
        public string BalanceAmount { get; set; }

        /// <summary>
        /// Type of amount. This value is returned only if you requested a balance inquiry. The issuer determines the value that is returned. Possible values for deposit accounts:   - **01**: Current ledger (posted) balance.  - **02**: Current available balance, which is typically the ledger balance less outstanding authorizations.  Some depository institutions also include pending deposits and the credit or overdraft line associated with the account. Possible values for credit card accounts:   - **01**: Credit amount remaining for customer (open to buy).  - **02**: Credit limit. 
        /// </summary>
        /// <value>Type of amount. This value is returned only if you requested a balance inquiry. The issuer determines the value that is returned. Possible values for deposit accounts:   - **01**: Current ledger (posted) balance.  - **02**: Current available balance, which is typically the ledger balance less outstanding authorizations.  Some depository institutions also include pending deposits and the credit or overdraft line associated with the account. Possible values for credit card accounts:   - **01**: Credit amount remaining for customer (open to buy).  - **02**: Credit limit. </value>
        [DataMember(Name="balanceAmountType", EmitDefaultValue=false)]
        public string BalanceAmountType { get; set; }

        /// <summary>
        /// Currency of the remaining balance on the account. For the possible values, see the ISO Standard Currency Codes. 
        /// </summary>
        /// <value>Currency of the remaining balance on the account. For the possible values, see the ISO Standard Currency Codes. </value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }


        /// <summary>
        /// **Chase Paymentech Solutions**  Indicates whether a customer has high credit limits. This information enables you to market high cost items to these customers and to understand the kinds of cards that high income customers are using.  This field is supported for Visa, Mastercard, Discover, and Diners Club. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown  **Litle**  Flag that indicates that a Visa cardholder or Mastercard cardholder is in one of the affluent categories. Possible values:   - **AFFLUENT**: High income customer with high spending pattern (&gt;100k USD annual income and &gt;40k USD annual    card usage).  - **MASS AFFLUENT**: High income customer (&gt;100k USD annual income).  **Processor specific maximum length**:   - Chase Paymentech Solutions: 1  - Litle: 13 
        /// </summary>
        /// <value>**Chase Paymentech Solutions**  Indicates whether a customer has high credit limits. This information enables you to market high cost items to these customers and to understand the kinds of cards that high income customers are using.  This field is supported for Visa, Mastercard, Discover, and Diners Club. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown  **Litle**  Flag that indicates that a Visa cardholder or Mastercard cardholder is in one of the affluent categories. Possible values:   - **AFFLUENT**: High income customer with high spending pattern (&gt;100k USD annual income and &gt;40k USD annual    card usage).  - **MASS AFFLUENT**: High income customer (&gt;100k USD annual income).  **Processor specific maximum length**:   - Chase Paymentech Solutions: 1  - Litle: 13 </value>
        [DataMember(Name="affluenceIndicator", EmitDefaultValue=false)]
        public string AffluenceIndicator { get; set; }

        /// <summary>
        /// **CyberSource through VisaNet**  Visa product ID.  **GPN**  Visa or Mastercard product ID.  **Litle**  Type of card used in the transaction. The only possible value is:   - PREPAID: Prepaid Card  **RBS WorldPay Atlanta**  Type of card used in the transaction. Possible values:   - **B**: Business Card  - **O**: Noncommercial Card  - **R**: Corporate Card  - **S**: Purchase Card  - **Blank**: Purchase card not supported  **Maximum length for processors**:   - CyberSource through VisaNet: 3  - GPN: 3  - Litle: 7  - RBS WorldPay Atlanta: 1 
        /// </summary>
        /// <value>**CyberSource through VisaNet**  Visa product ID.  **GPN**  Visa or Mastercard product ID.  **Litle**  Type of card used in the transaction. The only possible value is:   - PREPAID: Prepaid Card  **RBS WorldPay Atlanta**  Type of card used in the transaction. Possible values:   - **B**: Business Card  - **O**: Noncommercial Card  - **R**: Corporate Card  - **S**: Purchase Card  - **Blank**: Purchase card not supported  **Maximum length for processors**:   - CyberSource through VisaNet: 3  - GPN: 3  - Litle: 7  - RBS WorldPay Atlanta: 1 </value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Indicates whether the card is a commercial card, which enables you to include Level II data in your transaction requests. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown 
        /// </summary>
        /// <value>Indicates whether the card is a commercial card, which enables you to include Level II data in your transaction requests. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown </value>
        [DataMember(Name="commercial", EmitDefaultValue=false)]
        public string Commercial { get; set; }

        /// <summary>
        /// Type of commercial card. This field is supported only for CyberSource through VisaNet. Possible values:   - **B**: Business card  - **R**: Corporate card  - **S**: Purchasing card  - **0**: Noncommercial card 
        /// </summary>
        /// <value>Type of commercial card. This field is supported only for CyberSource through VisaNet. Possible values:   - **B**: Business card  - **R**: Corporate card  - **S**: Purchasing card  - **0**: Noncommercial card </value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }

        /// <summary>
        /// Indicates whether the card is a healthcare card. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown 
        /// </summary>
        /// <value>Indicates whether the card is a healthcare card. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown </value>
        [DataMember(Name="healthCare", EmitDefaultValue=false)]
        public string HealthCare { get; set; }

        /// <summary>
        /// Indicates whether the card is a payroll card. This field is supported for Visa, Discover, Diners Club, and JCB on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown 
        /// </summary>
        /// <value>Indicates whether the card is a payroll card. This field is supported for Visa, Discover, Diners Club, and JCB on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown </value>
        [DataMember(Name="payroll", EmitDefaultValue=false)]
        public string Payroll { get; set; }

        /// <summary>
        /// Indicates whether the card is eligible for Level III interchange fees, which enables you to include Level III data in your transaction requests. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown 
        /// </summary>
        /// <value>Indicates whether the card is eligible for Level III interchange fees, which enables you to include Level III data in your transaction requests. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown </value>
        [DataMember(Name="level3Eligible", EmitDefaultValue=false)]
        public string Level3Eligible { get; set; }

        /// <summary>
        /// Indicates whether the card is a PINless debit card. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown 
        /// </summary>
        /// <value>Indicates whether the card is a PINless debit card. This field is supported for Visa and Mastercard on **Chase Paymentech Solutions**. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown </value>
        [DataMember(Name="pinlessDebit", EmitDefaultValue=false)]
        public string PinlessDebit { get; set; }

        /// <summary>
        /// Indicates whether the card is a signature debit card. This information enables you to alter the way an order is processed. For example, you might not want to reauthorize a transaction for a signature debit card, or you might want to perform reversals promptly for a signature debit card. This field is supported for Visa, Mastercard, and Maestro (International) on Chase Paymentech Solutions. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown 
        /// </summary>
        /// <value>Indicates whether the card is a signature debit card. This information enables you to alter the way an order is processed. For example, you might not want to reauthorize a transaction for a signature debit card, or you might want to perform reversals promptly for a signature debit card. This field is supported for Visa, Mastercard, and Maestro (International) on Chase Paymentech Solutions. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown </value>
        [DataMember(Name="signatureDebit", EmitDefaultValue=false)]
        public string SignatureDebit { get; set; }

        /// <summary>
        /// Indicates whether the card is a prepaid card. This information enables you to determine when a gift card or prepaid card is presented for use when establishing a new recurring, installment, or deferred billing relationship.  This field is supported for Visa, Mastercard, Discover, Diners Club, and JCB on Chase Paymentech Solutions. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown 
        /// </summary>
        /// <value>Indicates whether the card is a prepaid card. This information enables you to determine when a gift card or prepaid card is presented for use when establishing a new recurring, installment, or deferred billing relationship.  This field is supported for Visa, Mastercard, Discover, Diners Club, and JCB on Chase Paymentech Solutions. Possible values:   - **Y**: Yes  - **N**: No  - **X**: Not applicable / Unknown </value>
        [DataMember(Name="prepaid", EmitDefaultValue=false)]
        public string Prepaid { get; set; }

        /// <summary>
        /// Indicates whether the card is regulated according to the Durbin Amendment. If the card is regulated, the card issuer is subject to price caps and interchange rules. This field is supported for Visa, Mastercard, Discover, Diners Club, and JCB on Chase Paymentech Solutions. Possible values:   - **Y**: Yes (assets greater than 10B USD)  - **N**: No (assets less than 10B USD)  - **X**: Not applicable / Unknown 
        /// </summary>
        /// <value>Indicates whether the card is regulated according to the Durbin Amendment. If the card is regulated, the card issuer is subject to price caps and interchange rules. This field is supported for Visa, Mastercard, Discover, Diners Club, and JCB on Chase Paymentech Solutions. Possible values:   - **Y**: Yes (assets greater than 10B USD)  - **N**: No (assets less than 10B USD)  - **X**: Not applicable / Unknown </value>
        [DataMember(Name="regulated", EmitDefaultValue=false)]
        public string Regulated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse201PaymentInformationAccountFeatures {\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AccountStatus: ").Append(AccountStatus).Append("\n");
            sb.Append("  BalanceAmount: ").Append(BalanceAmount).Append("\n");
            sb.Append("  BalanceAmountType: ").Append(BalanceAmountType).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  BalanceSign: ").Append(BalanceSign).Append("\n");
            sb.Append("  AffluenceIndicator: ").Append(AffluenceIndicator).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Commercial: ").Append(Commercial).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  HealthCare: ").Append(HealthCare).Append("\n");
            sb.Append("  Payroll: ").Append(Payroll).Append("\n");
            sb.Append("  Level3Eligible: ").Append(Level3Eligible).Append("\n");
            sb.Append("  PinlessDebit: ").Append(PinlessDebit).Append("\n");
            sb.Append("  SignatureDebit: ").Append(SignatureDebit).Append("\n");
            sb.Append("  Prepaid: ").Append(Prepaid).Append("\n");
            sb.Append("  Regulated: ").Append(Regulated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse201PaymentInformationAccountFeatures);
        }

        /// <summary>
        /// Returns true if InlineResponse201PaymentInformationAccountFeatures instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse201PaymentInformationAccountFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse201PaymentInformationAccountFeatures other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.AccountStatus == other.AccountStatus ||
                    this.AccountStatus != null &&
                    this.AccountStatus.Equals(other.AccountStatus)
                ) && 
                (
                    this.BalanceAmount == other.BalanceAmount ||
                    this.BalanceAmount != null &&
                    this.BalanceAmount.Equals(other.BalanceAmount)
                ) && 
                (
                    this.BalanceAmountType == other.BalanceAmountType ||
                    this.BalanceAmountType != null &&
                    this.BalanceAmountType.Equals(other.BalanceAmountType)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.BalanceSign == other.BalanceSign ||
                    this.BalanceSign != null &&
                    this.BalanceSign.Equals(other.BalanceSign)
                ) && 
                (
                    this.AffluenceIndicator == other.AffluenceIndicator ||
                    this.AffluenceIndicator != null &&
                    this.AffluenceIndicator.Equals(other.AffluenceIndicator)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Commercial == other.Commercial ||
                    this.Commercial != null &&
                    this.Commercial.Equals(other.Commercial)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.HealthCare == other.HealthCare ||
                    this.HealthCare != null &&
                    this.HealthCare.Equals(other.HealthCare)
                ) && 
                (
                    this.Payroll == other.Payroll ||
                    this.Payroll != null &&
                    this.Payroll.Equals(other.Payroll)
                ) && 
                (
                    this.Level3Eligible == other.Level3Eligible ||
                    this.Level3Eligible != null &&
                    this.Level3Eligible.Equals(other.Level3Eligible)
                ) && 
                (
                    this.PinlessDebit == other.PinlessDebit ||
                    this.PinlessDebit != null &&
                    this.PinlessDebit.Equals(other.PinlessDebit)
                ) && 
                (
                    this.SignatureDebit == other.SignatureDebit ||
                    this.SignatureDebit != null &&
                    this.SignatureDebit.Equals(other.SignatureDebit)
                ) && 
                (
                    this.Prepaid == other.Prepaid ||
                    this.Prepaid != null &&
                    this.Prepaid.Equals(other.Prepaid)
                ) && 
                (
                    this.Regulated == other.Regulated ||
                    this.Regulated != null &&
                    this.Regulated.Equals(other.Regulated)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.AccountStatus != null)
                    hash = hash * 59 + this.AccountStatus.GetHashCode();
                if (this.BalanceAmount != null)
                    hash = hash * 59 + this.BalanceAmount.GetHashCode();
                if (this.BalanceAmountType != null)
                    hash = hash * 59 + this.BalanceAmountType.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.BalanceSign != null)
                    hash = hash * 59 + this.BalanceSign.GetHashCode();
                if (this.AffluenceIndicator != null)
                    hash = hash * 59 + this.AffluenceIndicator.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Commercial != null)
                    hash = hash * 59 + this.Commercial.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.HealthCare != null)
                    hash = hash * 59 + this.HealthCare.GetHashCode();
                if (this.Payroll != null)
                    hash = hash * 59 + this.Payroll.GetHashCode();
                if (this.Level3Eligible != null)
                    hash = hash * 59 + this.Level3Eligible.GetHashCode();
                if (this.PinlessDebit != null)
                    hash = hash * 59 + this.PinlessDebit.GetHashCode();
                if (this.SignatureDebit != null)
                    hash = hash * 59 + this.SignatureDebit.GetHashCode();
                if (this.Prepaid != null)
                    hash = hash * 59 + this.Prepaid.GetHashCode();
                if (this.Regulated != null)
                    hash = hash * 59 + this.Regulated.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // AccountType (string) maxLength
            if(this.AccountType != null && this.AccountType.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountType, length must be less than 2.", new [] { "AccountType" });
            }

            // AccountStatus (string) maxLength
            if(this.AccountStatus != null && this.AccountStatus.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountStatus, length must be less than 1.", new [] { "AccountStatus" });
            }

            // BalanceAmount (string) maxLength
            if(this.BalanceAmount != null && this.BalanceAmount.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BalanceAmount, length must be less than 12.", new [] { "BalanceAmount" });
            }

            // BalanceAmountType (string) maxLength
            if(this.BalanceAmountType != null && this.BalanceAmountType.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BalanceAmountType, length must be less than 2.", new [] { "BalanceAmountType" });
            }

            // Currency (string) maxLength
            if(this.Currency != null && this.Currency.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 5.", new [] { "Currency" });
            }

            // BalanceSign (string) maxLength
            //if(this.BalanceSign != null && this.BalanceSign.Length > 1)
            //{
            //    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BalanceSign, length must be less than 1.", new [] { "BalanceSign" });
            //}

            // AffluenceIndicator (string) maxLength
            if(this.AffluenceIndicator != null && this.AffluenceIndicator.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AffluenceIndicator, length must be less than 13.", new [] { "AffluenceIndicator" });
            }

            // Category (string) maxLength
            if(this.Category != null && this.Category.Length > 7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Category, length must be less than 7.", new [] { "Category" });
            }

            // Commercial (string) maxLength
            if(this.Commercial != null && this.Commercial.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Commercial, length must be less than 1.", new [] { "Commercial" });
            }

            // Group (string) maxLength
            if(this.Group != null && this.Group.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Group, length must be less than 1.", new [] { "Group" });
            }

            // HealthCare (string) maxLength
            if(this.HealthCare != null && this.HealthCare.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HealthCare, length must be less than 1.", new [] { "HealthCare" });
            }

            // Payroll (string) maxLength
            if(this.Payroll != null && this.Payroll.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Payroll, length must be less than 1.", new [] { "Payroll" });
            }

            // Level3Eligible (string) maxLength
            if(this.Level3Eligible != null && this.Level3Eligible.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Level3Eligible, length must be less than 1.", new [] { "Level3Eligible" });
            }

            // PinlessDebit (string) maxLength
            if(this.PinlessDebit != null && this.PinlessDebit.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PinlessDebit, length must be less than 1.", new [] { "PinlessDebit" });
            }

            // SignatureDebit (string) maxLength
            if(this.SignatureDebit != null && this.SignatureDebit.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignatureDebit, length must be less than 1.", new [] { "SignatureDebit" });
            }

            // Prepaid (string) maxLength
            if(this.Prepaid != null && this.Prepaid.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Prepaid, length must be less than 1.", new [] { "Prepaid" });
            }

            // Regulated (string) maxLength
            if(this.Regulated != null && this.Regulated.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Regulated, length must be less than 1.", new [] { "Regulated" });
            }

            yield break;
        }
    }

}
