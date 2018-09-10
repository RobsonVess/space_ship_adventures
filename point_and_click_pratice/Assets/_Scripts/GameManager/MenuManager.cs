using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MenuManager : MonoBehaviour {
    public void ChangeScreen(string value)
    {
        ScreenManager.i.ChangeScreen(value);
    }
    
}
