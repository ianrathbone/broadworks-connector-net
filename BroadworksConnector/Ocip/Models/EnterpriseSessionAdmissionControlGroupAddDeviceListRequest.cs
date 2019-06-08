using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseSessionAdmissionControlGroupAddDeviceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> _devices;

    [XmlElement(ElementName = "devices", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> Devices {
        get => _devices;
        set {
            DevicesSpecified = true;
            _devices = value;
        }
    }

    [XmlIgnore]
    public bool DevicesSpecified { get; set; }
}
}