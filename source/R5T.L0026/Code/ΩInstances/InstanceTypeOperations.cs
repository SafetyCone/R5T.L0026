using System;


namespace R5T.L0026
{
	public class InstanceTypeOperations : IInstanceTypeOperations
	{
		#region Infrastructure

	    public static IInstanceTypeOperations Instance { get; } = new InstanceTypeOperations();

	    private InstanceTypeOperations()
	    {
        }

	    #endregion
	}
}