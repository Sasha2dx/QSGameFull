using System;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public class SafeZoneAdapter : UIBehaviour
{

   private void OnRectTransformDimensionsChange()
   {
      var rectTr = (RectTransform) transform;
      var safeArea = Screen.safeArea;
   
      var anchorMin = safeArea.position;
      var anchorMax = safeArea.position + safeArea.size;
      anchorMin.x /= Screen.width;
      anchorMin.y /= Screen.height;
      anchorMax.x /= Screen.width;
      anchorMax.y /= Screen.height;
      
      rectTr.anchorMin = anchorMin;
      rectTr.anchorMax = anchorMax;
   }
   
}
