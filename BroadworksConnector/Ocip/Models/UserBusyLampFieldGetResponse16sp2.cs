using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBusyLampFieldGetResponse16sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _listURI;

    [XmlElement(ElementName = "listURI", IsNullable = false, Namespace = "")]
    public string ListURI {
        get => _listURI;
        set {
            ListURISpecified = true;
            _listURI = value;
        }
    }

    [XmlIgnore]
    public bool ListURISpecified { get; set; }
    private bool _enableCallParkNotification;

    [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false, Namespace = "")]
    public bool EnableCallParkNotification {
        get => _enableCallParkNotification;
        set {
            EnableCallParkNotificationSpecified = true;
            _enableCallParkNotification = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallParkNotificationSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _monitoredUserTable;

    [XmlElement(ElementName = "monitoredUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable MonitoredUserTable {
        get => _monitoredUserTable;
        set {
            MonitoredUserTableSpecified = true;
            _monitoredUserTable = value;
        }
    }

    [XmlIgnore]
    public bool MonitoredUserTableSpecified { get; set; }
}
}
