using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetInstanceQueueStatusResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _numberOfCallsQueuedNow;

    [XmlElement(ElementName = "numberOfCallsQueuedNow", IsNullable = false, Namespace = "")]
    public int NumberOfCallsQueuedNow {
        get => _numberOfCallsQueuedNow;
        set {
            NumberOfCallsQueuedNowSpecified = true;
            _numberOfCallsQueuedNow = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfCallsQueuedNowSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _agentsCurrentlyStaffed;

    [XmlElement(ElementName = "agentsCurrentlyStaffed", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AgentsCurrentlyStaffed {
        get => _agentsCurrentlyStaffed;
        set {
            AgentsCurrentlyStaffedSpecified = true;
            _agentsCurrentlyStaffed = value;
        }
    }

    [XmlIgnore]
    public bool AgentsCurrentlyStaffedSpecified { get; set; }
}
}