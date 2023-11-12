
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Options
{

    /** This is a meta message which is not supposed to be shared but used to define database-related properties.
     These properties will be evaluated by the protoc converter plugins to determine -- for instance -- the mongoDB schema required to store and retrieve a decorated message.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Options/FieldOptionsSet")]
    public class FieldOptionsSet : Avikom.UnityAssets.Sets.RuntimeSet<FieldOptions> { }

}
