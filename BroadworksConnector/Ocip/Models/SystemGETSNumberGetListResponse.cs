using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSNumberGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _reservedNumberTable;

    [XmlElement(ElementName = "reservedNumberTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ReservedNumberTable {
        get => _reservedNumberTable;
        set {
            ReservedNumberTableSpecified = true;
            _reservedNumberTable = value;
        }
    }

    [XmlIgnore]
    public bool ReservedNumberTableSpecified { get; set; }
}
}
