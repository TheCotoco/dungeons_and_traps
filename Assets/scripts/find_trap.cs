using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class find_trap : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject trap;
    public GameObject player;
    public float baseTrapWarningDistance;
    public player_stats script;

   

    private void Start()
    {
        UiObject.SetActive(false);
        script = player.GetComponent<player_stats>();
    }

    private void Update()
    {
        if (trap)
        {
            var perception = script.perception;
            float distance = Vector3.Distance(trap.transform.position, player.transform.position);
            //print(distance);

            if (perception <= 10f)
            {
                //Debug.Log("percepcao menor que 10");
                if (distance < (baseTrapWarningDistance))
                {
                    UiObject.SetActive(true);

                }
                else
                {
                    UiObject.SetActive(false);
                }
                return;
            }

            if (perception > 10f && perception <= 15f)
            {
                //Debug.Log("percepcao >10 <15");
                if (distance < (baseTrapWarningDistance - 0.5f))
                {
                    UiObject.SetActive(true);
                }
                else
                {
                    UiObject.SetActive(false);
                }
                return;
            }

            //Debug.Log("percepcao >15");
            if (distance < (baseTrapWarningDistance - 1.5f))
            {
                UiObject.SetActive(true);
            }
            else
            {
                UiObject.SetActive(false);
            }
            return;
        }

        UiObject.SetActive(false);
    }
}
