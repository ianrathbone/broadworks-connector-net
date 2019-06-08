using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigAddFileServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _ftpHostNetAddress;

    [XmlElement(ElementName = "ftpHostNetAddress", IsNullable = false, Namespace = "")]
    public string FtpHostNetAddress {
        get => _ftpHostNetAddress;
        set {
            FtpHostNetAddressSpecified = true;
            _ftpHostNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool FtpHostNetAddressSpecified { get; set; }
    private string _ftpUserId;

    [XmlElement(ElementName = "ftpUserId", IsNullable = false, Namespace = "")]
    public string FtpUserId {
        get => _ftpUserId;
        set {
            FtpUserIdSpecified = true;
            _ftpUserId = value;
        }
    }

    [XmlIgnore]
    public bool FtpUserIdSpecified { get; set; }
    private string _ftpUserPassword;

    [XmlElement(ElementName = "ftpUserPassword", IsNullable = false, Namespace = "")]
    public string FtpUserPassword {
        get => _ftpUserPassword;
        set {
            FtpUserPasswordSpecified = true;
            _ftpUserPassword = value;
        }
    }

    [XmlIgnore]
    public bool FtpUserPasswordSpecified { get; set; }
    private string _cpeFileDirectory;

    [XmlElement(ElementName = "cpeFileDirectory", IsNullable = false, Namespace = "")]
    public string CpeFileDirectory {
        get => _cpeFileDirectory;
        set {
            CpeFileDirectorySpecified = true;
            _cpeFileDirectory = value;
        }
    }

    [XmlIgnore]
    public bool CpeFileDirectorySpecified { get; set; }
    private bool _passiveFTP;

    [XmlElement(ElementName = "passiveFTP", IsNullable = false, Namespace = "")]
    public bool PassiveFTP {
        get => _passiveFTP;
        set {
            PassiveFTPSpecified = true;
            _passiveFTP = value;
        }
    }

    [XmlIgnore]
    public bool PassiveFTPSpecified { get; set; }
}
}