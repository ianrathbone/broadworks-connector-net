using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceMonitorParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _pollingIntervalMinutes;

    [XmlElement(ElementName = "pollingIntervalMinutes", IsNullable = false, Namespace = "")]
    public int PollingIntervalMinutes {
        get => _pollingIntervalMinutes;
        set {
            PollingIntervalMinutesSpecified = true;
            _pollingIntervalMinutes = value;
        }
    }

    [XmlIgnore]
    public bool PollingIntervalMinutesSpecified { get; set; }
}
}
