using System;
using System.Collections.Generic;
using System.Linq;

using R5T.L0026.T000;
using R5T.T0132;


namespace R5T.L0026
{
	[FunctionalityMarker]
	public partial interface IInstanceTypeOperations : IFunctionalityMarker
	{
		public InstanceTypeInformation[] GetAllInstanceTypeInformations()
		{
			var instanceTypeInformationsByTypeName = this.GetInstanceTypeInformationsByTypeName();

			var output = instanceTypeInformationsByTypeName
				.Select(x => x.Value)
				.Now();

			return output;
		}

		public Dictionary<string, InstanceTypeInformation> GetInstanceTypeInformationsByTypeName()
		{
			var output = new Dictionary<string, InstanceTypeInformation>
			{
				{ InstanceTypeNames.Instance.Demonstrations, InstanceTypes.Instance.Demonstrations },
                { InstanceTypeNames.Instance.Demonstrations_Draft, InstanceTypes.Instance.Demonstrations_Draft },
                { InstanceTypeNames.Instance.Experiments, InstanceTypes.Instance.Experiments },
                { InstanceTypeNames.Instance.Experiments_Draft, InstanceTypes.Instance.Experiments_Draft },
                { InstanceTypeNames.Instance.Explorations, InstanceTypes.Instance.Explorations },
                { InstanceTypeNames.Instance.Explorations_Draft, InstanceTypes.Instance.Explorations_Draft },
                { InstanceTypeNames.Instance.Functionality, InstanceTypes.Instance.Functionality },
                { InstanceTypeNames.Instance.Functionality_Draft, InstanceTypes.Instance.Functionality_Draft },
                { InstanceTypeNames.Instance.Values, InstanceTypes.Instance.Values },
                { InstanceTypeNames.Instance.Values_Draft, InstanceTypes.Instance.Values_Draft },
            };

			return output;
		}
	}
}