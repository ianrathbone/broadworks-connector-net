using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementEnterpriseTrunkTrunkGroupKeyList 
{
    private List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> _trunkGroupList;

    [XmlElement(ElementName = "trunkGroupList", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> TrunkGroupList {
        get => _trunkGroupList;
        set {
            TrunkGroupListSpecified = true;
            _trunkGroupList = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupListSpecified { get; set; }
}
}