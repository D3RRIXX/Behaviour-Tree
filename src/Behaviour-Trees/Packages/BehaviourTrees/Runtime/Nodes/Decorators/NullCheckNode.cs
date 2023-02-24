using Derrixx.BehaviourTrees.Runtime.BlackboardScripts.BlackboardProperties;
using UnityEngine;

namespace Derrixx.BehaviourTrees.Runtime.Nodes
{
    public class NullCheckNode : ConditionalNode
    {
        [SerializeField] private ObjectBlackboardProperty _objectReference;
        [SerializeField] private bool _shouldBeNull = true;

        public override string GetDescription() 
            => $"{(_objectReference == null ? "Object Reference" : _objectReference.Key)} is {(_shouldBeNull ? "NULL" : "NOT NULL")}";

        protected override bool ConditionValue() => _objectReference == null;
    }
}
