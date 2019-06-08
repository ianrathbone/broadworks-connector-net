using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantGetInstanceResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private bool _enableVideo;

    [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
    public bool EnableVideo {
        get => _enableVideo;
        set {
            EnableVideoSpecified = true;
            _enableVideo = value;
        }
    }

    [XmlIgnore]
    public bool EnableVideoSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TimeSchedule _businessHours;

    [XmlElement(ElementName = "businessHours", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TimeSchedule BusinessHours {
        get => _businessHours;
        set {
            BusinessHoursSpecified = true;
            _businessHours = value;
        }
    }

    [XmlIgnore]
    public bool BusinessHoursSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

    [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule {
        get => _holidaySchedule;
        set {
            HolidayScheduleSpecified = true;
            _holidaySchedule = value;
        }
    }

    [XmlIgnore]
    public bool HolidayScheduleSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope _extensionDialingScope;

    [XmlElement(ElementName = "extensionDialingScope", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope ExtensionDialingScope {
        get => _extensionDialingScope;
        set {
            ExtensionDialingScopeSpecified = true;
            _extensionDialingScope = value;
        }
    }

    [XmlIgnore]
    public bool ExtensionDialingScopeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope _nameDialingScope;

    [XmlElement(ElementName = "nameDialingScope", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope NameDialingScope {
        get => _nameDialingScope;
        set {
            NameDialingScopeSpecified = true;
            _nameDialingScope = value;
        }
    }

    [XmlIgnore]
    public bool NameDialingScopeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantNameDialingEntry _nameDialingEntries;

    [XmlElement(ElementName = "nameDialingEntries", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantNameDialingEntry NameDialingEntries {
        get => _nameDialingEntries;
        set {
            NameDialingEntriesSpecified = true;
            _nameDialingEntries = value;
        }
    }

    [XmlIgnore]
    public bool NameDialingEntriesSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantReadMenu16 _businessHoursMenu;

    [XmlElement(ElementName = "businessHoursMenu", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantReadMenu16 BusinessHoursMenu {
        get => _businessHoursMenu;
        set {
            BusinessHoursMenuSpecified = true;
            _businessHoursMenu = value;
        }
    }

    [XmlIgnore]
    public bool BusinessHoursMenuSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantReadMenu16 _afterHoursMenu;

    [XmlElement(ElementName = "afterHoursMenu", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantReadMenu16 AfterHoursMenu {
        get => _afterHoursMenu;
        set {
            AfterHoursMenuSpecified = true;
            _afterHoursMenu = value;
        }
    }

    [XmlIgnore]
    public bool AfterHoursMenuSpecified { get; set; }
}
}
