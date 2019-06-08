using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupScheduleGetEventDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.ScheduleEvents> _scheduleEventsList;

    [XmlElement(ElementName = "scheduleEventsList", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ScheduleEvents> ScheduleEventsList {
        get => _scheduleEventsList;
        set {
            ScheduleEventsListSpecified = true;
            _scheduleEventsList = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleEventsListSpecified { get; set; }
}
}