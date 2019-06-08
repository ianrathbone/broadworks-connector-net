using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPolicyGetDefaultResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess _groupCallingPlanAccess;

    [XmlElement(ElementName = "groupCallingPlanAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess GroupCallingPlanAccess {
        get => _groupCallingPlanAccess;
        set {
            GroupCallingPlanAccessSpecified = true;
            _groupCallingPlanAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupCallingPlanAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupExtensionAccess _groupExtensionAccess;

    [XmlElement(ElementName = "groupExtensionAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupExtensionAccess GroupExtensionAccess {
        get => _groupExtensionAccess;
        set {
            GroupExtensionAccessSpecified = true;
            _groupExtensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupExtensionAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupLDAPIntegrationAccess _groupLDAPIntegrationAccess;

    [XmlElement(ElementName = "groupLDAPIntegrationAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupLDAPIntegrationAccess GroupLDAPIntegrationAccess {
        get => _groupLDAPIntegrationAccess;
        set {
            GroupLDAPIntegrationAccessSpecified = true;
            _groupLDAPIntegrationAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupLDAPIntegrationAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess _groupVoiceMessagingAccess;

    [XmlElement(ElementName = "groupVoiceMessagingAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess GroupVoiceMessagingAccess {
        get => _groupVoiceMessagingAccess;
        set {
            GroupVoiceMessagingAccessSpecified = true;
            _groupVoiceMessagingAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupVoiceMessagingAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess _groupDepartmentAdminUserAccess;

    [XmlElement(ElementName = "groupDepartmentAdminUserAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess GroupDepartmentAdminUserAccess {
        get => _groupDepartmentAdminUserAccess;
        set {
            GroupDepartmentAdminUserAccessSpecified = true;
            _groupDepartmentAdminUserAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupDepartmentAdminUserAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess _groupUserAuthenticationAccess;

    [XmlElement(ElementName = "groupUserAuthenticationAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess GroupUserAuthenticationAccess {
        get => _groupUserAuthenticationAccess;
        set {
            GroupUserAuthenticationAccessSpecified = true;
            _groupUserAuthenticationAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupUserAuthenticationAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess _groupUserGroupDirectoryAccess;

    [XmlElement(ElementName = "groupUserGroupDirectoryAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess GroupUserGroupDirectoryAccess {
        get => _groupUserGroupDirectoryAccess;
        set {
            GroupUserGroupDirectoryAccessSpecified = true;
            _groupUserGroupDirectoryAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupUserGroupDirectoryAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupUserProfileAccess _groupUserProfileAccess;

    [XmlElement(ElementName = "groupUserProfileAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupUserProfileAccess GroupUserProfileAccess {
        get => _groupUserProfileAccess;
        set {
            GroupUserProfileAccessSpecified = true;
            _groupUserProfileAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupUserProfileAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess _groupAdminProfileAccess;

    [XmlElement(ElementName = "groupAdminProfileAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess GroupAdminProfileAccess {
        get => _groupAdminProfileAccess;
        set {
            GroupAdminProfileAccessSpecified = true;
            _groupAdminProfileAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminProfileAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminUserAccess _groupAdminUserAccess;

    [XmlElement(ElementName = "groupAdminUserAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminUserAccess GroupAdminUserAccess {
        get => _groupAdminUserAccess;
        set {
            GroupAdminUserAccessSpecified = true;
            _groupAdminUserAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminUserAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess _groupAdminAdminAccess;

    [XmlElement(ElementName = "groupAdminAdminAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess GroupAdminAdminAccess {
        get => _groupAdminAdminAccess;
        set {
            GroupAdminAdminAccessSpecified = true;
            _groupAdminAdminAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminAdminAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess _groupAdminDepartmentAccess;

    [XmlElement(ElementName = "groupAdminDepartmentAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess GroupAdminDepartmentAccess {
        get => _groupAdminDepartmentAccess;
        set {
            GroupAdminDepartmentAccessSpecified = true;
            _groupAdminDepartmentAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminDepartmentAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess _groupAdminAccessDeviceAccess;

    [XmlElement(ElementName = "groupAdminAccessDeviceAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess GroupAdminAccessDeviceAccess {
        get => _groupAdminAccessDeviceAccess;
        set {
            GroupAdminAccessDeviceAccessSpecified = true;
            _groupAdminAccessDeviceAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminAccessDeviceAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess _groupAdminEnhancedServiceInstanceAccess;

    [XmlElement(ElementName = "groupAdminEnhancedServiceInstanceAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess GroupAdminEnhancedServiceInstanceAccess {
        get => _groupAdminEnhancedServiceInstanceAccess;
        set {
            GroupAdminEnhancedServiceInstanceAccessSpecified = true;
            _groupAdminEnhancedServiceInstanceAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminEnhancedServiceInstanceAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess _groupAdminFeatureAccessCodeAccess;

    [XmlElement(ElementName = "groupAdminFeatureAccessCodeAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess GroupAdminFeatureAccessCodeAccess {
        get => _groupAdminFeatureAccessCodeAccess;
        set {
            GroupAdminFeatureAccessCodeAccessSpecified = true;
            _groupAdminFeatureAccessCodeAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminFeatureAccessCodeAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess _groupAdminPhoneNumberExtensionAccess;

    [XmlElement(ElementName = "groupAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess GroupAdminPhoneNumberExtensionAccess {
        get => _groupAdminPhoneNumberExtensionAccess;
        set {
            GroupAdminPhoneNumberExtensionAccessSpecified = true;
            _groupAdminPhoneNumberExtensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminPhoneNumberExtensionAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess _groupAdminServiceAccess;

    [XmlElement(ElementName = "groupAdminServiceAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess GroupAdminServiceAccess {
        get => _groupAdminServiceAccess;
        set {
            GroupAdminServiceAccessSpecified = true;
            _groupAdminServiceAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminServiceAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess _serviceProviderAdminProfileAccess;

    [XmlElement(ElementName = "serviceProviderAdminProfileAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess ServiceProviderAdminProfileAccess {
        get => _serviceProviderAdminProfileAccess;
        set {
            ServiceProviderAdminProfileAccessSpecified = true;
            _serviceProviderAdminProfileAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminProfileAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess _serviceProviderAdminGroupAccess;

    [XmlElement(ElementName = "serviceProviderAdminGroupAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess ServiceProviderAdminGroupAccess {
        get => _serviceProviderAdminGroupAccess;
        set {
            ServiceProviderAdminGroupAccessSpecified = true;
            _serviceProviderAdminGroupAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminGroupAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess _serviceProviderAdminUserAccess;

    [XmlElement(ElementName = "serviceProviderAdminUserAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess ServiceProviderAdminUserAccess {
        get => _serviceProviderAdminUserAccess;
        set {
            ServiceProviderAdminUserAccessSpecified = true;
            _serviceProviderAdminUserAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminUserAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess _serviceProviderAdminAdminAccess;

    [XmlElement(ElementName = "serviceProviderAdminAdminAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess ServiceProviderAdminAdminAccess {
        get => _serviceProviderAdminAdminAccess;
        set {
            ServiceProviderAdminAdminAccessSpecified = true;
            _serviceProviderAdminAdminAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminAdminAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess _serviceProviderAdminDepartmentAccess;

    [XmlElement(ElementName = "serviceProviderAdminDepartmentAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess ServiceProviderAdminDepartmentAccess {
        get => _serviceProviderAdminDepartmentAccess;
        set {
            ServiceProviderAdminDepartmentAccessSpecified = true;
            _serviceProviderAdminDepartmentAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminDepartmentAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess _serviceProviderAdminAccessDeviceAccess;

    [XmlElement(ElementName = "serviceProviderAdminAccessDeviceAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess ServiceProviderAdminAccessDeviceAccess {
        get => _serviceProviderAdminAccessDeviceAccess;
        set {
            ServiceProviderAdminAccessDeviceAccessSpecified = true;
            _serviceProviderAdminAccessDeviceAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminAccessDeviceAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess _serviceProviderAdminPhoneNumberExtensionAccess;

    [XmlElement(ElementName = "serviceProviderAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess ServiceProviderAdminPhoneNumberExtensionAccess {
        get => _serviceProviderAdminPhoneNumberExtensionAccess;
        set {
            ServiceProviderAdminPhoneNumberExtensionAccessSpecified = true;
            _serviceProviderAdminPhoneNumberExtensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminPhoneNumberExtensionAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess _serviceProviderAdminServiceAccess;

    [XmlElement(ElementName = "serviceProviderAdminServiceAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess ServiceProviderAdminServiceAccess {
        get => _serviceProviderAdminServiceAccess;
        set {
            ServiceProviderAdminServiceAccessSpecified = true;
            _serviceProviderAdminServiceAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminServiceAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess _serviceProviderAdminServicePackAccess;

    [XmlElement(ElementName = "serviceProviderAdminServicePackAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess ServiceProviderAdminServicePackAccess {
        get => _serviceProviderAdminServicePackAccess;
        set {
            ServiceProviderAdminServicePackAccessSpecified = true;
            _serviceProviderAdminServicePackAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminServicePackAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess _serviceProviderAdminWebBrandingAccess;

    [XmlElement(ElementName = "serviceProviderAdminWebBrandingAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess ServiceProviderAdminWebBrandingAccess {
        get => _serviceProviderAdminWebBrandingAccess;
        set {
            ServiceProviderAdminWebBrandingAccessSpecified = true;
            _serviceProviderAdminWebBrandingAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminWebBrandingAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess _enterpriseAdminNetworkPolicyAccess;

    [XmlElement(ElementName = "enterpriseAdminNetworkPolicyAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess EnterpriseAdminNetworkPolicyAccess {
        get => _enterpriseAdminNetworkPolicyAccess;
        set {
            EnterpriseAdminNetworkPolicyAccessSpecified = true;
            _enterpriseAdminNetworkPolicyAccess = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseAdminNetworkPolicyAccessSpecified { get; set; }
}
}
