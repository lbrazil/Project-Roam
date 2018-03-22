using UnityEngine;

public class StateMachine : MonoBehaviour {

    private IState CurrentState;
    private IState PreviousState;

    // PRIVATE METHODS
    private void ChangeState(IState newState)
    {
        if(CurrentState != null)
        {
            CurrentState.Exit();
        }
        PreviousState = CurrentState;
        CurrentState = newState;
        CurrentState.Enter();
    }

    // PUBLIC METHODS
    public void ExecuteStateUpdate()
    {
        var runningState = CurrentState;
        if(runningState != null)
        {
            runningState.Execute();
        }

    }

    public void SwitchToPreviousState()
    {
        CurrentState.Exit();
        CurrentState = PreviousState;
        CurrentState.Enter();
    }

}
