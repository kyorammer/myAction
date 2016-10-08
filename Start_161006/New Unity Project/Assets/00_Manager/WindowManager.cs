using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WindowIndex
{
    Non = -1,
    Max,
}

public class WindowManager : MonoBehaviour
{
    public static WindowManager _instance;

    Stack<WindowBase>       _windowStack;
    public WindowIndex      _curWindowIndex;
    public bool             _ableBackWindow;

    public void AddWindow(WindowBase window)
    {
        _windowStack.Push(window);
    }

    public void PopWindow()
    {
        _windowStack.Pop();
    }

    public WindowBase GetCurWindow()
    {
        return _windowStack.Peek();
    }

    public int GetCurStackCount()
    {
        return _windowStack.Count;
    }
}
