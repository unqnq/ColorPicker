using UnityEngine;

public class UIControll : MonoBehaviour
{
    public GameObject panelPickColor;

    public void PickColor()
    {
        panelPickColor.SetActive(true);
    }

    public void saveColor()
    {
        panelPickColor.SetActive(false);
    }
}
