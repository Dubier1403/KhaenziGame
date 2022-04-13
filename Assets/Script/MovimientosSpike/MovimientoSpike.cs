using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MovimientoSpike : MonoBehaviour
{
    Animator anm;
    void Start()
    {
        anm = GetComponent<Animator>();
    }
    void Update()
    {
        anm.Play("Spike_idle");
    }
}
