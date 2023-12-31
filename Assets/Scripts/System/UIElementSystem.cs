using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIElementSystem : MonoBehaviour
{
    public void ShowMapLayer(int id)
    {    
        if (TestPanelManager.Instance.m_isQuestionPanelActive)
            return;
        LayerManager.Instance.m_isLayerActive = true;
        switch (id)
        {
            case 1:
                UIElementReference.Instance.m_CityMapPanel.SetActive(true);
                break;
            case 2:
                UIElementReference.Instance.m_FloorPlanPanel.SetActive(true);
                break;
        }
        UIElementReference.Instance.m_InfoPanel.SetActive(true);
        UIElementReference.Instance.m_InfoPanel.SetActive(false);
    }


    public void OnClickNextQuestion()
    {
        TestPanelManager.Instance.m_isQuestionPanelActive = false;
        GameEventReference.Instance.OpenTestPanel.Trigger();
    }
    public void OnGameReset() => GameEventReference.Instance.OnGameReset.Trigger();
    public void EnterViewPoint(int index) => GameEventReference.Instance.OnEnterViewPoint.Trigger(index);
    public void OnClickInfoButton(string message) => GameEventReference.Instance.OnInteractUIMessage.Trigger(message);
    public void OnClick360ModeButton(string message) => GameEventReference.Instance.OnEnter360Mode.Trigger(message);
    public void OnClickTaskModeButton(string message) => GameEventReference.Instance.OnEnterTaskMode.Trigger(message);
    public void OnClickInfoExpandButton() => GameEventReference.Instance.OnClickInfoExpandButton.Trigger();
    public void OnClickRegion(string regionID) => GameEventReference.Instance.OnChangeRegion.Trigger(regionID);
    public void OnCloseMessagePanel() => UIElementReference.Instance.m_MessagePanel.SetActive(false);
    public void OnClickLoungeHeader(int index) => GameEventReference.Instance.OnClickLoungeHeader.Trigger(index);
    public void OnClickClassHeader(int index) => GameEventReference.Instance.OnClickClassHeader.Trigger(index);
    public void OpenTestPanel() => GameEventReference.Instance.OpenTestPanel.Trigger();
    public void OnClickTestOption(int index) => GameEventReference.Instance.OnClickTestOption.Trigger(index);
    public void OnEnterNavigatePhase() => GameEventReference.Instance.OnEnterNavigatePhase.Trigger();
    public void OnExitNavigatePhase() => GameEventReference.Instance.OnExitNavigatePhase.Trigger();
    public void OnConfirmNavigate() => GameEventReference.Instance.OnConfirmNavigate.Trigger();
    public void OnClickFloorPlanButton() => GameEventReference.Instance.OnClickFloorPlanButton.Trigger();
    public void OnLanguageChanged(int language) => GameEventReference.Instance.OnLanguageChanged.Trigger(language);
    
    public void OnClickNextButton() => GameEventReference.Instance.OnClickNextButton.Trigger();
}
