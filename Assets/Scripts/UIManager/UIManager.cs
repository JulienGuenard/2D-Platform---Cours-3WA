using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    static public UIManager instance;

    public int beerNumber;
    public TextMeshProUGUI beerNumberText;

    void Awake()
    {
        if (instance == null) { instance = this; }
    }

    public void NewBeer()
    {
        beerNumber++;
        beerNumberText.text = beerNumber.ToString() + " / 12";
    }
}
