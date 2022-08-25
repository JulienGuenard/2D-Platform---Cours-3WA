using UnityEngine;

public class DwarfChkFace : MonoBehaviour
{
    GameObject woodAtRange;

    public GameObject GetWoodAtRange() { return woodAtRange; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "wood") woodAtRange = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "wood") woodAtRange = null;
    }
}
