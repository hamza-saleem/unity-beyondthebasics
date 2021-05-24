using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    private Animation playButtonAnimation;
    private void Awake()
    {
        playButtonAnimation = GetComponent<Animation>();
    }

    private void OnMouseOver()
    {
        playButtonAnimation.Play("PlayButtonAnim");
    }

    private void OnMouseExit()
    {
        playButtonAnimation.Stop("PlayButtonAnim");
    }
}
