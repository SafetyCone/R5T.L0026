using System;

using R5T.T0131;


namespace R5T.L0026
{
	[ValuesMarker]
	public partial interface IInstanceTypeNames : IValuesMarker
	{
		public string Demonstrations => "Demonstrations";
        public string Demonstrations_Draft => "Demonstrations-Draft";
        public string Experiments => "Experiments";
        public string Experiments_Draft => "Experiments-Draft";
        public string Explorations => "Explorations";
        public string Explorations_Draft => "Explorations-Draft";
        public string Functionality => "Functionality";
        public string Functionality_Draft => "Functionality-Draft";
        public string Values => "Values";
        public string Values_Draft => "Values-Draft";
    }
}