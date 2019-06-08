using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSResourcePriorityGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _resourcePriorityTable;

    [XmlElement(ElementName = "resourcePriorityTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ResourcePriorityTable {
        get => _resourcePriorityTable;
        set {
            ResourcePriorityTableSpecified = true;
            _resourcePriorityTable = value;
        }
    }

    [XmlIgnore]
    public bool ResourcePriorityTableSpecified { get; set; }
}
}