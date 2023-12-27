using SIPSorcery.Media;
using SIPSorcery.Net;
using SIPSorceryMedia.Abstractions;
using VoIPer.Utils;

namespace VoIPer.Peers
{
    public class Peer
    {
        public string Id;
        public RTCPeerConnection Connection { get; set; }
        public DateTime JoinTime { get; set; }

        public VideoTestPatternSource VideoPatternSource { get; set; }
        public AudioExtrasSource AudioSource { get; set; }

        public MediaStreamTrack VideStreamTrack { get; set; }
        public MediaStreamTrack AudioStreamTrack { get; set; }

        public Peer() {
            Id = IdentifierUtil.GenerateShort();
            JoinTime = DateTime.Now;
            Connection = new RTCPeerConnection(null);
        }

        public Peer SetOnConnect()
        {
            Connection.onconnectionstatechange += state =>
            {
                state switch
                {
                    RTCPeerConnectionState.connected => () =>
                    {

                    },
                    RTCPeerConnectionState.failed => () => {

                    },
                    RTCPeerConnectionState.closed => () => {

                    },
                    _ => throw new Exception("Unhandled case: " + state)
                };
            };

            return this;
        }

        public Peer SetEventsInstance()
        {

        }

        public static Peer Create() =>
            new Peer();
    }
}
