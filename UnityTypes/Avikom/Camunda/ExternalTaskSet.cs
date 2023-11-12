
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Camunda
{

    /** A storable representation of an external task published by the BPM engine (Camunda).
     The field description has been derived from the official REST-API documentation.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Camunda/ExternalTaskSet")]
    public class ExternalTaskSet : Avikom.UnityAssets.Sets.RuntimeSet<ExternalTask> { }

}
