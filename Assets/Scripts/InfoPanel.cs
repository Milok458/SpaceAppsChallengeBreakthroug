using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    public void SetData(string h, string b)
    {
        this.gameObject.transform.GetChild(0).GetComponent<Text>().text = h;
        this.gameObject.transform.GetChild(1).GetComponent<Text>().text = b;
    }

    public void HidePanel()
    {
        this.gameObject.SetActive(false);
    }
}
