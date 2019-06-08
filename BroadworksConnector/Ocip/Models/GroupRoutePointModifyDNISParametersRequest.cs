using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointModifyDNISParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private bool _displayDNISNumber;

    [XmlElement(ElementName = "displayDNISNumber", IsNullable = false, Namespace = "")]
    public bool DisplayDNISNumber {
        get => _displayDNISNumber;
        set {
            DisplayDNISNumberSpecified = true;
            _displayDNISNumber = value;
        }
    }

    [XmlIgnore]
    public bool DisplayDNISNumberSpecified { get; set; }
    private bool _displayDNISName;

    [XmlElement(ElementName = "displayDNISName", IsNullable = false, Namespace = "")]
    public bool DisplayDNISName {
        get => _displayDNISName;
        set {
            DisplayDNISNameSpecified = true;
            _displayDNISName = value;
        }
    }

    [XmlIgnore]
    public bool DisplayDNISNameSpecified { get; set; }
}
}