using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserShInterfaceGetUserIdDataResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry21sp1> _entry;

    [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry21sp1> Entry {
        get => _entry;
        set {
            EntrySpecified = true;
            _entry = value;
        }
    }

    [XmlIgnore]
    public bool EntrySpecified { get; set; }
}
}
