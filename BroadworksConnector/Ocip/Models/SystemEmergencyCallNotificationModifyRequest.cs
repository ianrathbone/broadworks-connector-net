using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemEmergencyCallNotificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _defaultFromAddress;

    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
    public string DefaultFromAddress {
        get => _defaultFromAddress;
        set {
            DefaultFromAddressSpecified = true;
            _defaultFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool DefaultFromAddressSpecified { get; set; }
}
}