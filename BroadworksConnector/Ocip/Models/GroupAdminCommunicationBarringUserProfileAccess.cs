using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupAdminCommunicationBarringUserProfileAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "None")]
    None,
 }
}
