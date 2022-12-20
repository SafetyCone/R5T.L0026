using System;


namespace R5T.L0026
{
	public class InstanceTypeNames : IInstanceTypeNames
	{
		#region Infrastructure

	    public static IInstanceTypeNames Instance { get; } = new InstanceTypeNames();

	    private InstanceTypeNames()
	    {
        }

	    #endregion
	}
}