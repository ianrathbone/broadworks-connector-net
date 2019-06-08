using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantConsolidatedModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel _unassignPhoneNumbers;

    [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel UnassignPhoneNumbers {
        get => _unassignPhoneNumbers;
        set {
            UnassignPhoneNumbersSpecified = true;
            _unassignPhoneNumbers = value;
        }
    }

    [XmlIgnore]
    public bool UnassignPhoneNumbersSpecified { get; set; }
    private bool _addPhoneNumberToGroup;

    [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false, Namespace = "")]
    public bool AddPhoneNumberToGroup {
        get => _addPhoneNumberToGroup;
        set {
            AddPhoneNumberToGroupSpecified = true;
            _addPhoneNumberToGroup = value;
        }
    }

    [XmlIgnore]
    public bool AddPhoneNumberToGroupSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private int _firstDigitTimeoutSeconds;

    [XmlElement(ElementName = "firstDigitTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int FirstDigitTimeoutSeconds {
        get => _firstDigitTimeoutSeconds;
        set {
            FirstDigitTimeoutSecondsSpecified = true;
            _firstDigitTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool FirstDigitTimeoutSecondsSpecified { get; set; }
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

    [XmlElement(ElementName = "businessHours", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "holidaySchedule", IsNullable = true, Namespace = "")]
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
    private BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu20 _businessHoursMenu;

    [XmlElement(ElementName = "businessHoursMenu", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu20 BusinessHoursMenu {
        get => _businessHoursMenu;
        set {
            BusinessHoursMenuSpecified = true;
            _businessHoursMenu = value;
        }
    }

    [XmlIgnore]
    public bool BusinessHoursMenuSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu20 _afterHoursMenu;

    [XmlElement(ElementName = "afterHoursMenu", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu20 AfterHoursMenu {
        get => _afterHoursMenu;
        set {
            AfterHoursMenuSpecified = true;
            _afterHoursMenu = value;
        }
    }

    [XmlIgnore]
    public bool AfterHoursMenuSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu20 _holidayMenu;

    [XmlElement(ElementName = "holidayMenu", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu20 HolidayMenu {
        get => _holidayMenu;
        set {
            HolidayMenuSpecified = true;
            _holidayMenu = value;
        }
    }

    [XmlIgnore]
    public bool HolidayMenuSpecified { get; set; }
    private string _networkClassOfService;

    [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
    public string NetworkClassOfService {
        get => _networkClassOfService;
        set {
            NetworkClassOfServiceSpecified = true;
            _networkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool NetworkClassOfServiceSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList _serviceList;

    [XmlElement(ElementName = "serviceList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList ServiceList {
        get => _serviceList;
        set {
            ServiceListSpecified = true;
            _serviceList = value;
        }
    }

    [XmlIgnore]
    public bool ServiceListSpecified { get; set; }
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
}
}
