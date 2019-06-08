using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.EnhancedCallLogsCallLogsRequestType _callLogType;

    [XmlElement(ElementName = "callLogType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnhancedCallLogsCallLogsRequestType CallLogType {
        get => _callLogType;
        set {
            CallLogTypeSpecified = true;
            _callLogType = value;
        }
    }

    [XmlIgnore]
    public bool CallLogTypeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EnhancedCallLogsTimeRange _dateTimeRange;

    [XmlElement(ElementName = "dateTimeRange", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnhancedCallLogsTimeRange DateTimeRange {
        get => _dateTimeRange;
        set {
            DateTimeRangeSpecified = true;
            _dateTimeRange = value;
        }
    }

    [XmlIgnore]
    public bool DateTimeRangeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EnhancedCallLogsNumberFilter _numberFilter;

    [XmlElement(ElementName = "numberFilter", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnhancedCallLogsNumberFilter NumberFilter {
        get => _numberFilter;
        set {
            NumberFilterSpecified = true;
            _numberFilter = value;
        }
    }

    [XmlIgnore]
    public bool NumberFilterSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EnhancedCallLogsRedirectedNumberFilter _redirectedNumberFilter;

    [XmlElement(ElementName = "redirectedNumberFilter", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnhancedCallLogsRedirectedNumberFilter RedirectedNumberFilter {
        get => _redirectedNumberFilter;
        set {
            RedirectedNumberFilterSpecified = true;
            _redirectedNumberFilter = value;
        }
    }

    [XmlIgnore]
    public bool RedirectedNumberFilterSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EnhancedCallLogsAccountAuthorizationCodeFilter _accountAuthorizationCodeFilter;

    [XmlElement(ElementName = "accountAuthorizationCodeFilter", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnhancedCallLogsAccountAuthorizationCodeFilter AccountAuthorizationCodeFilter {
        get => _accountAuthorizationCodeFilter;
        set {
            AccountAuthorizationCodeFilterSpecified = true;
            _accountAuthorizationCodeFilter = value;
        }
    }

    [XmlIgnore]
    public bool AccountAuthorizationCodeFilterSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EnhancedCallLogsSubscriberType _subscriberType;

    [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnhancedCallLogsSubscriberType SubscriberType {
        get => _subscriberType;
        set {
            SubscriberTypeSpecified = true;
            _subscriberType = value;
        }
    }

    [XmlIgnore]
    public bool SubscriberTypeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

    [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl {
        get => _responsePagingControl;
        set {
            ResponsePagingControlSpecified = true;
            _responsePagingControl = value;
        }
    }

    [XmlIgnore]
    public bool ResponsePagingControlSpecified { get; set; }
}
}
