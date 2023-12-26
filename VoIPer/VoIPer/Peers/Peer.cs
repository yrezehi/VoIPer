using SIPSorcery.Net;
using VoIPer.Utils;

namespace VoIPer.Peers
{
    public class Peer
    {
        public string Id;
        public RTCPeerConnection Connection { get; set; }
        public DateTime JoinTime { get; set; }

        public Peer() {
            Id = IdentifierUtil.GenerateShort();
            JoinTime = DateTime.Now;
            Connection = new RTCPeerConnection(null);
        }

        public async Task OnConnect()
        {
            Connection.onconnectionstatechange += state =>
            {
                var x = state switch
                {
                    RTCPeerConnectionState.connected ,
                    RTCPeerConnectionState.failed => "Case 2",
                    RTCPeerConnectionState.closed => "Case 3",
                    _ => throw new Exception("Unhandled case: " + state)
                };
            };
        }

        public static Peer Create() =>
            new Peer();
    }
}
