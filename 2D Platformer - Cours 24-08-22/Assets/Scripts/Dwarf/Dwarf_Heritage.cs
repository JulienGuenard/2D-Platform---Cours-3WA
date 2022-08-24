using UnityEngine;

public class Dwarf_Heritage : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public Animator animator;

    [HideInInspector] public Dwarf_Move dwarf_Move;
    [HideInInspector] public Dwarf_Jump dwarf_Jump;
    [HideInInspector] public Dwarf_Animation dwarf_Animation;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        dwarf_Move = GetComponent<Dwarf_Move>();
        dwarf_Jump = GetComponent<Dwarf_Jump>();
        dwarf_Animation = GetComponent<Dwarf_Animation>();
    }
}
