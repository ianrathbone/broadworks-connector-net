using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDomainGetAssignedGroupListRequest.
    /// Contains a table with column headings: "Group Id", "Group Name"
    /// and a row for each group.
    /// <see cref="ServiceProviderDomainGetAssignedGroupListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3278""}]")]
    public class ServiceProviderDomainGetAssignedGroupListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _groupTable;

        [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3278")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupTable
        {
            get => _groupTable;
            set
            {
                GroupTableSpecified = true;
                _groupTable = value;
            }
        }

        [XmlIgnore]
        protected bool GroupTableSpecified { get; set; }

    }
}
