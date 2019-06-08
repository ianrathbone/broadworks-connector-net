using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseEnterpriseTrunkModifyRequestPriorityWeightedRouting 
{
    private int _maximumRerouteAttemptsWithinPriority;

    [XmlElement(ElementName = "maximumRerouteAttemptsWithinPriority", IsNullable = false, Namespace = "")]
    public int MaximumRerouteAttemptsWithinPriority {
        get => _maximumRerouteAttemptsWithinPriority;
        set {
            MaximumRerouteAttemptsWithinPrioritySpecified = true;
            _maximumRerouteAttemptsWithinPriority = value;
        }
    }

    [XmlIgnore]
    public bool MaximumRerouteAttemptsWithinPrioritySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkPriorityWeightedTrunkGroupList _priorityWeightedTrunkGroupList;

    [XmlElement(ElementName = "priorityWeightedTrunkGroupList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkPriorityWeightedTrunkGroupList PriorityWeightedTrunkGroupList {
        get => _priorityWeightedTrunkGroupList;
        set {
            PriorityWeightedTrunkGroupListSpecified = true;
            _priorityWeightedTrunkGroupList = value;
        }
    }

    [XmlIgnore]
    public bool PriorityWeightedTrunkGroupListSpecified { get; set; }
}
}
