using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UsingAllObjects : MonoBehaviour
{
    protected Animator animationController;
    protected BoxCollider2D boxCollider;
    protected float distance;
    protected bool isOpened = false;

    //public Sprite usedSprite;
    //public Sprite defaultSprite;

    //protected SpriteRenderer spriteRenderer;

    protected virtual void Start()
    {
        GameObject player = GameObject.Find("Player");
        animationController = gameObject.GetComponent<Animator>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    
    protected virtual void Update()
    {
        distance = Vector3.Distance(GameObject.Find("Player").transform.position, gameObject.transform.position);
        if (Input.GetKeyUp(KeyCode.E) && distance < 1.5f)
        {
            if (isOpened)
                Close();
            else
                Open();
        }
    }

    protected virtual void Open()
    {
        isOpened = true;
    }

    protected virtual void Close()
    {
        isOpened = false;
    }
}
