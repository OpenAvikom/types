
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** This message describes a media instruction. This includes the instruction's (MIME) type and either an URI or the media as a binary stream.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/InstructionMediaSet")]
    public class InstructionMediaSet : Avikom.UnityAssets.Sets.RuntimeSet<InstructionMedia> { }

}
