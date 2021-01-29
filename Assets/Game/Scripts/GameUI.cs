using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{

    private Animator animator;
    private CanvasGroup cv;

    public void Start(){

        animator = GetComponent<Animator>();
        cv = GetComponent<CanvasGroup>();

        cv.interactable = false;
        cv.blocksRaycasts = false;

    }

    public void Show(){
        animator.Play("FadeinUI");
        cv.interactable = true;
        cv.blocksRaycasts = true;
    }

    public void Hide(){
        animator.Play("FadeoutUI");
        cv.interactable = false;
        cv.blocksRaycasts = false;
    }
}
