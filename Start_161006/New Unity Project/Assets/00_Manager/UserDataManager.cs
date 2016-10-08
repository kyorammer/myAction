using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataManager
{
    static UserDataManager _instance;
    public UserDataManager Instance
    {
        get {
            if (_instance == null)
                _instance = new UserDataManager();
            return _instance;
        }
    }

    public string _id;
    public string _nickName;
}
