// This class was generated on Mon, 08 Jan 2018 16:45:05 CST by version 0.1 of Braintree SDK Generator
// TemplateSettings.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yRT0sDQQzF736KMOdFPPcmeBHxD1q8iLTpTrYTmM2MmZSySL+7bP+6rIJgj/OSSX4v79NNu0xu4qbU5ohG8EJmLMviKveKyriI9IBt3+Iqd0fd6XFDpVbOxkn6AYHADkPKfsilq9y1Kna7LVeVeyb0jxI7N2kwFuqFjxUr+aPwpCmTGlNxk7ff+eCeDD0ajkE9lxyxm2WlhpSkpgH6j+U/mIF2v/F8rhYpRUIZWwjsPckA+ygNUW/Fc41GBdaBLJCCBS7QMEUPXGD37b/Isopx876pjuTFlGU5Bt/unUn/+A4/kMe33tH2ZWiSAkp3MCAwPwQx628/3zasA9cBLEGLGeqkSiUn8SxL2KcLp3TLmcxffAEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// The template settings.
    /// </summary>
    [DataContract]
    public class TemplateSettings {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TemplateSettings() {}

        /// <summary>
        /// The template settings metadata.
        /// </summary>
        [DataMember(Name="display_preference", EmitDefaultValue = false)]
        public TemplateSettingsMetadata DisplayPreference { get; set; }

        /// <summary>
        /// The field name for any field in `template_data` for which to map corresponding display preferences.
        /// </summary>
        [DataMember(Name="field_name", EmitDefaultValue = false)]
        public string FieldName { get; set; }
    }
}

