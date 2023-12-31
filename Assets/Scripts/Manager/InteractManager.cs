using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractManager : Singleton<InteractManager>
{
    private void Update()
    {
        HandleInteraction();
    }

    private void HandleInteraction()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, LayerMask.GetMask("InterfaceItem")) && Input.GetKeyDown(KeyCode.Mouse0)
            && !GameManager.Instance.IsCityMapPanelActive()
            && !FloorPlanManager.Instance.IsFloorPlanPanelActive())
        {
            int index = hit.collider.gameObject.GetComponent<InterfaceItem>().GetIndex();
            GameEventReference.Instance.OnInteract.Trigger(index);
        }
    }
}
