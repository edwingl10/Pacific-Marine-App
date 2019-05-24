using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class xrayTarget : MonoBehaviour, IDropHandler
{
    //references the instructions panel 
    public GameObject instructions;
    public GameObject XRay;
   //public GameObject Raptor;

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
            //gets the item being dragged, sets parent to the current transform
            xrayDrag.itemBeingDragged.transform.SetParent(transform);
            //if object in target slot, change to true 
            xrayDrag.slot = true;

            instructions.gameObject.GetComponent<Text>().text = "Record your observations of Sheriff on the clipboard.";
            //brings x-ray onto seal sprite 
            XRay.GetComponent<Animator>().SetBool("x_ray", true);
            //changes raptor animation once the x-ray is ontop
            //Raptor.GetComponent<Animator>().SetBool("raptor_xray", true);
        }
    }




}