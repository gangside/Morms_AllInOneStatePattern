using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 * 상태는 기본 6가지를 바로 사용할수있게 해놓았습니다.
 * 유니티 콜백함수인 OnTrigger, OnCollision 은 사용하고 싶으시면 따로 추가해서 사용할수있습니다.
 * 
 * 사용법:
 * 상태 바꾸는 함수는 ChangeState()입니다.
 * 최상단에 있는 열거형 목록들을 ctrl+h 를 통해 같은 문자열을 전부 원하는 이름으로 바꿔주세요.
 *  !!! 반드시 ctrl+h 이어야합니다. ctrl+r 로는 메서드 이름이 바뀌지 않아서 상태가 연결되지 않아요.
 * 즉, 결국 상태의 이름과 메서드의 이름이 같아집니다.
 * 이 코드에선 상태를 나타내는 문자열은 전부 대문자로 표기합니다. 헷갈리지 않게하기위한 규칙입니다.
 * 
 * 복잡하게 클래스 여러개 만들지 말고 한 클래스에서 상태를 관리하세요!
 * 
 */

public class StateCodePrefab : MonoBehaviour
{
    public enum NAME_State
    {
        STATE_ZERO,
        STATE_ONE,
        STATE_TWO,
        STATE_THREE,
        STATE_FOUR,
        STATE_FIVE
    }
    public NAME_State startState = NAME_State.STATE_ZERO;
    private NAME_State currentState;


    #region Internal-------------------------- # Please close # --------------------------
    private enum StateFlow
    {
        ENTER,
        UPDATE,
        EXIT
    }

    private void SetStartState(NAME_State startState)
    {
        currentState = startState;

        switch (currentState)
        {
            case NAME_State.STATE_ZERO: STATE_ZERO(StateFlow.ENTER); break;
            case NAME_State.STATE_ONE: STATE_ONE(StateFlow.ENTER); break;
            case NAME_State.STATE_TWO: STATE_TWO(StateFlow.ENTER);  break;
            case NAME_State.STATE_THREE: STATE_THREE(StateFlow.ENTER); break;
            case NAME_State.STATE_FOUR: STATE_FOUR(StateFlow.ENTER); break;
            case NAME_State.STATE_FIVE: STATE_FIVE(StateFlow.ENTER);  break;
        }
    }

    void Update()
    {
        CommonUpdate();

        switch (currentState)
        {
            case NAME_State.STATE_ZERO: STATE_ZERO(StateFlow.UPDATE); break;
            case NAME_State.STATE_ONE: STATE_ONE(StateFlow.UPDATE); break;
            case NAME_State.STATE_TWO: STATE_TWO(StateFlow.UPDATE); break;
            case NAME_State.STATE_THREE: STATE_THREE(StateFlow.UPDATE); break;
            case NAME_State.STATE_FOUR: STATE_FOUR(StateFlow.UPDATE); break;
            case NAME_State.STATE_FIVE: STATE_FIVE(StateFlow.UPDATE); break;
        }
    }

    private void ChangeState(NAME_State nextState)
    {
        switch (this.currentState)
        {
            case NAME_State.STATE_ZERO: STATE_ZERO(StateFlow.EXIT); break;
            case NAME_State.STATE_ONE: STATE_ONE(StateFlow.EXIT); break;
            case NAME_State.STATE_TWO: STATE_TWO(StateFlow.EXIT); break;
            case NAME_State.STATE_THREE: STATE_THREE(StateFlow.EXIT); break;
            case NAME_State.STATE_FOUR: STATE_FOUR(StateFlow.EXIT); break;
            case NAME_State.STATE_FIVE: STATE_FIVE(StateFlow.EXIT); break;
        }

        this.currentState = nextState;

        switch (this.currentState)
        {
            case NAME_State.STATE_ZERO: STATE_ZERO(StateFlow.ENTER); break;
            case NAME_State.STATE_ONE: STATE_ONE(StateFlow.ENTER); break;
            case NAME_State.STATE_TWO: STATE_TWO(StateFlow.ENTER); break;
            case NAME_State.STATE_THREE: STATE_THREE(StateFlow.ENTER); break;
            case NAME_State.STATE_FOUR: STATE_FOUR(StateFlow.ENTER); break;
            case NAME_State.STATE_FIVE: STATE_FIVE(StateFlow.ENTER); break;
        }
    }
    #endregion;


    void Start()
    {

        SetStartState(startState);
    }


    private void CommonUpdate()
    {
        
    }



//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  
    
    private void STATE_ZERO(StateFlow stateFlow)
    {
        switch (stateFlow)
        {
            case StateFlow.ENTER:
                Debug.Log($"<color=yellow>{this.name}</color> - 상태 : {currentState},   상태단계 : {stateFlow}");
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }


//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    private void STATE_ONE(StateFlow stateFlow)
    {
        switch (stateFlow)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }


//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    private void STATE_TWO(StateFlow stateFlow)
    {
        switch (stateFlow)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }


//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    private void STATE_THREE(StateFlow stateFlow)
    {
        switch (stateFlow)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }


//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    private void STATE_FOUR(StateFlow stateFlow)
    {
        switch (stateFlow)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }


//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    private void STATE_FIVE(StateFlow stateFlow)
    {
        switch (stateFlow)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }
}
