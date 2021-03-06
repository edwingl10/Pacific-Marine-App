﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class vitamin_target : MonoBehaviour, IDropHandler
{
    //references the instructions panel 
    public GameObject Instructions;
    public Animator anim;
    public GameObject clip_board;
    public GameObject pill;

    public GameObject seal;



    public void play_clipboard()
    {
        Animator cb = clip_board.GetComponent<Animator>();
        cb.SetBool("play", true);
        StartCoroutine(hide_clipboard());
    }

    IEnumerator hide_clipboard()
    {
        yield return new WaitForSeconds(5);
        Animator cb = clip_board.GetComponent<Animator>();
        cb.Play("hide_clipboard");

    }

    public GameObject item

    {
        get
        {
            //If target has a child
            if (transform.childCount > 0)
            {
                //returns first child
                return transform.GetChild(0).gameObject;
               

            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {

        //if we dont have an item in the target, accept new item
        if (!item)
        {
            //stops animation from playing 
            anim.enabled = false;
            //changes the transparency of the target to 0; its defualt state 
            Image img = GetComponent<Image>();
            Color c = img.color;
            c.a = 0;
            img.color = c;

            //gets the item being dragged, sets parent to the current transform
            vitamin_drag.itemBeingDragged.transform.SetParent(transform);


            //if object in target slot, change to true 
            vitamin_drag.slot = true;
            seal.GetComponent<Animator>().Play("openMouth");
            //hides the instructions panel
            Instructions.gameObject.SetActive(false);
            //hides pill game object
            pill.gameObject.SetActive(false);
            play_clipboard();

        }
    }




}