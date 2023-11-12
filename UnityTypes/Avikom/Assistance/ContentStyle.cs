
using UnityEngine;
using Avikom.UnityAssets.Variables;

namespace Avikom.UnityTypes.Assistance
{

    /** Defines the content style of a textual instruction. This should be used to transport contextual semantics such as urgency.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/ContentStyle")]
    public class ContentStyle : EnumVariable<Avikom.Types.Assistance.ContentStyle> { }

}
