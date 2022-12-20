using System;

using R5T.T0142;


namespace R5T.L0026.T000
{
    [DataTypeMarker]
    public class InstanceTypeInformation
    {
        public string MarkerAttributeNamespacedTypeName { get; set; }
        public string MarkerInterfaceNamespacedTypeName { get; set; }
        public string InterfacesProjectDirectoryRelativeDirectoryPath { get; set; }
    }
}
