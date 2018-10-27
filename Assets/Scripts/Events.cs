using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour {

    public delegate void ColliderHandler();

    public static event ColliderHandler OnColorColliderEnter;
    public static event ColliderHandler OnColorColliderExit; // probably not used but *shrug*
    
    public static void ColorColliderEnter()
    {
        if (OnColorColliderEnter != null)
        {
            OnColorColliderEnter();
        }
    }

    public static void ColorColliderExit()
    {
        if (OnColorColliderExit != null)
        {
            OnColorColliderExit();
        }
    }



}
