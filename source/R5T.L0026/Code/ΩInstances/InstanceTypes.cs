using System;


namespace R5T.L0026
{
	public class InstanceTypes : IInstanceTypes
	{
		#region Infrastructure

	    public static IInstanceTypes Instance { get; } = new InstanceTypes();

	    private InstanceTypes()
	    {
        }

	    #endregion
	}
}