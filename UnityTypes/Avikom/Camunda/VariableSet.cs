
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Camunda
{

    /** This message describes a Camunda variable.
     Values of commonly stored as a string and are parsed according to the type mentioned in `type` when needed.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Camunda/VariableSet")]
    public class VariableSet : Avikom.UnityAssets.Sets.RuntimeSet<Variable> { }

}
