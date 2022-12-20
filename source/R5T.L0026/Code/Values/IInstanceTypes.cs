using System;

using R5T.T0131;

using R5T.L0026.T000;


namespace R5T.L0026
{
	[ValuesMarker]
	public partial interface IInstanceTypes : IValuesMarker
	{
        public InstanceTypeInformation Demonstrations => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Demonstrations_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DemonstrationsMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DemonstrationsMarkerInterface,
        };
        public InstanceTypeInformation Demonstrations_Draft => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Demonstrations_Draft_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DraftDemonstrationsMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DraftDemonstrationsMarkerInterface,
        };


        public InstanceTypeInformation Experiments => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Experiments_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.ExperimentsMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.ExperimentsMarkerInterface,
        };
        public InstanceTypeInformation Experiments_Draft => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Experiments_Draft_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DraftExperimentsMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DraftExperimentsMarkerInterface,
        };


        public InstanceTypeInformation Explorations => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Explorations_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.ExplorationsMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.ExplorationsMarkerInterface,
        };
        public InstanceTypeInformation Explorations_Draft => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Explorations_Draft_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DraftExplorationsMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DraftExplorationsMarkerInterface,
        };


        public InstanceTypeInformation Functionality => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Functionality_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.FunctionalityMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.FunctionalityMarkerInterface,
        };
        public InstanceTypeInformation Functionality_Draft => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Functionality_Draft_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DraftFunctionalityMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DraftFunctionalityMarkerInterface,
        };


        public InstanceTypeInformation Values => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Values_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.ValuesMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.ValuesMarkerInterface,
        };
        public InstanceTypeInformation Values_Draft => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Values_Draft_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DraftValuesMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DraftValuesMarkerInterface,
        };
        
        
        public InstanceTypeInformation Tries => new InstanceTypeInformation
        {
            InterfacesProjectDirectoryRelativeDirectoryPath = Instances.ProjectDirectoryRelativePath.Tries_Interfaces_Directory,
            MarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.TriesMarkerAttribute,
            MarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.TriesMarkerInterface,
        };
    }
}