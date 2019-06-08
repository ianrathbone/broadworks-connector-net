using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupPilotUserCallOptimizationPolicy{
    [XmlEnum(Name = "Optimize For User Services")]
    OptimizeForUserServices,
    [XmlEnum(Name = "Optimize For High Call Volume")]
    OptimizeForHighCallVolume,
 }
}