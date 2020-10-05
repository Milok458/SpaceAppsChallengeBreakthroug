using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionPanel : MonoBehaviour
{
    private Mission mission;

    //public GameObject planetInfoPanel;

    public Mission GetEngine()
    {
        return this.mission;
    }

    public void SetMission(Mission m)
    {
        this.mission = m;
    }

    public void TriggerInfoPanel()
    {
        //planetInfoPanel.SetActive(true);
        //planetInfoPanel.GetComponent<PlanetInfoPanel>().SetData(this.mission.GetName(), this.mission.GetDescription(), this.mission.GetDistance());
    }
}
