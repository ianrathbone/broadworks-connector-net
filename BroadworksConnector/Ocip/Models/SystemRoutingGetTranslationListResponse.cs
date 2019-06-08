using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingGetTranslationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _routingTable;

    [XmlElement(ElementName = "routingTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable RoutingTable {
        get => _routingTable;
        set {
            RoutingTableSpecified = true;
            _routingTable = value;
        }
    }

    [XmlIgnore]
    public bool RoutingTableSpecified { get; set; }
}
}
