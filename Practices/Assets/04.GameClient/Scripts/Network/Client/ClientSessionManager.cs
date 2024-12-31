using System.Net;

namespace Practices.GameClient.Network.Client
{
    public class ClientSessionManager
    {
        public ClientSessionManager()
        {
            _serverIpAddress = IPAddress.Parse(GameClientSettings.ServerIp);
            _serverIpEndPoint = new IPEndPoint(_serverIpAddress, GameClientSettings.ServerPort);
            _udpSession = new ClientUdpSession(_serverIpEndPoint);
            _tcpSession = new ClientTcpSession();
        }


        ClientUdpSession _udpSession;
        ClientTcpSession _tcpSession;
        IPAddress _serverIpAddress;
        IPEndPoint _serverIpEndPoint;

        public void Start()
        {
            //_udpSession.Start();
            _tcpSession.Connect(_serverIpEndPoint);
        }
    }
}