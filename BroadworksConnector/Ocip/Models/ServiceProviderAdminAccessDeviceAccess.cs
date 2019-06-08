using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderAdminAccessDeviceAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Associate User With Device")]
    AssociateUserWithDevice,
    [XmlEnum(Name = "Read-Only")]
    ReadOnly,
 }
}
