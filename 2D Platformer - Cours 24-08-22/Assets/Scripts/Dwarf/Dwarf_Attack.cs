using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf_Attack : Dwarf_Heritage
{
    DwarfChkFace dwarfChkFace;

    protected override void Awake()
    {
        base.Awake();
        dwarfChkFace = GetComponentInChildren<DwarfChkFace>();
        dwarfChkFace.gameObject.transform.SetParent(null);
    }

    public void Attack()
    {
        dwarf_Animation.AttackStart();
        dwarf.DisableInputs();
        
        if (dwarfChkFace.GetWoodAtRange() == null) return;

        WoodObstacle wood = dwarfChkFace.GetWoodAtRange().GetComponent<WoodObstacle>();
        wood.ReduceLife();
    }
}
