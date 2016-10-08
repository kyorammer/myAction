using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBase : MonoBehaviour
{
    public string           _name;              // 오브젝트 이름
    public PlayerStateType  _state;
    public Status           _originStatus;      // 오리지널 스테이터스
    public Status           _resultStatus;      // 무기등 전부 장착했을 때 스테이터스
    public bool             _isDie;             // 죽었니?
}
