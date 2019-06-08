using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPasswordSecurityParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _useExistingHashing;

    [XmlElement(ElementName = "useExistingHashing", IsNullable = false, Namespace = "")]
    public bool UseExistingHashing {
        get => _useExistingHashing;
        set {
            UseExistingHashingSpecified = true;
            _useExistingHashing = value;
        }
    }

    [XmlIgnore]
    public bool UseExistingHashingSpecified { get; set; }
    private bool _enforcePasswordChangeOnExpiry;

    [XmlElement(ElementName = "enforcePasswordChangeOnExpiry", IsNullable = false, Namespace = "")]
    public bool EnforcePasswordChangeOnExpiry {
        get => _enforcePasswordChangeOnExpiry;
        set {
            EnforcePasswordChangeOnExpirySpecified = true;
            _enforcePasswordChangeOnExpiry = value;
        }
    }

    [XmlIgnore]
    public bool EnforcePasswordChangeOnExpirySpecified { get; set; }
}
}
