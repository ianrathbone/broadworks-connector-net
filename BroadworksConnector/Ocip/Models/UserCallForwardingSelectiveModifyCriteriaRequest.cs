using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallForwardingSelectiveModifyCriteriaRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private string _criteriaName;

    [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
    public string CriteriaName {
        get => _criteriaName;
        set {
            CriteriaNameSpecified = true;
            _criteriaName = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaNameSpecified { get; set; }
    private string _newCriteriaName;

    [XmlElement(ElementName = "newCriteriaName", IsNullable = false, Namespace = "")]
    public string NewCriteriaName {
        get => _newCriteriaName;
        set {
            NewCriteriaNameSpecified = true;
            _newCriteriaName = value;
        }
    }

    [XmlIgnore]
    public bool NewCriteriaNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

    [XmlElement(ElementName = "timeSchedule", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TimeSchedule TimeSchedule {
        get => _timeSchedule;
        set {
            TimeScheduleSpecified = true;
            _timeSchedule = value;
        }
    }

    [XmlIgnore]
    public bool TimeScheduleSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.CallForwardingSelectiveNumberSelection16 _forwardToNumberSelection;

    [XmlElement(ElementName = "forwardToNumberSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallForwardingSelectiveNumberSelection16 ForwardToNumberSelection {
        get => _forwardToNumberSelection;
        set {
            ForwardToNumberSelectionSpecified = true;
            _forwardToNumberSelection = value;
        }
    }

    [XmlIgnore]
    public bool ForwardToNumberSelectionSpecified { get; set; }
    private string _forwardToPhoneNumber;

    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true, Namespace = "")]
    public string ForwardToPhoneNumber {
        get => _forwardToPhoneNumber;
        set {
            ForwardToPhoneNumberSpecified = true;
            _forwardToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool ForwardToPhoneNumberSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CriteriaFromDnModify _fromDnCriteria;

    [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CriteriaFromDnModify FromDnCriteria {
        get => _fromDnCriteria;
        set {
            FromDnCriteriaSpecified = true;
            _fromDnCriteria = value;
        }
    }

    [XmlIgnore]
    public bool FromDnCriteriaSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementCallToNumberList _callToNumberList;

    [XmlElement(ElementName = "callToNumberList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementCallToNumberList CallToNumberList {
        get => _callToNumberList;
        set {
            CallToNumberListSpecified = true;
            _callToNumberList = value;
        }
    }

    [XmlIgnore]
    public bool CallToNumberListSpecified { get; set; }
}
}
