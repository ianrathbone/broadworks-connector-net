using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GETSInhibitedAvpCodeKey 
{
    private int _avpCode;

    [XmlElement(ElementName = "avpCode", IsNullable = false, Namespace = "")]
    public int AvpCode {
        get => _avpCode;
        set {
            AvpCodeSpecified = true;
            _avpCode = value;
        }
    }

    [XmlIgnore]
    public bool AvpCodeSpecified { get; set; }
    private int _vendorId;

    [XmlElement(ElementName = "vendorId", IsNullable = false, Namespace = "")]
    public int VendorId {
        get => _vendorId;
        set {
            VendorIdSpecified = true;
            _vendorId = value;
        }
    }

    [XmlIgnore]
    public bool VendorIdSpecified { get; set; }
}
}
