using UnityEngine;

public class Dwarf_Collect : Dwarf_Heritage
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Beer")
        {
            Destroy(collision.gameObject);
            UIManager.instance.NewBeer();
        }
    }
}
