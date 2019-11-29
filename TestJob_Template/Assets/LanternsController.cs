using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternsController : MonoBehaviour
{
    [SerializeField] private Animator[] lanternAnimators;
    [SerializeField] private bool randomizeAnimOffset;

    private bool isWind;

    private void Start()
    {
        if (randomizeAnimOffset)
        {
            foreach (Animator anim in lanternAnimators)
                anim.SetFloat("animOffset", Random.value);
        }
    }

    public void ToggleWind()
    {
        isWind = !isWind;

        foreach (Animator anim in lanternAnimators)
            anim.SetBool("isWind", isWind);
    }
}
