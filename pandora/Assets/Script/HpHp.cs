using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpHp : MonoBehaviour
{
   [SerializeField] private Slider slider;
   [SerializeField] private Camera camera;

   public void UpdateHp(float Current, float max){
    slider.value=Current/max;
   }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = camera.transform.rotation;
    }
}
