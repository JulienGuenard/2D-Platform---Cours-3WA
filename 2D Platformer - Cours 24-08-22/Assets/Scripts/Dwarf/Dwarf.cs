using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf : Dwarf_Heritage
{
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        dwarf_Animation.MoveStart(inputX);
        dwarf_Move.Move(inputX);

        if (Input.GetKey(KeyCode.Z)) { dwarf_Jump.Jump(); }
        if (Input.GetKeyDown(KeyCode.E)) { dwarf_Animation.VictoryStart(); }
    }
}
