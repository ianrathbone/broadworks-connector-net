using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Communication Barring CallMeNow Rules that replaces a
    /// previously configured list. By convention, an element of this type
    /// may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18609""}]")]
    public class ReplacementCommunicationBarringCallMeNowRuleList
    {

        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowRule> _rule = new List<BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowRule>();

        [XmlElement(ElementName = "rule", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18609")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowRule> Rule
        {
            get => _rule;
            set
            {
                RuleSpecified = true;
                _rule = value;
            }
        }

        [XmlIgnore]
        protected bool RuleSpecified { get; set; }

    }
}
