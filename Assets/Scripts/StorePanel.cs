using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorePanel : MonoBehaviour
{
    private Engine engine;

    public GameObject infoPanel;

    public Engine GetEngine()
    {
        return this.engine;
    }

    public void SetEngine(Engine e)
    {
        this.engine = e;
    }

    public void SetData()
    {
        Text name = this.gameObject.transform.GetChild(0).GetComponent<Text>();
        name.text = engine.GetName();
        Text price = this.gameObject.transform.GetChild(1).GetComponent<Text>();
        price.text = "Price: $" + engine.GetDevelopmentCost();
    }

    public void TriggerInfoPanel()
    {
        infoPanel.SetActive(true);
        infoPanel.GetComponent<InfoPanel>().SetData(this.engine.GetName(), this.engine.GetDescription());
    }
}
