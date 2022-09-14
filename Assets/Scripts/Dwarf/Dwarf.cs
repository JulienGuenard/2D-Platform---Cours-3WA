using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf : Dwarf_Heritage
{
    bool isInputsAllowed = true;

    void Update()
    {
        float inputX = 0;
        if (isInputsAllowed) inputX = Input.GetAxisRaw("Horizontal");

        dwarf_Animation.MoveStart(inputX);
        dwarf_Move.Move(inputX);

        if (!isInputsAllowed) return;

        if (Input.GetKey(KeyCode.Z)) { dwarf_Jump.Jump(); }
        if (Input.GetKeyDown(KeyCode.E)) { dwarf_Animation.VictoryStart(); }
        if (Input.GetKeyDown(KeyCode.A)) { dwarf_Attack.Attack(); }
    }

    public void DisableInputs() { isInputsAllowed = false; }
    public void EnableInputs() { isInputsAllowed = true; }
}
