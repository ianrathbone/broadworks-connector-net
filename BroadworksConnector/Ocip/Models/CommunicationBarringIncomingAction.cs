using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CommunicationBarringIncomingAction{
    [XmlEnum(Name = "Allow")]
    Allow,
    [XmlEnum(Name = "Allow Timed")]
    AllowTimed,
    [XmlEnum(Name = "Block")]
    Block,
 }
}