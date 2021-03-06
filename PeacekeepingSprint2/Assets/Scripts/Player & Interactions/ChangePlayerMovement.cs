﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerMovement : MonoBehaviour
{
    public GameObject thirdPersonController;

    public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter thirdPersonCharacterScript;

    // Start is called before the first frame update
    void Start()
    {        
        // get reference to the third person character controller in order to change the move speed multiplier variable.
        thirdPersonCharacterScript = thirdPersonController.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>();

    }

    public void StopMovement()
    {
        // lowers the speed multiplier on the character stopping their movement
        thirdPersonCharacterScript.m_MoveSpeedMultiplier = 0f;

        thirdPersonCharacterScript.m_JumpPower = 0f;

    }

    public void StartMovement()
    {
        // lowers the speed multiplier on the character increasing their movement
        thirdPersonCharacterScript.m_MoveSpeedMultiplier = 1f;

        thirdPersonCharacterScript.m_JumpPower = 7.5f;
    }
}
