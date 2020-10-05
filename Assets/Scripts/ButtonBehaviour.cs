using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject equipmentPanel;
    public GameObject storePanel;
    public GameObject proyectsPanel;
    public GameObject missionsPanel;
    public GameObject shadderPanel;

    public GameObject launchButton;
    
    public void ActivateEquipmentPanel()
    {
        ActivateSadder();
        DeactivatePanels();
        equipmentPanel.SetActive(true);
    }

    public void ActivateMissionsPanel()
    {
        ActivateSadder();
        DeactivatePanels();
        missionsPanel.SetActive(true);
    }

    public void ActivateProyectsPanel()
    {
        ActivateSadder();
        DeactivatePanels();
        proyectsPanel.SetActive(true);
    }

    public void RemoveLaunchButton()
    {
        launchButton.GetComponent<Button>().interactable = false;
    }

    public void ActivateLaunchButton()
    {
        launchButton.GetComponent<Button>().interactable = true;
        DeactivateShadder();
    }

    private void ActivateSadder()
    {
        shadderPanel.GetComponent<Image>().enabled = true;
    }

    private void DeactivateShadder()
    {
        shadderPanel.GetComponent<Image>().enabled = false;
    }

    public void DeactivatePanels()
    {
        equipmentPanel.SetActive(false);
        storePanel.SetActive(false);
        missionsPanel.SetActive(false);
        proyectsPanel.SetActive(false);
    }

    public void EquipmentSwitch()
    {
        if(equipmentPanel.activeSelf == true)
        {
            equipmentPanel.SetActive(false);
            storePanel.SetActive(true);
        }
        else
        {
            equipmentPanel.SetActive(true);
            storePanel.SetActive(false);
        }
    }

    public void DeactivateAllButtons()
    {
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach(GameObject button in buttons)
        {
            button.gameObject.GetComponent<Button>().interactable = false;
        }
    }

    public void ActivateAllButtons()
    {
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach (GameObject button in buttons)
        {
            button.gameObject.GetComponent<Button>().interactable = true;
        }
    }
}
