using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupVoiceMessagingAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Restricted")]
    Restricted,
 }
}