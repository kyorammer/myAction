using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerStateType
{
    Non = -1,
    Idle,
    Attack,
    BeShot,
    Die,
}

public enum ObjectConditionType
{
    Non = -1,
    Poison,
    Heal,
}

public enum CrowdControlType
{
    Non = -1,
    KnockBack,
    Snare,
    Airborne,
}