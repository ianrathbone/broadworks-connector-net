using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccountAuthorizationCodesGetListRequest.
    /// <see cref="GroupAccountAuthorizationCodesGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""65df37199ec43e5d21a187db39d63158:141""}]")]
    public class GroupAccountAuthorizationCodesGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeEntry> _codeEntry = new List<BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeEntry>();

        [XmlElement(ElementName = "codeEntry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"65df37199ec43e5d21a187db39d63158:141")]
        public List<BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeEntry> CodeEntry
        {
            get => _codeEntry;
            set
            {
                CodeEntrySpecified = true;
                _codeEntry = value;
            }
        }

        [XmlIgnore]
        protected bool CodeEntrySpecified { get; set; }

    }
}
