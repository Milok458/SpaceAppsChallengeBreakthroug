using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectPanel : MonoBehaviour
{
    private Project project;

    public GameObject infoPanel;

    public Project GetProject()
    {
        return this.project;
    }

    public void SetProject(Project p)
    {
        this.project = p;
    }

    public void SetData()
    {
        Text name = this.gameObject.transform.GetChild(0).GetComponent<Text>();
        name.text = project.GetName();
        Text price = this.gameObject.transform.GetChild(1).GetComponent<Text>();
        price.text = "Price: $" + project.GetCost();
    }

    public void TriggerInfoPanel()
    {
        infoPanel.SetActive(true);
        infoPanel.GetComponent<InfoPanel>().SetData(this.project.GetName(), this.project.GetDescription());
    }
}
