using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _deviceType;

    [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
    public string DeviceType {
        get => _deviceType;
        set {
            DeviceTypeSpecified = true;
            _deviceType = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeSpecified { get; set; }
    private bool _isObsolete;

    [XmlElement(ElementName = "isObsolete", IsNullable = false, Namespace = "")]
    public bool IsObsolete {
        get => _isObsolete;
        set {
            IsObsoleteSpecified = true;
            _isObsolete = value;
        }
    }

    [XmlIgnore]
    public bool IsObsoleteSpecified { get; set; }
    private bool _registrationCapable;

    [XmlElement(ElementName = "registrationCapable", IsNullable = false, Namespace = "")]
    public bool RegistrationCapable {
        get => _registrationCapable;
        set {
            RegistrationCapableSpecified = true;
            _registrationCapable = value;
        }
    }

    [XmlIgnore]
    public bool RegistrationCapableSpecified { get; set; }
    private bool _authenticationOverride;

    [XmlElement(ElementName = "authenticationOverride", IsNullable = false, Namespace = "")]
    public bool AuthenticationOverride {
        get => _authenticationOverride;
        set {
            AuthenticationOverrideSpecified = true;
            _authenticationOverride = value;
        }
    }

    [XmlIgnore]
    public bool AuthenticationOverrideSpecified { get; set; }
    private bool _rFC3264Hold;

    [XmlElement(ElementName = "RFC3264Hold", IsNullable = false, Namespace = "")]
    public bool RFC3264Hold {
        get => _rFC3264Hold;
        set {
            RFC3264HoldSpecified = true;
            _rFC3264Hold = value;
        }
    }

    [XmlIgnore]
    public bool RFC3264HoldSpecified { get; set; }
    private bool _isTrusted;

    [XmlElement(ElementName = "isTrusted", IsNullable = false, Namespace = "")]
    public bool IsTrusted {
        get => _isTrusted;
        set {
            IsTrustedSpecified = true;
            _isTrusted = value;
        }
    }

    [XmlIgnore]
    public bool IsTrustedSpecified { get; set; }
    private bool _e164Capable;

    [XmlElement(ElementName = "E164Capable", IsNullable = false, Namespace = "")]
    public bool E164Capable {
        get => _e164Capable;
        set {
            E164CapableSpecified = true;
            _e164Capable = value;
        }
    }

    [XmlIgnore]
    public bool E164CapableSpecified { get; set; }
    private bool _routeAdvance;

    [XmlElement(ElementName = "routeAdvance", IsNullable = false, Namespace = "")]
    public bool RouteAdvance {
        get => _routeAdvance;
        set {
            RouteAdvanceSpecified = true;
            _routeAdvance = value;
        }
    }

    [XmlIgnore]
    public bool RouteAdvanceSpecified { get; set; }
    private bool _forwardingOverride;

    [XmlElement(ElementName = "forwardingOverride", IsNullable = false, Namespace = "")]
    public bool ForwardingOverride {
        get => _forwardingOverride;
        set {
            ForwardingOverrideSpecified = true;
            _forwardingOverride = value;
        }
    }

    [XmlIgnore]
    public bool ForwardingOverrideSpecified { get; set; }
    private bool _wirelessIntegration;

    [XmlElement(ElementName = "wirelessIntegration", IsNullable = false, Namespace = "")]
    public bool WirelessIntegration {
        get => _wirelessIntegration;
        set {
            WirelessIntegrationSpecified = true;
            _wirelessIntegration = value;
        }
    }

    [XmlIgnore]
    public bool WirelessIntegrationSpecified { get; set; }
    private string _webBasedConfigURL;

    [XmlElement(ElementName = "webBasedConfigURL", IsNullable = true, Namespace = "")]
    public string WebBasedConfigURL {
        get => _webBasedConfigURL;
        set {
            WebBasedConfigURLSpecified = true;
            _webBasedConfigURL = value;
        }
    }

    [XmlIgnore]
    public bool WebBasedConfigURLSpecified { get; set; }
    private bool _isVideoCapable;

    [XmlElement(ElementName = "isVideoCapable", IsNullable = false, Namespace = "")]
    public bool IsVideoCapable {
        get => _isVideoCapable;
        set {
            IsVideoCapableSpecified = true;
            _isVideoCapable = value;
        }
    }

    [XmlIgnore]
    public bool IsVideoCapableSpecified { get; set; }
    private bool _pBXIntegration;

    [XmlElement(ElementName = "PBXIntegration", IsNullable = false, Namespace = "")]
    public bool PBXIntegration {
        get => _pBXIntegration;
        set {
            PBXIntegrationSpecified = true;
            _pBXIntegration = value;
        }
    }

    [XmlIgnore]
    public bool PBXIntegrationSpecified { get; set; }
    private bool _useBusinessTrunkingContact;

    [XmlElement(ElementName = "useBusinessTrunkingContact", IsNullable = false, Namespace = "")]
    public bool UseBusinessTrunkingContact {
        get => _useBusinessTrunkingContact;
        set {
            UseBusinessTrunkingContactSpecified = true;
            _useBusinessTrunkingContact = value;
        }
    }

    [XmlIgnore]
    public bool UseBusinessTrunkingContactSpecified { get; set; }
    private bool _staticRegistrationCapable;

    [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
    public bool StaticRegistrationCapable {
        get => _staticRegistrationCapable;
        set {
            StaticRegistrationCapableSpecified = true;
            _staticRegistrationCapable = value;
        }
    }

    [XmlIgnore]
    public bool StaticRegistrationCapableSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CPEDeviceModifyOptions _cpeDeviceOptions;

    [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CPEDeviceModifyOptions CpeDeviceOptions {
        get => _cpeDeviceOptions;
        set {
            CpeDeviceOptionsSpecified = true;
            _cpeDeviceOptions = value;
        }
    }

    [XmlIgnore]
    public bool CpeDeviceOptionsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EarlyMediaSupportType _earlyMediaSupport;

    [XmlElement(ElementName = "earlyMediaSupport", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EarlyMediaSupportType EarlyMediaSupport {
        get => _earlyMediaSupport;
        set {
            EarlyMediaSupportSpecified = true;
            _earlyMediaSupport = value;
        }
    }

    [XmlIgnore]
    public bool EarlyMediaSupportSpecified { get; set; }
}
}
