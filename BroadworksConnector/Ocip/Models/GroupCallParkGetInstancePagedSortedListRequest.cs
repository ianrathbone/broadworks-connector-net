using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkGetInstancePagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

    [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl {
        get => _responsePagingControl;
        set {
            ResponsePagingControlSpecified = true;
            _responsePagingControl = value;
        }
    }

    [XmlIgnore]
    public bool ResponsePagingControlSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByCallParkName _sortByCallParkName;

    [XmlElement(ElementName = "sortByCallParkName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByCallParkName SortByCallParkName {
        get => _sortByCallParkName;
        set {
            SortByCallParkNameSpecified = true;
            _sortByCallParkName = value;
        }
    }

    [XmlIgnore]
    public bool SortByCallParkNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallParkName> _searchCriteriaCallParkName;

    [XmlElement(ElementName = "searchCriteriaCallParkName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallParkName> SearchCriteriaCallParkName {
        get => _searchCriteriaCallParkName;
        set {
            SearchCriteriaCallParkNameSpecified = true;
            _searchCriteriaCallParkName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaCallParkNameSpecified { get; set; }
    private bool _searchCriteriaModeOr;

    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
    public bool SearchCriteriaModeOr {
        get => _searchCriteriaModeOr;
        set {
            SearchCriteriaModeOrSpecified = true;
            _searchCriteriaModeOr = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaModeOrSpecified { get; set; }
}
}