using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendMessageToSelectedDistributionListMenuKeys 
{
    private string _confirmSendingToDistributionList;

    [XmlElement(ElementName = "confirmSendingToDistributionList", IsNullable = false, Namespace = "")]
    public string ConfirmSendingToDistributionList {
        get => _confirmSendingToDistributionList;
        set {
            ConfirmSendingToDistributionListSpecified = true;
            _confirmSendingToDistributionList = value;
        }
    }

    [XmlIgnore]
    public bool ConfirmSendingToDistributionListSpecified { get; set; }
    private string _cancelSendingToDistributionList;

    [XmlElement(ElementName = "cancelSendingToDistributionList", IsNullable = false, Namespace = "")]
    public string CancelSendingToDistributionList {
        get => _cancelSendingToDistributionList;
        set {
            CancelSendingToDistributionListSpecified = true;
            _cancelSendingToDistributionList = value;
        }
    }

    [XmlIgnore]
    public bool CancelSendingToDistributionListSpecified { get; set; }
}
}
