
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Generic
{

    /** A message specifying the log combining the log level, the logging message and the origin
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/MessageSet")]
    public class MessageSet : Avikom.UnityAssets.Sets.RuntimeSet<Message> { }

}
