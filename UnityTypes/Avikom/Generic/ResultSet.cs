
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Generic
{

    /** A message to provide feedback about sucessful or failed remote procedure calls
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/ResultSet")]
    public class ResultSet : Avikom.UnityAssets.Sets.RuntimeSet<Result> { }

}
