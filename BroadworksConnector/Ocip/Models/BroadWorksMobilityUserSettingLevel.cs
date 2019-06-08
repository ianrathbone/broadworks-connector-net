using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum BroadWorksMobilityUserSettingLevel{
    [XmlEnum(Name = "Group")]
    Group,
    [XmlEnum(Name = "User")]
    User,
 }
}
