using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : UsingAllObjects
{
    
    protected override void Start()
    {
        base.Start();
    }

   
    protected override void Update()
    {
        base.Update();
    }

    protected override void Open()
    {
        base.Open();
        animationController.SetTrigger("Open");
        boxCollider.enabled = false;
    }

    protected override void Close()
    {
        base.Close();
        animationController.SetTrigger("Close");
        boxCollider.enabled = true;
    }

}
