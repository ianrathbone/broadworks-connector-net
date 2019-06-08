using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigRebuildDeviceConfigFileRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _deviceName;

    [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
    public string DeviceName {
        get => _deviceName;
        set {
            DeviceNameSpecified = true;
            _deviceName = value;
        }
    }

    [XmlIgnore]
    public bool DeviceNameSpecified { get; set; }
    private bool _force;

    [XmlElement(ElementName = "force", IsNullable = false, Namespace = "")]
    public bool Force {
        get => _force;
        set {
            ForceSpecified = true;
            _force = value;
        }
    }

    [XmlIgnore]
    public bool ForceSpecified { get; set; }
}
}
