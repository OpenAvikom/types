
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Headset
{

    /** A query passed to RasaService
     @author Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/RasaQuerySet")]
    public class RasaQuerySet : Avikom.UnityAssets.Sets.RuntimeSet<RasaQuery> { }

}
