
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** This message describes the common base for an instruction.
     Every instruction has an assistance level and can be modaly modulated
     They should all be compatible with the 'Basic Action Concept' (BAC) of SDA-M.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de>
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/InstructionMetaSet")]
    public class InstructionMetaSet : Avikom.UnityAssets.Sets.RuntimeSet<InstructionMeta> { }

}
