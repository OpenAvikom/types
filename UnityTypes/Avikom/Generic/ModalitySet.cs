
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Generic
{

    /** A message specifying one of three- or a combination of three interaction modalities supported 
     for, for example, instructions, peers, user_profiles and sessions.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/ModalitySet")]
    public class ModalitySet : Avikom.UnityAssets.Sets.RuntimeSet<Modality> { }

}
