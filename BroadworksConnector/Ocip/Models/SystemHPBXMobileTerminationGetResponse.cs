using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHPBXMobileTerminationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _routingPrefix;

    [XmlElement(ElementName = "routingPrefix", IsNullable = false, Namespace = "")]
    public string RoutingPrefix {
        get => _routingPrefix;
        set {
            RoutingPrefixSpecified = true;
            _routingPrefix = value;
        }
    }

    [XmlIgnore]
    public bool RoutingPrefixSpecified { get; set; }
}
}