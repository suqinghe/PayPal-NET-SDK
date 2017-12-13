// This class was generated on Wed, 13 Dec 2017 14:32:18 CST by version 0.1 of Braintree SDK Generator
// BillingInfo.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8RXX2/bNhB/36c4aC8NJshJuu0hT0udDijQpl7T7mFbYJ+pk3ULRSrkMakw5LsPpGTXtZ0g2TLvxYB5d+LvfveXf2Ufu5ayk+wVa81mAW9MZbM8+xUd41zTOTZRmuXZGXnluBW2Zk2dTWVdg/EUKutAagI2N5YVgSPFLZORIsuzU+ew6+86zLMPhOV7o7vspELtKR5cB3ZUrg4mzrbkhMlnJ7+vUHpxbBbb+LAsOWJAPeXega/hnq7k64hz8EHVgB7mwbMh76G2wfl/i9cEre/yFejTsnTk/U7Ug2CDXPQEgxXY+Z+kBIKnMiEdiB9sgQ0gtNg1ZASsA/osZEoqUzQuam7bqD187L8PhGLptvwZs3RgsKEn3S8uPMzrvRhsMOK6qbIlbWE5Bk0i5GDQgqi1H1yaDR1tAXrLhuAIbJVqZxn1F7QowIRmTi4HL45IciBRB/uDerwF9X071FAUw/FOzD6wUA7YCnybEBcHz1xO92Fua2u24z2JpwOTsVheF0fHL6FvAfsCZr2g3p2Ov3GbMjCV7nXgG9SxkNlD8AG17sANCFJB90nL5EFqFKjxhmIImgJ+tg40e4lB2dAqLRg7KPdY0pUeWk2x0ziqyIFYqEXak9GITHHLV9xSyVhYtxjFf6PJFy/2xJsXlAcLuKREyqcLSKo+BzRlSsk1KqOGlZrWyHsW/JeP8GA5Vqax+W158nHXrARlmxZN92UkPblx/nPGqUHWj8SZdJdjqPgjHB6+VHNt1dV1sELpf/+rvDhrFv3JuRU66Y9H6+evqLKOoLMBFiSA8MuHFOA8HTXBCyhHKARoVmBSdvuWFFcx2WfXbpD81GLXoi6UbWCGPqXEPchjT4ji2TBY0/4wG6ZuAZ88AYIKXmxDbsPUGt0BVwniLRqJNdRrrK1BAzWjTW720scrdl6ekn3JYJ8pp9EsAi5241sKY5Bua467mhkYVmhgTuCpp/2rCKewlX14bmsyG/HXqK48IEywm6AGVKkx7M3fpwUk6u8zHsYKV6zSfjxVNRpDuztCm8ZGHEzrJjCYrB4Da0E5owqDTsNt9vrd6Zu3s35szS7eXcxyQJilET6DG9SBotpy9j2z75NhU3jUApF8XVsi9rBDP7S/Rjir1RX7t0CahC/G44M8vhBKqthQCfMuLjs/fl9AtGnwMzehieNlnsSazELquC6Mx98ZXL6OPBz9ACUvWPy+Mm64e9rzu9PjFb7lSrzTz9NNPVDWePbio5srWUle2Azpmqg7PxsfpN3Bh3m8OpoOX3hxcX7w/zJ4eXd5983fAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Billing information for the invoice recipient.
    /// </summary>
    [DataContract]
    public class BillingInfo {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public BillingInfo() {}

        /// <summary>
        /// Additional information, such as business hours.
        /// </summary>
        [DataMember(Name="additional_info", EmitDefaultValue = false)]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Base Address object used as billing address in a payment or extended for Shipping Address.
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// The invoice recipient company business name.
        /// </summary>
        [DataMember(Name="business_name", EmitDefaultValue = false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// REQUIRED
        /// The invoice recipient email address.<blockquote><strong>Note:</strong>Before you get a QR code, you must create an invoice that specifies `qrinvoice@paypal.com `as the recipient email address in the `billing_info` object. Use a customer email address only if you want to email the invoice.</blockquote>
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The invoice recipient first name.
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The language in which an email can be sent to the recipient. Used only when the recipient lacks a PayPal account.
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The invoice recipient last name.
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The preferred notification channel for the recipient. Default is `EMAIL`. For `SMS`, a `phone` value is required.
        /// </summary>
        [DataMember(Name="notification_channel", EmitDefaultValue = false)]
        public string NotificationChannel { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue = false)]
        public Phone Phone { get; set; }
    }
}
