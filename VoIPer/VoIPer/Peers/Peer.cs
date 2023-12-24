using SIPSorcery.Net;

namespace VoIPer.Peers
{
    public class Peer
    {
        public int Id;
        public RTCPeerConnection Connection { get; set; }
        public DateTime JoinTime { get; set; }

        public Peer() {
            Connection = new RTCPeerConnection();
            JoinTime = DateTime.Now;
        }
    }
}
