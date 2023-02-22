﻿namespace Derrixx.BehaviourTrees.Runtime.Nodes
{
	/// <summary>
	/// A decorator node that returns either <see cref="Node.State.Success"/> or <see cref="Node.State.Failure"/> based on a condition.
	/// Inherit from this class to create your own conditional nodes.
	/// <seealso cref="IsTrueNode"/><seealso cref="AreEqualNode"/>
	/// </summary>
	public abstract class ConditionalNode : DecoratorNode
	{
		protected sealed override State OnEvaluate(BehaviourTreeRunner runner) => ConditionValue() ? Child.Evaluate(runner) : State.Failure;
		protected abstract bool ConditionValue();
	}
}