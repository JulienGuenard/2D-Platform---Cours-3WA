using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodObstacle : MonoBehaviour
{
    public List<Sprite> spriteList;

    int life = 3;

    SpriteRenderer spriteR;

    private void Awake()
    {
        spriteR = GetComponent<SpriteRenderer>();
    }

    public void ReduceLife()
    {
        life--;
        LifeState();
    }

    void LifeState()
    {
        switch(life)
        {
            case 2:
                spriteR.sprite = spriteList[0];
                break;
            case 1:
                spriteR.sprite = spriteList[1];
                break;
            case 0:
                Destroy(this.gameObject);
                break;
        }
    }
}
