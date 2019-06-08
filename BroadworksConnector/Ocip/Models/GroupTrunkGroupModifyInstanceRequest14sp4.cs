using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupModifyInstanceRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

    [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey {
        get => _trunkGroupKey;
        set {
            TrunkGroupKeySpecified = true;
            _trunkGroupKey = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupKeySpecified { get; set; }
    private string _newName;

    [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
    public string NewName {
        get => _newName;
        set {
            NewNameSpecified = true;
            _newName = value;
        }
    }

    [XmlIgnore]
    public bool NewNameSpecified { get; set; }
    private string _pilotUserId;

    [XmlElement(ElementName = "pilotUserId", IsNullable = true, Namespace = "")]
    public string PilotUserId {
        get => _pilotUserId;
        set {
            PilotUserIdSpecified = true;
            _pilotUserId = value;
        }
    }

    [XmlIgnore]
    public bool PilotUserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DepartmentKey _department;

    [XmlElement(ElementName = "department", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DepartmentKey Department {
        get => _department;
        set {
            DepartmentSpecified = true;
            _department = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

    [XmlElement(ElementName = "accessDevice", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDevice AccessDevice {
        get => _accessDevice;
        set {
            AccessDeviceSpecified = true;
            _accessDevice = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceSpecified { get; set; }
    private int _maxActiveCalls;

    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
    public int MaxActiveCalls {
        get => _maxActiveCalls;
        set {
            MaxActiveCallsSpecified = true;
            _maxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxActiveCallsSpecified { get; set; }
    private int? _maxIncomingCalls;

    [XmlElement(ElementName = "maxIncomingCalls", IsNullable = true, Namespace = "")]
    public int? MaxIncomingCalls {
        get => _maxIncomingCalls;
        set {
            MaxIncomingCallsSpecified = true;
            _maxIncomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxIncomingCallsSpecified { get; set; }
    private int? _maxOutgoingCalls;

    [XmlElement(ElementName = "maxOutgoingCalls", IsNullable = true, Namespace = "")]
    public int? MaxOutgoingCalls {
        get => _maxOutgoingCalls;
        set {
            MaxOutgoingCallsSpecified = true;
            _maxOutgoingCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxOutgoingCallsSpecified { get; set; }
    private bool _enableBursting;

    [XmlElement(ElementName = "enableBursting", IsNullable = false, Namespace = "")]
    public bool EnableBursting {
        get => _enableBursting;
        set {
            EnableBurstingSpecified = true;
            _enableBursting = value;
        }
    }

    [XmlIgnore]
    public bool EnableBurstingSpecified { get; set; }
    private int? _burstingMaxActiveCalls;

    [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = true, Namespace = "")]
    public int? BurstingMaxActiveCalls {
        get => _burstingMaxActiveCalls;
        set {
            BurstingMaxActiveCallsSpecified = true;
            _burstingMaxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxActiveCallsSpecified { get; set; }
    private int? _burstingMaxIncomingCalls;

    [XmlElement(ElementName = "burstingMaxIncomingCalls", IsNullable = true, Namespace = "")]
    public int? BurstingMaxIncomingCalls {
        get => _burstingMaxIncomingCalls;
        set {
            BurstingMaxIncomingCallsSpecified = true;
            _burstingMaxIncomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxIncomingCallsSpecified { get; set; }
    private int? _burstingMaxOutgoingCalls;

    [XmlElement(ElementName = "burstingMaxOutgoingCalls", IsNullable = true, Namespace = "")]
    public int? BurstingMaxOutgoingCalls {
        get => _burstingMaxOutgoingCalls;
        set {
            BurstingMaxOutgoingCallsSpecified = true;
            _burstingMaxOutgoingCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxOutgoingCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupCapacityExceededAction? _capacityExceededAction;

    [XmlElement(ElementName = "capacityExceededAction", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupCapacityExceededAction? CapacityExceededAction {
        get => _capacityExceededAction;
        set {
            CapacityExceededActionSpecified = true;
            _capacityExceededAction = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededActionSpecified { get; set; }
    private string _capacityExceededForwardAddress;

    [XmlElement(ElementName = "capacityExceededForwardAddress", IsNullable = true, Namespace = "")]
    public string CapacityExceededForwardAddress {
        get => _capacityExceededForwardAddress;
        set {
            CapacityExceededForwardAddressSpecified = true;
            _capacityExceededForwardAddress = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededForwardAddressSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupKey _capacityExceededRerouteTrunkGroupKey;

    [XmlElement(ElementName = "capacityExceededRerouteTrunkGroupKey", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupKey CapacityExceededRerouteTrunkGroupKey {
        get => _capacityExceededRerouteTrunkGroupKey;
        set {
            CapacityExceededRerouteTrunkGroupKeySpecified = true;
            _capacityExceededRerouteTrunkGroupKey = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededRerouteTrunkGroupKeySpecified { get; set; }
    private int _capacityExceededTrapInitialCalls;

    [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false, Namespace = "")]
    public int CapacityExceededTrapInitialCalls {
        get => _capacityExceededTrapInitialCalls;
        set {
            CapacityExceededTrapInitialCallsSpecified = true;
            _capacityExceededTrapInitialCalls = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededTrapInitialCallsSpecified { get; set; }
    private int _capacityExceededTrapOffsetCalls;

    [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false, Namespace = "")]
    public int CapacityExceededTrapOffsetCalls {
        get => _capacityExceededTrapOffsetCalls;
        set {
            CapacityExceededTrapOffsetCallsSpecified = true;
            _capacityExceededTrapOffsetCalls = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededTrapOffsetCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction? _unreachableDestinationAction;

    [XmlElement(ElementName = "unreachableDestinationAction", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction? UnreachableDestinationAction {
        get => _unreachableDestinationAction;
        set {
            UnreachableDestinationActionSpecified = true;
            _unreachableDestinationAction = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationActionSpecified { get; set; }
    private string _unreachableDestinationForwardAddress;

    [XmlElement(ElementName = "unreachableDestinationForwardAddress", IsNullable = true, Namespace = "")]
    public string UnreachableDestinationForwardAddress {
        get => _unreachableDestinationForwardAddress;
        set {
            UnreachableDestinationForwardAddressSpecified = true;
            _unreachableDestinationForwardAddress = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationForwardAddressSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupKey _unreachableDestinationRerouteTrunkGroupKey;

    [XmlElement(ElementName = "unreachableDestinationRerouteTrunkGroupKey", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupKey UnreachableDestinationRerouteTrunkGroupKey {
        get => _unreachableDestinationRerouteTrunkGroupKey;
        set {
            UnreachableDestinationRerouteTrunkGroupKeySpecified = true;
            _unreachableDestinationRerouteTrunkGroupKey = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationRerouteTrunkGroupKeySpecified { get; set; }
    private int _unreachableDestinationTrapInitialCalls;

    [XmlElement(ElementName = "unreachableDestinationTrapInitialCalls", IsNullable = false, Namespace = "")]
    public int UnreachableDestinationTrapInitialCalls {
        get => _unreachableDestinationTrapInitialCalls;
        set {
            UnreachableDestinationTrapInitialCallsSpecified = true;
            _unreachableDestinationTrapInitialCalls = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationTrapInitialCallsSpecified { get; set; }
    private int _unreachableDestinationTrapOffsetCalls;

    [XmlElement(ElementName = "unreachableDestinationTrapOffsetCalls", IsNullable = false, Namespace = "")]
    public int UnreachableDestinationTrapOffsetCalls {
        get => _unreachableDestinationTrapOffsetCalls;
        set {
            UnreachableDestinationTrapOffsetCallsSpecified = true;
            _unreachableDestinationTrapOffsetCalls = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationTrapOffsetCallsSpecified { get; set; }
    private int _invitationTimeout;

    [XmlElement(ElementName = "invitationTimeout", IsNullable = false, Namespace = "")]
    public int InvitationTimeout {
        get => _invitationTimeout;
        set {
            InvitationTimeoutSpecified = true;
            _invitationTimeout = value;
        }
    }

    [XmlIgnore]
    public bool InvitationTimeoutSpecified { get; set; }
    private bool _requireAuthentication;

    [XmlElement(ElementName = "requireAuthentication", IsNullable = false, Namespace = "")]
    public bool RequireAuthentication {
        get => _requireAuthentication;
        set {
            RequireAuthenticationSpecified = true;
            _requireAuthentication = value;
        }
    }

    [XmlIgnore]
    public bool RequireAuthenticationSpecified { get; set; }
    private string _sipAuthenticationUserName;

    [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = true, Namespace = "")]
    public string SipAuthenticationUserName {
        get => _sipAuthenticationUserName;
        set {
            SipAuthenticationUserNameSpecified = true;
            _sipAuthenticationUserName = value;
        }
    }

    [XmlIgnore]
    public bool SipAuthenticationUserNameSpecified { get; set; }
    private string _sipAuthenticationPassword;

    [XmlElement(ElementName = "sipAuthenticationPassword", IsNullable = true, Namespace = "")]
    public string SipAuthenticationPassword {
        get => _sipAuthenticationPassword;
        set {
            SipAuthenticationPasswordSpecified = true;
            _sipAuthenticationPassword = value;
        }
    }

    [XmlIgnore]
    public bool SipAuthenticationPasswordSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _hostedUserIdList;

    [XmlElement(ElementName = "hostedUserIdList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementUserIdList HostedUserIdList {
        get => _hostedUserIdList;
        set {
            HostedUserIdListSpecified = true;
            _hostedUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool HostedUserIdListSpecified { get; set; }
    private string _trunkGroupIdentity;

    [XmlElement(ElementName = "trunkGroupIdentity", IsNullable = true, Namespace = "")]
    public string TrunkGroupIdentity {
        get => _trunkGroupIdentity;
        set {
            TrunkGroupIdentitySpecified = true;
            _trunkGroupIdentity = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupIdentitySpecified { get; set; }
    private string _otgDtgIdentity;

    [XmlElement(ElementName = "otgDtgIdentity", IsNullable = true, Namespace = "")]
    public string OtgDtgIdentity {
        get => _otgDtgIdentity;
        set {
            OtgDtgIdentitySpecified = true;
            _otgDtgIdentity = value;
        }
    }

    [XmlIgnore]
    public bool OtgDtgIdentitySpecified { get; set; }
    private bool _includeTrunkGroupIdentity;

    [XmlElement(ElementName = "includeTrunkGroupIdentity", IsNullable = false, Namespace = "")]
    public bool IncludeTrunkGroupIdentity {
        get => _includeTrunkGroupIdentity;
        set {
            IncludeTrunkGroupIdentitySpecified = true;
            _includeTrunkGroupIdentity = value;
        }
    }

    [XmlIgnore]
    public bool IncludeTrunkGroupIdentitySpecified { get; set; }
    private bool _includeDtgIdentity;

    [XmlElement(ElementName = "includeDtgIdentity", IsNullable = false, Namespace = "")]
    public bool IncludeDtgIdentity {
        get => _includeDtgIdentity;
        set {
            IncludeDtgIdentitySpecified = true;
            _includeDtgIdentity = value;
        }
    }

    [XmlIgnore]
    public bool IncludeDtgIdentitySpecified { get; set; }
    private bool _enableNetworkAddressIdentity;

    [XmlElement(ElementName = "enableNetworkAddressIdentity", IsNullable = false, Namespace = "")]
    public bool EnableNetworkAddressIdentity {
        get => _enableNetworkAddressIdentity;
        set {
            EnableNetworkAddressIdentitySpecified = true;
            _enableNetworkAddressIdentity = value;
        }
    }

    [XmlIgnore]
    public bool EnableNetworkAddressIdentitySpecified { get; set; }
    private bool _allowUnscreenedCalls;

    [XmlElement(ElementName = "allowUnscreenedCalls", IsNullable = false, Namespace = "")]
    public bool AllowUnscreenedCalls {
        get => _allowUnscreenedCalls;
        set {
            AllowUnscreenedCallsSpecified = true;
            _allowUnscreenedCalls = value;
        }
    }

    [XmlIgnore]
    public bool AllowUnscreenedCallsSpecified { get; set; }
    private bool _allowUnscreenedEmergencyCalls;

    [XmlElement(ElementName = "allowUnscreenedEmergencyCalls", IsNullable = false, Namespace = "")]
    public bool AllowUnscreenedEmergencyCalls {
        get => _allowUnscreenedEmergencyCalls;
        set {
            AllowUnscreenedEmergencyCallsSpecified = true;
            _allowUnscreenedEmergencyCalls = value;
        }
    }

    [XmlIgnore]
    public bool AllowUnscreenedEmergencyCallsSpecified { get; set; }
    private bool _usePilotUserCallingLineIdentity;

    [XmlElement(ElementName = "usePilotUserCallingLineIdentity", IsNullable = false, Namespace = "")]
    public bool UsePilotUserCallingLineIdentity {
        get => _usePilotUserCallingLineIdentity;
        set {
            UsePilotUserCallingLineIdentitySpecified = true;
            _usePilotUserCallingLineIdentity = value;
        }
    }

    [XmlIgnore]
    public bool UsePilotUserCallingLineIdentitySpecified { get; set; }
    private bool _usePilotUserChargeNumber;

    [XmlElement(ElementName = "usePilotUserChargeNumber", IsNullable = false, Namespace = "")]
    public bool UsePilotUserChargeNumber {
        get => _usePilotUserChargeNumber;
        set {
            UsePilotUserChargeNumberSpecified = true;
            _usePilotUserChargeNumber = value;
        }
    }

    [XmlIgnore]
    public bool UsePilotUserChargeNumberSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction? _callForwardingAlwaysAction;

    [XmlElement(ElementName = "callForwardingAlwaysAction", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction? CallForwardingAlwaysAction {
        get => _callForwardingAlwaysAction;
        set {
            CallForwardingAlwaysActionSpecified = true;
            _callForwardingAlwaysAction = value;
        }
    }

    [XmlIgnore]
    public bool CallForwardingAlwaysActionSpecified { get; set; }
    private string _callForwardingAlwaysForwardAddress;

    [XmlElement(ElementName = "callForwardingAlwaysForwardAddress", IsNullable = true, Namespace = "")]
    public string CallForwardingAlwaysForwardAddress {
        get => _callForwardingAlwaysForwardAddress;
        set {
            CallForwardingAlwaysForwardAddressSpecified = true;
            _callForwardingAlwaysForwardAddress = value;
        }
    }

    [XmlIgnore]
    public bool CallForwardingAlwaysForwardAddressSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupKey _callForwardingAlwaysRerouteTrunkGroupKey;

    [XmlElement(ElementName = "callForwardingAlwaysRerouteTrunkGroupKey", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupKey CallForwardingAlwaysRerouteTrunkGroupKey {
        get => _callForwardingAlwaysRerouteTrunkGroupKey;
        set {
            CallForwardingAlwaysRerouteTrunkGroupKeySpecified = true;
            _callForwardingAlwaysRerouteTrunkGroupKey = value;
        }
    }

    [XmlIgnore]
    public bool CallForwardingAlwaysRerouteTrunkGroupKeySpecified { get; set; }
}
}