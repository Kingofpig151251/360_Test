﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;

public class Test1
{
    [MenuItem("Tools/CreateSO/Arrow")]
    public static void CreateArrowSO()
    {
        ArrowSO testData = ScriptableObject.CreateInstance<ArrowSO>();
        testData.m_position = Selection.activeTransform.gameObject.transform.position;
        testData.m_rotation = Selection.activeTransform.gameObject.transform.localEulerAngles;
        testData.m_size = Selection.activeTransform.gameObject.transform.localScale;
        testData.m_nextViewPointIndex = Selection.activeTransform.gameObject.GetComponent<InterfaceItem_Arrow>().m_nextViewPointIndex;

        string fullPath = "Assets/ScriptableObject/Arrow/VP.asset";
        UnityEditor.AssetDatabase.DeleteAsset(fullPath);
        UnityEditor.AssetDatabase.CreateAsset(testData, fullPath);
        UnityEditor.AssetDatabase.Refresh();
    }

    [MenuItem("GameObject/CreateSO/Info")]
    public static void CreateInfoSO()
    {
        InfoSO testData = ScriptableObject.CreateInstance<InfoSO>();
        testData.m_position = Selection.activeTransform.gameObject.transform.position;
        testData.m_rotation = Selection.activeTransform.gameObject.transform.localEulerAngles;
        testData.m_size = Selection.activeTransform.gameObject.transform.localScale;
        testData.m_title_ENG = Selection.activeTransform.gameObject.GetComponent<InterfaceItem_Info>().m_info.m_title_ENG;
        testData.m_title_SC = Selection.activeTransform.gameObject.GetComponent<InterfaceItem_Info>().m_info.m_title_SC;
        testData.m_title_TC = Selection.activeTransform.gameObject.GetComponent<InterfaceItem_Info>().m_info.m_title_TC;
        testData.m_content_ENG = Selection.activeTransform.gameObject.GetComponent<InterfaceItem_Info>().m_info.m_content_ENG;
        testData.m_content_SC = Selection.activeTransform.gameObject.GetComponent<InterfaceItem_Info>().m_info.m_content_SC;
        testData.m_content_TC = Selection.activeTransform.gameObject.GetComponent<InterfaceItem_Info>().m_info.m_content_TC;

        string fullPath = "Assets/ScriptableObject/Info/VP.asset";
        UnityEditor.AssetDatabase.DeleteAsset(fullPath);
        UnityEditor.AssetDatabase.CreateAsset(testData, fullPath);
        UnityEditor.AssetDatabase.Refresh();
    }
}
#endif