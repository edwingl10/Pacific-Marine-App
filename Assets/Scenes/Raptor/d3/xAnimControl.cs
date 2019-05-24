using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xAnimControl : MonoBehaviour
{
    // public Animator animator;
    public GameObject clip_board;


    public void play_clipboard()
    {
        Animator anim = clip_board.GetComponent<Animator>();
        anim.SetBool("play", true);

    }
}
