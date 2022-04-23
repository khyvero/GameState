using System;
public interface IState
{
   public abstract void OnEnterState(IState previousState);

   public abstract void OnExitState(IState nextState);
}
