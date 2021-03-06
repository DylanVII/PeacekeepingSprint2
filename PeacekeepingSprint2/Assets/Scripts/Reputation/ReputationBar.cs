﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReputationBar : MonoBehaviour
{

    //references
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    //create visual meter with slider
    public void SetRep(int rep)
    {

        slider.value = rep;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
