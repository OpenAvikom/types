
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Nlp
{

    /** This message is used to ask a question to be answered on the basis of the context.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Nlp/AnswerQuestionQuerySet")]
    public class AnswerQuestionQuerySet : Avikom.UnityAssets.Sets.RuntimeSet<AnswerQuestionQuery> { }

}
