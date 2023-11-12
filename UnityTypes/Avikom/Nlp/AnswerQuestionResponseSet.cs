
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Nlp
{

    /** This message is includes the response to the posed question and where in the context the answer was found.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Nlp/AnswerQuestionResponseSet")]
    public class AnswerQuestionResponseSet : Avikom.UnityAssets.Sets.RuntimeSet<AnswerQuestionResponse> { }

}
