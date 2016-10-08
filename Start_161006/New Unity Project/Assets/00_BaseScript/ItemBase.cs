using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Non = -1,
    Weapon,
    Portion,
    Max,
}

public enum ItemGradeType
{
    Non = -1,
    Normal,
    Rare,
    Unique,
    Legend,
    Max,
}

public class ItemBase : MonoBehaviour
{
    public string       _name;              // 오브젝트 이름
    public Status       _originStatus;      // 오리지널 스테이터스
    public ItemType     _itemType;          // 아이템 타입.
    public ItemGradeType    _grade;         // 아이템 등급.
}
