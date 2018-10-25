namespace mRemoteNG.Connection.Protocol.RAW
{
	public class RawProtocol : PuttyBase
	{
		public RawProtocol(IConnectionsService connectionsService) 
		    : base(connectionsService)
		{
			PuttyProtocol = Putty_Protocol.raw;
		}
				
		public enum Defaults
		{
			Port = 23
		}
	}
}