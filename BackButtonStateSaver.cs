﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BackButtonStateSaver : MonoBehaviour
{
    //private bool didBack = false;

    protected void OnEnable()
    {
        if (BackButtonManager.instance)
        {
            BackButtonManager.instance.AddState(this);
        }
    }

    public virtual void Back()
    {
        //didBack = true;
        BackButtonManager.instance.CloseLastMenu();
    }

    //protected void OnDisable() // лишнее??
    //{
    //    if (!didBack)
    //    {
    //        Back();
    //    }
    //}
}